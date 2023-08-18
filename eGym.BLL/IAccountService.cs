using eGym.BLL.Models;
using eGym.BLL.Models.Requests;

namespace eGym.BLL;

public interface IAccountService
{
    public Task<AccountDTO> GetById(int id);
    public Task<List<AccountDTO>> GetAll();
    public Task<List<AccountDTO>> Search(string text);
    public Task Delete(int id);
    public Task Create(CreateAccountRequest request);
    public Task Update(UpdateAccountRequest request, AccountDTO account);
    public Task<AccountDTO> Login(string username, string password);
}

