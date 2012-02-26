using System;

namespace GadgetVote.Client.Navigation
{
    public interface INavigable
    {
        INavigationService NavigationService { get; set; }
    }
}
