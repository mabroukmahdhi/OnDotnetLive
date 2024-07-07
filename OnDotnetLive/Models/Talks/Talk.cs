// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

using System;

namespace OnDotnetLive.Models.Talks
{
    public class Talk
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Speaker { get; set; }
        public string ShowUrl { get; set; }
        public DateTimeOffset Date { get; set; }
    }
}
