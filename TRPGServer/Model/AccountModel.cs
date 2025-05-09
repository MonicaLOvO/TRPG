
using TRPGServer.Entity.Character;
using TRPGServer.Model.Character;

namespace TRPGServer.Model
{
    public class AccountModel
    {
        public AccountModel()
        {
            Characters = [];
            UserName = "";
            Email = "";
        }
        public Guid? Id { get; set; }
        public string? UserName { get; set; }
        public string Email { get; set; }
        public string? Password { get; set; }
        public List<CharacterBaseModel> Characters;
    }
}
