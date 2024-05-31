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

        public OverviewPageViewModel()
        {
            StartWorkCommand = new Command(OnStartWork);
            EndWorkCommand = new Command(OnEndWork);
            CorrectTimeCommand = new Command(OnCorrectTime);
            AddTimeCommand = new Command(OnAddTime);
            OverviewCommand = new Command(OnOverview);
            LogoutCommand = new Command(OnLogout);
        }

        private void OnStartWork() { /* Implement logic */ }
        private void OnEndWork() { /* Implement logic */ }
        private void OnCorrectTime() { /* Implement logic */ }
        private void OnAddTime() { /* Implement logic */ }
        private void OnOverview() { /* Implement logic */ }
        private async void OnLogout() => await Application.Current.MainPage.Navigation.PopToRootAsync();
    }
}
