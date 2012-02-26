using System;
using System.Windows.Controls;
using System.Windows.Navigation;
using GalaSoft.MvvmLight.Messaging;

namespace Flags
{
    public class ViewManager
    {
        public void NavigateTo(Uri pageUri)
        {
            Messenger.Default.Send(pageUri, "NavigationRequest");
        }
    }
}
