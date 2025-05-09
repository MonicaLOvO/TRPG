using System.ComponentModel.DataAnnotations;

namespace TRPGServer.Entity
{
    public class Image : Tracking
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public string ImageBase64 { get; set; }
    }
}
