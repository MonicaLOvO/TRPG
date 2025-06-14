using Microsoft.EntityFrameworkCore;
using TRPGServer.Entity.RoomObject;
using TRPGServer.Entity.RoomObject.PlaySet;
using TRPGServer.Model.RoomObject;
using TRPGServer.Model.RoomObject.PlaySet;

namespace TRPGServer.Functions.Mapper
{
    public class ActorMapper
    {
        public static RoomActor MapToEntity(RoomActorModel dto)
        {
            RoomActor actor = new RoomActor()
            {
                AccountId = dto.Account.Id.Value,
                RoomId = dto.Room.Id.Value,
                Role = dto.Role ?? 0,
            };
            if (dto.Id != null)
            {
                actor.Id = dto.Id.Value;
            }

            return actor;
        }

        public static RoomActorModel MapToModel(RoomActor actor)
        {
            RoomActorModel actorModel = new();
            actorModel.Id = actor.Id;
            actorModel.Room = RoomMapper.MapToModel(actor.Room);
            actorModel.Account = AccountMapper.MapToModel(actor.Account);
            actorModel.Role = actor.Role;

            return actorModel;
        }
    }
}
