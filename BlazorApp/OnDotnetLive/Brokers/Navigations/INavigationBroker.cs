// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

namespace OnDotnetLive.Brokers.Navigations
{
    public interface INavigationBroker
    {
        void NavigateTo(string uri);

        void OpenNewTab(string uri);
    }
}
