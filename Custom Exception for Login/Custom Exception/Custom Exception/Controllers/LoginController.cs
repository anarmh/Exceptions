using Domain.Models;
using Service.Exceptions;
using Service.Services;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Exception.Controllers
{
    public class LoginController
    {
        public void GetLoginByUsernameAndPassword()
        {
            try
            {
                ILoginService login = new LoginService();
                var result = login.GetLogin("Anar","12345");
                Console.WriteLine($"{result.Username} {result.Password}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
