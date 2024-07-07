// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

using Microsoft.AspNetCore.Components;
using OnDotnetLive.Models.Views.TalkViews;
using OnDotnetLive.Services.Foundations.Navigations;

namespace OnDotnetLive.Views.Components.TalkComponents
{
    public partial class TalkComponent : ComponentBase
    {
        [Inject]
        public INavigationService NavigationService { get; set; }

        [Parameter]
        public TalkView TalkView { get; set; }

        private void WatchNowClicked() =>
            this.NavigationService.OpenNewTab(this.TalkView.YouTubeUrl);
    }
}