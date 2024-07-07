// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

using System.Collections.Generic;
using System.Threading.Tasks;
using OnDotnetLive.Models.Foundations.Talks;

namespace OnDotnetLive.Brokers.Apis
{
    public interface IApiBroker
    {
        ValueTask<List<Talk>> GetAllTalksAsync();
    }
}