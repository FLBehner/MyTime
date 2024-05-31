using System.Windows.Input;
using Microsoft.Maui.Controls;
using MyTime.Views; // Namespace für OverviewPage

namespace MyTime.ViewModels
{
    public class LoginPageViewModel : BaseViewModel
    {
        private string _username;
        private string _password;
        private string _loginMessage;

        public string Username
        {
            get => _username;
            set => SetProperty(ref _username, value);
        }

        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        public string LoginMessage
        {
            get => _loginMessage;
            set => SetProperty(ref _loginMessage, value);
        }

        public ICommand LoginCommand { get; }

        public LoginPageViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked()
        {
            if (Username == "user" && Password == "0000")
            {
                LoginMessage = string.Empty;
                await Application.Current.MainPage.Navigation.PushAsync(new OverviewPage());
            }
            else
            {
                LoginMessage = "Invalid login credentials";
            }
        }
    }
}
