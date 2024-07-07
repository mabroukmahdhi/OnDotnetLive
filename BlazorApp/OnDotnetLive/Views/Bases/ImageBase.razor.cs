// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

using Microsoft.AspNetCore.Components;

namespace OnDotnetLive.Views.Bases
{
    public partial class ImageBase : ComponentBase
    {
        [Parameter]
        public string Source { get; set; }

        [Parameter]
        public string Alt { get; set; }

        [Parameter]
        public string Width { get; set; }

        [Parameter]
        public string Height { get; set; }

        public string GetImageSource() =>
            this.Source;
    }
}
