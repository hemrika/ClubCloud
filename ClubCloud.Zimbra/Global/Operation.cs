using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Global
{
    public enum Operation
    {

        /// <remarks/>
        delete,

        /// <remarks/>
        modify,

        /// <remarks/>
        rename,

        /// <remarks/>
        addOwners,

        /// <remarks/>
        removeOwners,

        /// <remarks/>
        setOwners,

        /// <remarks/>
        grantRights,

        /// <remarks/>
        revokeRights,

        /// <remarks/>
        setRights,

        /// <remarks/>
        addMembers,

        /// <remarks/>
        removeMembers,

        /// <remarks/>
        acceptSubsReq,

        /// <remarks/>
        rejectSubsReq,
    }
}
