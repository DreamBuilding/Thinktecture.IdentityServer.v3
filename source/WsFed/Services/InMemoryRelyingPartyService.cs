﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Thinktecture.IdentityServer.WsFed.Models;

namespace Thinktecture.IdentityServer.WsFed.Services
{
    public class InMemoryRelyingPartyService : IRelyingPartyService
    {
        IEnumerable<RelyingParty> _rps;

        public InMemoryRelyingPartyService(IEnumerable<RelyingParty> rps)
        {
            _rps = rps;
        }

        public Task<RelyingParty> GetByRealmAsync(string realm)
        {
            return Task.FromResult(_rps.FirstOrDefault(rp => rp.Realm == realm && rp.Enabled));
        }
    }
}