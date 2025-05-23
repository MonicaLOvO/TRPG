using TRPGServer.Entity.RoomObject;

using System.ComponentModel.DataAnnotations;
namespace TRPGServer.Entity.WeaponFolder.WeaponFolder
{
    public class Weapon
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        public int? durable { get; set; }

    }
}
