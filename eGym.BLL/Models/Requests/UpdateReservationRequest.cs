namespace eGym.BLL.Models.Requests;

public class UpdateReservationRequest
{
    public DateTime? From { get; set; }
    public DateTime? To { get; set; }
    public string? Description { get; set; }
    public int? EmployeeId { get; set; }
}

