using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace Flags
{
    public class CountriesListWindowViewModel : ViewModelBase
    {
        private readonly ViewManager _viewManager;
        public RelayCommand ShowCountryDetailsWindowCommand { get; private set; }
        public RelayCommand ShowHelpWindowCommand { get; private set; }

        public string CountryTag { get; set; }
        public CountriesListWindowViewModel(ViewManager viewManager)
        {
            CountryTag = "ESP";

            _viewManager = viewManager;
            ShowCountryDetailsWindowCommand = new RelayCommand(ShowCountryDetails);
            ShowHelpWindowCommand = new RelayCommand(() => _viewManager.Show(View.Help));
        }

        void ShowCountryDetails()
        {
            _viewManager.Show(View.CountryDetails, CountryTag);
        }
    }
}