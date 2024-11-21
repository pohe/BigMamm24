using PizzaLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary.Interfaces
{
    public interface IUserService
    {
        
        public List<User> GetAllUsers();

        public User VerifyUser(string userName, string passWord);


    }
}
