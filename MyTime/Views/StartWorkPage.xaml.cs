using Microsoft.Maui.Controls;
using MyTime.ViewModels;

namespace MyTime.Views
{
    public partial class StartWorkPage : ContentPage
    {
        public StartWorkPage()
        {
            InitializeComponent();
            BindingContext = new StartWorkPageViewModel();
        }
    }
}
