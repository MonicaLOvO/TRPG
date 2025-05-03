using Microsoft.AspNetCore.Mvc;
using TRPGServer.Data;
using TRPGServer.Functions;
using TRPGServer.Functions.Interface;
namespace TRPGServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TRPGController : ControllerBase
    {
        private ILogicDemo service;
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly AppDbContext _appDbContext;

        public TRPGController(ILogger<WeatherForecastController> logger, ILogicDemo _service)
        {
            _logger = logger;
            service = _service;
        }

        public TRPGController(AppDbContext appDbContext) 
        {
            _appDbContext = appDbContext;
        }

        [HttpGet(Name = "test")]
        public string Get()
        {
            return $"{service.Variable}";
        }


    }
}
