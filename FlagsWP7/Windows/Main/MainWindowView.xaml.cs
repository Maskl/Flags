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

            Messenger.Default.Register<Uri>(this, "NavigationRequest", uri => NavigationService.Navigate(uri));
        }

        private void GestureListenerFlick(object sender, Microsoft.Phone.Controls.FlickGestureEventArgs e)
        {
            //if (e.Direction == System.Windows.Controls.Orientation.Horizontal && Math.Abs(e.HorizontalVelocity) > 500)
            //{
            //    _viewModel.ShowResults();
            //}
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            _viewModel.OnNavigatedTo();
        }

        private void BuyButtonClick(object sender, System.Windows.RoutedEventArgs e)
        {
            var task = new MarketplaceDetailTask();
            task.Show();
        }


        private readonly List<HubTile> _flippedTiles = new List<HubTile>();
        private void HubTile_OnTap(object sender, GestureEventArgs e)
        {
            var hub = (HubTile)sender;
            if (_flippedTiles.Contains(hub))
            {
                _flippedTiles.Remove(hub);
                VisualStateManager.GoToState(hub, "Expanded", true);
            }
            else
            {
                _flippedTiles.Add(hub);
                VisualStateManager.GoToState(hub, "Flipped", true);
            }
        }

        private void ApplicationBarIconButtonClick(object sender, EventArgs e)
        {
            _viewModel.ShowResults();
        }
    }
}