using System.ComponentModel.DataAnnotations;
using eGym.BLL.Models.Enums;

namespace eGym.BLL.Models.Requests;

public class CreateDietRequest
{
    [Required(ErrorMessage = "You have to provide Account id")]
    public int AccountId { get; set; }

    [Required(ErrorMessage = "You have to provide Day")]
    public DayOfWeek Day { get; set; }

    [Required(ErrorMessage = "You have to provide Meal")]
    public Meal Meal { get; set; }

    [Required(ErrorMessage = "You have to provide Description")]
    public string? Description { get; set; }
}

