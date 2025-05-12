

using TRPGServer.Model.Character;
using TRPGServer.Model.RoomObject.ActiveCharacter;
using TRPGServer.Model.RoomObject.PlaySet;
using TRPGServer.Model.RoomObject.RoomSet;

namespace TRPGServer.Model.RoomObject
{
    public class RoomModel
    {

        public RoomModel() 
        {
            Actors = [];
            Rules = [];
            Templates = [];
            Chat = [];
            Logs = [];
            Characters = [];
        }

        public Guid? Id { get; set; }

        public AccountModel? CreatorAccount { get; set; }

        public RoomActorModel[] Actors;

        public RoomRuleModel[] Rules;
        
        public RoomTemplateModel[] Templates;

        public RoomChatModel[] Chat;

        public RoomLogModel[] Logs;

        public RoomCharacterModel[] Characters;
    }
}
