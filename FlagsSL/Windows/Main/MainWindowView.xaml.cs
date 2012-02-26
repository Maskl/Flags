using System;
using System.Windows;
using System.Windows.Input;
using FlagsSL;
using GadgetVote.Client.Navigation;
using GalaSoft.MvvmLight.Messaging;
using NavigationSample;

namespace Flags
{
    public partial class MainWindowView : INavigable
    {
        public INavigationService NavigationService { get; set; }

        public MainWindowView()
        {
            InitializeComponent();

            Messenger.Default.Register<Uri>(this, "NavigationRequest", ExecuteGotoPage2Command);//uri => NavigationService.Navigate(uri.ToString()));
        }

        private void ExecuteGotoPage2Command(Uri notUsed)
        {
            MessageBox.Show(notUsed.ToString());
            NavigationService.Navigate(notUsed.ToString());
        }
    }
}
