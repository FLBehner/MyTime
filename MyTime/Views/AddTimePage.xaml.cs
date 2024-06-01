using Microsoft.Maui.Controls;
using MyTime.ViewModels;

namespace MyTime.Views
{
    public partial class AddTimePage : ContentPage
    {
        public AddTimePage()
        {
            InitializeComponent();
            BindingContext = new AddTimePageViewModel();
        }
    }
}
