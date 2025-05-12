using System.Reflection;
using Microsoft.EntityFrameworkCore;
using TRPGServer.Data;
using TRPGServer.Entity;
using TRPGServer.Entity.Character;
using TRPGServer.Functions.Interface;
using TRPGServer.Functions.Mapper;
using TRPGServer.Model;
using TRPGServer.Model.Character;

namespace TRPGServer.Functions.Logic.Character
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

        public List<CharacterBaseModel> GetAllCharacter()
        {
            List<CharacterBaseModel> characterModels = [];

            List<CharacterBase> characterList = _context.CharacterBase.Where(a => a.DeletedDate == null).ToList();

            foreach (CharacterBase character in characterList)
            {
                CharacterBaseModel characterModel = CharacterMapper.MapToModel(character);
                characterModels.Add(characterModel);
            }
            return characterModels;
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
