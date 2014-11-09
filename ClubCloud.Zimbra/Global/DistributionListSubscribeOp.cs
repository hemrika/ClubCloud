using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClubCloud.Zimbra.Global
{
    public enum DistributionListSubscribeOp
    {

        /// <remarks/>
        [XmlEnum(Name = "subscribe")]
        subscribe,

        /// <remarks/>
        [XmlEnum(Name = "unsubscribe")]
        unsubscribe,
    }

}
