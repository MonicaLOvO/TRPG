using Microsoft.AspNetCore.Mvc;
using TRPGServer.Functions.Interface;
using TRPGServer.Model;

namespace TRPGServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : Controller
    {
        private IAccountLogic _accountLogic;
        private readonly ILogger<AccountController> _logger;

        public AccountController(IServiceProvider serviceProvider, ILogger<AccountController> logger)
        {
            _accountLogic = serviceProvider.GetRequiredService<IAccountLogic>();
            //_accountLogic = accountLogic;
            _logger = logger;
        }


        [HttpPost("")]
        public Guid AddAccount([FromBody] AccountModel data)
        {
            return _accountLogic.CreateAccount(data);
        }

        [HttpPut("")]
        public bool UpdateAccount([FromBody] AccountModel data)
        {
            return _accountLogic.UpdateAccount(data);
        }

        [HttpGet("{Id}")]
        public AccountModel GetAccountById( Guid Id)
        {
            return _accountLogic.GetAccountById(Id);
        }

        [HttpPost("Login")]
        public AccountModel GetAccountByLogin([FromBody] AccountModel data)
        {
            return _accountLogic.GetAccountByLogin( data.Email,data.Password);
        }

        [HttpGet("GetAllAccount")]
        public List<AccountModel> GetAllAccount()
        {
            return _accountLogic.GetAllAccount();
        }

        [HttpDelete("")]
        public bool DeleteAccount(Guid Id)
        {
            return _accountLogic.DeleteAccount(Id);
        }


    }
}
