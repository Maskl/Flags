﻿using System;
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
        #region Properties
        private readonly ICountrySelector _countrySelector;
        public ObservableCollection<Country> Countries { get; set; }
        #endregion

        #region Relay Commands
        private ViewManager _viewManager;
        public RelayCommand<string> ShowInfoAboutCountryCommand { get; private set; }

        private void CreateRelayCommands(ViewManager viewManager)
        {
            _viewManager = viewManager;
            ShowInfoAboutCountryCommand = new RelayCommand<string>(ShowInfoAboutCountry);
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
            }
        }

        public void ParseMessageFromMainWindow(SearchParamsMessage message)
        {
            ParseMessageFromMainWindow(message.SearchParams);
        }

        public void ParseMessageFromMainWindow(string url)
        {
            // If we have whole URL then we remove part before "?".
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
        }
        #endregion

        #region Navigation
        private void ShowInfoAboutCountry(string tag)
        {
            _viewManager.Show(View.CountryDetails, tag);
        }
        #endregion
    }
}