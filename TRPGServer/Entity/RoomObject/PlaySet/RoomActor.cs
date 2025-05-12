using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TRPGServer.Entity.RoomObject.ActiveCharacter;
using TRPGServer.Model.RoomObject.ActiveCharacter;
using TRPGServer.Model.RoomObject.PlaySet;
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

        public ICollection<RoomCharacter> Characters;

        public ICollection<Note> Notes;

        public RoomActor()
        {
            Characters = [];
            Notes = [];
        }

    }
}
