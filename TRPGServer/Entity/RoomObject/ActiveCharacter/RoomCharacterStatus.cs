using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TRPGServer.Entity.Character;

namespace TRPGServer.Entity.RoomObject.ActiveCharacter
{
    public class RoomCharacterStatus : Tracking
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public string StatusName { get; set; }
        [Required]
        public int Value { get; set; } = 0;

        public string? Description { get; set; }
        [Required]
        public Guid RoomCharacterId { get; set; }
        [ForeignKey(nameof(RoomCharacterId))]
        public virtual RoomCharacter RoomCharacter { get; set; }
    }
}
