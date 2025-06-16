using Microsoft.AspNetCore.Mvc;
using TRPGServer.Functions.Interface;
using TRPGServer.Functions.Logic.RoomLogicFolder;
using TRPGServer.Model;
using TRPGServer.Model.RoomObject;
using TRPGServer.Model.RoomObject.PlaySet;

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

        [HttpGet("SearchRoom/{searchQuery}")]
        public ResultContainer SearchRoom(string searchQuery, [FromQuery] string? page, [FromQuery] string? limit)
        {
            page = page ?? "1";
            limit = limit ?? "10";

            return _roomLogic.SearchRoom(searchQuery, page, limit);
        }

        [HttpDelete("{Id}")]
        public bool DeleteRoom(Guid Id)
        {
            return _roomLogic.DeleteRoom(Id);
        }
    }
}
