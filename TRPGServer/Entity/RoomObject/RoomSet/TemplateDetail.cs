using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TRPGServer.Entity.RoomObject.RoomSet
{
    public class TemplateDetail
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public Guid RoomTemplateId { get; set; }
        [ForeignKey(nameof(RoomTemplateId))]
        public RoomTemplate RoomTemplate { get; set; }

        [Required]
        public bool VisiableToPlayer { get; set; } = true;

        public string Title { get; set; }
        public string Content { get; set; }
    }
}
