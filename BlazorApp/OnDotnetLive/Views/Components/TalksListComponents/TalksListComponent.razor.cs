// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using OnDotnetLive.Models.Talks;
using OnDotnetLive.Services.Foundations.Talks;

namespace OnDotnetLive.Views.Components.TalksListComponents
{
    public partial class TalksListComponent : ComponentBase
    {
        private List<Talk> talks;

        [Inject]
        public ITalkService TalkService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            talks = await TalkService.RetrieveAllTalksAsync();
        }
    }
}