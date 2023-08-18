using AutoMapper;
using eGym.BLL.Models;
using eGym.BLL.Models.Requests;
using eGym.DAL;
using eGym.Domain;

namespace eGym.BLL.Implementation;

public class ReservationService : IReservationService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

	public ReservationService(IUnitOfWork unitOfWork, IMapper mapper)
	{
        _unitOfWork = unitOfWork;
        _mapper = mapper;
	}

    public async Task Create(CreateReservationRequest request)
    {
        var reservation = _mapper.Map<Reservation>(request);
        reservation.Status = 1;
        await _unitOfWork.Reservations.Insert(reservation);
    }

    public async Task Delete(int id)
    {
        await _unitOfWork.Reservations.Delete(id);
    }

    public async Task Update(UpdateReservationRequest request, ReservationDTO reservation)
    {
        var updatedReservation = _mapper.Map(request, reservation);
        await _unitOfWork.Reservations.Update(_mapper.Map<Reservation>(updatedReservation));
    }

    public async Task<ReservationDTO> GetById(int id)
    {
        var result = await _unitOfWork.Reservations.GetById(id);

        var employee = await _unitOfWork.Employees.GetById(result.EmployeeId);

        var response = _mapper.Map<ReservationDTO>(result);

        response.EmployeeName = employee.FirstName + " " + employee.LastName;

        return response;
    }

    public async Task<List<ReservationDTO>> GetByUser(int userId)
    {
        var result = await _unitOfWork.Reservations.GetWhere(x => x.AccountId.Equals(userId));
        var response = _mapper.Map<List<ReservationDTO>>(result);

        foreach(var x in response)
        {
            var employee = await _unitOfWork.Employees.GetById(x.EmployeeId);

            x.EmployeeName = employee.FirstName + " " + employee.LastName;
        }

        return response;
    }

    public async Task<List<ReservationDTO>> GetNewestByUser(int userId, DateTime date)
    {
        var result = await _unitOfWork.Reservations.GetWhere(x => x.AccountId.Equals(userId) && x.From.Date >= date.Date);
        var response = _mapper.Map<List<ReservationDTO>>(result);

        foreach (var x in response)
        {
            var employee = await _unitOfWork.Employees.GetById(x.EmployeeId);

            x.EmployeeName = employee.FirstName + " " + employee.LastName;
        }

        return response;
    }

    public async Task<List<ReservationDTO>> GetByEmployee(int employeeId, DateTime date)
    {
        var result = await _unitOfWork.Reservations.GetWhere(x => x.EmployeeId.Equals(employeeId));
        if (result != null && result.Any())
            result = result.Where(x => x.From.ToShortDateString().Equals(date.ToShortDateString()));

        var response = _mapper.Map<List<ReservationDTO>>(result);

        foreach (var x in response)
        {
            var employee = await _unitOfWork.Employees.GetById(x.EmployeeId);

            x.EmployeeName = employee.FirstName + " " + employee.LastName;
        }

        return response;
    }

    public async Task UpdateStatus(ReservationDTO reservation)
    {
        await _unitOfWork.Reservations.Update(_mapper.Map<Reservation>(reservation));
    }

    public async Task<List<ReservationDTO>> GetPendingReservations(int employeeId, DateTime date)
    {
        var result = await _unitOfWork.Reservations.GetWhere(x => x.EmployeeId.Equals(employeeId) && x.Status == 1 && x.From.Date >= date.Date);
        var response = _mapper.Map<List<ReservationDTO>>(result);

        foreach (var x in response)
        {
            var employee = await _unitOfWork.Employees.GetById(x.EmployeeId);

            x.EmployeeName = employee.FirstName + " " + employee.LastName;
        }

        return response;
    }

    public async Task<List<ReservationDTO>> GetPaidReservations(int employeeId, DateTime date)
    {
        var result = await _unitOfWork.Reservations.GetWhere(x => x.EmployeeId.Equals(employeeId) && x.Status == 3 && x.From.Date == date.Date);
        var response = _mapper.Map<List<ReservationDTO>>(result);

        foreach (var x in response)
        {
            var employee = await _unitOfWork.Employees.GetById(x.EmployeeId);

            x.EmployeeName = employee.FirstName + " " + employee.LastName;
        }

        return response;
    }
}