using System;
using System.Windows.Navigation;
using GalaSoft.MvvmLight.Messaging;

namespace Flags
{
    public partial class MainWindowViewWP7
    {
        public MainWindowViewWP7()
        {
            InitializeComponent();

            Messenger.Default.Register<Uri>(this, "NavigationRequest", uri => NavigationService.Navigate(uri));
        }

    }
}