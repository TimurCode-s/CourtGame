using CourtGame.Models;

namespace CourtGame.Views;

public partial class AboutGamePage : ContentPage
{
	public List<GamePictures> Pictures { get; set; }
	public AboutGamePage()
	{
		InitializeComponent();
		Pictures = new List<GamePictures>();

		BindingContext = this;

        Pictures.Add(new GamePictures { image = "gamepic.png" });
        Pictures.Add(new GamePictures { image = "gamepic1.png" });

    }
}