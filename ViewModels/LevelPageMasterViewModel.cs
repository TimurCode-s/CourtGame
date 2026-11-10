using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourtGame.Models;
using CourtGame.ViewModels;
using CourtGame.Services;


namespace CourtGame.ViewModels
{
    public class LevelPageMasterViewModel : ViewModelBase
    {
        #region Fieds

        private List<string> _images;

        public List<string> Images
        {
            get { return _images; }
            set
            {
                _images = value;
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
        #endregion

        #region Commands


        #endregion


        #region Constructor
        public LevelPageMasterViewModel(Case focusCase)
        {
            //Images = focusCase.Images;




        }

        #endregion

        #region Methods

        #endregion

    }
}