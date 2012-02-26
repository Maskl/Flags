using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace Flags
{
    public class ResultsWindowViewModel : ViewModelBase
    {
        private readonly ViewManager _viewManager;
        public RelayCommand ShowCountryDetailsWindowCommand { get; private set; }
        public RelayCommand ShowHelpWindowCommand { get; private set; }

        public ResultsWindowViewModel(ViewManager viewManager)
        {
            CountryTag = "USA";

            _viewManager = viewManager;
            ShowCountryDetailsWindowCommand = new RelayCommand(ShowCountryDetails);
            ShowHelpWindowCommand = new RelayCommand(() => _viewManager.Show(View.Help));
            Messenger.Default.Register<SearchParamsMessage>(this, ApplySearchParams);
        }

        private void ApplySearchParams(SearchParamsMessage message)
        {
            CountryTag = message.SearchParams.Substring(6, 3).ToUpper();
        }

        void ShowCountryDetails()
        {
            _viewManager.Show(View.CountryDetails, CountryTag);
        }


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