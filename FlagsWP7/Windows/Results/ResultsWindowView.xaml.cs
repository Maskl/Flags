using System;
using System.Windows;
using System.Windows.Navigation;
using GalaSoft.MvvmLight.Ioc;

namespace Flags
{
    public partial class ResultsWindowView
    {
        private readonly ResultsWindowViewModel _viewModel;
        public ResultsWindowView()
        {
            InitializeComponent();
            _viewModel = DataContext as ResultsWindowViewModel;
        }

        private void HelpAppBarButtonClick(object sender, EventArgs e)
        {
            _viewModel.ShowHelpWindowCommand.Execute(null);
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var url = e.Uri.ToString();
            var parameters = url.Substring(url.IndexOf("?", StringComparison.Ordinal) + 1);
            _viewModel.ParseSearchParameters(parameters);
        }
    }
}