namespace eGym.Domain;

public class Employee
{
    public int EmployeeId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }
    public string? Email { get; set; }
    public int Role { get; set; }
    public int Gender { get; set; }
    public DateTime BirthDate { get; set; }
}

