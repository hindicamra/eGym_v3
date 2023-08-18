namespace eGym.Domain;

public class Customer
{
    public int CustomerId { get; set; }

    public string StripeCustomerId { get; set; }

    public string Email { get; set; }

    public string Name { get; set; }

    public int AccountId { get; set; }
    public Account Account { get; set; }

    public int CardId { get; set; }
    public Card Card { get; set; }
}

