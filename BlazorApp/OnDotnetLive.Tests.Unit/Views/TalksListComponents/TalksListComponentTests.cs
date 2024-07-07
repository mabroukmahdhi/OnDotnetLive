// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.FluentUI.AspNetCore.Components;
using Moq;
using OnDotnetLive.Services.Views.TalkViews;
using OnDotnetLive.Views.Components.TalksListComponents;

namespace OnDotnetLive.Tests.Unit.Views.TalksListComponents
{
    public partial class TalksListComponentTests : TestContext
    {
        private readonly Mock<ITalkViewService> talkViewServiceMock;
        private IRenderedComponent<TalksListComponent> renderedTalksListComponent;

        public TalksListComponentTests()
        {
            this.talkViewServiceMock = new Mock<ITalkViewService>();

            this.Services.AddFluentUIComponents();
            this.Services.AddScoped(services => talkViewServiceMock.Object);
            this.JSInterop.Mode = JSRuntimeMode.Loose;
        }
    }
}
