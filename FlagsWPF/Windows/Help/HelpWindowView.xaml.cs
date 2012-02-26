using Flags.MVVMUtils;

namespace Flags
{
    public partial class HelpWindowView
    {
        public HelpWindowView()
        {
            InitializeComponent();
            Closing += (s, e) => ViewModelLocator.Cleanup();
        }
    }
}