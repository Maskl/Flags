using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace Flags
{
    public class MenuWindowViewModel : ViewModelBase
    {        
        #region Relay Commands
        private ViewManager _viewManager;
        public RelayCommand ShowMainWindowCommand { get; private set; }
        public RelayCommand ShowCountriesListWindowCommand { get; private set; }
        public RelayCommand ShowHelpWindowCommand { get; private set; }
        public RelayCommand ShowHistoryWindowCommand { get; private set; }

        private void CreateRelayCommands(ViewManager viewManager)
        {
            _viewManager = viewManager;
            ShowMainWindowCommand = new RelayCommand(() => _viewManager.Show(View.Main));
            ShowCountriesListWindowCommand = new RelayCommand(() => _viewManager.Show(View.CountriesList));
            ShowHelpWindowCommand = new RelayCommand(() => _viewManager.Show(View.Help));
            ShowHistoryWindowCommand = new RelayCommand(() => _viewManager.Show(View.History));
        }
        #endregion
        
        #region Initialization
        public MenuWindowViewModel(ViewManager viewManager)
        {
            CreateRelayCommands(viewManager);
        }
        #endregion

    }
}