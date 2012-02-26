using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace Flags
{
    public class ResultsWindowViewModel : ViewModelBase
    {
        private readonly ViewManager _viewManager;
        public RelayCommand ShowCountryDetailsWindowCommand { get; private set; }
        public RelayCommand ShowHelpWindowCommand { get; private set; }

        public string TestString { get; set; }
        public ResultsWindowViewModel(ViewManager viewManager)
        {
            TestString = "A tu mamy wyniki";

            _viewManager = viewManager;
            ShowCountryDetailsWindowCommand = new RelayCommand(() => _viewManager.Show(View.CountryDetails));
            ShowHelpWindowCommand = new RelayCommand(() => _viewManager.Show(View.Help));
        }
    }
}