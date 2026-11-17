using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourtGame.Views;
using CourtGame.Models;
using CourtGame.Services;

namespace CourtGame.ViewModels
{
    public class LevelPageViewModel : ViewModelBase
    {
        #region Fields
        #endregion

        #region Commands
        public Command GoBackCommand { get; set; }
        public Command Level1Command { get; set; }
        #endregion

        #region Constructor
        public LevelPageViewModel()
        {
            GoBackCommand = new Command(GoBack_Clicked);
            Level1Command = new Command(Level1_Clicked);
        }
        #endregion

        #region Methods
        private async void GoBack_Clicked()
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }
        private async void Level1_Clicked()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new LevelPageMaster(0));
        }
        #endregion
    }
}
