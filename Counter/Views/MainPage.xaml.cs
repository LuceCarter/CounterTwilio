using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Counter.ViewModels;
using Xamarin.Forms;

namespace Counter.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }        
    }
}
