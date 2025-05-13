using TRPGServer.Model.Character;

namespace TRPGServer.Functions.Interface
{
    public interface IItemLogic
    {
        bool CheckData(CharacterItemsModel item);
        DateTime? CheckDeleted(Guid Id);
        Guid CreateItem(CharacterItemsModel dto);
        bool DeleteItem(Guid Id);
        List<CharacterItemsModel> GetAllItemsByCharacter(Guid Id);
        CharacterItemsModel GetItemById(Guid Id);
        bool UpdateItem(CharacterItemsModel dto);
    }
}