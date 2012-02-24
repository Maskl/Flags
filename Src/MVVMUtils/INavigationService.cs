using System;
using System.Windows.Navigation;

namespace Flags
{
    public interface INavigationService
    {
        event NavigatingCancelEventHandler Navigating;
        void NavigateTo(Uri uri);
        void GoBack();

        string GetTestText();
    }
}