using System;

namespace Flags
{
    public partial class CountriesListWindowView
    {
        private readonly CountriesListWindowViewModel _viewModel;
        public CountriesListWindowView()
        {
            InitializeComponent();
            _viewModel = DataContext as CountriesListWindowViewModel;
        }

        private void HelpAppBarButtonClick(object sender, EventArgs e)
        {
            _viewModel.ShowHelpWindowCommand.Execute(null);
        }

        private void BackIconButtonClick(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void GestureListenerFlick(object sender, Microsoft.Phone.Controls.FlickGestureEventArgs e)
        {
            if (e.Direction == System.Windows.Controls.Orientation.Horizontal && Math.Abs(e.HorizontalVelocity) > 300 && NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }
    }
}