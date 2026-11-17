using CourtGame.Models;
using CourtGame.Services;
using CourtGame.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CourtGame.ViewModels
{
    public class LevelPageMasterViewModel : ViewModelBase
    {
        #region Fieds
        int count = 0;
        private bool typing;

        private List<string> image;

        public List<string> Images
        {
            get { return image; }
            set
            {
                image = value;
                OnPropertyChanged();
            }
        }

        private string date;

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        private List<string> names;

        public List<string> Names
        {
            get { return names; }
            set { names = value; }
        }

        private List<string> dialogs1;

        public List<string> Dialogs1
        {
            get { return dialogs1; }
            set { dialogs1 = value; }
        }

        private List<string> dialogs2;
        public List<string> Dialogs2
        {
            get { return dialogs2; }
            set { dialogs2 = value; }
        }

        private List<string> dialogs3;
        public List<string> Dialogs3
        {
            get { return dialogs3; }
            set { dialogs3 = value; }
        }

        private string location;
        public string Location
        {
            get => location;
            set
            {
                location = value;
                OnPropertyChanged();
            }

        }

        private string description;
        public string Description
        { 
            get => description;
            set
            {
                description = value;
                OnPropertyChanged();
            }

        }

        private string dialogText;
        public string DialogText
        { 
            get => dialogText;
            set
            {
                dialogText = value;
                OnPropertyChanged();
            }

        }
        private bool visible;
        public bool Visible
        { 
            get => visible;
            set
            {
                visible = value;
                OnPropertyChanged();
            }

        }
        
        #endregion

        #region Commands
        public Command MicroCommand { get; set; }
        public Command DialogCommmand { get; set; }

        #endregion


        #region Constructor
        public LevelPageMasterViewModel(int num)
        {
            Images = DataRepository.cases[num].Images;
            Dialogs1 = DataRepository.cases[num].Dialogs1;
            MicroCommand = new Command(OnMicroClicked);
            DialogCommmand = new Command(OnDialogClicked);
        }

        #endregion

        #region Methods
        public async void OnMicroClicked()
        {
            Visible = true;
        }
        public async void OnDialogClicked()
        {
            if (count == Dialogs1.Count)
            {
                count = 0;
                Visible = false;
            }
            else
            {
                typing = true;
                for (int i = 0; i < Dialogs1.Count; i++)
                {
                    for (int j = 0; j < Dialogs1[i].Length; j++)
                    {
                        DialogText += Dialogs1[i][j];
                        await Task.Delay(50);
                    }
                    DialogText = "";
                }
                typing = false;
            }
                
            //DialogText = Dialogs1[count];

            //count++;
        }
        #endregion

    }
}