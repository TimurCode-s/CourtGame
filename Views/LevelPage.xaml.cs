using CourtGame.Resources.Levels;

namespace CourtGame.Views;

public partial class LevelPage : ContentPage
{
    public LevelPage()
    {
        InitializeComponent();
    }

    private async void GoBack_Button(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void Level1_Button(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Level1");
    }
}