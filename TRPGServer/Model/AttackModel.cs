
using TRPGServer.Model.RoomObject.ActiveCharacter;

namespace TRPGServer.Model
{
    public class AttackModel
    {
        public Guid AttackerId { get; set; }
        public Guid TargetId { get; set; }
        public int Accuracy { get; set; }

        public RoomCharacterItemModel? Item { get; set; }


    }
}
