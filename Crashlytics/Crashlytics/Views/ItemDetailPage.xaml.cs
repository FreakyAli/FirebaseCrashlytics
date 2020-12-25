using Crashlytics.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Crashlytics.Views
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