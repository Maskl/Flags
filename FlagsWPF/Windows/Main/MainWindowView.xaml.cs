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
    }
}