using Flags.MVVMUtils;

namespace Flags
{
    public partial class ResultsWindowView
    {
        public ResultsWindowView()
        {
            InitializeComponent();
            Closing += (s, e) => ViewModelLocator.Cleanup();
        }
    }
}