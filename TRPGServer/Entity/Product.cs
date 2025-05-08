using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Sockets;
using System.Xml.Linq;

namespace TRPGServer.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Type { get; set; }

        public double Price { get; set; }

        //[Key]
        //public int ProducerID { get; set; }

        //[Required]
        //[StringLength(254)]
        //public string Name { get; set; }

        // Foreign Key
        //public int CategoryId { get; set; }

        // Navigation property
        //[ForeignKey(nameof(CharacterId))]
        //public Category Category { get; set; }

        //docker run -p 3307:3306 --name Database -e MYSQL_ROOT_PASSWORD = password - e MYSQL_ROOT_HOST=% -d mysql/mysql-server:latest  --default-authentication-plugin=mysql_native_password
    }
}
