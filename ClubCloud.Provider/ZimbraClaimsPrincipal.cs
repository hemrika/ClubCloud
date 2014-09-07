using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Provider
{
    public class ZimbraClaimsPrincipal : ClaimsPrincipal
    {
        public ZimbraClaimsPrincipal() : base()
        { }

        public ZimbraClaimsPrincipal(IIdentity identity)
            : base(identity)
        { }

        public ZimbraClaimsPrincipal(IPrincipal principal)
            : base(principal)
        { }

        public ZimbraClaimsPrincipal(IEnumerable<ClaimsIdentity> identities)
            : base(identities)
        { }

        public ZimbraClaimsPrincipal(SerializationInfo info, StreamingContext context) : base(info,context)
        { }
    }
}
