namespace eGym.Domain;

public class Reservation
{
    public int ReservationId { get; set; }
    public DateTime From { get; set; }
    public DateTime To { get; set; }
    public string? Description { get; set; }
    public int Status { get; set; }
    public int ReservationType { get; set; }

    public int AccountId { get; set; }
    public Account? Account { get; set; }

    public int EmployeeId { get; set; }
    public Employee? Employee { get; set; }
}

