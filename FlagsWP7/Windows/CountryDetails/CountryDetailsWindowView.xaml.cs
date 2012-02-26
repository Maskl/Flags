using System;
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
    }
}