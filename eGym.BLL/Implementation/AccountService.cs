using AutoMapper;
using eGym.BLL.Models;
using eGym.BLL.Models.Requests;
using eGym.DAL;
using eGym.Domain;
using System.Linq;
using System.Collections.Generic;

namespace eGym.BLL.Implementation;

public class AccountService : IAccountService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

	public AccountService(IUnitOfWork unitOfWork, IMapper mapper)
	{
        _unitOfWork = unitOfWork;
        _mapper = mapper;
	}

	public async Task<AccountDTO> GetById(int id)
	{
        var result = await _unitOfWork.Accounts.GetById(id);
        return _mapper.Map<AccountDTO>(result);
	}

    public async Task<List<AccountDTO>> GetAll()
    {
        var result = await _unitOfWork.Accounts.GetAll();
        return _mapper.Map<List<AccountDTO>>(result);
    }

    public async Task Delete(int id)
    {
        await _unitOfWork.Accounts.Delete(id);
    }

    public async Task Create(CreateAccountRequest request)
    {
        var account = _mapper.Map<Account>(request);
        account.Role = 2;
        await _unitOfWork.Accounts.Insert(account);
    }

    public async Task Update(UpdateAccountRequest request, AccountDTO account)
    {
        var updatedAccount = _mapper.Map(request, account);
        await _unitOfWork.Accounts.Update(_mapper.Map<Account>(updatedAccount));
    }

    public async Task<AccountDTO> Login(string username, string password)
    {
        var result = await _unitOfWork.Accounts.GetWhere(x => x.Username.Equals(username) && x.Password.Equals(password));
        if (result != null && result.Any())
        {
            return _mapper.Map<AccountDTO>(result.ToList().FirstOrDefault());
        }
        return null;
    }

    public async Task<List<AccountDTO>> Search(string text)
    {
        var result = await _unitOfWork.Accounts.GetWhere(x => x.FirstName.Contains(text) || x.LastName.Contains(text));
        return _mapper.Map<List<AccountDTO>>(result);
    }
}

