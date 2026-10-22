using CourtGame.Models;
using CourtGame.Services;

namespace CourtGame.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}
	public async void OnLoginClicked(object sender, EventArgs e)
	{
        bool isValid = true;
        DataRepository data = new DataRepository();
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
        if (Email.Text == "" || Email.Text == null || !Email.Text.Contains("@"))
        {
            EmailErr.IsVisible = true;
            isValid = false;

        }
        
        if (isValid)
        {
            if (data.LoginUser(Name.Text, Password.Text, Email.Text))
            {
                await DisplayAlert("Login Successful", "Welcome back!", "OK");
                await Navigation.PushAsync(new HomePage());
            }
            else
            {
                await DisplayAlert("Login Failed", "Try again", "OK");

            }
        }

        isValid = true;

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