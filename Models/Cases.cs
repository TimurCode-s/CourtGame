using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtGame.Models
{
    public class Cases
    {
        //case properties
        public List<string> images { get; set; }
        public string description { get; set; }
        public string location { get; set; }
        public string date { get; set; }
        public List<string> names { get; set; }
        public List<string> dialogs1 { get; set; }
        public List<string> dialogs2 { get; set; }
        public List<string> dialogs3 { get; set; }
        

    }
}
