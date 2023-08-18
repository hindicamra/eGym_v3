using System;
namespace eGym.BLL.Models;

public class ServiceDTO
{
	public int ServiceId { get; set; }
	public string Descritption { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Picture { get; set; } = string.Empty;
}

