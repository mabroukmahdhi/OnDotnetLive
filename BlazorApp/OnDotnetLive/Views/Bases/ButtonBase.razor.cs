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
        public string Text { get; set; }

        [Parameter]
        public Action OnClick { get; set; }

        [Parameter]
        public bool IsDisabled { get; set; }

        public void Click() => OnClick.Invoke();

        public void Disable()
        {
            this.IsDisabled = true;
            InvokeAsync(StateHasChanged);
        }

        public void Enable()
        {
            this.IsDisabled = false;
            InvokeAsync(StateHasChanged);
        }
    }
}
