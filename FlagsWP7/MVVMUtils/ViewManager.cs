using System;
using System.Collections.Generic;
using GalaSoft.MvvmLight.Messaging;

namespace Flags
{
    public class ViewManager
    {
        private readonly Dictionary<View, string> _viewToUri;  

        public ViewManager()
        {
            _viewToUri = new Dictionary<View, string>
                            {
                                {View.Main, "/Windows/Main/MainWindowView.xaml"},
                                {View.Results, "/Windows/Results/ResultsWindowView.xaml?{0}"},
                                {View.CountriesList, "/Windows/CountriesList/CountriesListWindowView.xaml"},
                                {View.CountryDetails, "/Windows/CountryDetails/CountryDetailsWindowView.xaml?{0}"},
                                {View.Help, "/Windows/Help/HelpWindowView.xaml"}
                            };
        }

        public void Show(View view, object param = null)
        {
            Messenger.Default.Send(
                param == null
                    ? new Uri(_viewToUri[view], UriKind.Relative)
                    : new Uri(String.Format(_viewToUri[view], param), UriKind.Relative), "NavigationRequest");
        }
    }
}
