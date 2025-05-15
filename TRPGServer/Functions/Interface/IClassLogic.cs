using TRPGServer.Entity.Character;
using TRPGServer.Entity.Class;

namespace TRPGServer.Functions.Interface
{
    public interface IClassLogic
    {
        Guid AddItemsToCharacter(ClassItems sourse, Guid ClassId);
        Guid AddItemsToClass(CharacterItems sourse, Guid ClassId);
        Guid AddStatusToCharacter(ClassStatus sourse, Guid ClassId);
        Guid AddStatusToClass(CharacterStatus sourse, Guid ClassId);
        Guid DuplicateToCharacter(Guid ClassId);
        Guid DuplicateToClass(Guid CharacterId);
    }
}