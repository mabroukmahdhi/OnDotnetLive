// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Moq;
using OnDotnetLive.Brokers.Apis;
using OnDotnetLive.Brokers.Loggings;
using OnDotnetLive.Models.Foundations.Talks;
using OnDotnetLive.Services.Foundations.Talks;
using Tynamix.ObjectFiller;

namespace OnDotnetLive.Tests.Unit.Services.Foundations.Talks
{
    public partial class TalkServiceTests
    {
        private readonly Mock<IApiBroker> apiBrokerMock;
        private readonly Mock<ILoggingBroker> loggingBrokerMock;
        private readonly ITalkService talkService;

        public TalkServiceTests()
        {
            this.apiBrokerMock = new Mock<IApiBroker>();
            this.loggingBrokerMock = new Mock<ILoggingBroker>();

            this.talkService = new TalkService(
                apiBroker: this.apiBrokerMock.Object,
                loggingBroker: this.loggingBrokerMock.Object);
        }

        private static List<Talk> CreateRandomTalks() =>
            new Filler<Talk>().Create(count: GetRandomNumber()).ToList();

        private static int GetRandomNumber() => new IntRange(min: 2, max: 10).GetValue();

        private static Expression<Func<Exception, bool>> SameExceptionAs(
            Exception expectedException)
        {
            return actualException => actualException.Message == expectedException.Message
                && actualException.InnerException.Message == expectedException.InnerException.Message;
        }
    }
}
