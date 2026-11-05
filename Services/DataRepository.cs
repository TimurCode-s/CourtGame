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
        public static List<Cases> cases { get; set; } = new List<Cases>();

        public DataRepository()
        {
            users.Add(new User { Name = "Timur", Password = "1234", Email = "fe@gmail.com"});
            users.Add(new User { Name = "Ben", Password = "3423", Email = "Benchick@gmail.com"});
            users.Add(new User { Name = "ELdan", Password = "Eldan", Email = "Eldan@gmail.com"});
            users.Add(new User { Name = "Ilya", Password = "67ila", Email = "Sigma@gmail.com"});

            cases.Add(new Cases { images = new List<string> { "defendant1.png", "lawyer1.png" },
                description = "Late one night, a valuable diamond necklace disappeared from the Riverside Museum. The security alarm was triggered at 11:45 PM, and security cameras showed a suspicious figure leaving the building shortly afterward.\r\n\r\nDaniel Carter, a former museum employee, was arrested after his fingerprints were discovered near the display case.\r\n\r\nHowever, Daniel strongly denies the accusations. He claims he was nowhere near the museum that night and believes someone is trying to frame him.\r\n\r\nThe prosecution argues that the fingerprints, security footage, and witness testimony prove his guilt.\r\n\r\nThe defense believes there is more to this story than meets the eye.",
                date = "October 14, 2026",
                names = new List<string> { "Daniel Carter", "Detective Sarah", "Museum Curator" },
                dialogs1 = new List<string> { "Hello, I'm Detective Sarah.", "Hi, I'm Daniel Carter." },
                dialogs2 = new List<string> { "We need to investigate the crime scene.", "I understand." },
                dialogs3 = new List<string> { "The evidence is clear.", "I still maintain my innocence." },
                location = "Riverside Museum",
            });


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
