using System.Windows.Controls;
using System.Windows.Navigation;

namespace Flags
{
    public partial class MainWindowView : Page
    {
        private MainWindowViewModel _vm;

        public MainWindowView()
        {
            InitializeComponent();

            _vm = (MainWindowViewModel)DataContext;
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
    }
}

