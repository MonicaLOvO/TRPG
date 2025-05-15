using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TRPGServer.Model.RoomObject.ActiveCharacter;
using TRPGServer.Model.RoomObject.PlaySet;
using TRPGServer.Model.RoomObject.RoomSet;
using TRPGServer.Model;
using TRPGServer.Entity.RoomObject.PlaySet;
using TRPGServer.Entity.RoomObject.ActiveCharacter;
using TRPGServer.Entity.RoomObject.RoomSet;

namespace TRPGServer.Entity.RoomObject
{
    public class Room : Tracking
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public Guid AccountId { get; set; }
        [ForeignKey(nameof(AccountId))]
        [Required]
        public string Name { get; set; }
        public virtual Account Account { get; set; }

        public virtual ICollection<RoomActor> Actors { get; set; }

        public virtual ICollection<RoomRule> Rules { get; set; }

        public virtual ICollection<RoomTemplate> Templates { get; set; }

        public virtual ICollection<RoomChat> Chat { get; set; }

        public virtual ICollection<RoomLog> Logs { get; set; }

        public virtual ICollection<RoomCharacter> Characters { get; set; }

        public Room()
        {
            Actors = [];
            Rules = [];
            Templates = [];
            Chat = [];
            Logs = [];
            Characters = [];
        }
    }
}
