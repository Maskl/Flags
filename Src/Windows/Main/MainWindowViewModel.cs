using GalaSoft.MvvmLight;

namespace Flags
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string TestString { get; set; }
        public MainWindowViewModel()
        {
            TestString = "Testowy string z VM";
        }
    }
}