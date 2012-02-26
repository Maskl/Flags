using System;

namespace GadgetVote.Client.Navigation
{
    public class NavigationService : INavigationService
    {
        private readonly System.Windows.Navigation.NavigationService _navigationService;

        public NavigationService(System.Windows.Navigation.NavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public void Navigate(string url)
        {
            _navigationService.Navigate(new Uri(url, UriKind.RelativeOrAbsolute));
        }

        public void Back()
        {
            if(_navigationService.CanGoBack)
                _navigationService.GoBack();
        }
    }

}
