using eGym.BLL.Models;
using eGym.BLL.Models.Requests;

namespace eGym.BLL;

public interface IEmployeeService
{
    public Task<EmployeeDTO> GetById(int id);
    public Task<List<EmployeeDTO>> GetAll();
    public Task<List<EmployeeDTO>> Search(string text);
    public Task<List<EmployeeActivity>> GetEmployeeActivity(int employeeId);
    public Task Delete(int id);
    public Task Create(CreateEmployeeRequest request);
    public Task Update(UpdateAccountRequest request, EmployeeDTO employee);
    public Task<EmployeeDTO> Login(string username, string password);
}

