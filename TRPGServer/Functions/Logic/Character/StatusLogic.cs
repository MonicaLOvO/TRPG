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
    public class StatusLogic : IStatusLogic
    {
        private readonly AppDbContext _context;

        public StatusLogic(IServiceProvider serviceProvider)
        {
            _context = serviceProvider.GetRequiredService<AppDbContext>();
        }

        public CharacterStatusModel GetStatusById(Guid Id)
        {
            CharacterStatus? status = _context.CharacterStatus
                .Where(c => c.Id == Id).FirstOrDefault();
            if (status == null)
            {
                return new CharacterStatusModel();
            }

            //var temp = status.Items.FirstOrDefault();
            //return new CharacterStatusModel();
            return CharacterMapper.StatusToModel(status);
        }
        public List<CharacterStatusModel> GetAllStatusByCharacter(Guid Id)
        {
            List<CharacterStatusModel> resultList = [];

            CharacterBase? character = _context.CharacterBase
                .Include(c => c.Status)
                .Where(c => c.Id == Id).FirstOrDefault();

            if (character == null)
            {
                return resultList;
            }
            foreach (var status in character.Status)
            {
                CharacterStatusModel result = CharacterMapper.StatusToModel(status);
                resultList.Add(result);
            }
            //var temp = status.Items.FirstOrDefault();
            //return new CharacterStatusModel();
            return resultList;
        }

        public Guid CreateStatus(CharacterStatusModel dto)
        {
            CharacterStatus status = new CharacterStatus();
            bool finalCheck = false;
            finalCheck = CheckData(dto);

            if (finalCheck == false)
            {
                return Guid.Empty;
            }
            status = CharacterMapper.StatusToEntity(dto, _context);
            _context.CharacterStatus.Add(status);
            _context.SaveChanges();
            return status.Id;
        }

        public bool UpdateStatus(CharacterStatusModel dto)
        {
            bool finalCheck = false;
            finalCheck = CheckData(dto);
            if (finalCheck == false)
            {
                return false;
            }
            CharacterStatus? status = _context.CharacterStatus.Where(a => a.Id == dto.Id && a.DeletedDate == null).FirstOrDefault();
            if (status == null)
            {
                return false;
            }
            status = CharacterMapper.StatusToEntity(dto, _context, status);
            _context.SaveChanges();
            return true;

        }

        public bool DeleteStatus(Guid Id)
        {
            CharacterStatus? status = _context.CharacterStatus.Find(Id);
            if (status == null)
            {
                return false;
            }
            status.DeletedDate = DateTime.Now;
            _context.SaveChanges();
            return true;

        }

        public DateTime? CheckDeleted(Guid Id)
        {
            CharacterStatus? status = _context.CharacterStatus.Find(Id);
            return status?.DeletedDate;
        }

        public bool CheckData(CharacterStatusModel status)
        {
            if (status == null)
            {
                return false;
            }
            return true;
        }
    }
}
