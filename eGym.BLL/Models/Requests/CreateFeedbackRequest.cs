using System;
namespace eGym.BLL.Models.Requests;

public class CreateFeedbackRequest
{
    public int Employees { get; set; }
    public int Equipment { get; set; }
    public int ServiceQuality { get; set; }
    public string? Comment { get; set; }
    public int AccountId { get; set; }
}

