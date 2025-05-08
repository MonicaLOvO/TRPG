

using TRPGServer.Model.RoomObject.ActiveCharacter;
using static TRPGServer.Entity.Enum.RoleEnum;

namespace TRPGServer.Model.RoomObject.PlaySet
{
    public class RoomActorModel
    {
        public Guid Id { get; set; }

        public RoomModel Room { get; set; }

        public AccountModel Account { get; set; }

        public RoleType Role { get; set; }

        public RoomCharacterModel[] Characters;

        public NoteModel[] Notes;

    }
}
