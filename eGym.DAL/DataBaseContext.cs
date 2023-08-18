using eGym.Domain;
using Microsoft.EntityFrameworkCore;

namespace eGym.DAL;

public partial class DataBaseContext : DbContext
{
    public DataBaseContext(DbContextOptions<DataBaseContext> options)
    : base(options)
    {
    }

    public DbSet<Account> Account { get; set; }
    public DbSet<Employee> Employee { get; set; }
    public DbSet<Diet> Diet { get; set; }
    public DbSet<Payment> Payment { get; set; }
    public DbSet<Reservation> Reservation { get; set; }
    public DbSet<Training> Training { get; set; }
    public DbSet<Feedback> Feedback { get; set; }
    public DbSet<Service> Service { get; set; }
    public DbSet<Card> Card { get; set; }
    public DbSet<Customer> Customer { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}