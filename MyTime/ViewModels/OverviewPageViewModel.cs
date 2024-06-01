using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace MyTime.ViewModels
{
    public class OverviewPageViewModel : BaseViewModel
    {
        public ICommand StartWorkCommand { get; }
        public ICommand EndWorkCommand { get; }
        public ICommand CorrectTimeCommand { get; }
        public ICommand AddTimeCommand { get; }
        public ICommand OverviewCommand { get; }
        public ICommand LogoutCommand { get; }
        public ICommand NavigateToStartWorkPageCommand { get; }
        public ICommand NavigateToEndWorkPageCommand { get; }
        public ICommand NavigateToCorrectTimePageCommand { get; }
        public ICommand NavigateToAddTimePageCommand { get; }

        public OverviewPageViewModel()
        {
            StartWorkCommand = new Command(OnStartWork);
            EndWorkCommand = new Command(OnEndWork);
            CorrectTimeCommand = new Command(OnCorrectTime);
            AddTimeCommand = new Command(OnAddTime);
            OverviewCommand = new Command(OnOverview);
            LogoutCommand = new Command(OnLogout);
            NavigateToStartWorkPageCommand = new Command(OnNavigateToStartWorkPage);
            NavigateToEndWorkPageCommand = new Command(OnNavigateToEndWorkPage);
            NavigateToCorrectTimePageCommand = new Command(OnNavigateToCorrectTimePage);
            NavigateToAddTimePageCommand = new Command(OnNavigateToAddTimePage);
        }

        private async void OnStartWork() { /* Implement logic */ }
        private async void OnEndWork() { /* Implement logic */ }
        private async void OnCorrectTime() { /* Implement logic */ }
        private async void OnAddTime() { /* Implement logic */ }
        private async void OnOverview() { /* Implement logic */ }
        private async void OnLogout() => await Application.Current.MainPage.Navigation.PopToRootAsync();
        private async void OnNavigateToStartWorkPage()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new Views.StartWorkPage());
        }
        private async void OnNavigateToEndWorkPage()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new Views.EndWorkPage());
        }
        private async void OnNavigateToCorrectTimePage()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new Views.CorrectTimePage());
        }
        private async void OnNavigateToAddTimePage()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new Views.AddTimePage());
        }
    }
}
