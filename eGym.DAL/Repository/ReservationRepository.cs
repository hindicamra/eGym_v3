using eGym.Domain;

namespace eGym.DAL.Repository;

public class ReservationRepository : GenericRepository<Reservation>, IReservationRepository
{
	public ReservationRepository(DataBaseContext dbContext) : base(dbContext)
	{
	}
}

