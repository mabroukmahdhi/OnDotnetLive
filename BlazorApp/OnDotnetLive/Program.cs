// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.FluentUI.AspNetCore.Components;
using OnDotnetLive.Applications;
using OnDotnetLive.Brokers.Apis;
using OnDotnetLive.Brokers.DateTimes;
using OnDotnetLive.Brokers.Loggings;
using OnDotnetLive.Brokers.Navigations;
using OnDotnetLive.Services.Foundations.Navigations;
using OnDotnetLive.Services.Foundations.Talks;

namespace OnDotnetLive
{
    public class Program
    {
        private static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<MainApplication>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddHttpClient();

            builder.Services.AddFluentUIComponents();

            builder.Services.AddSingleton<IDateTimeBroker, DateTimeBroker>();
            builder.Services.AddSingleton<ILoggingBroker, LoggingBroker>();
            builder.Services.AddScoped<IApiBroker, ApiBroker>();
            builder.Services.AddScoped<INavigationBroker, NavigationBroker>();

            builder.Services.AddScoped<ITalkService, TalkService>();
            builder.Services.AddScoped<INavigationService, NavigationService>();

            await builder.Build().RunAsync();
        }
    }
}