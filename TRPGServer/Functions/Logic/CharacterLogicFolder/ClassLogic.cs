using Microsoft.EntityFrameworkCore;
using TRPGServer.Data;
using TRPGServer.Entity.Character;
using TRPGServer.Entity.Class;
using TRPGServer.Functions.Interface;
using TRPGServer.Functions.Mapper;
using TRPGServer.Model.Character;
using TRPGServer.Model.Class;

namespace TRPGServer.Functions.Logic.CharacterLogicFolder
{
    public class ClassLogic : IClassLogic
    {
        private readonly AppDbContext _context;

        public ClassLogic(IServiceProvider serviceProvider)
        {
            _context = serviceProvider.GetRequiredService<AppDbContext>();
        }

        public Guid DuplicateToClass(Guid CharacterId)
        {
            ClassBase result = new ClassBase();
            var sourse = _context.CharacterBase
                .Include(c => c.Items)
                .Include(c => c.Status)
                .Where(c => c.Id == CharacterId).FirstOrDefault();

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
            _context.ClassBase.Add(result);
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
            var sourse = _context.ClassBase
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

        public Guid AddItemsToCharacter(ClassItems sourse, Guid ClassId)
        {
            CharacterItems result = new CharacterItems()
            {
                ItemName = sourse.ItemName,
                Value = sourse.Value,
                Quantity = sourse.Quantity ?? 1,
                Description = sourse.Description,
                DiceId = sourse.DiceId,
                CharacterId = ClassId
            };
            _context.CharacterItems.Add(result);
            _context.SaveChanges();
            return result.Id;
        }
        public Guid AddStatusToCharacter(ClassStatus sourse, Guid ClassId)
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
            ClassItems result = new ClassItems()
            {
                ItemName = sourse.ItemName,
                Value = sourse.Value,
                Quantity = sourse.Quantity,
                Description = sourse.Description,
                DiceId = sourse.DiceId,
                CharacterId = ClassId
            };



            _context.ClassItems.Add(result);
            _context.SaveChanges();
            return result.Id;
        }
        public Guid AddStatusToClass(CharacterStatus sourse, Guid ClassId)
        {
            ClassStatus result = new()
            {
                StatusName = sourse.StatusName,
                Value = sourse.Value,
                Description = sourse.Description,
                CharacterId = ClassId
            };



            _context.ClassStatus.Add(result);
            _context.SaveChanges();
            return result.Id;
        }

    }
}
