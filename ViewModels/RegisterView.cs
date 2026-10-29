using CourtGame.Helper;
using CourtGame.Models;
using CourtGame.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtGame.ViewModels
{
    public class RegisterView : ViewModelBase
    {
        #region Fields 
        private string name = "";
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                
                OnPropertyChanged();
            }
        }

        private string password = "";
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged();
            }
        }

        private string email = "";
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged();
            }
        }

        private bool errNameVis;
        public bool ErrName
        {
            get => errNameVis;
            set
            {
                if (errNameVis == value) return;

                errNameVis = value;
                OnPropertyChanged();
            }
        }

        private bool errEmVis;
        public bool EmailErr
        {
            get => errEmVis;
            set
            {
                if (errEmVis == value) return;

                errEmVis = value;
                OnPropertyChanged();
            }
        }

        private bool errPassVis = false;
        public bool ErrPassword
        {
            get => errPassVis;
            set
            {
                if (errPassVis == value) return;

                errPassVis = value;
                OnPropertyChanged();
            }
        }
        private bool ispasswordvisible = true;
        public bool IsPasswordVisible
        {
            get { return ispasswordvisible; }
            set
            {
                ispasswordvisible = value;

                OnPropertyChanged();
            }
        }
        private string Icon = IconFonts.Visibility;
        public string IconVisibility
        {
            get { return Icon; }
            set
            {
                Icon = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Commands
        public Command RegisterCommand { get; }
        public Command LoginCommand { get; }
        public Command TogglePasswordCommand { get; }
        #endregion

        #region Constructor
        public RegisterView()
        {
            RegisterCommand = new Command(OnRegisterClicked);
            LoginCommand = new Command(OnLoginClicked);
            TogglePasswordCommand = new Command(OnTogglePasswordClicked);

        }
        #endregion
        #region Methods
        private async void OnRegisterClicked()
        {
            bool isValid = true;
            DataRepository data = new DataRepository();

            if (Password == "" || Password == null)
            {
                ErrPassword = false;
                isValid = false;
            }
            else ErrPassword = false;
            if (Name == "" || Name == null)
            {
                ErrName = true;
                isValid = false;

            }
            else ErrName = false;
            if (Email == "" || Email == null || !Email.Contains("@"))
            {
                EmailErr = true;
                isValid = false;

            }
            else EmailErr = false;
            if (isValid)
            {
                if (data.AddUser(Name, Password, Email))
                {
                    await Application.Current.MainPage.DisplayAlert("Success", "User registered successfully!", "OK");
                    await Application.Current.MainPage.Navigation.PushAsync(new Views.LoginPage());

                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Failed", "User already exist", "OK");
                }
            }
            else await Application.Current.MainPage.DisplayAlert("Failed", "Something went wrong, please check your input", "OK");

            isValid = true;

        }
        private async void OnLoginClicked()
        {
            // Navigate to login page
            await Application.Current.MainPage.Navigation.PushAsync(new Views.LoginPage());
        }
        private async void OnTogglePasswordClicked()
        {
            IsPasswordVisible = !IsPasswordVisible;
            if (IsPasswordVisible)
            {
                Icon = IconFonts.Visibility;
            }
            else
            {
                Icon = IconFonts.Visibility_off;
            }
        }
       
        #endregion
    }
}
