﻿using System.Windows;

namespace Flags
{
    public class ViewManager
    {
        public void Show(View view)
        {
            Window newWindow;
            
            switch (view)
            {
                case View.Main:
                    newWindow = new MainWindowView();
                    break;
                    
                case View.Results:
                    newWindow = new ResultsWindowView();
                    break;

                default:
                    return;
            }

            newWindow.ShowDialog();
        }
    }
}