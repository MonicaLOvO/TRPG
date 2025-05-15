using TRPGServer.Entity.Character;
using TRPGServer.Entity.RoomObject.ActiveCharacter;

namespace TRPGServer.Functions.Interface
{
    public interface IRoomCharacterLogic
    {
        Guid AddItemsToCharacter(RoomCharacterItem sourse, Guid ClassId);
        Guid AddItemsToClass(CharacterItems sourse, Guid ClassId);
        Guid AddStatusToCharacter(RoomCharacterStatus sourse, Guid ClassId);
        Guid AddStatusToClass(CharacterStatus sourse, Guid ClassId);
        Guid DuplicateToCharacter(Guid ClassId);
        Guid DuplicateToRoomCharacter(Guid CharacterId, Guid RoomId, Guid ActorId);
    }
}