using CourtGame.ViewModels;

namespace CourtGame.Views;

public partial class AboutGamePage : ContentPage
{
	public AboutGamePage()
	{
		InitializeComponent();
		BindingContext = new AboutGamePageViewModel();
    }
}