using LoginApp.Pages;

namespace LoginApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage (new LoginUsuarioPage());
        }
    }
}