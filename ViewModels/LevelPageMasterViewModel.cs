using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourtGame.Models;
using CourtGame.ViewModels;

namespace CourtGame.ViewModels
{
    public class LevelPageMasterViewModel : ViewModelBase
    {
        #region Fieds
        private Cases _case;
        public Cases Case
        {
            get => _case;
            set
            {
                _case = value;
                OnPropertyChanged();
            }
        }
        private List<string> images;
        public List<string> Images
        {
            get => Images;
            set
            {
                images = value;
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
        public LevelPageMasterViewModel(Cases cases)
        {
            Case = cases;
        }

        #endregion

        #region Methods

        #endregion

    }
}