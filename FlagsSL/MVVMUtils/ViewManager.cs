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
                                 {View.Results, new Uri("/Windows/Results/ResultsWindowView.xaml", UriKind.Relative)}
                             };
        }

        public void Show(View view)
        {
            Messenger.Default.Send(_viewToUri[view], "NavigationRequest");
        }
    }
}
