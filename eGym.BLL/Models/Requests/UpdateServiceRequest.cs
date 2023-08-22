namespace eGym.BLL.Models.Requests;

public class UpdateServiceRequest : CreateServiceRequest
{
    public int ServiceId { get; set; }
    public string Descritption { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Picture { get; set; } = string.Empty;
}

