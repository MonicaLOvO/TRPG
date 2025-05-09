

namespace TRPGServer.Model.RoomObject
{
    public class DiceModel
    {

        public Guid? Id { get; set; } 
        public int? Side { get; set; }
        public GameTypeModel? GameType { get; set; }


    }
}
