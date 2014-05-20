﻿/*
 * Copyright (c) Dominick Baier, Brock Allen.  All rights reserved.
 * see license
 */

using System.Threading.Tasks;
using Thinktecture.IdentityServer.WsFed.Models;

namespace Thinktecture.IdentityServer.WsFed.Services
{
    public interface IRelyingPartyService
    {
        Task<RelyingParty> GetByRealmAsync(string realm);
    }
}