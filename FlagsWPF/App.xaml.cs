using GalaSoft.MvvmLight.Threading;

namespace Flags
{
    public partial class App
    {
        static App()
        {
            DispatcherHelper.Initialize();
        }
    }
}
