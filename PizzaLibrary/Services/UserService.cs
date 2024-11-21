using PizzaLibrary.Data;
using PizzaLibrary.Helpers;
using PizzaLibrary.Interfaces;
using PizzaLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary.Services
{
    public class UserService : IUserService
    {
        //string JsonFileName = @"Data\JsonUsers.json";

        public List<User> GetAllUsers()
        {
            //return JsonFileReader.ReadJsonUsers(JsonFileName);
            return MockData.UserData;
    }

        public User VerifyUser(string userName, string passWord)
        {
            foreach (var user in GetAllUsers())
            {
                if (userName.Equals(user.Name) && passWord.Equals(user.Password))
                {
                    return user;
                }
            }
            return null;

        }
    }
}
