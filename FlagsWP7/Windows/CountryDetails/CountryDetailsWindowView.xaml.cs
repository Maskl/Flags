﻿using System;
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
            _viewModel.SelectCountry(e.Uri.ToString());
        }

        private void BackIconButtonClick(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void GestureListenerFlick(object sender, Microsoft.Phone.Controls.FlickGestureEventArgs e)
        {
            if (e.Direction == System.Windows.Controls.Orientation.Horizontal && e.HorizontalVelocity > 300)
            {
                NavigationService.GoBack();
            }
        }
    }
}