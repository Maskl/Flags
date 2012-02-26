using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Navigation;
using GalaSoft.MvvmLight.Messaging;

namespace Flags
{
    public class ViewManager : IViewManager
    {
        private readonly Dictionary<View, Uri> _viewToUri;  

        public ViewManager()
        {
            _viewToUri = new Dictionary<View, Uri>
                             {
                                 {View.Main, new Uri("/Windows/Main/MainWindowViewWP7.xaml", UriKind.Relative)},
                                 {View.Results, new Uri("/Windows/Results/ResultsWindowViewWP7.xaml", UriKind.Relative)}
                             };
        }

        public void Show(View view)
        {
            Messenger.Default.Send(_viewToUri[view], "NavigationRequest");
        }
    }
}
