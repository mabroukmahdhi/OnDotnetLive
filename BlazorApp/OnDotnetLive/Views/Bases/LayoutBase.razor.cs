// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

using Microsoft.AspNetCore.Components;

namespace OnDotnetLive.Views.Bases
{
    public partial class LayoutBase : ComponentBase
    {
        [Parameter]
        public RenderFragment Header { get; set; }

        [Parameter]
        public RenderFragment Main { get; set; }

        [Parameter]
        public RenderFragment NavigationMenu { get; set; }

        [Parameter]
        public RenderFragment Footer { get; set; }
    }
}
