using System;
using System.Windows.Navigation;
using GalaSoft.MvvmLight.Messaging;

namespace Flags
{
    public partial class CountryDetailsWindowView
    {
        private readonly CountryDetailsWindowViewModel _viewModel;
        public CountryDetailsWindowView()
        {
            InitializeComponent();
            _viewModel = DataContext as CountryDetailsWindowViewModel;
        }

        private void HelpAppBarButtonClick(object sender, EventArgs e)
        {
            _viewModel.ShowHelpWindowCommand.Execute(null);
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var url = e.Uri.ToString();
            var parameters = url.Substring(url.IndexOf("?", StringComparison.Ordinal) + 1);
            _viewModel.SelectCountry(parameters);
        }
    }
}