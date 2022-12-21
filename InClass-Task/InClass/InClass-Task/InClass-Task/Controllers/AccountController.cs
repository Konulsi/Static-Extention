using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_Task.Controllers
{
    public class AccountController
    {
        public void Login()
        {
            IAccountService accountService = new AccountService();

            Console.WriteLine("Add username");
            string username = Console.ReadLine();

            Console.WriteLine("Add password");
            string password = Console.ReadLine();  

            var result = accountService.Login(username, password);

            if (result)
            {
                Console.WriteLine("Girish ugurludur");
            }
            else
            {
                Console.WriteLine("Username ve ya password sehvdir");
            }
            
        }
    }
}
