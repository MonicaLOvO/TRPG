using TRPGServer.Model.RoomObject;

namespace TRPGServer.Functions.Interface
{
    public interface IRoomLogic
    {
        bool CheckData(RoomModel room);
        DateTime? CheckDeleted(Guid Id);
        Guid CreateRoom(RoomModel dto);
        bool DeleteRoom(Guid Id);
        List<RoomModel> GetAllRoomByCreator(Guid creatorId);
        RoomModel GetRoomById(Guid Id);
        bool UpdateRoom(RoomModel dto);
    }
}