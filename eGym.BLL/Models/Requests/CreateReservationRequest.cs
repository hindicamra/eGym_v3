using System.ComponentModel.DataAnnotations;
using eGym.BLL.Models.Enums;

namespace eGym.BLL.Models.Requests;

public class CreateReservationRequest
{
    [Required(ErrorMessage = "You have to provide date from")]
    public DateTime From { get; set; }

    [Required(ErrorMessage = "You have to provide date to")]
    public DateTime To { get; set; }

    public string? Description { get; set; }

    [Required(ErrorMessage = "You have to provide reservation type")]
    public ReservationType ReservationType { get; set; }

    [Required(ErrorMessage = "You have to provide Account id")]
    public int AccountId { get; set; }

    [Required(ErrorMessage = "You have to provide Employee id")]
    public int EmployeeId { get; set; }
}

