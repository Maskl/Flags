namespace Flags
{
    public enum View
    {
        Main,
        Results,
        List,
        Details,
        Help
    }

    public interface IViewManager
    {
        void Show(View view);
    }
}