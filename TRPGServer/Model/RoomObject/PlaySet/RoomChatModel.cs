

namespace TRPGServer.Model.RoomObject.PlaySet
{
    public class RoomChatModel
    {

        public Guid? Id { get; set; } 
        public RoomModel? Room { get; set; }

        public string? Title { get; set; }
        public string? Content { get; set; }
        public DateTime? Time { get; set; }
    }
}
