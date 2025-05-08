using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TRPGServer.Entity.RoomObject;
using static System.Net.Mime.MediaTypeNames;

namespace TRPGServer.Entity.Character
{
    public class CharacterItems
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public string ItemName { get; set; }
        public int Value { get; set; }
        [Required]
        public int Quantity { get; set; } = 1;
        public string Description { get; set; }

        public Guid DiceId { get; set; }
        [ForeignKey(nameof(DiceId))]
        public Dice Dice { get; set; }

        [Required]
        public Guid CharacterId { get; set; }
        [ForeignKey(nameof(CharacterId))]
        public CharacterBase CharacterBase { get; set; }
    }
}
