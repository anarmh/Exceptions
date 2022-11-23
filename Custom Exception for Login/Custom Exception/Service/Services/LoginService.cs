using Domain.Models;
using Service.Exceptions;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class LoginService : ILoginService
    {
        public Login GetLogin(string? username, string? password)
        {
            List<Login> logins = new List<Login>();
            logins.Add(new Login { Username = "Anar", Password = "12345" });
            logins.Add(new Login { Username = "Elnar", Password = "123456" });
            logins.Add(new Login { Username = "Tunar", Password = "123457" });

            var result= logins.Find(m => m.Username == username && m.Password == password);

            if (result == null)
            {
                throw new LoginNotFoundException("Login not found");
            }
            return result;
        }   
    }
}
