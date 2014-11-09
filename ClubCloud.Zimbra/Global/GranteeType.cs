using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClubCloud.Zimbra.Global
{
    [System.SerializableAttribute()]
    public enum GranteeType
    {

        [XmlEnum(Name = "usr")]
        usr,

        [XmlEnum(Name = "grp")]
        grp,

        [XmlEnum(Name = "egp")]
        egp,

        [XmlEnum(Name = "all")]
        all,

        [XmlEnum(Name = "dom")]
        dom,

        [XmlEnum(Name = "edom")]
        edom,

        [XmlEnum(Name = "gst")]
        gst,

        [XmlEnum(Name = "key")]
        key,

        [XmlEnum(Name = "pub")]
        pub,

        [XmlEnum(Name = "email")]
        email,
    }
}
