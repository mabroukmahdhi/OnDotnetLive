// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace OnDotnetLive.Brokers.Navigations
{
    public class NavigationBroker(NavigationManager navigationManager, IJSRuntime jsRuntime) : INavigationBroker
    {
        private readonly NavigationManager navigationManager = navigationManager;
        private readonly IJSRuntime jsRuntime = jsRuntime;

        public void NavigateTo(string uri) =>
            this.navigationManager.NavigateTo(uri);

        public async void OpenNewTab(string uri) =>
            await this.jsRuntime.InvokeVoidAsync("openInNewTab", uri);
    }
}
