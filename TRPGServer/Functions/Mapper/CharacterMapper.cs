
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Drawing;
using System.Reflection;
using System.Xml.Linq;
using System;
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
        public static CharacterBase MapToEntity(CharacterBaseModel dto, AppDbContext _context, CharacterBase entity = null)
        {
            CharacterBase character = new CharacterBase();
            if (entity != null)
            {
                character = entity;
            }
            //character.Account = _context.Account.Find(dto.Account.Id) ?? AccountMapper.MapToEntity(dto.Account);
            character.Name = dto.Name ?? "";
            character.Age = dto.Age;
            character.Gender = dto.Gender;
            character.Description = dto.Description ?? "";
            character.Occupation = dto.Occupation;
            character.Era = dto.Era;
            //character.Image = _context.Image.Find(dto.Image.Id);
            character.STR = dto.STR ?? 0;
            character.CON = dto.CON ?? 0;
            character.SIZ = dto.SIZ ?? 0;
            character.DEX = dto.DEX ?? 0;
            character.APP = dto.APP ?? 0;
            character.INT = dto.INT ?? 0;
            character.POW = dto.POW ?? 0;
            character.EDU = dto.EDU ?? 0;
            character.LUCK = dto.LUCK;
            character.Hp = dto.Hp ?? 0;
            character.MP = dto.MP ?? 0;
            character.SAN = dto.SAN ?? 0;
            character.Mov = dto.Mov ?? 0;

            character.AccountId = dto.Account?.Id??Guid.Empty ;
            character.ImageId = dto.Image?.Id ?? null;

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

        public static CharacterStatus StatusToEntity(CharacterStatusModel dto, AppDbContext _context, CharacterStatus entity = null)
        {
            CharacterStatus status = new CharacterStatus();
            if (entity != null)
            {
                status = entity;
            }

            status.CharacterId = dto.CharacterBase.Id.Value;
            status.StatusName = dto.StatusName ?? "";
            status.Value = dto.Value ?? 0;
            status.Description = dto.Description ?? "";

            if (dto.Id != null)
            {
                status.Id = dto.Id.Value;
            }

            return status;
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
        public static CharacterItems ItemToEntity(CharacterItemsModel dto, AppDbContext _context, CharacterItems entity = null)
        {
            CharacterItems Item = new CharacterItems();
            if (entity != null)
            {
                Item = entity;
            }


            Item.CharacterId = dto.CharacterBase.Id.Value;
            Item.DiceId = dto.Dice.Id.Value;
            Item.Dice = _context.Dice.Find(dto.Dice.Id);
            Item.ItemName = dto.ItemName ?? "";
            Item.Value = dto.Value ?? 0;
            Item.Description = dto.Description ?? "";
            Item.Quantity = dto.Quantity ?? 0;


            if (dto.Id != null)
            {
                Item.Id = dto.Id.Value;
            }

            return Item;
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
