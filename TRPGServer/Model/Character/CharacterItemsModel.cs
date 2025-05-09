

using TRPGServer.Model.RoomObject;

namespace TRPGServer.Model.Character
{
    public class CharacterItemsModel
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
