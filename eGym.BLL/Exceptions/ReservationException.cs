using System;
namespace eGym.BLL.Exceptions;

public class ReservationException : Exception
{
	public ReservationException()
	{
	}

	public ReservationException(string message) : base(message)
	{
	}
}

