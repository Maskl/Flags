using System;
using System.Windows.Navigation;

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
            _viewModel.ParseMessageFromMainWindow(e.Uri.ToString());
        }

        private void ButtonClick(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}