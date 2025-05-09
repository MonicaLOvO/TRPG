using TRPGServer.Model.Character;

namespace TRPGServer.Model.RoomObject.ActiveCharacter
{
    public class RoomCharacterStatusModel
    {

        public Guid? Id { get; set; }

        public string? StatusName { get; set; }

        public int? Value { get; set; } 
        public string? Description { get; set; }
        public CharacterBaseModel? CharacterBase { get; set; }
    }
}
