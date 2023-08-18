using System;
using eGym.Domain;

namespace eGym.DAL.Repository;

public class FeedbackRepository : GenericRepository<Feedback>, IFeedbackRepository
{
	public FeedbackRepository(DataBaseContext _context) : base(_context)
	{
	}
}

