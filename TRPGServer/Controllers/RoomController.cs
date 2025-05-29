using Microsoft.AspNetCore.Mvc;
using TRPGServer.Functions.Interface;
using TRPGServer.Model.RoomObject;

namespace TRPGServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoomController : Controller
    {

        private IRoomLogic _roomLogic;
        private readonly ILogger<RoomController> _logger;

        public RoomController(IServiceProvider serviceProvider, ILogger<RoomController> logger)
        {
            _roomLogic = serviceProvider.GetRequiredService<IRoomLogic>();
            _logger = logger;
        }

        [HttpGet("{Id}")]
        public RoomModel GetRoomById(Guid Id)
        {
            return _roomLogic.GetRoomById(Id);
        }

        [HttpPost("")]
        public Guid CreateRoom([FromBody] RoomModel data)
        {
            return _roomLogic.CreateRoom(data);
        }

        [HttpPut("")]
        public bool UpdateRoom([FromBody] RoomModel data)
        {
            return _roomLogic.UpdateRoom(data);
        }

        [HttpGet("GetAllRoom/{Id}")]
        public List<RoomModel> GetAllRoomByCreator(Guid Id)
        {
            return _roomLogic.GetAllRoomByCreator(Id);
        }

        [HttpDelete("{Id}")]
        public bool DeleteRoom(Guid Id)
        {
            return _roomLogic.DeleteRoom(Id);
        }
    }
}
