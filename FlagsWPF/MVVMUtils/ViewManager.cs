using System.Windows;
using GalaSoft.MvvmLight.Messaging;

namespace Flags
{
    public class ViewManager
    {
        public void Show(View view, object param = null)
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

                case View.CountriesList:
                    newWindow = new CountriesListWindowView();
                    break;

                case View.CountryDetails:
                    newWindow = new CountryDetailsWindowView();
                    Messenger.Default.Send(new CountryToShowDetailsMessage((string)param));
                    break;

                case View.Help:
                    newWindow = new HelpWindowView();
                    break;

                default:
                    return;
            }

            newWindow.ShowDialog();
        }
    }
}
