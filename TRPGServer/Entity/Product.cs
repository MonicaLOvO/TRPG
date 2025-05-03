using System.Net.Sockets;
using System.Xml.Linq;

namespace TRPGServer.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public double Price { get; set; }

        //docker run -p 3307:3306 --name Database -e MYSQL_ROOT_PASSWORD = password - e MYSQL_ROOT_HOST=% -d mysql/mysql-server:latest  --default-authentication-plugin=mysql_native_password
    }
}
