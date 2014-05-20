﻿/*
 * Copyright (c) Dominick Baier, Brock Allen.  All rights reserved.
 * see license
 */

using Owin;
using System;
using System.Collections.Generic;

namespace Thinktecture.IdentityServer.Core.Configuration
{
    public class IdentityServerCoreOptions
    {
        public IdentityServerServiceFactory Factory { get; set; }
        public AuthenticationOptions AuthenticationOptions { get; set; }
        public Action<IAppBuilder, string> SocialIdentityProviderConfiguration { get; set; }
        public Action<IAppBuilder, PluginDependencies> PluginConfiguration { get; set; }
    }
}