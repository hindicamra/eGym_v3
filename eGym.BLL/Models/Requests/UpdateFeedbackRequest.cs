using System;
namespace eGym.BLL.Models.Requests;

public class UpdateFeedbackRequest
{
    public int? Employees { get; set; }
    public int? Equipment { get; set; }
    public int? ServiceQuality { get; set; }
    public string? Comment { get; set; }
}