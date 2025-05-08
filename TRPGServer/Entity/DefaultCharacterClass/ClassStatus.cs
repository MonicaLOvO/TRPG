using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TRPGServer.Entity.Character;

namespace TRPGServer.Entity.Class
{
    public class ClassStatus
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public string StatusName { get; set; }
        [Required]
        public int Value { get; set; } = 0;

        public string Description { get; set; }

        public Guid CharacterId { get; set; }
        [ForeignKey(nameof(CharacterId))]
        public CharacterBase CharacterBase { get; set; }
    }
}
