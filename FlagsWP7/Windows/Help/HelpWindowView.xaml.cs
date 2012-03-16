using System;

namespace Flags
{
    public partial class HelpWindowView
    {
        public HelpWindowView()
        {
            InitializeComponent();
        }

        private void BackIconButtonClick(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void GestureListenerFlick(object sender, Microsoft.Phone.Controls.FlickGestureEventArgs e)
        {
            if (e.Direction == System.Windows.Controls.Orientation.Horizontal && Math.Abs(e.HorizontalVelocity) > 300)
            {
                NavigationService.GoBack();
            }
        }
    }
}