using Microsoft.EntityFrameworkCore;
using TRPGServer.Data;
using TRPGServer.Entity.RoomObject;
using TRPGServer.Entity.RoomObject.ActiveCharacter;
using TRPGServer.Entity.RoomObject.PlaySet;
using TRPGServer.Functions.Interface;
using TRPGServer.Functions.Mapper;
using TRPGServer.Model.RoomObject;
using TRPGServer.Model.RoomObject.PlaySet;

namespace TRPGServer.Functions.Logic.RoomLogicFolder
{
    public class ActorLogic : IActorLogic
    {
        private readonly AppDbContext _context;

        public ActorLogic(IServiceProvider serviceProvider)
        {
            _context = serviceProvider.GetRequiredService<AppDbContext>();
        }
        public RoomActorModel GetActorById(Guid Id)
        {
            RoomActor? actor = _context.RoomActor
                .Include(c => c.Characters)
                .Include(c => c.Notes)
                .Where(c => c.Id == Id).FirstOrDefault();
            if (actor == null)
            {
                return new RoomActorModel();
            }

            return ActorMapper.MapToModel(actor);
        }

        public List<RoomActorModel> GetAllActorByRoom(Guid roomId)
        {
            List<RoomActorModel> resultList = [];

            List<RoomActor>? selectedList = _context.RoomActor
                .Where(c => c.RoomId == roomId)
                .Where(a => a.DeletedDate == null)
                .ToList();


            if (selectedList == null || selectedList.Count == 0)
            {
                return resultList;
            }
            foreach (var actor in selectedList)
            {
                RoomActorModel result = ActorMapper.MapToModel(actor);
                resultList.Add(result);
            }
            return resultList;
        }

        public Guid CreateActor(RoomActorModel dto)
        {
            RoomActor actor = new RoomActor();
            bool finalCheck = false;
            finalCheck = CheckData(dto);

            if (finalCheck == false)
            {
                return Guid.Empty;
            }
            actor = ActorMapper.MapToEntity(dto);
            _context.RoomActor.Add(actor);
            _context.SaveChanges();
            return actor.Id;
        }

        public bool UpdateActor(RoomActorModel dto)
        {
            bool finalCheck = false;
            finalCheck = CheckData(dto);
            if (finalCheck == false)
            {
                return false;
            }
            RoomActor? actor = _context.RoomActor.Where(a => a.Id == dto.Id && a.DeletedDate == null).FirstOrDefault();
            if (actor == null)
            {
                return false;
            }
            List<RoomCharacter> characterList = new List<RoomCharacter>();
            foreach (var Character in dto.Characters)
            {
                characterList.Add(_context.RoomCharacter.Where(a => a.Id == Character.Id && a.DeletedDate == null).FirstOrDefault());
            }
            actor.Characters = characterList;
            _context.SaveChanges();
            return true;

        }

        public bool DeleteActor(Guid Id)
        {
            RoomActor? actor = _context.RoomActor.Find(Id);
            if (actor == null)
            {
                return false;
            }
            actor.DeletedDate = DateTime.Now;
            _context.SaveChanges();
            return true;

        }

        public DateTime? CheckDeleted(Guid Id)
        {
            RoomActor? actor = _context.RoomActor.Find(Id);
            return actor?.DeletedDate;
        }

        public bool CheckData(RoomActorModel actor)
        {
            if (actor == null)
            {
                return false;
            }
            return true;
        }
    }
}
