using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TRPGServer.Entity.RoomObject.PlaySet
{
    public class RoomChat : Tracking
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public Guid RoomId { get; set; }
        [ForeignKey(nameof(RoomId))]
        public virtual Room Room { get; set; }

        public string? Title { get; set; }
        public string? Content { get; set; }
        public DateTime? Time { get; set; } = DateTime.Now;
    }
}
