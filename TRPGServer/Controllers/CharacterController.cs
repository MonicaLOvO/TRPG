using Microsoft.AspNetCore.Mvc;
using TRPGServer.Entity.RoomObject;
using TRPGServer.Functions.Interface;
using TRPGServer.Functions.Logic;
using TRPGServer.Model;
using TRPGServer.Model.Character;
using TRPGServer.Model.RoomObject.ActiveCharacter;

namespace TRPGServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : Controller
    {
        private IClassLogic _classLogic;
        private IRoomCharacterLogic _roomCharacterLogic;
        private ICharacterLogic _characterLogic;
        private IStatusLogic _statusLogic;
        private IItemLogic _itemLogic;
        private readonly ILogger<CharacterController> _logger;

        public CharacterController(IServiceProvider serviceProvider, ILogger<CharacterController> logger)
        {
            _characterLogic = serviceProvider.GetRequiredService<ICharacterLogic>();
            _roomCharacterLogic = serviceProvider.GetRequiredService<IRoomCharacterLogic>();
            _classLogic = serviceProvider.GetRequiredService<IClassLogic>();
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

        [HttpGet("GetAllCharacter/{Id}")]
        public List<CharacterBaseModel> GetAllCharacter(Guid Id)
        {
            return _characterLogic.GetAllCharacterByCreator(Id);
        }

        [HttpDelete("{Id}")]
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
        [HttpDelete("Status/{Id}")]
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
        [HttpDelete("Item/{Id}")]
        public bool DeleteItem(Guid Id)
        {
            return _itemLogic.DeleteItem(Id);
        }

        [HttpPut("DuplicateToClass/{Id}")]
        public Guid DuplicateToClass(Guid Id)
        {
            return _classLogic.DuplicateToClass(Id);
        }

        [HttpPut("DuplicateClassToCharacter/{Id}")]
        public Guid DuplicateToCharacter(Guid Id)
        {
            return _classLogic.DuplicateToCharacter(Id);
        }

        [HttpPut("DuplicateToClass")]
        public Guid DuplicateToRoomCharacter([FromBody] RoomCharacterModel dto)
        {
            return _roomCharacterLogic.DuplicateToRoomCharacter(dto.Id ?? Guid.Empty, dto.Room?.Id ?? Guid.Empty, dto.RoomActor?.Id??Guid.Empty);
        }

        [HttpPut("DuplicateRoomCharacterToCharacter/{Id}")]
        public Guid DuplicateRoomCharacterToCharacter(Guid Id)
        {
            return _roomCharacterLogic.DuplicateToCharacter(Id);
        }
    }
}
