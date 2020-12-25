using Crashlytics.Models;
using Crashlytics.ViewModels;
using Xamarin.Forms;

namespace Crashlytics.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}