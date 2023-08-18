using System.ComponentModel.DataAnnotations;

namespace eGym.BLL.Models.Requests;

public class CreateTrainingRequest
{
    [Required(ErrorMessage = "You have to provide Account id")]
    public int AccountId { get; set; }

    [Required(ErrorMessage = "You have to provide Day")]
    public DayOfWeek Day { get; set; }

    [Required(ErrorMessage = "You have to provide Descrition id")]
    public string Description { get; set; } = string.Empty;
}

