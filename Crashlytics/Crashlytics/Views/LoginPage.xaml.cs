﻿using Crashlytics.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Crashlytics.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }
    }
}