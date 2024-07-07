// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using OnDotnetLive.Models.Components.ComponentStates;
using OnDotnetLive.Models.Views.TalkViews;
using OnDotnetLive.Services.Views.TalkViews;

namespace OnDotnetLive.Views.Components.TalksListComponents
{
    public partial class TalksListComponent : ComponentBase
    {
        [Inject]
        protected ITalkViewService TalkViewService { get; set; }

        public ComponentState State { get; set; }
        public List<TalkView> TalkViews;


        protected override async Task OnInitializedAsync()
        {
            this.TalkViews = await TalkViewService.RetrieveAllTalkViewsAsync();
            this.State = ComponentState.Content;
        }
    }
}