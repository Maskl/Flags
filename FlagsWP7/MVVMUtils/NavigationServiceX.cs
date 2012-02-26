using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Shell;

namespace Flags
{
    public class NavigationServiceX : INavigationService
    {
        private Frame _mainFrame;

        public event NavigatingCancelEventHandler Navigating;

        public void NavigateTo(Uri pageUri)
        {
        //////    NavigationService.Navigate(new Uri("/ReultsWindowViewWP7.xaml", UriKind.Relative));
            //if (EnsureMainFrame())
            //{
            //    _mainFrame.Navigate(pageUri);
            //}
        }

        public void GoBack()
        {
            //if (EnsureMainFrame()
            //    && _mainFrame.CanGoBack)
            //{
            //    _mainFrame.GoBack();
            //}
        }

        public string GetTestText()
        {
            return "Jestem WP siodemka";
        }

        private bool EnsureMainFrame()
        {
            //if (_mainFrame != null)
            //{
            //    return true;
            //}

            //var mainPage = (Application.Current.RootVisual as MainWindowViewWP7);

            //if (mainPage != null)
            //{
            //    _mainFrame = mainPage.NavigationFrame;

            //    if (_mainFrame != null)
            //    {
            //        // Could be null if the app runs inside a design tool
            //        _mainFrame.Navigating += (s, e) =>
            //        {
            //            if (Navigating != null)
            //            {
            //                Navigating(s, e);
            //            }
            //        };

            //        return true;
            //    }
            //}

            return false;
        }
    }
}
