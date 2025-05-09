

using TRPGServer.Model.Character;

namespace TRPGServer.Model.RoomObject.ActiveCharacter
{
    public class RoomCharacterItemModel
    {

        public Guid? Id { get; set; }
        public string? ItemName { get; set; }
        public int? Value { get; set; }
        public int? Quantity { get; set; }
        public string? Description { get; set; }
        public DiceModel? Dice { get; set; }
        public CharacterBaseModel? CharacterBase { get; set; }
    }
}
