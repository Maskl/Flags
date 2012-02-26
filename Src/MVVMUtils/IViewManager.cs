namespace Flags
{
    public enum ViewEnum
    {
        Main,
        Results,
        List,
        Details,
        Help
    }

    public interface IViewManager
    {
        void Show(ViewEnum view);
    }
}