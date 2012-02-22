using GalaSoft.MvvmLight;

namespace Flags
{
    public class MainWindowViewModel : ViewModelBase
    {
        static public int x;
        public MainWindowViewModel()
        {
            int a;
            a = 23;
            x = a;
        }
    }
}