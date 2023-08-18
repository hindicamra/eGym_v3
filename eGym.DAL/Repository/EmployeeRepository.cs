using System;
using eGym.Domain;

namespace eGym.DAL.Repository
{
	public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
	{
		public EmployeeRepository(DataBaseContext context) : base(context)
		{
		}
	}
}

