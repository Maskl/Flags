using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace Flags
{
    public class MainWindowViewModel : ViewModelBase
    {
        public RelayCommand ShowResultsWindowCommand { get; private set; }

        private readonly ViewManager _viewManager;

        public string TestString { get; set; }
        public MainWindowViewModel(ViewManager viewManager)
        {
            _viewManager = viewManager;

            TestString = "Testowy string";

            ShowResultsWindowCommand = new RelayCommand(ShowAllMeasurementsView);
        }

        private void ShowAllMeasurementsView()
        {
            _viewManager.Show(View.Results);
        }


    
    }
}