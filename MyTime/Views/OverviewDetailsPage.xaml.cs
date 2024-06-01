using Microsoft.Maui.Controls;
using MyTime.ViewModels;

namespace MyTime.Views
{
    public partial class OverviewDetailsPage : ContentPage
    {
        public OverviewDetailsPage()
        {
            InitializeComponent();
            BindingContext = new OverviewDetailsPageViewModel();
        }
    }
}
