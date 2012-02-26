using GalaSoft.MvvmLight;

namespace Flags
{
    public class HelpWindowViewModel : ViewModelBase
    {
        public string TestString { get; set; }
        public HelpWindowViewModel()
        {
            TestString = "A tu mamy HelpWindowViewModel";
        }
    }
}