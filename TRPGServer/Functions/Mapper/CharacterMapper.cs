
using Microsoft.EntityFrameworkCore;
using TRPGServer.Data;
using TRPGServer.Entity;
using TRPGServer.Entity.Character;
using TRPGServer.Functions.Interface;
using TRPGServer.Functions.Logic;
using TRPGServer.Model;
using TRPGServer.Model.Character;

namespace TRPGServer.Functions.Mapper
{
    public class CharacterMapper
    {
        public static CharacterBase MapToEntity(CharacterBaseModel dto, AppDbContext _context)
        {
            CharacterBase character = new CharacterBase
            {

                Account = _context.Account.Find(dto.Account.Id) ?? AccountMapper.MapToEntity(dto.Account),
                Name = dto.Name ?? "",
                Age = dto.Age,
                Gender = dto.Gender,
                Description = dto.Description ?? "",
                Occupation = dto.Occupation,
                Era = dto.Era,
                Image = _context.Image.Find(dto.Image.Id),
                STR = dto.STR ?? 0,
                CON = dto.CON ?? 0,
                SIZ = dto.SIZ ?? 0,
                DEX = dto.DEX ?? 0,
                APP = dto.APP ?? 0,
                INT = dto.INT ?? 0,
                POW = dto.POW ?? 0,
                EDU = dto.EDU ?? 0,
                LUCK = dto.LUCK,
                Hp = dto.Hp ?? 0,
                MP = dto.MP ?? 0,
                SAN = dto.SAN ?? 0,
                Mov = dto.Mov ?? 0



            };
            character.AccountId = dto.Account.Id ?? character.Account.Id;
            character.ImageId = dto.Image.Id ?? character.Image.Id;

            if (dto.Id != null)
            {
                character.Id = dto.Id.Value;
            }

            return character;
        }

        public static CharacterBaseModel MapToModel(CharacterBase character)
        {
            CharacterBaseModel characterModel = new()
            {
                Account = character.Account == null ? AccountMapper.MapToModel(character.Account): null,
                //Image = character.Image,
                Name = character.Name ?? "",
                Age = character.Age,
                Gender = character.Gender,
                Description = character.Description ?? "",
                Occupation = character.Occupation,
                Era = character.Era,

                STR = character.STR,
                CON = character.CON,
                SIZ = character.SIZ,
                DEX = character.DEX,
                APP = character.APP,
                INT = character.INT,
                POW = character.POW,
                EDU = character.EDU,
                LUCK = character.LUCK,
                Hp = character.Hp,
                MP = character.MP,
                SAN = character.SAN,
                Mov = character.Mov
            }; 

            return characterModel;
        }

        public static CharacterStatus StatusToEntity(CharacterStatusModel dto, AppDbContext _context)
        {
            CharacterStatus entity = new CharacterStatus
            {
                CharacterId = dto.CharacterBase.Id.Value,
                StatusName = dto.StatusName ?? "",
                Value = dto.Value ?? 0,
                Description = dto.Description ?? "",

            };

            if (dto.Id != null)
            {
                entity.Id = dto.Id.Value;
            }

            return entity;
        }

        public static CharacterStatusModel StatusToModel(CharacterStatus entity)
        {
            CharacterStatusModel model = new()
            {

                //CharacterBase = entity.CharacterBase,
                //Image = character.Image,
                Id = entity.Id,
                StatusName = entity.StatusName,
                Value = entity.Value,
                Description = entity.Description ?? "",

            };

            return model;
        }
        public static CharacterItems ItemToEntity(CharacterItemsModel dto, AppDbContext _context)
        {
            CharacterItems entity = new CharacterItems
            {

                CharacterBase = _context.CharacterBase.Find(dto.CharacterBase.Id),
                Dice = _context.Dice.Find(dto.Dice.Id),
                ItemName = dto.ItemName ?? "",
                Value = dto.Value ?? 0,
                Description = dto.Description ?? "",
                Quantity = dto.Quantity ?? 0,

            };
            entity.CharacterId = dto.CharacterBase.Id ?? entity.CharacterBase.Id;
            entity.DiceId = dto.Dice.Id ?? entity.Dice.Id;

            if (dto.Id != null)
            {
                entity.Id = dto.Id.Value;
            }

            return entity;
        }

        public static CharacterItemsModel ItemToModel(CharacterItems entity)
        {
            CharacterItemsModel model = new()
            {

                //CharacterBase = entity.CharacterBase,
                //Dice = character.Dice,
                Id = entity.Id,
                ItemName = entity.ItemName ?? "",
                Value = entity.Value ?? 0,
                Description = entity.Description ?? "",
                Quantity = entity.Quantity,

            };

            return model;
        }
    }
}
