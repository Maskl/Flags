using System;
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

    }
}