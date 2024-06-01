using System;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace MyTime.ViewModels
{
    public class EndWorkPageViewModel : BaseViewModel
    {
        private DateTime _currentDate;
        private TimeSpan _endTime;

        public DateTime CurrentDate
        {
            get => _currentDate;
            set => SetProperty(ref _currentDate, value);
        }

        public TimeSpan EndTime
        {
            get => _endTime;
            set => SetProperty(ref _endTime, value);
        }

        public ICommand ConfirmEndWorkCommand { get; }

        public EndWorkPageViewModel()
        {
            CurrentDate = DateTime.UtcNow.AddHours(2); // GMT+2
            EndTime = RoundToNearestQuarterHour(CurrentDate.TimeOfDay);

            ConfirmEndWorkCommand = new Command(OnConfirmEndWork);
        }

        private async void OnConfirmEndWork()
        {
            // Logic for confirming end work, e.g., saving to database
            await Application.Current.MainPage.DisplayAlert("Arbeitsende", "Arbeitsende wurde bestätigt.", "OK");
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
