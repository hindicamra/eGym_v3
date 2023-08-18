using System;
namespace eGym.BLL.Exceptions;

public class CustomerException : Exception
{
	public CustomerException()
	{
	}

	public CustomerException(string message) : base(message)
	{
	}
}

