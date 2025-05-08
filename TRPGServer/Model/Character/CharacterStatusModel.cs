
namespace TRPGServer.Model.Character
{
    public class CharacterStatusModel
    {

        public Guid Id { get; set; } 
        public string StatusName { get; set; }
        public int Value { get; set; }

        public string Description { get; set; }
        public CharacterBaseModel CharacterBase { get; set; }
    }
}
