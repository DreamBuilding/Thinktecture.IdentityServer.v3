﻿/*
 * Copyright (c) Dominick Baier, Brock Allen.  All rights reserved.
 * see license
 */
using System.IdentityModel.Services;
using System.Security.Claims;
using Thinktecture.IdentityServer.Core.Authentication;
using Thinktecture.IdentityServer.WsFed.Models;

namespace Thinktecture.IdentityServer.WsFed.Validation
{
    public class SignInValidationResult
    {
        public bool IsError { get; set; }
        public string Error { get; set; }
        public string ErrorMessage { get; set; }

        public bool IsSignInRequired { get; set; }
        public SignInMessage SignInMessage { get; set; }

        public RelyingParty RelyingParty { get; set; }
        public SignInRequestMessage SignInRequestMessage { get; set; }
        
        public string ReplyUrl { get; set; }
        public ClaimsPrincipal Subject { get; set; }
    }
}