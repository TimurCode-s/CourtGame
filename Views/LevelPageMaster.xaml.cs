using CourtGame.Models;

namespace CourtGame.Views;

public partial class LevelPageMaster : ContentPage
{
	static List<Cases> Case { get; set; }
	public LevelPageMaster()
	{
		InitializeComponent();
	}
}