using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace Flags
{
    public class MainWindowViewModel : ViewModelBase
    {

        public RelayCommand ShowResultsWindowCommand { get; private set; }

        private INavigationService _navigationService;

        public string TestString { get; set; }
        public MainWindowViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            TestString = navigationService.GetTestText(); //"Testowy string z VM";

            ShowResultsWindowCommand = new RelayCommand(ShowAllMeasurementsView);




            Uri nextPage = new System.Uri("/Windows/Results/ResultsWindowViewWP7.xaml", System.UriKind.Relative);
            GoToPage2Command = new RelayCommand(() => Messenger.Default.Send(nextPage, "NavigationRequest")); 
        }

        private void ShowAllMeasurementsView()
        {
            _navigationService.NavigateTo(null);
            //var newView = new ResultsWindowViewWPF();
            //newView.ShowDialog();
        }

        protected void SendNavigationRequestMessage(Uri uri)
        {
            Messenger.Default.Send<Uri>(uri, "NavigationRequest");
        }

        public RelayCommand GoToPage2Command { get; private set; }

    
    }
}