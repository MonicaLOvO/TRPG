using Microsoft.EntityFrameworkCore;
using TRPGServer.Entity;
using TRPGServer.Model;

namespace TRPGServer.Functions.Mapper
{
    public class AccountMapper
    {
        public static Account MapToEntity(AccountModel dto)
        {
            Account account = new Account
            {
                UserName = dto.UserName,
                Email = dto.Email,
                Password = dto.Password??""
            };

            if(dto.Id != null)
            {
                account.Id = dto.Id.Value;
            }

            return account;
        }

        public static AccountModel MapToModel(Account account) {
            AccountModel accountModel = new()
            {
                Id = account.Id,
                UserName = account.UserName,
                Email = account.Email
            };

            return accountModel;
        }
    }
}
