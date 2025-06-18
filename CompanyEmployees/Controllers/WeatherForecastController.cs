using Contracts;
using Microsoft.AspNetCore.Mvc;

[Route("[controller]")]
[ApiController]
public class WeatherForecastController : ControllerBase
{
    private readonly ILoggerManager _logger;

    public WeatherForecastController(ILoggerManager logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<string> Get()
    {
        _logger.LogInfo("Info message from WeatherForecastController.");
        _logger.LogDebug("Debug message from WeatherForecastController.");
        _logger.LogWarn("Warning message from WeatherForecastController.");
        _logger.LogError("Error message from WeatherForecastController.");
        return new string[] { "value1", "value2" };
    }
}