// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------


using FluentAssertions;
using Moq;
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
            initializedTalkComponent.DescriptionLabelBase.Should().BeNull();
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
            var expectedThumbnailUrl = inputTalkView.GuestThumbnailUrl;
            var expectedTitle = inputTalkView.Title;
            var expectedDescription = inputTalkView.Description;
            var expectedName = inputTalkView.GuestName;
            var expectedYouTubeUrl = inputTalkView.YouTubeUrl;
            var expectedWatchButtonText = "Watch now";

            // when
            this.renderedTalkComponent = RenderComponent<TalkComponent>(parameters =>
                parameters.Add(p => p.TalkView, inputTalkView));

            // then
            this.renderedTalkComponent.Instance.State.Should().Be(expectedComponentState);
            this.renderedTalkComponent.Instance.TalkView.Should().NotBeNull();
            this.renderedTalkComponent.Instance.ThumbnailImageBase.Should().NotBeNull();
            this.renderedTalkComponent.Instance.TitleLabelBase.Should().NotBeNull();
            this.renderedTalkComponent.Instance.DescriptionLabelBase.Should().NotBeNull();
            this.renderedTalkComponent.Instance.NameLabelBase.Should().NotBeNull();
            this.renderedTalkComponent.Instance.NameLabelBase.Should().NotBeNull();
            this.renderedTalkComponent.Instance.WatchButtonBase.Should().NotBeNull();

            this.renderedTalkComponent.Instance.ThumbnailImageBase.Source.Should().Be(expectedThumbnailUrl);
            this.renderedTalkComponent.Instance.TitleLabelBase.Text.Should().Be(expectedTitle);
            this.renderedTalkComponent.Instance.DescriptionLabelBase.Text.Should().Be(expectedDescription);
            this.renderedTalkComponent.Instance.DescriptionLabelBase.IsVisible.Should().BeFalse();
            this.renderedTalkComponent.Instance.NameLabelBase.Text.Should().Be(expectedName);
            this.renderedTalkComponent.Instance.WatchButtonBase.Text.Should().Be(expectedWatchButtonText);

            this.navigationServiceMock.VerifyNoOtherCalls();
        }

        [Fact]
        public void ShouldRedirectToYoutube()
        {
            // given
            var randomTalkView = CreateRandomTalkView();
            var inputTalkView = randomTalkView;
            var expectedYouTubeUrl = inputTalkView.YouTubeUrl;

            // when
            this.renderedTalkComponent = RenderComponent<TalkComponent>(parameters =>
                parameters.Add(p => p.TalkView, inputTalkView));

            this.renderedTalkComponent.Instance.WatchButtonBase.Click();

            // then
            this.navigationServiceMock.Verify(Services =>
                Services.OpenNewTab(expectedYouTubeUrl),
                    Times.Once);

            this.navigationServiceMock.VerifyNoOtherCalls();
        }
    }
}
