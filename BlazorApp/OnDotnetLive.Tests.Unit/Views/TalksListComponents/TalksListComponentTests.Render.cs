// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------


using FluentAssertions;
using OnDotnetLive.Models.Components.ComponentStates;
using OnDotnetLive.Views.Components.TalksListComponents;

namespace OnDotnetLive.Tests.Unit.Views.TalksListComponents
{
    public partial class TalksListComponentTests
    {
        [Fact]
        public void ShouldInitializeComponent()
        {
            // given
            ComponentState expectedComponentState =
                ComponentState.Loading;

            // when
            var initialTalksListComponent = new TalksListComponent();

            // then
            initialTalksListComponent.State.Should().Be(expectedComponentState);
            initialTalksListComponent.TalkViews.Should().BeNull();
        }
    }
}
