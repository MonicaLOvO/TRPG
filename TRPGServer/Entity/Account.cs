using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Sockets;
using System.Xml.Linq;
using TRPGServer.Entity.Character;
using TRPGServer.Model.Character;
namespace TRPGServer.Entity
{
    public class Account : Tracking
    {
       [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        public virtual ICollection<CharacterBase> Characters { get; set; }

        public Account()
        {
            Characters = [];
            
        }

    }
}
