using System;
using System.ComponentModel.DataAnnotations;

namespace eGym.Domain;

public class Payment
{
    public int PaymentId { get; set; }

    public string Description { get; set; }

    public string ReceiptEmail { get; set; }

    public int CCV { get; set; }

    public string Currency { get; set; }

    public long Amount { get; set; }

    public int CustomerId { get; set; }
    public Customer? Customer { get; set; }

    public int? ReservationId { get; set; }
    public Reservation? Reservation { get; set; }
}

