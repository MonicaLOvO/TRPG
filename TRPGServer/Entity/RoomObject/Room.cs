using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TRPGServer.Entity.RoomObject
{
    public class Room : Tracking
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public Guid CreatorId { get; set; }
        [ForeignKey(nameof(CreatorId))]
        public Account Account { get; set; }



    }
}
