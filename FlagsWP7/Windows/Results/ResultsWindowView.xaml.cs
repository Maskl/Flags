using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using GestureEventArgs = System.Windows.Input.GestureEventArgs;

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

        // Flipping tiles (show country details).
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
    }
}