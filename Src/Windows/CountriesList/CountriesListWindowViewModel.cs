using GalaSoft.MvvmLight;

namespace Flags
{
    public class CountriesListWindowViewModel : ViewModelBase
    {
        public string TestString { get; set; }
        public CountriesListWindowViewModel()
        {
            TestString = "A tu mamy CountriesListWindowViewModel";
        }
    }
}