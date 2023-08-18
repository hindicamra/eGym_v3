﻿using System;
using eGym.BLL.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace eGym.BLL.Models.Requests;

public class CreateEmployeeRequest
{
    [Required(ErrorMessage = "You have to provide first name")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "You have to provide last name")]
    public string LastName { get; set; }

    [Required(ErrorMessage = "You have to provide username")]
    public string Username { get; set; }

    [Required(ErrorMessage = "You have to provide password")]
    [StringLength(20, MinimumLength = 3)]
    public string Password { get; set; }

    [Required(ErrorMessage = "You have to provide email")]
    [DataType(DataType.EmailAddress)]
    [EmailAddress]
    public string Email { get; set; }

    [Required(ErrorMessage = "You have to provide role")]
    public Role Role { get; set; }

    [Required(ErrorMessage = "You have to provide gender")]
    public Gender Gender { get; set; }

    public DateTime BirthDate { get; set; }
}

