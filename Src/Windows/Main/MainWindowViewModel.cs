using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace Flags
{
    public class MainWindowViewModel : ViewModelBase
    {

        public RelayCommand ShowResultsWindowCommand { get; private set; }

        public string TestString { get; set; }
        public MainWindowViewModel(INavigationService navigationService)
        {
            TestString = navigationService.GetTestText(); //"Testowy string z VM";

            ShowResultsWindowCommand = new RelayCommand(ShowAllMeasurementsView);
        }

        private void ShowAllMeasurementsView()
        {
            //var newView = new ResultsWindowViewWPF();
            //newView.ShowDialog();
        }
    }
}