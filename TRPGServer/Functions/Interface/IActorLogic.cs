using TRPGServer.Model.RoomObject.PlaySet;

namespace TRPGServer.Functions.Interface
{
    public interface IActorLogic
    {
        bool CheckData(RoomActorModel actor);
        DateTime? CheckDeleted(Guid Id);
        Guid CreateActor(RoomActorModel dto);
        bool DeleteActor(Guid Id);
        RoomActorModel GetActorById(Guid Id);
        List<RoomActorModel> GetAllActorByRoom(Guid roomId);
        bool UpdateActor(RoomActorModel dto);
    }
}