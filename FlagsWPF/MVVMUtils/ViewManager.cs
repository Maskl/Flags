using System;
using System.Collections.Generic;
using System.Windows;

namespace Flags
{
    public class ViewManager : IViewManager
    {
        public void Show(View view)
        {
            Window newWindow;
            
            switch (view)
            {
                case View.Main:
                    newWindow = new MainWindowViewWPF();
                    break;
                    
                case View.Results:
                    newWindow = new ResultsWindowViewWPF();
                    break;

                default:
                    return;
            }

            newWindow.ShowDialog();
        }
    }
}
