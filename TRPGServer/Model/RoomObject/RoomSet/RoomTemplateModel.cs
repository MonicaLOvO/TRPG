

using TRPGServer.Model.Character;

namespace TRPGServer.Model.RoomObject.RoomSet
{
    public class RoomTemplateModel
    {

        public Guid Id { get; set; }
        public RoomModel Room { get; set; }

        public TemplateDetailModel[] TemplateDetails;

        public string Title { get; set; }
        public bool VisiableToPlayer { get; set; }

    }
}
