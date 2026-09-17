using CourtGame.Resources.Views;
using CourtGame.Resources.Levels;
namespace CourtGame
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("Level1", typeof(Level1));
        }
    }
}
