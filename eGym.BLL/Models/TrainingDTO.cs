namespace eGym.BLL.Models;

public class TrainingDTO
{
    public int TrainingId { get; set; }
    public int AccountId { get; set; }
    public DayOfWeek Day { get; set; }
    public string? Description { get; set; }
}

