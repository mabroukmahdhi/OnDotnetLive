// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

using Microsoft.AspNetCore.Components;

namespace OnDotnetLive.Views.Bases
{
    public partial class GridItemBase : ComponentBase
    {

        [Parameter]
        public int XS { get; set; } = 6;

        [Parameter]
        public int SM { get; set; } = 3;

        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}
