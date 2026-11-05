using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourtGame.Views;
using CourtGame.Models;

namespace CourtGame.ViewModels
{
    public class LevelPageViewModel
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
            Cases Case = new Cases
            {
                images = new List<string> { "defendant1.png", "lawyer1.png" },
                description = "Late one night, a valuable diamond necklace disappeared from the Riverside Museum. The security alarm was triggered at 11:45 PM, and security cameras showed a suspicious figure leaving the building shortly afterward.\r\n\r\nDaniel Carter, a former museum employee, was arrested after his fingerprints were discovered near the display case.\r\n\r\nHowever, Daniel strongly denies the accusations. He claims he was nowhere near the museum that night and believes someone is trying to frame him.\r\n\r\nThe prosecution argues that the fingerprints, security footage, and witness testimony prove his guilt.\r\n\r\nThe defense believes there is more to this story than meets the eye.",
                date = "October 14, 2026",
                names = new List<string> { "Daniel Carter", "Detective Sarah", "Museum Curator" },
                dialogs1 = new List<string> { "Hello, I'm Detective Sarah.", "Hi, I'm Daniel Carter." },
                dialogs2 = new List<string> { "We need to investigate the crime scene.", "I understand." },
                dialogs3 = new List<string> { "The evidence is clear.", "I still maintain my innocence." },
                location = "Riverside Museum",
            };

            //LevelPageMasterViewModel(Case);
            await Application.Current.MainPage.Navigation.PushAsync(new LevelPageMaster());
        }
        #endregion
    }
}
