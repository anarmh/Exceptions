using Domain.Models;
using Service.Exception;
using Service.Helpers.Constants;
using Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class AccountService : IAccountService
    {
        public User GetUserById(int? id)
        {
            if (id == null) throw new BadRequestException(ExceptionMessages.BadRequest);
            var users = GetUsers();
            var result = users.Find(m => m.Id == id);
            if(result == null)
            {
                throw new System.Exception(ExceptionMessages.NotFound);
            }

            return result;
        }

        private List<User> GetUsers() 
        {
            List<User> users = new List<User>();
            users.Add(new User { Id = 1, Username = "Test1", Email = "Test@gmail.com", Password = "12345" });
            users.Add(new User { Id = 2, Username = "Test2", Email = "Test@gmail.com", Password = "112345" });
            users.Add(new User { Id = 3, Username = "Test3", Email = "Test@gmail.com", Password = "132345" });
            users.Add(new User { Id = 4, Username = "Test4", Email = "Test@gmail.com", Password = "142345" });

            return users;

        }

        public bool Register(User user)
        {
            if(user.Email!= null)
            {
                if (!user.Email.Contains("@"))
                {
                    return false;
                }
            }
            return true;
        }
        
    }
}
