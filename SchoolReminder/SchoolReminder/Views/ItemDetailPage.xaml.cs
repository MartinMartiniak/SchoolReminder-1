using SchoolReminder.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace SchoolReminder.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}