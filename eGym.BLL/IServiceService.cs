using eGym.BLL.Models;
using eGym.BLL.Models.Requests;

namespace eGym.BLL;

public interface IServiceService
{
    public Task<ServiceDTO> GetById(int id);
    public Task<List<ServiceDTO>> GetAll();
    public Task Delete(int id);
    public Task Create(CreateServiceRequest request);
    public Task Update(UpdateServiceRequest request, ServiceDTO service);
}

