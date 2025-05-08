using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TRPGServer.Entity.Character;
using TRPGServer.Entity.RoomObject;
using static System.Net.Mime.MediaTypeNames;

namespace TRPGServer.Entity.Class
{
    public class ClassItems
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public string ItemName { get; set; }
        public int Value { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }

        public Guid DiceId { get; set; }
        [ForeignKey(nameof(DiceId))]
        public Dice Dice { get; set; }


        public Guid CharacterId { get; set; }
        [ForeignKey(nameof(CharacterId))]
        public CharacterBase CharacterBase { get; set; }
    }
}
