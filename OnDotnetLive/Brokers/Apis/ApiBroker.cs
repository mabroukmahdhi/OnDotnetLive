// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;
using OnDotnetLive.Models.Talks;

namespace OnDotnetLive.Brokers.Apis
{
    public partial class ApiBroker(HttpClient httpClient) : IApiBroker
    {
        // The ApiBroker is supposed to make HTTP requests to API endpoints through the HttpClient.
        private readonly HttpClient httpClient = httpClient;

        // The GetAllTalksAsync method is supposed to make an HTTP GET request to the API endpoint that returns all talks.
        // For demonstration purposes, this method is implemented with static values.
        public async ValueTask<List<Talk>> GetAllTalksAsync()
        {
            var talks = new List<Talk>
            {
                new() {
                    Id = Guid.NewGuid(),
                    Title = "Building Enterprise Apps with Blazor",
                    Description = "Blazor is a great platform for building enterprise apps! In this week's episode, community MVP Mabrouk Mahdhi shows us some of the lessons he's learned building Blazor apps for enterprises.",
                    Speaker = "Mabrouk Mahdhi",
                    ShowUrl = "https://www.youtube.com/live/OxId5ErcMCY?si=ILR1puHTk5LmQqki",
                    Date = DateTimeOffset.Parse("2024-07-08T19:00:00Z",CultureInfo.GetCultureInfo("de")).ToUniversalTime()
                },
                new() {
                    Id = Guid.NewGuid(),
                    Title = "Working with custom controls in .NET MAUI",
                    Description = "Are you building .NET MAUI apps? In this week's episode, community MVP Pedro Jesus joins us to show how to take advantage of the new architecture to customize controls without needing to create any custom components.",
                    Speaker = "Pedro Jesus",
                    ShowUrl="https://www.youtube.com/live/tOCh0d4PpOw?si=5REyg3OA-rfr6wF2",
                    Date =  DateTimeOffset.Parse("2024-07-01T18:00:00Z",CultureInfo.GetCultureInfo("de")).ToUniversalTime()
                },
                new() {
                    Id = Guid.NewGuid(),
                    Title = "Building a game with .NET and Azure Open AI",
                    Description = "What's a good way to have more fun with A.I.? Let's try building a game! In this week's episode, community MVP Sebastián Leonardo Pérez builds a simple game using .NET and Azure Open AI with text-to-speech services, spontaneous image generation, and chat-generated text.",
                    Speaker = "Sebastián Leonardo Pérez",
                    ShowUrl="https://www.youtube.com/live/9suL6pUf6Wg?si=7FFr74204dtaXMxF",
                    Date =  DateTimeOffset.Parse("2024-06-24T18:00:00Z",CultureInfo.GetCultureInfo("de")).ToUniversalTime()
                }
            };

            return await new ValueTask<List<Talk>>(talks);
        }
    }
}