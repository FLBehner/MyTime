using Microsoft.Maui.Controls;
using MyTime.ViewModels;

namespace MyTime.Views
{
    public partial class CorrectTimePage : ContentPage
    {
        public CorrectTimePage()
        {
            InitializeComponent();
            BindingContext = new CorrectTimePageViewModel();
        }
    }
}
