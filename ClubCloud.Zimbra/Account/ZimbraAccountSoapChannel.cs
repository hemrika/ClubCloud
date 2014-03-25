using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Account
{
    internal interface ZimbraAccountSoapChannel : zimbraAccountSoap, System.ServiceModel.IClientChannel
    {
    }

}
