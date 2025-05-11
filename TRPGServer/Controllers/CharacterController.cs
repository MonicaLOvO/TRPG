using Microsoft.AspNetCore.Mvc;
using TRPGServer.Functions.Interface;
using TRPGServer.Functions.Logic;
using TRPGServer.Model;
using TRPGServer.Model.Character;

namespace TRPGServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : Controller
    {
        private ICharacterLogic _characterLogic;
        private readonly ILogger<CharacterController> _logger;

        public CharacterController(IServiceProvider serviceProvider, ILogger<CharacterController> logger)
        {
            _characterLogic = serviceProvider.GetRequiredService<ICharacterLogic>();
            //_accountLogic = accountLogic;
            _logger = logger;
        }

        [HttpGet("{Id}")]
        public CharacterBaseModel GetCharacterById(Guid Id)
        {
            return _characterLogic.GetCharacterById(Id);
        }
    }
}
