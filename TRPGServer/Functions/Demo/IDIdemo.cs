using System.Net.Sockets;
using System.Xml.Linq;

namespace TRPGServer.Functions.Demo
{
    public interface IDIdemo
    {
        int Value1 { get; set; }
        int Value2 { get; set; }


        //docker run -p 3306:3306 --name Database -e MYSQL_ROOT_PASSWORD = password - e MYSQL_ROOT_HOST=% -d mysql/mysql-server:latest  --default-authentication-plugin=mysql_native_password
    }
}