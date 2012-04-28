using System;
using FlagsWP7.Localization;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace Flags
{
    public class CountryDetailsWindowViewModel : ViewModelBase
    {
        #region Properties
        private readonly ICountrySelector _countrySelector;

        private Country _selectedCountry;
        public Country SelectedCountry
        {
            get { return _selectedCountry; }
            set { _selectedCountry = value; CreateDescription(); RaisePropertyChanged("SelectedCountry"); }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; RaisePropertyChanged("Description"); }
        }
        #endregion

        #region Relay Commands
        private ViewManager _viewManager;
        public RelayCommand ShowHelpWindowCommand { get; private set; }

        private void CreateRelayCommands(ViewManager viewManager)
        {
            _viewManager = viewManager;
            ShowHelpWindowCommand = new RelayCommand(() => _viewManager.Show(View.Help));
        }
        #endregion

        #region Initialization
        public CountryDetailsWindowViewModel(ViewManager viewManager, ICountrySelector countrySelector)
        {
            CreateRelayCommands(viewManager);

            _countrySelector = countrySelector;

            Messenger.Default.Register<CountryToShowDetailsMessage>(this, SelectCountry);

            // For Expression Blend only
            if (IsInDesignModeStatic)
            {
                SelectedCountry = new Country {Tag = "no", Name = "Norway", Continent = "Europe", Capital = "Oslo"};
            }
        }

        private void SelectCountry(CountryToShowDetailsMessage message)
        {
            SelectCountry(message.Country);
        }

        public void SelectCountry(string tag)
        {
            SelectedCountry = _countrySelector.GetCountryByTag(tag);
        }

        private void CreateDescription()
        {
            if (SelectedCountry == null)
                return;

            Description = TranslationsResource.CountryDetailsContinent + SelectedCountry.Continent +
                "\n" + TranslationsResource.CountryDetailsCapital + SelectedCountry.Capital +
                "\n" + TranslationsResource.CountryDetailsISO + SelectedCountry.Tag.ToUpper();
        }
        #endregion
    }
}