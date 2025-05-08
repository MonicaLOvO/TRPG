using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TRPGServer.Entity.Class
{
    public class ClassBase
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Description { get; set; }
        public string Occupation { get; set; }
        public string Era { get; set; }
        public Guid ImageId { get; set; }
        [ForeignKey(nameof(ImageId))]
        public Image Image { get; set; }

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
        public int LUCK { get; set; }

        [Required]
        public int Hp { get; set; } = 0;

        [Required]
        public int MP { get; set; } = 0;
        [Required]
        public int SAN { get; set; } = 0;
        [Required]
        public int Mov { get; set; } = 0;
    }
}
