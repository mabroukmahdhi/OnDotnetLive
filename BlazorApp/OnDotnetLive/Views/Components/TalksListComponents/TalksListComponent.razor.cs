// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using OnDotnetLive.Models.Views.TalkViews;
using OnDotnetLive.Services.Views.TalkViews;

namespace OnDotnetLive.Views.Components.TalksListComponents
{
    public partial class TalksListComponent : ComponentBase
    {
        private List<TalkView> talkViews;

        [Inject]
        protected ITalkViewService TalkViewService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            talkViews = await TalkViewService.RetrieveAllTalkViewsAsync();
        }
    }
}