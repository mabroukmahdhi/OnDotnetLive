// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

using System;
using Microsoft.AspNetCore.Components;

namespace OnDotnetLive.Views.Bases
{
    public partial class ButtonBase : ComponentBase
    {
        [Parameter]
        public Action OnClick { get; set; }

        [Parameter]
        public string Text { get; set; }

        private void HandleClick() =>
             OnClick?.Invoke();
    }
}
