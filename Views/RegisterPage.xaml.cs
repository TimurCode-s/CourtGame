using CourtGame.Services;
using CourtGame.Models;

namespace CourtGame.Views;

public partial class RegisterPage : ContentPage
{
	public RegisterPage()
	{
		InitializeComponent();
	}

	public void OnRegisterClicked(object sender, EventArgs e)
	{
		bool isValid = true;
        DataRepository data = new DataRepository();

        if (Password.Text == "" || Password.Text == null)
        {
            PassErr.IsVisible = true;
            isValid = false;
        }
        if(Name.Text == "" || Name.Text == null)
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
            if (data.AddUser(Name.Text, Password.Text, Email.Text))
            {
                DataRepository.users.Add(new User { Name = Name.Text, Password = Password.Text, Email = EmailErr.Text });
                DisplayAlert("Success", "User registered successfully!", "OK");
                Navigation.PushAsync(new HomePage());

            }
            else
            {
                DisplayAlert("Failed", "User with user name like yours already exist", "OK");
            }
        }
        isValid = true;
        
    }
    public async void OnLoginClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new LoginPage());
    }
    public void OnTogglePasswordClicked(object sender, EventArgs e)
    {
        Password.IsPassword = !Password.IsPassword;
    }
}