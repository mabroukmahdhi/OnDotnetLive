// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.FluentUI.AspNetCore.Components;
using Moq;
using OnDotnetLive.Models.Views.TalkViews;
using OnDotnetLive.Services.Foundations.Navigations;
using OnDotnetLive.Views.Components.TalkComponents;
using Tynamix.ObjectFiller;

namespace OnDotnetLive.Tests.Unit.Views.TalksListComponents
{
    public partial class TalkComponentTests : TestContext
    {
        private readonly Mock<INavigationService> navigationServiceMock;
        private IRenderedComponent<TalkComponent> renderedTalkComponent;

        public TalkComponentTests()
        {
            this.navigationServiceMock = new Mock<INavigationService>();

            this.Services.AddFluentUIComponents();
            this.Services.AddScoped(services => navigationServiceMock.Object);
            this.JSInterop.Mode = JSRuntimeMode.Loose;
        }

        private static TalkView CreateRandomTalkView() =>
            CreateTalkViewFiller().Create();

        private static string GetRandomString() => new MnemonicString().GetValue();

        private static Filler<TalkView> CreateTalkViewFiller()
        {
            var filler = new Filler<TalkView>();

            return filler;
        }
    }
}
