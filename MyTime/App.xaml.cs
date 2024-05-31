using Microsoft.Maui.Controls;
using MyTime.Views;

namespace MyTime
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
        }
    }
}
