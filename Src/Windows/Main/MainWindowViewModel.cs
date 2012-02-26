using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace Flags
{
    public class MainWindowViewModel : ViewModelBase
    {
        public RelayCommand ShowResultsWindowCommand { get; private set; }

        private ViewManager _navigationService;

        public string TestString { get; set; }
        public MainWindowViewModel(ViewManager navigationService)
        {
            _navigationService = navigationService;

            TestString = "Testowy string";

            ShowResultsWindowCommand = new RelayCommand(ShowAllMeasurementsView);
        }

        private void ShowAllMeasurementsView()
        {
            var nextPage = new Uri("/Windows/Results/ResultsWindowViewWP7.xaml", UriKind.Relative);
            _navigationService.NavigateTo(nextPage);
        }


    
    }
}