using Microsoft.Maui.Controls;
using MyTime.ViewModels;

namespace MyTime.Views
{
    public partial class EndWorkPage : ContentPage
    {
        public EndWorkPage()
        {
            InitializeComponent();
            BindingContext = new EndWorkPageViewModel();
        }
    }
}
