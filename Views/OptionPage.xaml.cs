namespace CourtGame.Resources.Views;

public partial class OptionPage : ContentPage
{
	public OptionPage()
	{
		InitializeComponent();
	}
    private async void GoBack_Button(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomePage());
    }
}