using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using FlagsW8.Model;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace FlagsW8
{
    public sealed partial class ItemsPage
    {
        public ObservableCollection<Country> ResultCountries;

        public ItemsPage()
        {
            Window.Current.SizeChanged += WindowSizeChanged;     
            Country.BoxSize = 510;
            Country.MaxImageSizeX = 50;
            Country.MaxImageSizeY = 30;
            this.InitializeComponent();
        }

        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
            ResultCountries = new ObservableCollection<Country>();
            DefaultViewModel["ShapeOptions"] = FlagParamsManager.Shapes;
            DefaultViewModel["AddOptions"] = FlagParamsManager.Adds;
            DefaultViewModel["ColorOptions"] = FlagParamsManager.Colors;
            DefaultViewModel["ResultCountries"] = ResultCountries;
        }

        private void FlagParameterSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var color = ColorGridView.SelectedItems.Aggregate(0, (current, col) => current | 1 << (((FlagColor)col).Id - 1));
            var shape = ShapeGridView.SelectedItems.Aggregate(0, (current, sha) => current | 1 << (((FlagShape)sha).Id - 1));
            var addit = AddGridView.SelectedItems.Aggregate(0, (current, add) => current | 1 << (((FlagAdd)add).Id - 1));
            CountryManager.GetCountriesByParams(ResultCountries, color, shape, addit);
        }

        private void ResultCountryClicked(object sender, ItemClickEventArgs e)
        {
            var country = (Country)e.ClickedItem;
            CountryNameLabel.Text = country.Name;
            CountryDetailsText.Text = country.ShortDescription;
            CountryFlagImage.Source = country.BigImage;

            var viewState = ApplicationView.Value;
            if (viewState != ApplicationViewState.Snapped)
            {
                DarkenerBackground.Visibility = Visibility.Visible;
                CountryDetailsPopup.Visibility = Visibility.Visible;
            }

            CountryNameLabelSnapped.Text = country.Name;
            CountryDetailsTextSnapped.Text = country.ShortDescription;
            CountryFlagImageSnapped.Source = country.BigImage;
            CountryDetailsGridSnapped.Visibility = Visibility.Visible;
            MainScrollViewerSnapped.ScrollToVerticalOffset(99999);
        }

        private void CloseCountryDetailsClicked(object sender, RoutedEventArgs e)
        {
            DarkenerBackground.Visibility = Visibility.Collapsed;
            CountryDetailsPopup.Visibility = Visibility.Collapsed;
        }

        private void ClearButtonClicked(object sender, RoutedEventArgs e)
        {
            ShapeGridView.SelectedItem = FlagParamsManager.Shapes[0];
            AddGridView.SelectedItem = null;
            ColorGridView.SelectedItem = null;
        }

        private void WindowSizeChanged(object sender, Windows.UI.Core.WindowSizeChangedEventArgs e)
        {
            // Awful solution. There is no public setter for GridView.SelectedItems, I can't easily bind or copy
            // selected items from MainGrid to SnappedGrid so I just move controls on visual state change...
            MoveControlToSnappedGridOrMainGrid(ShapeViewbox, 1, 5, 1, 3);
            MoveControlToSnappedGridOrMainGrid(AddViewbox, 5, 5, 1, 7);
            MoveControlToSnappedGridOrMainGrid(ColorViewbox, 9, 5, 1, 11);
            MoveControlToSnappedGridOrMainGrid(ResultViewbox, 13, 5, 1, 15);
        }

        private void MoveControlToSnappedGridOrMainGrid(FrameworkElement control, int mainColumn, int mainRow, int snappedColumn, int snappedRow)
        {
            var viewState = ApplicationView.Value;
            if (viewState == ApplicationViewState.Snapped && control.Parent == MainGrid)
            {
                MainGrid.Children.Remove(control);
                MainGridSnapped.Children.Add(control);
                Grid.SetColumn(control, snappedColumn);
                Grid.SetRow(control, snappedRow);
            }

            if (viewState != ApplicationViewState.Snapped && control.Parent == MainGridSnapped)
            {
                MainGridSnapped.Children.Remove(control);
                MainGrid.Children.Add(control);
                Grid.SetColumn(control, mainColumn);
                Grid.SetRow(control, mainRow);
            }
        }
    }
}
