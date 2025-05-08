
using TRPGServer.Model.Character;

namespace TRPGServer.Model
{
    public class AccountModel
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string email { get; set; }
        public string Password { get; set; }
        public CharacterBaseModel[] Characters;
    }
}
