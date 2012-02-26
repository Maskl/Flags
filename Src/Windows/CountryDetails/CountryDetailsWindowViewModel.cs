using GalaSoft.MvvmLight;

namespace Flags
{
    public class CountryDetailsWindowViewModel : ViewModelBase
    {
        public string TestString { get; set; }
        public CountryDetailsWindowViewModel()
        {
            TestString = "A tu mamy CountryDetailsWindowViewModel";
        }
    }
}