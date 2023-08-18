namespace eGym.Domain;

public class Feedback
{
    public int FeedbackId { get; set; }
    public int Employees { get; set; }
    public int Equipment { get; set; }
    public int ServiceQuality { get; set; }
    public string? Comment { get; set; }

    public int AccountId { get; set; }
    public Account? Account { get; set; }
}