using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static TRPGServer.Entity.Enum.RoleEnum;

namespace TRPGServer.Entity.RoomObject.PlaySet
{
    public class RoomActor : Tracking
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public Guid RoomId { get; set; }
        [ForeignKey(nameof(RoomId))]
        public virtual Room Room { get; set; }

        [Required]
        public Guid AccountId { get; set; }
        [ForeignKey(nameof(AccountId))]
        public virtual Account Account { get; set; }

        [Required]
        public virtual RoleType Role { get; set; }

        

    }
}
