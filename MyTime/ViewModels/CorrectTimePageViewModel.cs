using System;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace MyTime.ViewModels
{
    public class CorrectTimePageViewModel : BaseViewModel
    {
        private DateTime _currentDate;
        private TimeSpan _correctedTime;

        public DateTime CurrentDate
        {
            get => _currentDate;
            set => SetProperty(ref _currentDate, value);
        }

        public TimeSpan CorrectedTime
        {
            get => _correctedTime;
            set => SetProperty(ref _correctedTime, value);
        }

        public ICommand ConfirmStartCorrectionCommand { get; }
        public ICommand ConfirmEndCorrectionCommand { get; }

        public CorrectTimePageViewModel()
        {
            CurrentDate = DateTime.UtcNow.AddHours(2); // GMT+2
            CorrectedTime = RoundToNearestQuarterHour(CurrentDate.TimeOfDay);

            ConfirmStartCorrectionCommand = new Command(OnConfirmStartCorrection);
            ConfirmEndCorrectionCommand = new Command(OnConfirmEndCorrection);
        }

        private async void OnConfirmStartCorrection()
        {
            // Logic for confirming start time correction, e.g., saving to database
            await Application.Current.MainPage.DisplayAlert("Arbeitsstart", "Arbeitsstartzeit wurde korrigiert.", "OK");
            await Application.Current.MainPage.Navigation.PopAsync();
        }

        private async void OnConfirmEndCorrection()
        {
            // Logic for confirming end time correction, e.g., saving to database
            await Application.Current.MainPage.DisplayAlert("Arbeitsende", "Arbeitsendezeit wurde korrigiert.", "OK");
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
