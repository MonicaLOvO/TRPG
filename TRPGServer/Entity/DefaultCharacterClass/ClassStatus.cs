using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TRPGServer.Entity.Character;

namespace TRPGServer.Entity.Class
{
    public class ClassStatus : Tracking
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public string StatusName { get; set; }
        [Required]
        public int Value { get; set; } = 0;

        public string? Description { get; set; }

        public Guid? ClassBaseId { get; set; }
        [ForeignKey(nameof(ClassBaseId))]
        public virtual ClassBase? ClassBase { get; set; }
    }
}
