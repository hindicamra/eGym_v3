using System.ComponentModel.DataAnnotations;

namespace eGym.BLL.Models.Requests;

public class LoginRequest
{
    [Required(ErrorMessage = "You have to provide username")]
    public string Username { get; set; }

    [Required(ErrorMessage = "You have to provide password")]
    public string Password { get; set; }
}

