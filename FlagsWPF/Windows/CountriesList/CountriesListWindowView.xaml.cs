using Flags.MVVMUtils;

namespace Flags
{
    public partial class CountriesListWindowView
    {
        public CountriesListWindowView()
        {
            InitializeComponent();
            Closing += (s, e) => ViewModelLocator.Cleanup();
        }
    }
}