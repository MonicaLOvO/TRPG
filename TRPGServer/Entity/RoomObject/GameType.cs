using System.ComponentModel.DataAnnotations;

namespace TRPGServer.Entity.RoomObject
{
    public class GameType
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public string Type { get; set; }
    }
}
