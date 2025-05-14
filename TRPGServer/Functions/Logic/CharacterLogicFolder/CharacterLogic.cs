using System.Reflection;
using Microsoft.EntityFrameworkCore;
using TRPGServer.Data;
using TRPGServer.Entity;
using TRPGServer.Entity.Character;
using TRPGServer.Entity.RoomObject;
using TRPGServer.Functions.Interface;
using TRPGServer.Functions.Mapper;
using TRPGServer.Model;
using TRPGServer.Model.Character;
using TRPGServer.Model.RoomObject;

namespace TRPGServer.Functions.Logic.CharacterLogicFolder
{
    public class CharacterLogic : ICharacterLogic
    {
        private readonly AppDbContext _context;

        public CharacterLogic(IServiceProvider serviceProvider)
        {
            _context = serviceProvider.GetRequiredService<AppDbContext>();
        }
        public CharacterBaseModel GetCharacterById(Guid Id)
        {
            CharacterBase? character = _context.CharacterBase
                .Include(c => c.Items)
                .Include(c => c.Status)
                .Where(c => c.Id == Id).FirstOrDefault();
            if (character == null)
            {
                return new CharacterBaseModel();
            }

            //var temp = character.Items.FirstOrDefault();
            //return new CharacterBaseModel();
            return CharacterMapper.MapToModel(character);
        }

        public List<CharacterBaseModel> GetAllCharacterByCreator(Guid creatorId)
        {

            List<CharacterBaseModel> resultList = [];

            List<CharacterBase>? selectedList = _context.CharacterBase.Where(a => a.DeletedDate == null && a.AccountId == creatorId).ToList();


            if (selectedList == null || selectedList.Count == 0)
            {
                return resultList;
            }
            foreach (var character in selectedList)
            {
                CharacterBaseModel result = CharacterMapper.MapToModel(character);
                resultList.Add(result);
            }

            return resultList;
        }

        public Guid CreateCharacter(CharacterBaseModel dto)
        {
            CharacterBase character = new CharacterBase();
            bool finalCheck = false;
            finalCheck = CheckData(dto);

            if (finalCheck == false)
            {
                return Guid.Empty;
            }
            character = CharacterMapper.MapToEntity(dto, _context);
            _context.CharacterBase.Add(character);
            _context.SaveChanges();
            return character.Id;
        }

        public bool UpdateCharacter(CharacterBaseModel dto)
        {
            bool finalCheck = false;
            finalCheck = CheckData(dto);
            if (finalCheck == false)
            {
                return false;
            }
            CharacterBase? character = _context.CharacterBase.Where(a => a.Id == dto.Id && a.DeletedDate == null).FirstOrDefault();
            if (character == null)
            {
                return false;
            }
            character = CharacterMapper.MapToEntity(dto, _context, character);
            _context.SaveChanges();
            return true;

        }

        public bool DeleteCharacter(Guid Id)
        {
            CharacterBase? character = _context.CharacterBase.Find(Id);
            if (character == null)
            {
                return false;
            }
            character.DeletedDate = DateTime.Now;
            _context.SaveChanges();
            return true;

        }

        public DateTime? CheckDeleted(Guid Id)
        {
            CharacterBase? character = _context.CharacterBase.Find(Id);
            return character?.DeletedDate;
        }

        public bool CheckData(CharacterBaseModel character)
        {
            if (character == null)
            {
                return false;
            }
            return true;
        }
    }
}
