using eGym.Domain;

namespace eGym.DAL.Repository;

public class DietRepository : GenericRepository<Diet>, IDietRepository
{
	public DietRepository(DataBaseContext context) : base(context)
    {
	}
}

