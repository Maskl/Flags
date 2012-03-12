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

        private void ButtonClick(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}