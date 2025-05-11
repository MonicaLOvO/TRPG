using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TRPGServer.Entity.Character;

namespace TRPGServer.Entity.RoomObject.ActiveCharacter
{
    public class RoomCharacterItem : Tracking
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public string ItemName { get; set; }
        public int? Value { get; set; }
        [Required]
        public int Quantity { get; set; } = 1;
        public string? Description { get; set; }

        public Guid? DiceId { get; set; }
        [ForeignKey(nameof(DiceId))]
        public virtual Dice? Dice { get; set; }

        [Required]
        public Guid CharacterId { get; set; }
        [ForeignKey(nameof(CharacterId))]
        public virtual CharacterBase CharacterBase { get; set; }
    }
}
