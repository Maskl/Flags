﻿using System;
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

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            _viewModel.ParseMessageFromMainWindow(e.Uri.ToString());
        }

        private void BackIconButtonClick(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void GestureListenerFlick(object sender, Microsoft.Phone.Controls.FlickGestureEventArgs e)
        {
            //if (e.Direction == System.Windows.Controls.Orientation.Horizontal && Math.Abs(e.HorizontalVelocity) > 500 && NavigationService.CanGoBack)
            {
            //    NavigationService.GoBack();
            }
        }
    }
}