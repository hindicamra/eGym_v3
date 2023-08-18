using eGym.Domain;

namespace eGym.DAL.Repository;

public class AccountRepository : GenericRepository<Account>, IAccountRepository
{
    public AccountRepository(DataBaseContext context) : base(context)
    {
    }
}

