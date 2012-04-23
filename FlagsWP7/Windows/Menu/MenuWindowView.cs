using System;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.Phone.Tasks;

namespace Flags
{
    public partial class MenuWindowView
    {
        public MenuWindowView()
        {
            InitializeComponent();
            Messenger.Default.Register<Uri>(this, "NavigationRequest", uri => NavigationService.Navigate(uri));

        }

    }
}