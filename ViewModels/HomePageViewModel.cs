using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtGame.ViewModels
{
    public class HomePageViewModel : ViewModelBase
    {
        #region Commands
        public Command StartCommand { get; }
        public Command OptionCommand { get; }
        public Command ExitCommand { get; }

        #endregion

        #region Constructor 
        public HomePageViewModel()
        {
            StartCommand = new Command(Start_Button);
            OptionCommand = new Command(Option_Button);
            ExitCommand = new Command(Exit_Button);

        }

        #endregion

        #region Methods
        private async void Start_Button()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new Views.LevelPage());
        }
        private async void Option_Button()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new Views.OptionPage());
        }
        private async void Exit_Button()
        {
            //exit from app
        }

        #endregion


    }
}
