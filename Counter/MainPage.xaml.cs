using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace Counter
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        private int count = 0;
        public event PropertyChangedEventHandler PropertyChanged;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private int _sliderValue;
        public int SliderValue {
            get => _sliderValue;
            set
            {
                if ( value != _sliderValue)
                {
                    _sliderValue = value;
                    NotifyPropertyChanged("Slider");
                }
            }
        }             

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void IncrementCounterClicked(object sender, EventArgs e)
        {
            count += SliderValue;
            CounterLabel.Text = count.ToString();
        }
    }
}
