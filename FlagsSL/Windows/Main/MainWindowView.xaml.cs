using System;
using System.Windows.Controls;
using System.Windows.Navigation;
using GalaSoft.MvvmLight.Messaging;

namespace Flags
{
    public partial class MainWindowView : Page
    {
        private MainWindowViewModel _vm;

        public MainWindowView()
        {
            InitializeComponent();

            _vm = (MainWindowViewModel)DataContext;

            //Messenger.Default.Register<Uri>(this, "NavigationRequest", uri => NavigationService.Navigate(uri));
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
    }
}

