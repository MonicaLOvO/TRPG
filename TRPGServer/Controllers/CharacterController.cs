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
        private IStatusLogic _statusLogic;
        private IItemLogic _itemLogic;
        private readonly ILogger<CharacterController> _logger;

        public CharacterController(IServiceProvider serviceProvider, ILogger<CharacterController> logger)
        {
            _characterLogic = serviceProvider.GetRequiredService<ICharacterLogic>();
            _statusLogic = serviceProvider.GetRequiredService<IStatusLogic>();
            _itemLogic = serviceProvider.GetRequiredService<IItemLogic>();
            //_accountLogic = accountLogic;
            _logger = logger;
        }

        [HttpGet("{Id}")]
        public CharacterBaseModel GetCharacterById(Guid Id)
        {
            return _characterLogic.GetCharacterById(Id);
        }

        [HttpPost("")]
        public Guid CreateCharacter([FromBody] CharacterBaseModel data)
        {
            return _characterLogic.CreateCharacter(data);
        }

        [HttpPut("")]
        public bool UpdateCharacter([FromBody] CharacterBaseModel data)
        {
            return _characterLogic.UpdateCharacter(data);
        }

        [HttpGet("GetAllCharacter")]
        public List<CharacterBaseModel> GetAllCharacter()
        {
            return _characterLogic.GetAllCharacter();
        }

        [HttpDelete("")]
        public bool DeleteCharacter(Guid Id)
        {
            return _characterLogic.DeleteCharacter(Id);
        }


        [HttpGet("Status/{Id}")]
        public CharacterStatusModel GetStatusById(Guid Id)
        {
            return _statusLogic.GetStatusById(Id);
        }
        [HttpPost("Status")]
        public Guid CreateStatus([FromBody] CharacterStatusModel data)
        {
            return _statusLogic.CreateStatus(data);
        }
        [HttpPut("Status")]
        public bool UpdateStatus([FromBody] CharacterStatusModel data)
        {
            return _statusLogic.UpdateStatus(data);
        }
        [HttpGet("GetAllStatus/{Id}")]
        public List<CharacterStatusModel> GetAllStatusByCharacter(Guid Id)
        {
            return _statusLogic.GetAllStatusByCharacter(Id);
        }
        [HttpDelete("Status")]
        public bool DeleteStatus(Guid Id)
        {
            return _statusLogic.DeleteStatus(Id);
        }


        [HttpGet("Item/{Id}")]
        public CharacterItemsModel GetItemById(Guid Id)
        {
            return _itemLogic.GetItemById(Id);
        }
        [HttpPost("Item")]
        public Guid CreateItem([FromBody] CharacterItemsModel data)
        {
            return _itemLogic.CreateItem(data);
        }
        [HttpPut("Item")]
        public bool UpdateItem([FromBody] CharacterItemsModel data)
        {
            return _itemLogic.UpdateItem(data);
        }
        [HttpGet("GetAllItem/{Id}")]
        public List<CharacterItemsModel> GetAllItemsByCharacter(Guid Id)
        {
            return _itemLogic.GetAllItemsByCharacter(Id);
        }
        [HttpDelete("Item")]
        public bool DeleteItem(Guid Id)
        {
            return _itemLogic.DeleteItem(Id);
        }
    }
}
