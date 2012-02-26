﻿using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace Flags
{
    public class ResultsWindowViewModel : ViewModelBase
    {
        private readonly ViewManager _viewManager;
        public RelayCommand ShowCountryDetailsWindowCommand { get; private set; }
        public RelayCommand ShowHelpWindowCommand { get; private set; }

        public string CountryTag { get; set; }
        public ResultsWindowViewModel(ViewManager viewManager)
        {
            CountryTag = "USA";

            _viewManager = viewManager;
            ShowCountryDetailsWindowCommand = new RelayCommand(ShowCountryDetails);
            ShowHelpWindowCommand = new RelayCommand(() => _viewManager.Show(View.Help));
        }

        void ShowCountryDetails()
        {
            Messenger.Default.Send(new CountryToShowDetailsMessage(CountryTag));
            _viewManager.Show(View.CountryDetails);
        }
    }
}