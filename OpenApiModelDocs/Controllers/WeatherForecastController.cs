using Microsoft.AspNetCore.Mvc;
using OpenApiModelDocs.Models;

namespace OpenApiModelDocs.Controllers;

/// <summary>
/// Implements weather forecast related endpoints.
/// </summary>
[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries =
    [
        "Freezing",
        "Bracing",
        "Chilly",
        "Cool",
        "Mild",
        "Warm",
        "Balmy",
        "Hot",
        "Sweltering",
        "Scorching"
    ];

    private readonly ILogger<WeatherForecastController> _logger;

    /// <summary>
    /// Creates a new instance of <see cref="WeatherForecastController"/>.
    /// </summary>
    /// <param name="logger">Injected <see cref="ILogger"/> instance.</param>
    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// Gets weather forecast for the next five days.
    /// </summary>
    /// <returns>A sequence of daily weather forecasts.</returns>
    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable
            .Range(1, 5)
            .Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
    }
}
