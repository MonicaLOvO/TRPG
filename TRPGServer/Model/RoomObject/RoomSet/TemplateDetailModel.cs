

namespace TRPGServer.Model.RoomObject.RoomSet
{
    public class TemplateDetailModel
    {

        public Guid Id { get; set; }
        public RoomTemplateModel RoomTemplate { get; set; }
        public bool VisiableToPlayer { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
