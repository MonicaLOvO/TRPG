using Microsoft.AspNetCore.Mvc;
using TRPGServer.Data;
using TRPGServer.Functions;
using TRPGServer.Functions.Interface;
using TRPGServer.Functions.Logic;
using TRPGServer.Model;
namespace TRPGServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TRPGController : ControllerBase
    {
        private IAccountLogic _accountLogic;
        private readonly ILogger<TRPGController> _logger;

        public TRPGController(IServiceProvider serviceProvider, ILogger<TRPGController> logger) 
        {
            _accountLogic = serviceProvider.GetRequiredService<IAccountLogic>();
            //_accountLogic = accountLogic;
            _logger = logger;
        }

        [HttpGet("test")]
        public string ConnectionTest()
        {
            return $"Pong";
        }

        [HttpPost("AddAccount")]
        public Guid AddAccount([FromBody] AccountModel data)
        {
            return _accountLogic.CreateAccount(data);
        }

        [HttpGet("test/{username}")]
        public string Get(string username)
        {
            return $"Pong";
        }

        [HttpGet("test/query")]
        public string TestQuery([FromQuery] string username)
        {
            return $"Pong";
        }

    }
}
