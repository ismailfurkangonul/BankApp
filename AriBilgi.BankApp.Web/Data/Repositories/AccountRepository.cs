using AriBilgi.BankApp.Web.Data.Context;
using AriBilgi.BankApp.Web.Data.Entities;
using AriBilgi.BankApp.Web.Data.Interfaces;
using System.Linq;

namespace AriBilgi.BankApp.Web.Data.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankContext _context;

        public AccountRepository(BankContext context)
        {
            _context = context;
        }

        public void CreateAccount(Account account)
        {
            _context.Accounts.Add(account);
            _context.SaveChanges();
        }

        public int GetAccountCount(int UserId)
        {
            return _context.Accounts.Count(x => x.ApplicationUserId == UserId);
        }

        public bool SendMoney(int fromAccountId, int toAccountNo, decimal amount)
        {
            Account toAccount = null;
           Account fromAccount= _context.Accounts.Where(x => x.Id == fromAccountId).SingleOrDefault();
            if(fromAccount.Balance<amount)
           
              return false;
            if (!_context.Accounts.Any(x => x.AccountNo == toAccountNo))
                return false;
            else
            

            toAccount = _context.Accounts.Where(x => x.AccountNo == toAccountNo).SingleOrDefault();

            fromAccount.Balance -= amount;
            toAccount.Balance += amount;
            _context.Accounts.Update(fromAccount);
            _context.Accounts.Update(toAccount);

            _context.SaveChanges();

            return true;

        }
    }
}
