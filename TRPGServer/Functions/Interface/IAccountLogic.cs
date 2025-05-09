using TRPGServer.Entity;
using TRPGServer.Model;

namespace TRPGServer.Functions.Interface
{
    public interface IAccountLogic
    {
        bool CheckData(AccountModel account);
        Guid CreateAccount(AccountModel dto);
        bool UpdateAccount(AccountModel dto);
        AccountModel GetAccountById(Guid Id);
        AccountModel GetAccountByLogin(string email, string password);
        List<AccountModel> GetAllAccount();
        bool DeleteAccount(Guid Id);
        DateTime? CheckDeleted(Guid Id);
    }
}