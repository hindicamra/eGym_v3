using eGym.BLL.Models.Enums;

namespace eGym.BLL.Models;

public class AccountDTO
{
    public int AccountId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }
    public string? Email { get; set; }
    public Role Role { get; set; } = Role.User;
    public Gender Gender { get; set; }
    public DateTime BirthDate { get; set; }

}

