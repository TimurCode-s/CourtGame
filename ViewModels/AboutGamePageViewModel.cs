using CourtGame.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtGame.ViewModels
{
    class AboutGamePageViewModel : ViewModelBase
    {
        #region Fields


        public ObservableCollection<string> Pictures { get; set; }

    
        #endregion


        #region Commands

        #endregion

        #region Constructor
        public AboutGamePageViewModel()
        {
            Pictures = new ObservableCollection<string>();
            Pictures.Add("gamepic1.png");
            Pictures.Add("gamepic.png");
        }
        #endregion 

        #region Methods
        
        #endregion 

    }
}
