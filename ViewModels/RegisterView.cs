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

        private string errName = "";
        public string ErrName
        {
            get { return errName; }
            set
            {
                errName = value;
                OnPropertyChanged();
            }
        }

        private string errEmail = "";
        public string EmailErr
        {
            get { return errEmail; }
            set
            {
                errEmail = value;
                OnPropertyChanged();
            }
        }

        private string errPassword = "";
        public string ErrPassword
        {
            get { return errPassword; }
            set
            {
                errPassword = value;
                OnPropertyChanged();
            }
        }
        private bool isPasswordVisible = true;
        public bool IsPasswordVisible
        {
            get { return isPasswordVisible; }
            set
            {
                isPasswordVisible = value;

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
                ErrPassword = "Password must contain at least 8 characters.";
                isValid = false;
            }
            if (Name == "" || Name == null)
            {
                ErrName = "Name is required.";
                isValid = false;

            }
            if (Email == "" || Email == null || !Email.Contains("@"))
            {
                EmailErr = "Please enter a valid email address.";
                isValid = false;

            }
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
        private async void ShowErr()
        {
            ErrName = "Name is required";
        }
        #endregion
    }
}
