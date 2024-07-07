// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------


using FluentAssertions;
using OnDotnetLive.Models.Components.ComponentStates;
using OnDotnetLive.Views.Components.TalkComponents;

namespace OnDotnetLive.Tests.Unit.Views.TalksListComponents
{
    public partial class TalkComponentTests
    {
        [Fact]
        public void ShouldInitializeComponent()
        {
            // given
            ComponentState expectedComponentState =
               ComponentState.Loading;

            // when
            var initializedTalkComponent = new TalkComponent();

            // then
            initializedTalkComponent.State.Should().Be(expectedComponentState);
            initializedTalkComponent.TalkView.Should().BeNull();
            initializedTalkComponent.ThumbnailImageBase.Should().BeNull();
            initializedTalkComponent.TitleLabelBase.Should().BeNull();
            initializedTalkComponent.NameLabelBase.Should().BeNull();
            initializedTalkComponent.NameLabelBase.Should().BeNull();
            initializedTalkComponent.WatchButtonBase.Should().BeNull();
        }

        [Fact]
        public void ShouldRenderComponent()
        {
            // given
            ComponentState expectedComponentState =
               ComponentState.Content;

            var randomTalkView = CreateRandomTalkView();
            var inputTalkView = randomTalkView;

            // when
            this.renderedTalkComponent = RenderComponent<TalkComponent>(parameters =>
                parameters.Add(p => p.TalkView, inputTalkView));

            // then
            this.renderedTalkComponent.Instance.State.Should().Be(expectedComponentState);
            this.renderedTalkComponent.Instance.TalkView.Should().NotBeNull();
            this.renderedTalkComponent.Instance.ThumbnailImageBase.Should().NotBeNull();
            this.renderedTalkComponent.Instance.TitleLabelBase.Should().NotBeNull();
            this.renderedTalkComponent.Instance.NameLabelBase.Should().NotBeNull();
            this.renderedTalkComponent.Instance.NameLabelBase.Should().NotBeNull();
            this.renderedTalkComponent.Instance.WatchButtonBase.Should().NotBeNull();

            this.navigationServiceMock.VerifyNoOtherCalls();
        }

    }
}
