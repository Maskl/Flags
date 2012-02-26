using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace Flags
{
    public class ResultsWindowViewModel : ViewModelBase
    {
        public ObservableCollection<Country> Countries { get; set; }
        private readonly ViewManager _viewManager;
        public RelayCommand ShowCountryDetailsWindowCommand { get; private set; }
        public RelayCommand ShowHelpWindowCommand { get; private set; }

        public string CountryDetailsUri { get; set; }

        public ResultsWindowViewModel(ViewManager viewManager)
        {
            Countries = new ObservableCollection<Country>();
            CountryTag = "USA";
            CountryDetailsUri = "/Country/ARG";

            _viewManager = viewManager;
            ShowCountryDetailsWindowCommand = new RelayCommand(ShowCountryDetails);
            ShowHelpWindowCommand = new RelayCommand(() => _viewManager.Show(View.Help));
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
            GetCountriesListByParams(Countries, color, shape, add);
        }

        private void GetCountriesListByParams(Collection<Country> list, int color, int shape, int add)
        {
            if (color % 2 == 0) list.Add(new Country { Tag = "POL", Name = "Poland", Continent = "Europe", Capital = "Warsaw" });
            if (color % 2 != 0) list.Add(new Country { Tag = "USA", Name = "United States", Continent = "North America", Capital = "Washington" });
            if (shape % 3 == 0) list.Add(new Country { Tag = "AUT", Name = "Austria", Continent = "Europe", Capital = "Vien" });
            if (shape % 4 == 0) list.Add(new Country { Tag = "JAP", Name = "Japan", Continent = "Asia", Capital = "Tokyo" });
            if (add % 2 != 0) list.Add(new Country { Tag = "NOR", Name = "Norway", Continent = "Europe", Capital = "Oslo" });
            if (add % 3 != 0) list.Add(new Country { Tag = "ARG", Name = "Argentina", Continent = "South America", Capital = "Buenos Aires" });
        }

        void ShowCountryDetails()
        {
            _viewManager.Show(View.CountryDetails, CountryTag);
        }

        public Country SelectedCountry { get; set; }
        private string _countryTag;
        public string CountryTag
        {
            get { return _countryTag; }
            set
            {
                if (_countryTag == value)
                    return;

                _countryTag = value;

                RaisePropertyChanged("CountryTag");
            }
        }
    }
}