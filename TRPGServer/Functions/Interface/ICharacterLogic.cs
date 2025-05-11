using TRPGServer.Model.Character;

namespace TRPGServer.Functions.Interface
{
    public interface ICharacterLogic
    {
        CharacterBaseModel GetCharacterById(Guid Id);
    }
}