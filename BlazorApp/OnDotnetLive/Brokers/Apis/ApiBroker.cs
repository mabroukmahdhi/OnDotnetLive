// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using OnDotnetLive.Models.Talks;

namespace OnDotnetLive.Brokers.Apis
{
    public partial class ApiBroker(IJSRuntime jsRuntime) : IApiBroker
    {
        // The ApiBroker is supposed to make HTTP requests to API endpoints using the HttpClient.
        // We will use the JSRuntime to make No-cors requests..
        private readonly IJSRuntime jsRuntime = jsRuntime;

        // The GetAllTalksAsync method is supposed to make an HTTP GET request to the API endpoint that returns all talks.
        // For demonstration purposes, this method is implemented with static values.
        public async ValueTask<List<Talk>> GetAllTalksAsync()
        {
            var url = "https://dotnet.microsoft.com/api/videos/on-dotnet-live";

            var talks = await jsRuntime.InvokeAsync<object>("fetchWithNoCors", url);

            return new List<Talk>();
        }
    }
}