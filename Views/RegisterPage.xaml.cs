using CourtGame.Services;
using CourtGame.Models;
using CourtGame.Helper;
using CourtGame.ViewModels;
namespace CourtGame.Views;

public partial class RegisterPage : ContentPage
{
    public RegisterPage()
	{
        InitializeComponent();
        BindingContext = new CourtGame.ViewModels.RegisterView();
    }
}