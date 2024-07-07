// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

using System.Collections.Generic;

namespace OnDotnetLive.Models.Views.TalkViews
{
    public class TalkView
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string GuestName { get; set; }
        public string GuestSocial { get; set; }
        public string GuestThumbnailUrl { get; set; }
        public string YouTubeUrl { get; set; }
        public List<string> Tags { get; set; }
    }
}
