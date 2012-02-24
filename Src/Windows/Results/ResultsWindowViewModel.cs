using GalaSoft.MvvmLight;

namespace Flags
{
    public class ResultsWindowViewModel : ViewModelBase
    {
        public string TestString { get; set; }
        public ResultsWindowViewModel()
        {
            TestString = "A tu mamy wyniki";
        }
    }
}