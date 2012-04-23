using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Navigation;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Tasks;
using GestureEventArgs = System.Windows.Input.GestureEventArgs;

namespace Flags
{
    public partial class MainWindowView
    {
        private readonly MainWindowViewModel _viewModel;
        public MainWindowView()
        {
            InitializeComponent();
            _viewModel = DataContext as MainWindowViewModel;
        }


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            _viewModel.OnNavigatedTo();
        }

        private void ApplicationBarIconButtonClick(object sender, EventArgs e)
        {
            _viewModel.ShowResults();
        }
    }
}