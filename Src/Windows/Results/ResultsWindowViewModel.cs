using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Media;
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

        private List<Group<Country>> _countriesGroup;
        public List<Group<Country>> CountriesGroup
        {
            get { return _countriesGroup; }
            set { _countriesGroup = value; RaisePropertyChanged("CountriesGroup"); }
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

            // For Expression Blend only
            if (IsInDesignModeStatic)
            {
                _countrySelector.GetCountriesByParams(Countries, 123, 345, 567);

                Zzzzx();
            }
        }

        private void Zzzzx()
        {
            var allTorrents = (from torrent in Countries
                               select torrent);

            var emptyGroups = new List<Group<Country>>()
            {
                new Group<Country>("#", new List<Country>()),
                new Group<Country>("A", new List<Country>()),
                new Group<Country>("B", new List<Country>()),
                new Group<Country>("C", new List<Country>()),
                new Group<Country>("D", new List<Country>()),
                new Group<Country>("E", new List<Country>()),
                new Group<Country>("F", new List<Country>()),
                new Group<Country>("G", new List<Country>()),
                new Group<Country>("H", new List<Country>()),
                new Group<Country>("I", new List<Country>()),
                new Group<Country>("J", new List<Country>()),
                new Group<Country>("K", new List<Country>()),
                new Group<Country>("L", new List<Country>()),
                new Group<Country>("M", new List<Country>()),
                new Group<Country>("N", new List<Country>()),
                new Group<Country>("O", new List<Country>()),
                new Group<Country>("P", new List<Country>()),
                new Group<Country>("Q", new List<Country>()),
                new Group<Country>("R", new List<Country>()),
                new Group<Country>("S", new List<Country>()),
                new Group<Country>("T", new List<Country>()),
                new Group<Country>("U", new List<Country>()),
                new Group<Country>("V", new List<Country>()),
                new Group<Country>("W", new List<Country>()),
                new Group<Country>("X", new List<Country>()),
                new Group<Country>("Y", new List<Country>()),
                new Group<Country>("Z", new List<Country>())
            };

            var groupedTorrents = (from t in allTorrents
                                   group t by t.FirstLetter.ToString() into grp
                                   orderby grp.Key
                                   select new Group<Country>(grp.Key, grp));

            CountriesGroup = (from t in groupedTorrents.Union(emptyGroups)
                                   orderby t.Title
                                   select t).ToList();

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

            //// Create dictionary: param name -> value (int).
            var values = parameters.Split('&').Select(value => value.Split('=')).ToDictionary(pair => pair[0], pair => Convert.ToInt32(pair[1]));
            var color = values["color"];
            var shape = values["shape"];
            var add = values["add"];

            // Get list of countries with proper flags.
            _countrySelector.GetCountriesByParams(Countries, color, shape, add);

            if (Countries.Count > 0)
                SelectedCountry = Countries[0];

            Zzzzx();
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




    public class Group<T> : IEnumerable<T>
    {
        public Group(string name, IEnumerable<T> items)
        {
            this.Title = name;
            this.Items = new List<T>(items);
        }

        public override bool Equals(object obj)
        {
            Group<T> that = obj as Group<T>;

            return (that != null) && (this.Title.Equals(that.Title));
        }

        public override int GetHashCode()
        {
            return this.Title.GetHashCode();
        }

        public string Title
        {
            get;
            set;
        }

        public IList<T> Items
        {
            get;
            set;
        }

        public bool HasItems
        {
            get
            {
                return Items.Count > 0;
            }
        }

        public Brush GroupBackgroundBrush
        {
            get
            {
                if (HasItems)
                    return (SolidColorBrush)Application.Current.Resources["PhoneAccentBrush"];
                else
                    return (SolidColorBrush)Application.Current.Resources["PhoneChromeBrush"];
            }
        }

        #region IEnumerable<T> Members

        public IEnumerator<T> GetEnumerator()
        {
            return this.Items.GetEnumerator();
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.Items.GetEnumerator();
        }

        #endregion
    }
}