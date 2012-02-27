using Flags.MVVMUtils;

namespace Flags
{
    public partial class MainWindowView
    {
        public MainWindowView()
        {
            InitializeComponent();
            Closing += (s, e) => ViewModelLocator.Cleanup();
        }

        private void CloseMenuItemClick(object sender, System.Windows.RoutedEventArgs e)
        {
            Close();
        }
    }
}