// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

using System.Collections.Generic;
using System.Threading.Tasks;
using FluentAssertions;
using Force.DeepCloner;
using Moq;
using OnDotnetLive.Models.Foundations.Talks;

namespace OnDotnetLive.Tests.Unit.Services.Foundations.Talks
{
    public partial class TalkServiceTests
    {
        [Fact]
        public async Task ShouldRetrieveAllTalksAsync()
        {
            // given
            List<Talk> randomTalks = CreateRandomTalks();
            List<Talk> retrievedTalks = randomTalks;
            List<Talk> expetedTalks = retrievedTalks.DeepClone();

            this.apiBrokerMock.Setup(broker =>
                broker.GetAllTalksAsync())
                    .ReturnsAsync(retrievedTalks);

            // when
            List<Talk> actualTalks =
                await this.talkService.RetrieveAllTalksAsync();

            // then
            actualTalks.Should().BeEquivalentTo(expetedTalks);

            this.apiBrokerMock.Verify(broker =>
                broker.GetAllTalksAsync(),
                    Times.Once);

            this.apiBrokerMock.VerifyNoOtherCalls();
            this.loggingBrokerMock.VerifyNoOtherCalls();
        }
    }
}
