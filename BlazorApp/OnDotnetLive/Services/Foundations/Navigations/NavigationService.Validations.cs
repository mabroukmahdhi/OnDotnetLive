// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

using OnDotnetLive.Models.Navigations.Exceptions;

namespace OnDotnetLive.Services.Foundations.Navigations
{
    public partial class NavigationService
    {
        private void ValidateUri(string uri)
        {
            if (string.IsNullOrWhiteSpace(uri))
            {
                throw new InvalidNavigationUrlException();
            }
        }
    }
}
