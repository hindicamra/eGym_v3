﻿namespace eGym.Domain;

public class Card
{
    public int CardId { get; set; }

    public string Name { get; set; }

    public string CardNumber { get; set; }

    public string ExpirationYear { get; set; }

    public string ExpirationMonth { get; set; }

    public string CVC { get; set; }
}

