using System.Collections.ObjectModel;
using FlagsW8.Data;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using FlagsW8.Model;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Items Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234233

namespace FlagsW8
{
    /// <summary>
    /// A page that displays a collection of item previews.  In the Split Application this page
    /// is used to display and select one of the available groups.
    /// </summary>
    public sealed partial class ItemsPage : FlagsW8.Common.LayoutAwarePage
    {
        public ItemsPage()
        {
            Country.BoxSize = 510;
            Country.MaxImageSizeX = 50;
            Country.MaxImageSizeY = 30;
            this.InitializeComponent();
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="navigationParameter">The parameter value passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested.
        /// </param>
        /// <param name="pageState">A dictionary of state preserved by this page during an earlier
        /// session.  This will be null the first time a page is visited.</param>
        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
            var i = 0;
            ResultCountries = new ObservableCollection<Country>();
            foreach (var country in CountryManager.Countries)
            {
                if (++i > 8)
                    break;

                ResultCountries.Add(country);
            }

            DefaultViewModel["ShapeOptions"] = FlagParamsManager.Shapes;
            DefaultViewModel["AddOptions"] = FlagParamsManager.Adds;
            DefaultViewModel["ColorOptions"] = FlagParamsManager.Colors;
            DefaultViewModel["ResultCountries"] = ResultCountries;
        }

        public ObservableCollection<Country> ResultCountries;

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
            CountryFlagImage.Source = country.Image;

            DarkenerBackground.Visibility = Visibility.Visible;
            CountryDetailsPopup.Visibility = Visibility.Visible;
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

        private void Wp7VersionDownloadClicked(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AboutButtonClicked(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
