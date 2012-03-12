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
    }
}