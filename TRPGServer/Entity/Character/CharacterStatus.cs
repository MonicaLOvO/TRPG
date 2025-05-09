using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TRPGServer.Entity.Character
{
    public class CharacterStatus : Tracking
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public string StatusName { get; set; }
        [Required]
        public int Value { get; set; } = 0;

        public string? Description { get; set; }
        [Required]
        public Guid CharacterId { get; set; }
        [ForeignKey(nameof(CharacterId))]
        public CharacterBase CharacterBase { get; set; }
    }
}
