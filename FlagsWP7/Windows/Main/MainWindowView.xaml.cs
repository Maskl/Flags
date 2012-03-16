using System;
using System.Windows.Navigation;
using GalaSoft.MvvmLight.Messaging;

namespace Flags
{
    public partial class MainWindowView
    {
        private readonly MainWindowViewModel _viewModel;
        public MainWindowView()
        {
            InitializeComponent();

            _viewModel = DataContext as MainWindowViewModel;

            Messenger.Default.Register<Uri>(this, "NavigationRequest", uri => NavigationService.Navigate(uri));
        }

        private void CountriesListAppBarButtonClick(object sender, EventArgs e)
        {
            _viewModel.ShowCountriesListWindowCommand.Execute(null);
        }

        private void HelpAppBarButtonClick(object sender, EventArgs e)
        {
            _viewModel.ShowHelpWindowCommand.Execute(null);
        }

        private void GestureListenerFlick(object sender, Microsoft.Phone.Controls.FlickGestureEventArgs e)
        {
            //if (e.Direction == System.Windows.Controls.Orientation.Horizontal && Math.Abs(e.HorizontalVelocity) > 300)
            //{
            //    _viewModel.ShowResults();
            //}
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            _viewModel.ShowPleaseWaitInfo = false;
        }
    }
}