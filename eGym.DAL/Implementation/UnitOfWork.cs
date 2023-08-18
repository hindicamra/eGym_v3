using eGym.DAL.Repository;

namespace eGym.DAL.Implementation;

public class UnitOfWork : IUnitOfWork
{
	private readonly DataBaseContext _context;

	public UnitOfWork(DataBaseContext context)
	{
		_context = context;
        Accounts = new AccountRepository(_context);
        Employees = new EmployeeRepository(_context);
        Feedbacks = new FeedbackRepository(_context);
        Diets = new DietRepository(_context);
        Reservations = new ReservationRepository(_context);
        Payments = new PaymentRepository(_context);
        Trainings = new TrainingRepository(_context);
        Customers = new CustomerRepository(_context);
        Cards = new CardRepository(_context);
        Services = new ServiceRepository(_context);
    }

    public IAccountRepository Accounts { get; private set; }
    public IEmployeeRepository Employees { get; private set; }
    public IFeedbackRepository Feedbacks { get; private set; }
    public IDietRepository Diets { get; private set; }
    public IReservationRepository Reservations { get; private set; }
    public IPaymentRepository Payments { get; private set; }
    public ITrainingRepository Trainings { get; private set; }
    public IServiceRepository Services { get; private set; }
    public ICardRepository Cards { get; private set; }
    public ICustomerRepository Customers { get; private set; }

    public int Complete()
    {
        return _context.SaveChanges();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}

