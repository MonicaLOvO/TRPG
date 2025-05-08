using TRPGServer.Entity;
using TRPGServer.Model;

namespace TRPGServer.Functions.Interface
{
    public interface IAccountLogic
    {
        bool CheckData(Account account);
        Guid CreateAccount(AccountModel dto);
    }
}