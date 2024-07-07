// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

using System;
using Microsoft.Extensions.Logging;

namespace OnDotnetLive.Brokers.Loggings
{
    public class LoggingBroker(ILogger<LoggingBroker> logger) : ILoggingBroker
    {
        private readonly ILogger<LoggingBroker> logger = logger;

        public void LogInformation(string message) =>
            this.logger.LogInformation(message);

        public void LogTrace(string message) =>
            this.logger.LogTrace(message);

        public void LogDebug(string message) =>
            this.logger.LogDebug(message);

        public void LogWarning(string message) =>
            this.logger.LogWarning(message);

        public void LogError(Exception exception) =>
            this.logger.LogError(exception.Message, exception);

        public void LogCritical(Exception exception) =>
            this.logger.LogCritical(exception, exception.Message);
    }
}
