using AutoMapper;
using eGym.BLL.Models;
using eGym.BLL.Models.Requests;
using eGym.DAL;
using eGym.Domain;

namespace eGym.BLL.Implementation;

public class EmployeeService : IEmployeeService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public EmployeeService(IUnitOfWork unitOfWork, IMapper mapper)
	{
        _unitOfWork = unitOfWork;
        _mapper = mapper;
	}

	public async Task Create(CreateEmployeeRequest request)
	{
        await _unitOfWork.Employees.Insert(_mapper.Map<Employee>(request));
	}

    public async Task Delete(int id)
    {
        await _unitOfWork.Employees.Delete(id);
    }

    public async Task Update(UpdateAccountRequest request, EmployeeDTO employee)
    {
        var updatedEmployee = _mapper.Map(request, employee);
        await _unitOfWork.Employees.Update(_mapper.Map<Employee>(updatedEmployee));
    }

    public async Task<EmployeeDTO> GetById(int id)
    {
        var result = await _unitOfWork.Employees.GetById(id);
        return _mapper.Map<EmployeeDTO>(result);
    }

    public async Task<List<EmployeeDTO>> GetAll()
    {
        var result = await _unitOfWork.Employees.GetAll();
        return _mapper.Map<List<EmployeeDTO>>(result);
    }

    public async Task<EmployeeDTO> Login(string username, string password)
    {
        var result = await _unitOfWork.Employees.GetWhere(x => x.Username.Equals(username) && x.Password.Equals(password));
        if (result != null && result.Any())
        {
            return _mapper.Map<EmployeeDTO>(result.ToList().FirstOrDefault());
        }
        return null;
    }

    public async Task<List<EmployeeActivity>> GetEmployeeActivity(int employeeId)
    {
        var result = await _unitOfWork.Reservations.GetWhere(x => x.EmployeeId.Equals(employeeId));
        var groupedDictionary = result
        .GroupBy(x => new { Date = x.From.Month + "-" + x.From.Year })
        .ToDictionary(g => g.Key, g => g.Count());

        var response = new List<EmployeeActivity>();

        foreach(var x in groupedDictionary)
        {
            response.Add(new EmployeeActivity()
            {
                Date = x.Key.ToString(),
                NumberOfReservation = x.Value
            });
        }

        return response;
    }

    public async Task<List<EmployeeDTO>> Search(string text)
    {
        var result = await _unitOfWork.Employees.GetWhere(x => x.FirstName.Contains(text) || x.LastName.Contains(text));
        return _mapper.Map<List<EmployeeDTO>>(result);
    }
}

