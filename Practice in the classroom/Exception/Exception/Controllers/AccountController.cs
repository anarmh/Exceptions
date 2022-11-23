using Domain.Models;
using Service.Services;
using Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception.Controllers
{
    public class AccountController
    {
        public void Register()
        {
           

            try
            {
                Console.WriteLine("Add email: ");
                string email = Console.ReadLine();
                Console.WriteLine("Add username: ");
                string username = Console.ReadLine();

                Console.WriteLine("Add password: ");
                string password = Console.ReadLine();

                IAccountService accountService = new AccountService();

                User user = new User()
                {
                    Email = email,
                    Username = username,
                    Password = password
                };

                var result = accountService.Register(user);

                if (!result) throw new SystemException("Email doesnt have symbol @ ");
                Console.WriteLine("Success");

            }
            catch (System.Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public void GetUserById() 
        {
            try
            {
                IAccountService service = new AccountService();
                var result = service.GetUserById(null);
                Console.WriteLine(result.Username);
            }
            catch (System.Exception ex)
            {

                Console.WriteLine(ex.Message) ;
            }
        
        
        
        }
    }
}
