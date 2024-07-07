// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

using Microsoft.AspNetCore.Components;

namespace OnDotnetLive.Views.Bases
{
    public partial class NavMenuBase : ComponentBase
    {
        private bool expanded = true;

        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}
