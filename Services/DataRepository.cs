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

       
        public bool AddUser(string Name, string Password, string email)
        {
            string pattern = @"^[a-zA-Z0-9]+$";

            if (users.Any(u => u.Name == Name) || !Regex.IsMatch(Name, pattern) || users.Any(u => u.Email == email))
            {
                return false;
            }
            users.Add(new User { Name = Name, Password = Password, Email = email });
            return true; 
        }

    }
}
