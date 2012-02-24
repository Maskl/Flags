using Flags.MVVMUtils;

namespace Flags
{
    public partial class ResultsWindowViewWPF
    {
        public ResultsWindowViewWPF()
        {
            InitializeComponent();
            Closing += (s, e) => ViewModelLocator.Cleanup();
        }
    }
}