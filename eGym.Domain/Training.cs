namespace eGym.Domain;

public class Training
{
    public int TrainingId { get; set; }
    public int Day { get; set; }
    public string? Description { get; set; }

    public int AccountId { get; set; }
    public Account? Account { get; set; }
}

