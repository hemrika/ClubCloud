using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClubCloud.Zimbra.Global
{
    public enum changeType
    {

        [XmlEnum(Name = "new")]
        New,

        [XmlEnum(Name = "mod")]
        Mod,

   }
}
