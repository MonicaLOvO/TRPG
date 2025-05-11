using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TRPGServer.Entity.RoomObject.PlaySet
{
    public class Note : Tracking
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? Title { get; set; }
        public string? Content { get; set; }
        [Required]
        public Guid ActorId { get; set; }
        [ForeignKey(nameof(ActorId))]
        public virtual RoomActor RoomActor { get; set; }
    }
}
