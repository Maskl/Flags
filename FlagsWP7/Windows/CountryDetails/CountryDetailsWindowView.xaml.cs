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

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            _viewModel.SelectCountry(e.Uri.ToString());
        }
    }
}