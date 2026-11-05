using CourtGame.ViewModels;

namespace CourtGame.Views;

public partial class LevelPage : ContentPage
{
    public LevelPage()
    {
        InitializeComponent();
        BindingContext = new LevelPageViewModel();
    }
}