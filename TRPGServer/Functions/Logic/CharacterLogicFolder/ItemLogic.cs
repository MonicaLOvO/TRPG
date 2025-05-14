using Microsoft.EntityFrameworkCore;
using TRPGServer.Data;
using TRPGServer.Entity.Character;
using TRPGServer.Functions.Interface;
using TRPGServer.Functions.Mapper;
using TRPGServer.Model.Character;

namespace TRPGServer.Functions.Logic.CharacterLogicFolder
{
    public class ItemLogic : IItemLogic
    {
        private readonly AppDbContext _context;

        public ItemLogic(IServiceProvider serviceProvider)
        {
            _context = serviceProvider.GetRequiredService<AppDbContext>();
        }

        public CharacterItemsModel GetItemById(Guid Id)
        {
            CharacterItems? item = _context.CharacterItems
                .Where(c => c.Id == Id).FirstOrDefault();
            if (item == null)
            {
                return new CharacterItemsModel();
            }

            //var temp = item.Items.FirstOrDefault();
            //return new CharacterItemsModel();
            return CharacterMapper.ItemToModel(item);
        }
        public List<CharacterItemsModel> GetAllItemsByCharacter(Guid Id)
        {
            List<CharacterItemsModel> resultList = [];

            CharacterBase? character = _context.CharacterBase
                .Include(c => c.Items)
                .Where(c => c.Id == Id && c.DeletedDate == null).FirstOrDefault();

            if (character == null)
            {
                return resultList;
            }
            foreach (var item in character.Items)
            {
                CharacterItemsModel result = CharacterMapper.ItemToModel(item);
                resultList.Add(result);
            }
            //var temp = item.Items.FirstOrDefault();
            //return new CharacterItemsModel();
            return resultList;
        }

        public Guid CreateItem(CharacterItemsModel dto)
        {
            CharacterItems item = new CharacterItems();
            bool finalCheck = false;
            finalCheck = CheckData(dto);

            if (finalCheck == false)
            {
                return Guid.Empty;
            }
            item = CharacterMapper.ItemToEntity(dto, _context);
            _context.CharacterItems.Add(item);
            _context.SaveChanges();
            return item.Id;
        }

        public bool UpdateItem(CharacterItemsModel dto)
        {
            bool finalCheck = false;
            finalCheck = CheckData(dto);
            if (finalCheck == false)
            {
                return false;
            }
            CharacterItems? item = _context.CharacterItems.Where(a => a.Id == dto.Id && a.DeletedDate == null).FirstOrDefault();
            if (item == null)
            {
                return false;
            }
            item = CharacterMapper.ItemToEntity(dto, _context, item);
            _context.SaveChanges();
            return true;

        }

        public bool DeleteItem(Guid Id)
        {
            CharacterItems? item = _context.CharacterItems.Find(Id);
            if (item == null)
            {
                return false;
            }
            item.DeletedDate = DateTime.Now;
            _context.SaveChanges();
            return true;

        }

        public DateTime? CheckDeleted(Guid Id)
        {
            CharacterItems? item = _context.CharacterItems.Find(Id);
            return item?.DeletedDate;
        }

        public bool CheckData(CharacterItemsModel item)
        {
            if (item == null)
            {
                return false;
            }
            return true;
        }
    }
}
