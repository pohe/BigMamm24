using PizzaLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary.Services
{
    public class LogInService
    {
        private User _loggedInUser;

        public void UserLogIn(User user)
        {
            _loggedInUser = user;
        }
        public void UserLogOut()
        {
            _loggedInUser = null;
        }
        public User GetLoggedUser()
        {
            return _loggedInUser;
        }
    }
}
