using System;
namespace eGym.Domain;

public class Service
{
	public int ServiceId { get; set; }
	public string Descritption { get; set; } = string.Empty;
	public string Title { get; set; } = string.Empty;
	public string Picture { get; set; } = string.Empty;
}