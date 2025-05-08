using System.Reflection;
using System.Security.Principal;
using Microsoft.EntityFrameworkCore;
using TRPGServer.Data;
using TRPGServer.Entity;
using TRPGServer.Functions.Interface;
using TRPGServer.Model;

namespace TRPGServer.Functions.Logic
{
    public class AccountLogic : IAccountLogic
    {
        private readonly AppDbContext _context;

        public AccountLogic(IServiceProvider serviceProvider)
        {
            _context = serviceProvider.GetRequiredService<AppDbContext>();
        }

        public Guid CreateAccount(AccountModel dto)
        {
            Account account = new Account();
            bool finalCheck = false;
     
            account.UserName = dto.UserName;
            account.email = dto.email;
            account.Password = dto.Password;

            finalCheck = CheckData(account);
            if (finalCheck)
            {
                _context.Account.Add(account);
            }
            _context.SaveChanges();
            return account.Id;
        }

        public bool CheckData(Account account)
        {
            foreach (PropertyInfo prop in account.GetType().GetProperties((BindingFlags.Public | BindingFlags.Instance)))
            {
                if (prop.Name == "Id") 
                    continue;
                
                if (prop.GetIndexParameters().Length > 0)
                    continue;
                if (prop.GetValue(account) == null)
                    return false;
            }
            return true;
        }
    }
}
