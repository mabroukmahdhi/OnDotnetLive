// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

using System;

namespace OnDotnetLive.Models.Talks.Exceptions
{
    public class FailedTalkServiceException(Exception innerException)
        : Exception(message: "Failed Talk service error occurred, contact support.", innerException)
    { }
}
