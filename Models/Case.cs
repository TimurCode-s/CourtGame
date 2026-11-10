using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtGame.Models
{
    public class Case
    {
        //case properties
        public List<string> Images { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Date { get; set; }
        public List<string> Names { get; set; }
        public List<string> Dialogs1 { get; set; }
        public List<string> Dialogs2 { get; set; }
        public List<string> Dialogs3 { get; set; }
        

    }
}
