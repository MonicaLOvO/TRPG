using TRPGServer.Model.Character;

namespace TRPGServer.Functions.Interface
{
    public interface ICharacterLogic
    {
        bool CheckData(CharacterBaseModel character);
        DateTime? CheckDeleted(Guid Id);
        Guid CreateCharacter(CharacterBaseModel dto);
        bool DeleteCharacter(Guid Id);
        List<CharacterBaseModel> GetAllCharacter();
        CharacterBaseModel GetCharacterById(Guid Id);
        bool UpdateCharacter(CharacterBaseModel dto);
    }
}