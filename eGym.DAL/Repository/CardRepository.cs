using System;
using eGym.Domain;

namespace eGym.DAL.Repository;

public class CardRepository : GenericRepository<Card>, ICardRepository
{
	public CardRepository(DataBaseContext context) : base(context)
	{
	}
}

