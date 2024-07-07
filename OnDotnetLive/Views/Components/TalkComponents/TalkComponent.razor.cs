// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

using Microsoft.AspNetCore.Components;
using OnDotnetLive.Models.Talks;

namespace OnDotnetLive.Views.Components.TalkComponents
{
    public partial class TalkComponent : ComponentBase
    {
        [Parameter]
        public Talk Talk { get; set; }
    }
}