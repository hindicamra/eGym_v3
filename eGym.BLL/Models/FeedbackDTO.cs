using System;
namespace eGym.BLL.Models;

public class FeedbackDTO
{
    public int AccountId { get; set; }
    public int FeedbackId { get; set; }
    public int Employees { get; set; }
    public int Equipment { get; set; }
    public int ServiceQuality { get; set; }
    public string? Comment { get; set; }
    public string? Username { get; set; }
}

