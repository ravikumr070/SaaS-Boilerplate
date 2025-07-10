namespace Infrastructure.Cors;

public class CorsSettings
{
    public string? Angular { get; set; }
    public string? Blazor { get; set; }
    public string? React { get; set; }
    public string? Data { get; set; }
}
public class CorsSettingData
{
    public CorsSettings CorsSettings { get; set; }
}