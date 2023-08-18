using eGym.Domain;

namespace eGym.DAL.Repository;

public class TrainingRepository : GenericRepository<Training>, ITrainingRepository
{
	public TrainingRepository(DataBaseContext dbContext) : base(dbContext)
	{
	}
}

