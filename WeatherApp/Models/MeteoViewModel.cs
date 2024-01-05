namespace WeatherApp.Models;

public class MeteoViewModel
{
    public required string City { get; set; }
    public required string Picture { get; set; }
    public required double Temperature { get; set; }
}