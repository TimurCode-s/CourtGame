
namespace CourtGame.Resources.Views;
public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}
    private async void Start_Button(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LevelPage());
    }
    private async void Option_Button(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new OptionPage());
    }



    //Exit from game :)
    private async void Exit_Button(object sender, EventArgs e)
	{
    }
	
	
}