using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourtGame.Models;
using System.Text.RegularExpressions;

namespace CourtGame.Services
{
    internal class DataRepository
    {
        public static List<User> users { get; set; } = new List<User>();

        public DataRepository()
        {
            users.Add(new User { Name = "Timur", Password = "1234", Email = "fe@gmail.com"});
            users.Add(new User { Name = "Ben", Password = "3423", Email = "Benchick@gmail.com"});
            users.Add(new User { Name = "ELdan", Password = "Eldan", Email = "Eldan@gmail.com"});
            users.Add(new User { Name = "Ilya", Password = "67ila", Email = "Sigma@gmail.com"});

        }
       
        public bool AddUser(string Name, string Password, string Email)
        {
            

            string pattern = @"^[a-zA-Z0-9]+$";

            if (users.Any(u => u.Name == Name) || !Regex.IsMatch(Name, pattern) || users.Any(u => u.Email == Email))
            {
                return false;
            }
            users.Add(new User { Name = Name, Password = Password, Email = Email });
            return true; 
        }

        public bool LoginUser(string Name, string Password, string Email)
        {
            return users.Any(u => u.Name == Name && u.Password == Password && u.Email == Email);
        }

    }
}
