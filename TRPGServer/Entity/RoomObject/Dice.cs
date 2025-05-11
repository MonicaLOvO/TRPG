using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TRPGServer.Entity.RoomObject
{
    public class Dice : Tracking
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public int Side { get; set; }
        [Required]
        public Guid TypeId { get; set; }
        [ForeignKey(nameof(TypeId))]
        public virtual GameType GameType { get; set; }


    }
}
