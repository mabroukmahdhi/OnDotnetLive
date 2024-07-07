// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

using Microsoft.AspNetCore.Components;

namespace OnDotnetLive.Views.Bases
{
    public partial class GridBase : ComponentBase
    {
        [Parameter]
        public int Spacing { get; set; } = 3;

        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}
