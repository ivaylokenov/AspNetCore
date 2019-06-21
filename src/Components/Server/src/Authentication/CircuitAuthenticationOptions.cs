// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Authentication;

namespace Microsoft.AspNetCore.Components.Server
{
    // Required by the default authentication handler implementation. Otherwise, unused.
    internal class CircuitAuthenticationOptions : AuthenticationSchemeOptions
    {
    }
}