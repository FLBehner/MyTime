using System;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace MyTime.ViewModels
{
    public class OverviewDetailsPageViewModel : BaseViewModel
    {
        public string CurrentDate { get; }
        public string CurrentTime { get; }

        // Diese Werte müssen aus einer Datenquelle stammen, hier werden sie für das Beispiel festgelegt
        public string WorkedHours { get; } = "40 Stunden";
        public string DaysWithPerDiem { get; } = "5 Tage";
        public string DaysWithHolidayBonus { get; } = "2 Tage";
        public string RemainingVacationDays { get; } = "10 Tage";
        public string UsedVacationDays { get; } = "5 Tage";
        public string SickDays { get; } = "3 Tage";

        public ICommand LogoutCommand { get; }

        public OverviewDetailsPageViewModel()
        {
            var now = DateTime.UtcNow.AddHours(2); // GMT+2
            CurrentDate = now.ToString("dd.MM.yyyy");
            CurrentTime = now.ToString("HH:mm");

            LogoutCommand = new Command(OnLogout);
        }

        private async void OnLogout()
        {
            await Application.Current.MainPage.Navigation.PopToRootAsync();
        }
    }
}
