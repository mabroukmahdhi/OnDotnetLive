// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

using Microsoft.AspNetCore.Components;

namespace OnDotnetLive.Views.Bases
{
    public partial class ConditionBase:ComponentBase
    {
        [Parameter]
        public bool Condition { get; set; }

        [Parameter]
        public RenderFragment Match { get; set; }

        [Parameter]
        public RenderFragment NotMatch { get; set; }
    }
}
