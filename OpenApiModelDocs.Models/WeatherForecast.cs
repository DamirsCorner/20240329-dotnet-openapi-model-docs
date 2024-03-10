namespace OpenApiModelDocs.Models;

/// <summary>
/// Daily weather forecast.
/// </summary>
public class WeatherForecast
{
    /// <summary>
    /// Date of the forecast.
    /// </summary>
    public DateOnly Date { get; set; }

    /// <summary>
    /// Temperature in degrees Celsius.
    /// </summary>
    public int TemperatureC { get; set; }

    /// <summary>
    /// Temperature in degrees Fahrenheit.
    /// </summary>
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    /// <summary>
    /// Single-word description of the weather.
    /// </summary>
    public string? Summary { get; set; }
}
