
using TRPGServer.Model.RoomObject;

namespace TRPGServer.Model
{
    public class StoryModel
    {
       
        public Guid Id { get; set; }

        public string Description { get; set; }
    
        public RoomModel Room { get; set; }
        public ImageModel Image { get; set; }




    }
}
