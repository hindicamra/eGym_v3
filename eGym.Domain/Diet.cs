namespace eGym.Domain;

public class Diet
{
	public int DietId { get; set; }
    public int Day { get; set; }
    public int Meal { get; set; }
    public string? Description { get; set; }

    public int AccountId { get; set; }
    public Account? Account { get; set; }
}

