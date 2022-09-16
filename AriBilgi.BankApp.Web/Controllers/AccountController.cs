using AriBilgi.BankApp.Web.Data.Context;
using AriBilgi.BankApp.Web.Data.Entities;
using AriBilgi.BankApp.Web.Data.Interfaces;
using AriBilgi.BankApp.Web.Mapping;
using AriBilgi.BankApp.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AriBilgi.BankApp.Web.Controllers
{
    public class AccountController : Controller
    {



        private readonly IApplicationUserMapping _userMapping;
        private readonly IRepository<ApplicationUser> _userRepo;
        private readonly IRepository<Account> _accountRepo;

        private readonly IAccountRepository _accountRepoSp;

        public AccountController(IRepository<Account> accountRepo, IRepository<ApplicationUser> userRepo, IApplicationUserMapping userMapping, IAccountRepository accountRepoSp)
        {
            _accountRepo = accountRepo;
            _userRepo = userRepo;
            _userMapping = userMapping;
            _accountRepoSp = accountRepoSp;
        }

        public IActionResult Index(int UserId)
        {
            ApplicationUserDTO dto = _userMapping.MapToDTO(_userRepo.GetById(UserId));

            dto.AccountList = _accountRepo.GetAll(x => x.ApplicationUserId == UserId);

            return View(dto);
        }

        #region Http Methods
        [HttpPost]
        public IActionResult Create(Account account)
        {
            _accountRepo.Create(account);

            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public IActionResult SendMoney(int fromAccountId,int toAccountNo,decimal amount)
        {
            _accountRepoSp.SendMoney(fromAccountId, toAccountNo, amount);
            return RedirectToAction("Index", "Home");


        }

        #endregion
    }
}
