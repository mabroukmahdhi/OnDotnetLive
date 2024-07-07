// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.FluentUI.AspNetCore.Components;
using OnDotnetLive.Models.IconNames;

namespace OnDotnetLive.Views.Bases
{
    public partial class NavLinkBase : ComponentBase
    {
        [Parameter]
        public string Href { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public IconName Icon { get; set; }

        [Parameter]
        public string Text { get; set; }

        [Parameter]
        public bool MatchAll { get; set; }

        private Icon GetFluentUIIcon() => Icon switch
        {
            IconName.Home => new Icons.Regular.Size20.Home(),
            IconName.Talks => new Icons.Regular.Size20.Tv(),
            _ => new Icons.Regular.Size20.Home()
        };

        private NavLinkMatch GetNavLinkMatch() =>
            MatchAll ? NavLinkMatch.All : NavLinkMatch.Prefix;
    }
}
