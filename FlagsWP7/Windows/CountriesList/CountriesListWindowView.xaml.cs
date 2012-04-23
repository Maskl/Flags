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

        private void BackIconButtonClick(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}