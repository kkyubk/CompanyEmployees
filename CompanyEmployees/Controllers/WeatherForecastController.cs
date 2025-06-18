using Contracts;
using Microsoft.AspNetCore.Mvc;

[Route("[controller]")]
[ApiController]
public class WeatherForecastController : ControllerBase
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;

    public WeatherForecastController(IRepositoryManager repository, ILoggerManager logger)
    {
        _repository = repository;
        _logger = logger;
    }

    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
        //_repository.Company.AnyMethodFromCompanyRepository();
        //_repository.Employee.AnyMethodFromEmployeeRepository();
        return new string[] { "value1", "value2" };
    }
}