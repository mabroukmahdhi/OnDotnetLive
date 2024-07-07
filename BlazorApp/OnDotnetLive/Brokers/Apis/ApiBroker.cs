// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using OnDotnetLive.Models.Configurations;
using OnDotnetLive.Models.Talks;

namespace OnDotnetLive.Brokers.Apis
{
    public partial class ApiBroker : IApiBroker
    {
        private readonly HttpClient httpClient;
        public ApiBroker(HttpClient httpClient, IConfiguration configuration)
        {
            this.httpClient = httpClient;

            var apiConfiguration =
                configuration.Get<LocalConfiguration>().ApiConfiguration;

            this.httpClient.BaseAddress =
                new System.Uri(apiConfiguration.Url);
        }

        public async ValueTask<List<Talk>> GetAllTalksAsync() =>
            await this.httpClient.GetFromJsonAsync<List<Talk>>("api/talks");
    }
}