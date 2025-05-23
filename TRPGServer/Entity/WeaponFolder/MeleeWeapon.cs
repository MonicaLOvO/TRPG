using System.ComponentModel.DataAnnotations;
namespace TRPGServer.Entity.WeaponFolder
{
    public class MeleeWeapon
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
