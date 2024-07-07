// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------


using System;
using System.Collections.Generic;
using OnDotnetLive.Models.Guests;

namespace OnDotnetLive.Models.Talks
{
    public class Talk
    {
        public string Id { get; set; }
        public string Show { get; set; }
        public string ShowId { get; set; }
        public string VideoId { get; set; }
        public string Title { get; set; }
        public string Topic { get; set; }
        public bool HasDisplayTitle { get; set; }
        public string DisplayTitle { get; set; }
        public string CommunityLinksUrl { get; set; }
        public string ShowNotesUrl { get; set; }
        public string Description { get; set; }
        public DateTime? ScheduledStartTime { get; set; }
        public DateTime? ActualStartTime { get; set; }
        public DateTime? ActualEndTime { get; set; }
        public int LengthInHours { get; set; }
        public bool HasLinks { get; set; }
        public bool HasShowNotes { get; set; }
        public int Priority { get; set; }
        public string Url { get; set; }
        public string AltUrl { get; set; }
        public string ThumbnailUrl { get; set; }
        public string Category { get; set; }
        public List<Guest> Guests { get; set; }
        public List<string> Tags { get; set; }
        public bool BlinkLive { get; set; }
        public bool ShowInWebsiteFeed { get; set; }
        public string ScheduledStartTimeHumanized { get; set; }
        public bool IsUpcoming { get; set; }
        public bool IsOnAir { get; set; }
    }
}
