using System;

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
    }
}