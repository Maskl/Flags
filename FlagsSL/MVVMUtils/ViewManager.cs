using System;
using System.Collections.Generic;
using GalaSoft.MvvmLight.Messaging;

namespace Flags
{
    public class ViewManager
    {
        private readonly Dictionary<View, Uri> _viewToUri;  

        public ViewManager()
        {
            _viewToUri = new Dictionary<View, Uri>
                             {
                                 {View.Main, new Uri("/Windows/Main/MainWindowView.xaml", UriKind.Relative)},
                                 {View.Results, new Uri("/Windows/Results/ResultsWindowView.xaml", UriKind.Relative)},
                                 {View.CountriesList, new Uri("/Windows/CountriesList/CountriesListWindowView.xaml", UriKind.Relative)},
                                 {View.CountryDetails, new Uri("/Windows/CountryDetails/CountryDetailsWindowView.xaml", UriKind.Relative)},
                                 {View.Help, new Uri("/Windows/Help/HelpWindowView.xaml", UriKind.Relative)}
                             };
        }

        public void Show(View view)
        {
            Messenger.Default.Send(_viewToUri[view], "NavigationRequest");
        }
    }
}
