using GalaSoft.MvvmLight.Threading;

namespace FlagsWPF
{
    public partial class App
    {
        static App()
        {
            DispatcherHelper.Initialize();
        }
    }
}
