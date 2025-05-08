

using TRPGServer.Model.Character;
using TRPGServer.Model.RoomObject;

namespace TRPGServer.Model.Class
{
    public class ClassItemsModel
    {
        public Guid Id { get; set; }
        public string ItemName { get; set; }
        public int Value { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public DiceModel Dice { get; set; }
        public CharacterBaseModel CharacterBase { get; set; }
    }
}
