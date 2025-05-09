

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
            RoomActors = [];
            RoomRules = [];
            RoomTemplates = [];
            RoomChat = [];
            RoomLogs = [];
            RoomCharacters = [];
        }

        public Guid? Id { get; set; }

        public AccountModel? CreatorAccount { get; set; }

        public RoomActorModel[] RoomActors;

        public RoomRuleModel[] RoomRules;
        
        public RoomTemplateModel[] RoomTemplates;

        public RoomChatModel[] RoomChat;

        public RoomLogModel[] RoomLogs;

        public RoomCharacterModel[] RoomCharacters;
    }
}
