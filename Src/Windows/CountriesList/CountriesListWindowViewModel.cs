﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

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

        private List< LongListGroup<Country> > _countriesGrupped;
        public List< LongListGroup<Country> > CountriesGrupped
        {
            get { return _countriesGrupped; }
            set { _countriesGrupped = value; RaisePropertyChanged("CountriesGrupped"); }
        }

        #endregion

        #region Relay Commands
        private ViewManager _viewManager;
        public RelayCommand ShowCountryDetailsWindowCommand { get; private set; }
        public RelayCommand ShowHelpWindowCommand { get; private set; }
        public RelayCommand<object> SelectionChanged { get; private set; }

        private void CreateRelayCommands(ViewManager viewManager)
        {
            _viewManager = viewManager;
            ShowCountryDetailsWindowCommand = new RelayCommand(ShowCountryDetails);
            ShowHelpWindowCommand = new RelayCommand(() => _viewManager.Show(View.Help));
            SelectionChanged = new RelayCommand<object>(ChangeSelection);
        }

        private void ChangeSelection(object obj)
        {
            SelectedCountry = (Country)obj;
            ShowCountryDetails();
        }

        #endregion

        #region Initialization
        public CountriesListWindowViewModel(ViewManager viewManager, ICountrySelector countrySelector)
        {
            CreateRelayCommands(viewManager);

            _countrySelector = countrySelector;

            Countries = new ObservableCollection<Country>();
            _countrySelector.GetAllCountries(Countries);

#if !WINDOWS_PHONE
            if (Countries.Count > 0)
                SelectedCountry = Countries[0];
#endif

            CreateGroups();
        }

        private void CreateGroups()
        {
            var allCountries = (from c in Countries select c);
            var characters = new List<string> { "#", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

            var groups = new List<LongListGroup<Country>>();
            characters.ForEach(x => groups.Add(new LongListGroup<Country>(x, new List<Country>())));

            var longListGrouped = (from c in allCountries
                                   group c by c.FirstLetter.ToString() into grp
                                   orderby grp.Key
                                   select new LongListGroup<Country>(grp.Key, grp));

            CountriesGrupped = (from t in longListGrouped.Union(groups)
                                      orderby t.Title
                                      select t).ToList();
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