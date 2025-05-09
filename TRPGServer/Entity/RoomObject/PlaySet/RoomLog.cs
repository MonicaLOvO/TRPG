using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TRPGServer.Entity.RoomObject.PlaySet
{
    public class RoomLog : Tracking
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public Guid RoomId { get; set; }
        [ForeignKey(nameof(RoomId))]
        public Room Room { get; set; }

        public string? Title { get; set; }
        public string? Content { get; set; }
        public DateTime? Time { get; set; } = DateTime.Now;
    }
}
