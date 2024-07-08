// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Moq;
using OnDotnetLive.Models.Foundations.Talks;
using OnDotnetLive.Models.Foundations.Talks.Exceptions;

namespace OnDotnetLive.Tests.Unit.Services.Foundations.Talks
{
    public partial class TalkServiceTests
    {
        [Fact]
        public async Task ShouldThrowServiceExceptionOnRetrieveAllIfServiceErrorOccursAndLogItAsync()
        {
            // given
            var serviceException = new Exception();

            var failedTalkServiceExcption =
                new FailedTalkServiceException(serviceException);

            var expectedTalkServiceException =
                new TalkServiceException(failedTalkServiceExcption);

            this.apiBrokerMock.Setup(broker =>
                broker.GetAllTalksAsync())
                    .ThrowsAsync(serviceException);

            // when
            ValueTask<List<Talk>> retrieveAllTalksTask =
                this.talkService.RetrieveAllTalksAsync();

            // then
            await Assert.ThrowsAsync<TalkServiceException>(() =>
                retrieveAllTalksTask.AsTask());

            this.apiBrokerMock.Verify(broker =>
                broker.GetAllTalksAsync(),
                    Times.Once);

            this.loggingBrokerMock.Verify(broker =>
                broker.LogError(It.Is(SameExceptionAs(
                    expectedTalkServiceException))),
                        Times.Once);

            this.apiBrokerMock.VerifyNoOtherCalls();
            this.loggingBrokerMock.VerifyNoOtherCalls();
        }
    }
}
