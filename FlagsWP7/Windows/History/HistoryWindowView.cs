using System;
using Microsoft.Phone.Tasks;

namespace Flags
{
    public partial class HistoryWindowView
    {
        public HistoryWindowView()
        {
            InitializeComponent();
        }

        private void BackIconButtonClick(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void RateButtonClick(object sender, System.Windows.RoutedEventArgs e)
        {
            var task = new MarketplaceReviewTask();
            task.Show();
        }
    }
}