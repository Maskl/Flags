using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace Flags
{
    public class MainWindowViewModel : ViewModelBase
    {
        private readonly ViewManager _viewManager;
        public RelayCommand ShowResultsWindowCommand { get; private set; }
        public RelayCommand ShowCountriesListWindowCommand { get; private set; }
        public RelayCommand ShowHelpWindowCommand { get; private set; }

        public MainWindowViewModel(ViewManager viewManager)
        {
            TestString = "Testowy string";

            _viewManager = viewManager;
            ShowResultsWindowCommand = new RelayCommand(() => _viewManager.Show(View.Results));
            ShowCountriesListWindowCommand = new RelayCommand(() => _viewManager.Show(View.CountriesList));
            ShowHelpWindowCommand = new RelayCommand(() => _viewManager.Show(View.Help));
        }


        private string _testString;
        public string TestString
        {
            get { return _testString; }
            set
            {
                if (_testString == value)
                    return;

                _testString = value;

                RaisePropertyChanged("CountryTag");
            }
        }
    }
}