using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace Flags
{
    public class CountryDetailsWindowViewModel : ViewModelBase
    {
        private readonly ViewManager _viewManager;
        public RelayCommand ShowHelpWindowCommand { get; private set; }

        public string TestString { get; set; }
        public CountryDetailsWindowViewModel(ViewManager viewManager)
        {
            TestString = "A tu mamy CountryDetailsWindowViewModel";

            _viewManager = viewManager;
            ShowHelpWindowCommand = new RelayCommand(() => _viewManager.Show(View.Help));

            Messenger.Default.Register<CountryToShowDetailsMessage>(this, ChooseCountry);
        }

        private void ChooseCountry(CountryToShowDetailsMessage message)
        {
            Country = message.Country + "!";
        }


        private string _country;
        public string Country
        {
            get { return _country; }
            set
            {
                if (_country == value)
                    return;

                _country = value;

                RaisePropertyChanged("Country");
            }
        }

    }
}