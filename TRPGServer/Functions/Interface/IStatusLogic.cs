using TRPGServer.Model.Character;

namespace TRPGServer.Functions.Interface
{
    public interface IStatusLogic
    {
        bool CheckData(CharacterStatusModel status);
        DateTime? CheckDeleted(Guid Id);
        Guid CreateStatus(CharacterStatusModel dto);
        bool DeleteStatus(Guid Id);
        List<CharacterStatusModel> GetAllStatusByCharacter(Guid Id);
        CharacterStatusModel GetStatusById(Guid Id);
        bool UpdateStatus(CharacterStatusModel dto);
    }
}