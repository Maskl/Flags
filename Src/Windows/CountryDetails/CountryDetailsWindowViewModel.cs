using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

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
        }
    }
}