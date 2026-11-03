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
    public class LogInView : ViewModelBase
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
        public bool ErrEmail
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
        public LogInView()
        {
            RegisterCommand = new Command(OnRegisterClicked);
            LoginCommand = new Command(OnLoginClicked);
            TogglePasswordCommand = new Command(OnTogglePasswordClicked);
        }
        #endregion
        #region Methods
        private async void OnRegisterClicked()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new Views.RegisterPage());

        }
        private async void OnLoginClicked()
        {
            bool isValid = true;
            DataRepository data = new DataRepository();
            if (string.IsNullOrWhiteSpace(Password))
            {
                ErrPassword = true;
                isValid = false;
            }
            else
            {
                ErrPassword = false;
            }
            if (string.IsNullOrWhiteSpace(Name))
            {
                ErrName = true;
                isValid = false;
            }
            else
            {
                ErrName = false;
            }
            if (string.IsNullOrWhiteSpace(Email) || !Email.Contains("@"))
            {
                ErrEmail = true;
                isValid = false;
            }
            else
            {
                ErrEmail = false;
            }

            if (isValid)
            {
                if (data.LoginUser(Name, Password, Email))
                {
                    await Application.Current.MainPage.DisplayAlert("Login Successful", "Welcome back!", "OK");
                    await Application.Current.MainPage.Navigation.PushAsync(new Views.HomePage());
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Login Failed", "Try again", "OK");
                }
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Login Failed", "Try again", "OK");
            }

                isValid = true;

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

