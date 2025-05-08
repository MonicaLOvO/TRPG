using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Sockets;
using System.Xml.Linq;
using TRPGServer.Entity.RoomObject;
namespace TRPGServer.Entity
{
    public class Story
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Description { get; set; }
        [Required]
        public Guid RoomId { get; set; }
        [ForeignKey(nameof(RoomId))]
        public Room Room { get; set; }

        public Guid ImageId { get; set; }
        [ForeignKey(nameof(ImageId))]
        public Image Image { get; set; }




    }
}
