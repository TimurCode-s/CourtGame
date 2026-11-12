using CourtGame.Models;
using CourtGame.ViewModels;

namespace CourtGame.Views;

public partial class LevelPageMaster : ContentPage
{
	public LevelPageMaster(int num)
	{
		InitializeComponent();
		BindingContext = new LevelPageMasterViewModel(num);	

    }
}