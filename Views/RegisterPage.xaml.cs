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
		DataRepository data = new DataRepository();
		if(data.AddUser(Name.Text, Password.Text))
		{
            DataRepository.users.Add(new User { Name = Name.Text, Password = Password.Text });
			DisplayAlert("Success", "User registered successfully!", "OK");
			

        }
		else
		{
            DisplayAlert("Failed", "User with user name like yours already exist", "OK");
        }
            
        
		
    }
}