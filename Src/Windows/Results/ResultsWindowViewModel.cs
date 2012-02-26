using System;
using System.Collections.ObjectModel;
using System.Linq;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace Flags
{
    public class ResultsWindowViewModel : ViewModelBase
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
        public ResultsWindowViewModel(ViewManager viewManager, ICountrySelector countrySelector)
        {
            CreateRelayCommands(viewManager);

            _countrySelector = countrySelector;

            Countries = new ObservableCollection<Country>();
            Messenger.Default.Register<SearchParamsMessage>(this, ParseMessageFromMainWindow);
        }

        public void ParseMessageFromMainWindow(SearchParamsMessage message)
        {
            ParseMessageFromMainWindow(message.SearchParams);
        }

        public void ParseMessageFromMainWindow(string url)
        {
            // If we have whole URL then we remobe part before "?".
            var parameters = url.Contains("?")
                ? url.Substring(url.IndexOf("?", StringComparison.Ordinal) + 1)
                : url;

            // Create dictionary: param name -> value (int).
            var values = parameters.Split('&').Select(value => value.Split('=')).ToDictionary(pair => pair[0], pair => Convert.ToInt32(pair[1]));
            var color = values["color"];
            var shape = values["shape"];
            var add = values["add"];

            // Get list of countries with proper flags.
            _countrySelector.GetCountriesByParams(Countries, color, shape, add);
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