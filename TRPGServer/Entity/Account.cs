using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Sockets;
using System.Xml.Linq;
namespace TRPGServer.Entity
{
    public class Account
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public string UserName { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string Password { get; set; }

    }
}
