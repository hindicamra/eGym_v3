using System;

namespace eGym.BLL.Models.Requests;

public class PaymentRequest
{
    public string Description { get; set; }

    public string ReceiptEmail { get; set; }

    public int CCV { get; set; }

    public string Currency { get; set; }

    public long Amount { get; set; }

    public string CustomerId { get; set; }

    public int ReservationId { get; set; }
}

