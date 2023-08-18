namespace eGym.BLL.Models.Requests;

public class UpdateTrainingRequest
{
    public DayOfWeek? Day { get; set; }
    public string? Description { get; set; }
}