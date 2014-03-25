using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Administration
{
    internal interface zimbraAdminSoapChannel : zimbraAdminSoap, System.ServiceModel.IClientChannel
    {
    }

}
