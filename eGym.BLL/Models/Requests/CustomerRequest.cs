using System;
namespace eGym.BLL.Models.Requests;

public class CustomerRequest
{
    public string Email { get; set; }

    public string Name { get; set; }

    public int AccountId { get; set; }

    public Card CreditCard { get; set; }
}

public class Card
{
    public string Name { get; set; }

    public string CardNumber { get; set; }

    public string ExpirationYear { get; set; }

    public string ExpirationMonth { get; set; }

    public string CVC { get; set; }
}