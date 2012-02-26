using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace Flags
{
    public class CountriesListWindowViewModel : ViewModelBase
    {
        #region Properties
        private readonly ICountrySelector _countrySelector;
        public ObservableCollection<Country> Countries { get; set; }

        private Country _selectedCountry;
        public Country SelectedCountry
        {
            get { return _selectedCountry; }
            set { _selectedCountry = value; RaisePropertyChanged("SelectedCountry"); }
        }

        private string _resultUri;
        public string ResultUri
        {
            get { return _resultUri; }
            set { _resultUri = value; RaisePropertyChanged("ResultUri"); }
        }
        #endregion

        #region Relay Commands
        private ViewManager _viewManager;
        public RelayCommand ShowCountryDetailsWindowCommand { get; private set; }
        public RelayCommand ShowHelpWindowCommand { get; private set; }

        private void CreateRelayCommands(ViewManager viewManager)
        {
            _viewManager = viewManager;
            ShowCountryDetailsWindowCommand = new RelayCommand(ShowCountryDetails);
            ShowHelpWindowCommand = new RelayCommand(() => _viewManager.Show(View.Help));
        }
        #endregion

        #region Initialization
        public CountriesListWindowViewModel(ViewManager viewManager, ICountrySelector countrySelector)
        {
            CreateRelayCommands(viewManager);

            _countrySelector = countrySelector;

            Countries = new ObservableCollection<Country>();
            _countrySelector.GetAllCountries(Countries);
            if (Countries.Count > 0)
                SelectedCountry = Countries[0];
        }        
        #endregion

        #region Navigation
        void ShowCountryDetails()
        {
            if (SelectedCountry == null)
                return;

            _viewManager.Show(View.CountryDetails, SelectedCountry.Tag);
        }
        #endregion
    }
}