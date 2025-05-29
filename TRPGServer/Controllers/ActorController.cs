using Microsoft.AspNetCore.Mvc;
using TRPGServer.Functions.Interface;
using TRPGServer.Model.RoomObject;
using TRPGServer.Model.RoomObject.PlaySet;

namespace TRPGServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ActorController : Controller
    {
        private IActorLogic _actorLogic;
        private readonly ILogger<ActorController> _logger;

        public ActorController(IServiceProvider serviceProvider, ILogger<ActorController> logger)
        {
            _actorLogic = serviceProvider.GetRequiredService<IActorLogic>();
            _logger = logger;
        }

        [HttpGet("{Id}")]
        public RoomActorModel GetActorById(Guid Id)
        {
            return _actorLogic.GetActorById(Id);
        }

        [HttpPost("")]
        public Guid CreateActor([FromBody] RoomActorModel data)
        {
            return _actorLogic.CreateActor(data);
        }

        [HttpPut("")]
        public bool UpdateActor([FromBody] RoomActorModel data)
        {
            return _actorLogic.UpdateActor(data);
        }

        [HttpGet("GetAllActorByRoom/{Id}")]
        public List<RoomActorModel> GetAllActorByRoom(Guid Id)
        {
            return _actorLogic.GetAllActorByRoom(Id);
        }

        [HttpDelete("{Id}")]
        public bool DeleteActor(Guid Id)
        {
            return _actorLogic.DeleteActor(Id);
        }
    }
}
