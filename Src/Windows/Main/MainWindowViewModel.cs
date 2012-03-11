﻿using System;
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
            set { _addNumber ^= value /*XOR!*/; RecalculateResultUri(); RaisePropertyChanged("AddNumber"); }
        }

        private int _colorNumber;
        public int ColorNumber
        {
            get { return _colorNumber; }
            set { _colorNumber ^= value /*XOR!*/; RecalculateResultUri(); RaisePropertyChanged("ColorNumber"); }
        }

        private int _shapeNumber;
        public int ShapeNumber
        {
            get { return _shapeNumber; }
            set { _shapeNumber ^= value /*XOR!*/; RecalculateResultUri(); RaisePropertyChanged("ShapeNumber"); }
        }

        private string _resultUri;
        public string ResultUri
        {
            get { return _resultUri; }
            set { _resultUri = value; RaisePropertyChanged("ResultUri"); }
        }

        #endregion

        #region Relay Commands
        private ViewManager _viewManager;
        public RelayCommand ShowResultsWindowCommand { get; private set; }
        public RelayCommand ShowCountriesListWindowCommand { get; private set; }
        public RelayCommand ShowHelpWindowCommand { get; private set; }

        public RelayCommand<string> ModifyColorNumberCommand { get; private set; }
        public RelayCommand<string> ModifyShapeNumberCommand { get; private set; }
        public RelayCommand<string> ModifyAddNumberCommand { get; private set; }

        private void CreateRelayCommands(ViewManager viewManager)
        {
            _viewManager = viewManager;
            ShowResultsWindowCommand = new RelayCommand(ShowResults);
            ShowCountriesListWindowCommand = new RelayCommand(() => _viewManager.Show(View.CountriesList));
            ShowHelpWindowCommand = new RelayCommand(() => _viewManager.Show(View.Help));

            ModifyColorNumberCommand = new RelayCommand<string>(ModifyColorNumber);
            ModifyShapeNumberCommand = new RelayCommand<string>(ModifyShapeNumber);
            ModifyAddNumberCommand = new RelayCommand<string>(ModifyAddNumber);
        }

        private void ModifyColorNumber(string num)
        {
            ColorNumber = 1 << Convert.ToInt32(num);
        }

        private void ModifyShapeNumber(string num)
        {
            ShapeNumber = ShapeNumber | (1 << Convert.ToInt32(num));
        }

        private void ModifyAddNumber(string num)
        {
            AddNumber = 1 << Convert.ToInt32(num);
        }
        #endregion

        #region Initialization
        public MainWindowViewModel(ViewManager viewManager)
        {
            CreateRelayCommands(viewManager);

            ColorNumber = 2;
            ShapeNumber = AddNumber = 0;
        }
        #endregion

        #region Navigation
        public void ShowResults()
        {
            _viewManager.Show(View.Results, ResultUri);
        }

        private void RecalculateResultUri()
        {
            ResultUri = String.Format("color={0}&shape={1}&add={2}", ColorNumber, ShapeNumber, AddNumber);
        }
        #endregion
    }
}