using TRPGServer.Entity;
using TRPGServer.Entity.Character;
using TRPGServer.Entity.RoomObject;
using TRPGServer.Model;
using TRPGServer.Model.RoomObject;

namespace TRPGServer.Functions.Mapper
{
    public class RoomMapper
    {
        public static Room MapToEntity(RoomModel dto)
        {
            Room room = new Room() 
            {
                AccountId = dto.CreatorAccount.Id.Value,
                Name = dto.Name,
            };
            if (dto.Id != null)
            {
                room.Id = dto.Id.Value;
            }

            return room;
        }

        public static RoomModel MapToModel(Room room)
        {
            RoomModel roomModel = new()
            {
                Id = room.Id,
                CreatorAccount = room.Account == null ? AccountMapper.MapToModel(room.Account):null,
                
            };

            return roomModel;
        }

    }
}
