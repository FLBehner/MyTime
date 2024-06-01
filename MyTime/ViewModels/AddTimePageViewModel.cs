using System;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace MyTime.ViewModels
{
    public class AddTimePageViewModel : BaseViewModel
    {
        private DateTime _currentDate;
        private TimeSpan _addedTime;

        public DateTime CurrentDate
        {
            get => _currentDate;
            set => SetProperty(ref _currentDate, value);
        }

        public TimeSpan AddedTime
        {
            get => _addedTime;
            set => SetProperty(ref _addedTime, value);
        }

        public ICommand ConfirmStartAdditionCommand { get; }
        public ICommand ConfirmEndAdditionCommand { get; }

        public AddTimePageViewModel()
        {
            CurrentDate = DateTime.UtcNow.AddHours(2); // GMT+2
            AddedTime = RoundToNearestQuarterHour(CurrentDate.TimeOfDay);

            ConfirmStartAdditionCommand = new Command(OnConfirmStartAddition);
            ConfirmEndAdditionCommand = new Command(OnConfirmEndAddition);
        }

        private async void OnConfirmStartAddition()
        {
            // Logic for confirming start time addition, e.g., saving to database
            await Application.Current.MainPage.DisplayAlert("Arbeitsstart", "Arbeitsstartzeit wurde nachgetragen.", "OK");
            await Application.Current.MainPage.Navigation.PopAsync();
        }

        private async void OnConfirmEndAddition()
        {
            // Logic for confirming end time addition, e.g., saving to database
            await Application.Current.MainPage.DisplayAlert("Arbeitsende", "Arbeitsendezeit wurde nachgetragen.", "OK");
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
