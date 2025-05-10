using System.Reflection;
using TRPGServer.Data;
using TRPGServer.Entity;
using TRPGServer.Functions.Mapper;
using TRPGServer.Model;
using TRPGServer.Model.Character;

namespace TRPGServer.Functions.Logic.Character
{
    public class StatusLogic
    {
        private readonly AppDbContext _context;

        public StatusLogic(IServiceProvider serviceProvider)
        {
            _context = serviceProvider.GetRequiredService<AppDbContext>();
        }

        //public Guid CreateStatus(CharacterStatusModel dto)
        //{
        //    Account account = new Account();
        //    bool finalCheck = false;
        //    finalCheck = CheckData(dto);

        //    if (finalCheck == false)
        //    {
        //        return Guid.Empty;
        //    }
        //    account = AccountMapper.MapToEntity(dto);
        //    _context.Account.Add(account);
        //    _context.SaveChanges();
        //    return account.Id;
        //}


        public bool CheckData(CharacterStatusModel status)
        {
            foreach (PropertyInfo prop in status.GetType().GetProperties((BindingFlags.Public | BindingFlags.Instance)))
            {
                if (prop.Name == "Id")
                    continue;
                if (prop.Name == "Description")
                    continue;
                if (prop.GetIndexParameters().Length > 0)
                    continue;
                if (prop.GetValue(status) == null)
                    return false;
            }
            return true;
        }
    }
}
