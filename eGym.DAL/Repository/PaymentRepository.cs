using System;
using eGym.Domain;

namespace eGym.DAL.Repository;

public class PaymentRepository : GenericRepository<Payment>, IPaymentRepository
{
	public PaymentRepository(DataBaseContext _context) : base(_context)
	{
	}
}

