using Microsoft.EntityFrameworkCore;
using TRPGServer.Data;
using TRPGServer.Entity.Character;
using TRPGServer.Entity.Class;
using TRPGServer.Entity.RoomObject.ActiveCharacter;
using TRPGServer.Functions.Interface;

namespace TRPGServer.Functions.Logic.CharacterLogicFolder
{
    public class RoomCharacterLogic : IRoomCharacterLogic
    {
        private readonly AppDbContext _context;

        public RoomCharacterLogic(IServiceProvider serviceProvider)
        {
            _context = serviceProvider.GetRequiredService<AppDbContext>();
        }

        public Guid DuplicateToRoomCharacter(Guid CharacterId, Guid RoomId, Guid ActorId)
        {
            RoomCharacter result = new RoomCharacter();
            var sourse = _context.CharacterBase
                .Include(c => c.Items)
                .Include(c => c.Status)
                .Where(c => c.Id == CharacterId).FirstOrDefault();

            result.SourseId = CharacterId;
            result.Name = sourse.Name ?? "";
            result.Age = sourse.Age;
            result.Gender = sourse.Gender;
            result.Description = sourse.Description ?? "";
            result.Occupation = sourse.Occupation;
            result.Era = sourse.Era;
            result.RoomId = RoomId;
            result.ActorId = ActorId;

            result.STR = sourse.STR;
            result.CON = sourse.CON;
            result.SIZ = sourse.SIZ;
            result.DEX = sourse.DEX;
            result.APP = sourse.APP;
            result.INT = sourse.INT;
            result.POW = sourse.POW;
            result.EDU = sourse.EDU;
            result.LUCK = sourse.LUCK;
            result.Hp = sourse.Hp;
            result.MP = sourse.MP;
            result.SAN = sourse.SAN;
            result.Mov = sourse.Mov;

            result.ImageId = sourse.ImageId;
            _context.RoomCharacter.Add(result);
            _context.SaveChanges();

            foreach (var item in sourse.Items)
            {
                AddItemsToClass(item, result.Id);
            }
            foreach (var status in sourse.Status)
            {
                AddStatusToClass(status, result.Id);
            }

            return result.Id;
        }
        public Guid DuplicateToCharacter(Guid ClassId)
        {
            CharacterBase result = new CharacterBase();
            var sourse = _context.RoomCharacter
                .Include(c => c.Items)
                .Include(c => c.Status)
                .Where(c => c.Id == ClassId).FirstOrDefault();

            result.Name = sourse.Name ?? "";
            result.Age = sourse.Age;
            result.Gender = sourse.Gender;
            result.Description = sourse.Description ?? "";
            result.Occupation = sourse.Occupation;
            result.Era = sourse.Era;

            result.STR = sourse.STR;
            result.CON = sourse.CON;
            result.SIZ = sourse.SIZ;
            result.DEX = sourse.DEX;
            result.APP = sourse.APP;
            result.INT = sourse.INT;
            result.POW = sourse.POW;
            result.EDU = sourse.EDU;
            result.LUCK = sourse.LUCK;
            result.Hp = sourse.Hp;
            result.MP = sourse.MP;
            result.SAN = sourse.SAN;
            result.Mov = sourse.Mov;

            result.ImageId = sourse.ImageId;
            _context.CharacterBase.Add(result);
            _context.SaveChanges();

            foreach (var item in sourse.Items)
            {
                AddItemsToCharacter(item, result.Id);
            }
            foreach (var status in sourse.Status)
            {
                AddStatusToCharacter(status, result.Id);
            }

            return result.Id;
        }

        public Guid AddItemsToCharacter(RoomCharacterItem sourse, Guid ClassId)
        {
            CharacterItems result = new CharacterItems()
            {
                ItemName = sourse.ItemName,
                Value = sourse.Value,
                Quantity = sourse.Quantity,
                Description = sourse.Description,
                DiceId = sourse.DiceId,
                CharacterId = ClassId
            };
            _context.CharacterItems.Add(result);
            _context.SaveChanges();
            return result.Id;
        }
        public Guid AddStatusToCharacter(RoomCharacterStatus sourse, Guid ClassId)
        {
            CharacterStatus result = new()
            {
                StatusName = sourse.StatusName,
                Value = sourse.Value,
                Description = sourse.Description,
                CharacterId = ClassId
            };

            _context.CharacterStatus.Add(result);
            _context.SaveChanges();
            return result.Id;
        }
        public Guid AddItemsToClass(CharacterItems sourse, Guid ClassId)
        {
            RoomCharacterItem result = new RoomCharacterItem()
            {
                ItemName = sourse.ItemName,
                Value = sourse.Value,
                Quantity = sourse.Quantity,
                Description = sourse.Description,
                DiceId = sourse.DiceId,
                RoomCharacterId = ClassId
            };



            _context.RoomCharacterItem.Add(result);
            _context.SaveChanges();
            return result.Id;
        }
        public Guid AddStatusToClass(CharacterStatus sourse, Guid ClassId)
        {
            RoomCharacterStatus result = new()
            {
                StatusName = sourse.StatusName,
                Value = sourse.Value,
                Description = sourse.Description,
                RoomCharacterId = ClassId
            };



            _context.RoomCharacterStatus.Add(result);
            _context.SaveChanges();
            return result.Id;
        }
    }
}
