using eGym.Domain;

namespace eGym.DAL.Repository;

public class ServiceRepository : GenericRepository<Service>, IServiceRepository
{
	public ServiceRepository(DataBaseContext context) : base(context)
	{
	}
}