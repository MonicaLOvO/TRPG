using System;
using System.Reflection;
using System.Security.Principal;
using Microsoft.EntityFrameworkCore;
using TRPGServer.Data;
using TRPGServer.Entity;
using TRPGServer.Functions.Interface;
using TRPGServer.Functions.Mapper;
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
            finalCheck = CheckData(dto);

            if (finalCheck==false)
            {
                return Guid.Empty;
            }
            account = AccountMapper.MapToEntity(dto);
            _context.Account.Add(account);
            _context.SaveChanges();
            return account.Id;
        }

        public bool UpdateAccount(AccountModel dto)
        {
            bool finalCheck = false;
            finalCheck = CheckData(dto);
            if (finalCheck==false)
            {
                return false;
            }
            Account? account = _context.Account.Where(a => a.Id == dto.Id && a.DeletedDate == null).FirstOrDefault();
            if (account == null) { 
                return false;
            }
            account.UserName = dto.UserName?? account.UserName;
            account.Email = dto.Email;
            account.Password = dto.Password?? account.Password;
            _context.SaveChanges();
            return true;
            
        }

        public AccountModel GetAccountById(Guid Id)
        {
            Account? account = _context.Account.Find(Id);
            if(account == null)
            {
                return new AccountModel();
            }
           
            return AccountMapper.MapToModel(account);
        }

        public AccountModel GetAccountByLogin(string email, string password)
        {
            Account? account = _context.Account.Where(a => a.Email == email && a.DeletedDate == null).FirstOrDefault();

            if (account != null && password == account.Password)
            {
                return AccountMapper.MapToModel(account);
            }

            return new AccountModel();
        }

        public List<AccountModel> GetAllAccount()
        {
            List<AccountModel> accountModels = [];

            List<Account> accountList = _context.Account.Where(a => a.DeletedDate == null).ToList();

            foreach (Account account in accountList) 
            {
                AccountModel accountModel = AccountMapper.MapToModel(account);
                accountModels.Add(accountModel);
            }
            return accountModels;
        }

        public bool DeleteAccount(Guid Id)
        {
            Account? account = _context.Account.Find(Id);
            if (account == null) 
            {
                return false;
            }
            account.DeletedDate = DateTime.Now;
            _context.SaveChanges();
            return true;

        }

        public bool CheckData(AccountModel account)
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

        public DateTime? CheckDeleted(Guid Id)
        {
            Account? account = _context.Account.Find(Id);
            return account?.DeletedDate;
        }
    }
}
