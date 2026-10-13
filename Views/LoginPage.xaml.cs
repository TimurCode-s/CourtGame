namespace CourtGame.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}
	public void OnLoginClicked(object sender, EventArgs e)
	{
		foreach (var user in Services.DataRepository.users)
		{
			if(user.Name == Name.Text && user.Password == Password.Text)
			{
				Navigation.PushAsync(new HomePage());
				return;
            }
        }
    }	
}