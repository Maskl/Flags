using System;
using GalaSoft.MvvmLight.Messaging;

namespace Flags
{
    public partial class MainWindowView
    {
        public MainWindowView()
        {
            InitializeComponent();

       //     Messenger.Default.Register<Uri>(this, "NavigationRequest", uri => NavigationService.Navigate(uri));
        }

    }
}