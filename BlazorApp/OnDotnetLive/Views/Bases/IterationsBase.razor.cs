// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace OnDotnetLive.Views.Bases
{
    public partial class IterationsBase<TItem> : ComponentBase
    {
        [Parameter]
        public RenderFragment<TItem> ChildContent { get; set; }

        [Parameter]
        public IEnumerable<TItem> Items { get; set; }
    }
}
