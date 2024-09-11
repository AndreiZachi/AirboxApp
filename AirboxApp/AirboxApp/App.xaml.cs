using AirboxApp.Views;

namespace AirboxApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PresenterPage();
        }
    }
}
