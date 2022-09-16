using AriBilgi.BankApp.Web.Data.Entities;

namespace AriBilgi.BankApp.Web.Data.Interfaces
{
    public interface IAccountRepository
    {
        int GetAccountCount(int UserId);

        void CreateAccount(Account account);

        bool SendMoney(int fromAccountId,int toAccountNo,decimal amount);
       
    }
}
