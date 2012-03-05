using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace Flags
{
    public class MainWindowViewModel : ViewModelBase
    {
        #region Properties
        private int _addNumber;
        public int AddNumber
        {
            get { return _addNumber; }
            set { _addNumber = ApplyMask(_addNumber, value); RecalculateResultUri(); RaisePropertyChanged("AddNumber"); }
        }

        private int _colorNumber;
        public int ColorNumber
        {
            get { return _colorNumber; }
            set { _colorNumber = value; RecalculateResultUri(); RaisePropertyChanged("ColorNumber"); }
        }

        private int _shapeNumber;
        public int ShapeNumber
        {
            get { return _shapeNumber; }
            set { _shapeNumber = value; RecalculateResultUri(); RaisePropertyChanged("ShapeNumber"); }
        }

        private string _resultUri;
        public string ResultUri
        {
            get { return _resultUri; }
            set { _resultUri = value; RaisePropertyChanged("ResultUri"); }
        }

        private int ApplyMask(int old, int mask)
        {
            return ((old & mask) == 0) ? old + mask : old - mask;
        }
        #endregion

        #region Relay Commands
        private ViewManager _viewManager;
        public RelayCommand ShowResultsWindowCommand { get; private set; }
        public RelayCommand ShowCountriesListWindowCommand { get; private set; }
        public RelayCommand ShowHelpWindowCommand { get; private set; }

        private void CreateRelayCommands(ViewManager viewManager)
        {
            _viewManager = viewManager;
            ShowResultsWindowCommand = new RelayCommand(ShowResults);
            ShowCountriesListWindowCommand = new RelayCommand(() => _viewManager.Show(View.CountriesList));
            ShowHelpWindowCommand = new RelayCommand(() => _viewManager.Show(View.Help));
        }
        #endregion

        #region Initialization
        public MainWindowViewModel(ViewManager viewManager)
        {
            CreateRelayCommands(viewManager);

            // REM:
            ColorNumber = 123;
            ShapeNumber = 345;
            AddNumber = 8;
        }
        #endregion

        #region Navigation
        public void ShowResults()
        {
            _viewManager.Show(View.Results, ResultUri);
        }

        private void RecalculateResultUri()
        {
            var color = ColorNumber;
            var shape = ShapeNumber;
            var add = AddNumber;
            ResultUri = String.Format("color={0}&shape={1}&add={2}", color, shape, add);
        }
        #endregion
    }
}