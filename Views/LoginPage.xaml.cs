using CourtGame.Models;
using CourtGame.Services;

namespace CourtGame.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}
	public void OnLoginClicked(object sender, EventArgs e)
	{
        bool isValid = true;
        if (Password.Text == "" || Password.Text == null)
        {
            PassErr.IsVisible = true;
            isValid = false;
        }
        if (Name.Text == "" || Name.Text == null)
        {
            NameErr.IsVisible = true;
            isValid = false;

        }
        if (isValid)
        {
            bool found = false;
            foreach (var user in Services.DataRepository.users)
            {
                if (user.Name == Name.Text && user.Password == Password.Text)
                {
                    Navigation.PushAsync(new HomePage());
                    found = true;
                    
                }
            }
            if (!found)
            {
                DisplayAlert("Failed", "User was not found", "OK");
            }
        }
       
    }	
    public async void OnRegisterClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new RegisterPage());
    }
    public void OnTogglePasswordClicked(object sender, EventArgs e)
    {
        Password.IsPassword = !Password.IsPassword;
    }
}