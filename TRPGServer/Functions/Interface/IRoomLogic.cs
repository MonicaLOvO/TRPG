using TRPGServer.Model;
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
        ResultContainer SearchRoom(string searchQuery, string page, string limit);
        RoomModel GetRoomById(Guid Id);
        bool UpdateRoom(RoomModel dto);
    }
}