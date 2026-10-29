using CourtGame.Models;

namespace CourtGame.Views;

public partial class AboutGamePage : ContentPage
{
	public List<GamePictures> Pictures { get; set; }
	public AboutGamePage()
	{
		InitializeComponent();
		BindingContext = this;

        Pictures = new List<GamePictures>();


        Pictures.Add(new GamePictures { image = "gamepic.png" });
        Pictures.Add(new GamePictures { image = "gamepic1.png" });

    }
}