// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

using Microsoft.AspNetCore.Components;
using Microsoft.FluentUI.AspNetCore.Components;
using OnDotnetLive.Models.Components.LabelBaseTypographies;

namespace OnDotnetLive.Views.Bases
{
    public partial class LabelBase : ComponentBase
    {
        [Parameter]
        public string Text { get; set; }

        [Parameter]
        public LabelBaseTypography Typo { get; set; }

        private Typography GetTypography() => Typo switch
        {
            LabelBaseTypography.Body => Typography.Body,
            LabelBaseTypography.Subject => Typography.Subject,
            LabelBaseTypography.Header => Typography.Header,
            LabelBaseTypography.PaneHeader => Typography.PaneHeader,
            LabelBaseTypography.EmailHeader => Typography.EmailHeader,
            LabelBaseTypography.PageTitle => Typography.PageTitle,
            LabelBaseTypography.HeroTitle => Typography.HeroTitle,
            LabelBaseTypography.H1 => Typography.H1,
            LabelBaseTypography.H2 => Typography.H2,
            LabelBaseTypography.H3 => Typography.H3,
            LabelBaseTypography.H4 => Typography.H4,
            LabelBaseTypography.H5 => Typography.H5,
            LabelBaseTypography.H6 => Typography.H6,
            _ => Typography.Body
        };
    }
}
