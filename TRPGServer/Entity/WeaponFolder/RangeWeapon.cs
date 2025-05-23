using System.ComponentModel.DataAnnotations;
namespace TRPGServer.Entity.WeaponFolder
{
    public class RangeWeapon
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();


    }
}
