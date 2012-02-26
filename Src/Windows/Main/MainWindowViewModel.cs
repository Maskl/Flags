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
        
        public string ResultUri { get; set; }

        public MainWindowViewModel(ViewManager viewManager)
        {
            TestString = "Sh=1, Col=23, Add=5";
            ResultUri = "/Results/jakies_parametry_i_inne_znaczki";

            _viewManager = viewManager;
            ShowResultsWindowCommand = new RelayCommand(ShowResults);
            ShowCountriesListWindowCommand = new RelayCommand(() => _viewManager.Show(View.CountriesList));
            ShowHelpWindowCommand = new RelayCommand(() => _viewManager.Show(View.Help));
        }

        void ShowResults()
        {
            _viewManager.Show(View.Results, TestString);
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