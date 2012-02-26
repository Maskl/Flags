using Flags.MVVMUtils;

namespace Flags
{
    public partial class CountryDetailsWindowView
    {
        public CountryDetailsWindowView()
        {
            InitializeComponent();
            Closing += (s, e) => ViewModelLocator.Cleanup();
        }
    }
}