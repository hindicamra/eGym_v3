using AutoMapper;
using eGym.BLL.Models;
using eGym.BLL.Models.Requests;
using eGym.DAL;
using eGym.Domain;

namespace eGym.BLL.Implementation;

public class ServiceService : IServiceService
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

	public ServiceService(IMapper mapper, IUnitOfWork unitOfWork)
	{
        _mapper = mapper;
        _unitOfWork = unitOfWork;
	}

    public async Task Create(CreateServiceRequest request)
    {
        await _unitOfWork.Services.Insert(_mapper.Map<Service>(request));
    }

    public async Task Delete(int id)
    {
        await _unitOfWork.Services.Delete(id);
    }

    public async Task<List<ServiceDTO>> GetAll()
    {
        var result = await _unitOfWork.Services.GetAll();
        return _mapper.Map<List<ServiceDTO>>(result);
    }

    public async Task<ServiceDTO> GetById(int id)
    {
        var result = await _unitOfWork.Services.GetById(id);
        return _mapper.Map<ServiceDTO>(result);
    }

    public async Task Update(UpdateServiceRequest request, ServiceDTO service)
    {
        var updatedService = _mapper.Map(request, service);
        await _unitOfWork.Services.Update(_mapper.Map<Service>(updatedService));
    }
}

