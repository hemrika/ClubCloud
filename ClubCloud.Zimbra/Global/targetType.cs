using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClubCloud.Zimbra.Global
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:zimbra")]
    public enum targetType
    {

        [XmlEnum(Name = "account")]
        Account,

        [XmlEnum(Name = "calresource")]
        Calender,

        [XmlEnum(Name = "cos")]
        cos,

        [XmlEnum(Name = "dl")]
        dl,

        [XmlEnum(Name = "group")]
        Group,

        [XmlEnum(Name = "domain")]
        Domain,

        [XmlEnum(Name = "server")]
        Server,

        [XmlEnum(Name = "ucservice")]
        ucservice,

        [XmlEnum(Name = "xmppcomponent")]
        xmppcomponent,

        [XmlEnum(Name = "zimlet")]
        Zimlet,

        [XmlEnum(Name = "config")]
        Configuration,

        [XmlEnum(Name = "global")]
        Global,
    }
}
