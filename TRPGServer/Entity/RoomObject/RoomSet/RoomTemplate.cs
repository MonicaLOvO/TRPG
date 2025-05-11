using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TRPGServer.Entity.RoomObject.RoomSet
{
    public class RoomTemplate : Tracking
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public Guid RoomId { get; set; }
        [ForeignKey(nameof(RoomId))]
        public virtual Room Room { get; set; }

        public string? Title { get; set; }
        [Required]
        public bool VisiableToPlayer { get; set; } = true;

    }
}
