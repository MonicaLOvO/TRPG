using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TRPGServer.Entity.Class;
using TRPGServer.Entity.RoomObject.PlaySet;

namespace TRPGServer.Entity.RoomObject.ActiveCharacter
{
    public class RoomCharacter : Tracking
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public Guid RoomId { get; set; }
        [ForeignKey(nameof(RoomId))]
        public virtual Room Room { get; set; }

        [Required]
        public Guid ActorId { get; set; }
        [ForeignKey(nameof(ActorId))]
        public virtual RoomActor RoomActor { get; set; }

        [Required]
        public string Name { get; set; }
        public int? Age { get; set; }
        public string? Gender { get; set; }
        public string? Description { get; set; }
        public string? Occupation { get; set; }
        public string? Era { get; set; }
        public Guid? ImageId { get; set; }
        [ForeignKey(nameof(ImageId))]
        public virtual Image? Image { get; set; }

        [Required]
        public int STR { get; set; } = 0;
        [Required]
        public int CON { get; set; } = 0;
        [Required]
        public int SIZ { get; set; } = 0;
        [Required]
        public int DEX { get; set; } = 0;
        [Required]
        public int APP { get; set; } = 0;
        [Required]
        public int INT { get; set; } = 0;
        [Required]
        public int POW { get; set; } = 0;
        [Required]
        public int EDU { get; set; } = 0;
        public int? LUCK { get; set; }

        [Required]
        public int Hp { get; set; } = 0;

        [Required]
        public int MP { get; set; } = 0;
        [Required]
        public int SAN { get; set; } = 0;
        [Required]
        public int Mov { get; set; } = 0;

        public virtual ICollection<RoomCharacterItem> Items { get; set; }
        public virtual ICollection<RoomCharacterStatus> Status { get; set; }

        public RoomCharacter()
        {
            Items = [];
            Status = [];
        }
    }
}
