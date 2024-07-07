// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

using System.Collections.Generic;
using System.Threading.Tasks;
using OnDotnetLive.Brokers.Apis;
using OnDotnetLive.Brokers.Loggings;
using OnDotnetLive.Models.Foundations.Talks;

namespace OnDotnetLive.Services.Foundations.Talks
{
    public partial class TalkService(IApiBroker apiBroker, ILoggingBroker loggingBroker) : ITalkService
    {
        private readonly IApiBroker apiBroker = apiBroker;
        private readonly ILoggingBroker loggingBroker = loggingBroker;

        public ValueTask<List<Talk>> RetrieveAllTalksAsync() =>
            TryCatch(this.apiBroker.GetAllTalksAsync);
    }
}