using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Counter
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        private int count = 0;
        

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

        public string SliderLabel => SliderValue.ToString();

        public event PropertyChangedEventHandler PropertyChanged;
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
