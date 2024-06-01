using System;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace MyTime.ViewModels
{
    public class StartWorkPageViewModel : BaseViewModel
    {
        private DateTime _currentDate;
        private TimeSpan _startTime;

        public DateTime CurrentDate
        {
            get => _currentDate;
            set => SetProperty(ref _currentDate, value);
        }

        public TimeSpan StartTime
        {
            get => _startTime;
            set => SetProperty(ref _startTime, value);
        }

        public ICommand ConfirmStartWorkCommand { get; }

        public StartWorkPageViewModel()
        {
            CurrentDate = DateTime.UtcNow.AddHours(2); // GMT+2
            StartTime = RoundToNearestQuarterHour(CurrentDate.TimeOfDay);

            ConfirmStartWorkCommand = new Command(OnConfirmStartWork);
        }

        private async void OnConfirmStartWork()
        {
            // Logic for confirming start work, e.g., saving to database
            await Application.Current.MainPage.DisplayAlert("Arbeitsstart", "Arbeitsstart wurde bestätigt.", "OK");
            await Application.Current.MainPage.Navigation.PopAsync();
        }

        private TimeSpan RoundToNearestQuarterHour(TimeSpan input)
        {
            int totalMinutes = (int)Math.Round(input.TotalMinutes / 15.0) * 15;
            int hours = totalMinutes / 60;
            int minutes = totalMinutes % 60;

            if (minutes == 60)
            {
                hours += 1;
                minutes = 0;
            }

            return new TimeSpan(hours, minutes, 0);
        }
    }
}
