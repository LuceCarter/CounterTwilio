using System;
using System.Windows.Input;
using MvvmHelpers;
using Xamarin.Forms;

namespace Counter.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public ICommand IncrementCommand { get;  }
        public MainPageViewModel()
        {
            IncrementCommand = new Command(() => IncrementCount());
        }

        private int count = 0;
        public int Count
        {
            get => count;
            set => SetProperty(ref count, value);
        }

        private void IncrementCount()
        {
            Count += SliderValue;
        }

        private int sliderValue = 1;
        public int SliderValue
        {
            get => sliderValue;
            set => SetProperty(ref sliderValue, value);
        }
    }
}
