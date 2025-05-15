using Microsoft.EntityFrameworkCore;
using TRPGServer.Data;
using TRPGServer.Entity;
using TRPGServer.Entity.Character;
using TRPGServer.Entity.RoomObject;
using TRPGServer.Functions.Interface;
using TRPGServer.Functions.Mapper;
using TRPGServer.Model.Character;
using TRPGServer.Model.RoomObject;

namespace TRPGServer.Functions.Logic.RoomLogicFolder
{
    public class RoomLogic : IRoomLogic
    {
        private readonly AppDbContext _context;

        public RoomLogic(IServiceProvider serviceProvider)
        {
            _context = serviceProvider.GetRequiredService<AppDbContext>();
        }
        public RoomModel GetRoomById(Guid Id)
        {
            Room? room = _context.Room
                .Include(c => c.Actors)
                .Include(c => c.Rules)
                .Include(c => c.Templates)
                .Include(c => c.Chat)
                .Include(c => c.Logs)
                .Include(c => c.Characters)
                .Where(c => c.Id == Id).FirstOrDefault();
            if (room == null)
            {
                return new RoomModel();
            }

            return RoomMapper.MapToModel(room);
        }

        public List<RoomModel> GetAllRoomByCreator(Guid creatorId)
        {
            List<RoomModel> resultList = [];

            List<Room>? selectedList = _context.Room
                .Where(c => c.AccountId == creatorId)
                .Where(a => a.DeletedDate == null)
                .ToList();


            if (selectedList == null || selectedList.Count == 0)
            {
                return resultList;
            }
            foreach (var room in selectedList)
            {
                RoomModel result = RoomMapper.MapToModel(room);
                resultList.Add(result);
            }
            return resultList;
        }

        public Guid CreateRoom(RoomModel dto)
        {
            Room room = new Room();
            bool finalCheck = false;
            finalCheck = CheckData(dto);

            if (finalCheck == false)
            {
                return Guid.Empty;
            }
            room = RoomMapper.MapToEntity(dto);
            _context.Room.Add(room);
            _context.SaveChanges();
            return room.Id;
        }

        public bool UpdateRoom(RoomModel dto)
        {
            bool finalCheck = false;
            finalCheck = CheckData(dto);
            if (finalCheck == false)
            {
                return false;
            }
            Room? room = _context.Room.Where(a => a.Id == dto.Id && a.DeletedDate == null).FirstOrDefault();
            if (room == null)
            {
                return false;
            }
            room.Name = dto.Name;
            _context.SaveChanges();
            return true;

        }

        public bool DeleteRoom(Guid Id)
        {
            Room? room = _context.Room.Find(Id);
            if (room == null)
            {
                return false;
            }
            room.DeletedDate = DateTime.Now;
            _context.SaveChanges();
            return true;

        }

        public DateTime? CheckDeleted(Guid Id)
        {
            Room? room = _context.Room.Find(Id);
            return room?.DeletedDate;
        }

        public bool CheckData(RoomModel room)
        {
            if (room == null)
            {
                return false;
            }
            return true;
        }
    }
}
