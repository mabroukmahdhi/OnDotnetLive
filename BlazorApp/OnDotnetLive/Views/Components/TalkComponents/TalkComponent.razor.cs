// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

using Microsoft.AspNetCore.Components;
using OnDotnetLive.Models.Components.ComponentStates;
using OnDotnetLive.Models.Views.TalkViews;
using OnDotnetLive.Services.Foundations.Navigations;
using OnDotnetLive.Views.Bases;

namespace OnDotnetLive.Views.Components.TalkComponents
{
    public partial class TalkComponent : ComponentBase
    {
        [Inject]
        public INavigationService NavigationService { get; set; }

        [Parameter]
        public TalkView TalkView { get; set; }

        public ComponentState State { get; set; }
        public ImageBase ThumbnailImageBase { get; set; }
        public LabelBase TitleLabelBase { get; set; }
        public LabelBase NameLabelBase { get; set; }
        public ButtonBase WatchButtonBase { get; set; }

        protected override void OnInitialized() =>
            this.State = ComponentState.Content;

        private void WatchNowClicked() =>
            this.NavigationService.OpenNewTab(this.TalkView.YouTubeUrl);
    }
}