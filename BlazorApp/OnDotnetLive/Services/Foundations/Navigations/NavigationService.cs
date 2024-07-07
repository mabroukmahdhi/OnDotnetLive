// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

using OnDotnetLive.Brokers.Loggings;
using OnDotnetLive.Brokers.Navigations;

namespace OnDotnetLive.Services.Foundations.Navigations
{
    public partial class NavigationService(INavigationBroker navigationBroker, ILoggingBroker loggingBroker) : INavigationService
    {
        private readonly INavigationBroker navigationBroker = navigationBroker;
        private readonly ILoggingBroker loggingBroker = loggingBroker;

        public void NavigateTo(string uri) =>
        TryCatch(() =>
        {
            ValidateUri(uri);

            this.navigationBroker.NavigateTo(uri);
        });


        public void OpenNewTab(string uri) =>
        TryCatch(() =>
        {
            ValidateUri(uri);

            this.navigationBroker.OpenNewTab(uri);
        });
    }
}
