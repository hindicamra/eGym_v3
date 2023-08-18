using System;
using eGym.BLL.Models.Enums;

namespace eGym.BLL.Models;

public class EmployeeDTO
{
    public int EmployeeId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }
    public string? Email { get; set; }
    public Role Role { get; set; }
    public Gender Gender { get; set; }
    public DateTime BirthDate { get; set; }
}

