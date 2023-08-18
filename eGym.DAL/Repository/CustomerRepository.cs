using System;
using eGym.Domain;

namespace eGym.DAL.Repository;

public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
{
	public CustomerRepository(DataBaseContext context) : base(context)
	{
	}
}

