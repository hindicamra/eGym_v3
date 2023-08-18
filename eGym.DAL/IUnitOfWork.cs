namespace eGym.DAL;

public interface IUnitOfWork : IDisposable
{
    IAccountRepository Accounts { get; }
    IEmployeeRepository Employees { get; }
    IFeedbackRepository Feedbacks { get; }
    IDietRepository Diets { get; }
    IReservationRepository Reservations { get; }
    IPaymentRepository Payments { get; }
    ITrainingRepository Trainings { get; }
    IServiceRepository Services { get; }
    ICustomerRepository Customers { get; }
    ICardRepository Cards { get; }

    int Complete();
}