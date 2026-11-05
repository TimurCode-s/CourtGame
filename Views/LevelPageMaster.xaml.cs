using CourtGame.Models;
using CourtGame.ViewModels;

namespace CourtGame.Views;

public partial class LevelPageMaster : ContentPage
{
	public LevelPageMaster()
	{
		InitializeComponent();
		BindingContext = new LevelPageMasterViewModel(new Cases());	
    }
}