using System;

namespace Flags
{
    public class ViewManager
    {
        public void NavigateTo(Uri pageUri)
        {
            var newView = new ResultsWindowViewWPF();
            newView.ShowDialog();
        }
    }
}
