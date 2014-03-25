using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClubCloud.Zimbra.Global
{
    public enum infoSection
    {
        [XmlEnum(Name = "All")]
        All,
        [XmlEnum(Name = "mbox")]
        MailBox,
        [XmlEnum(Name = "prefs")]
        Preferences,
        [XmlEnum(Name = "attrs")]
        Attributes,
        [XmlEnum(Name = "zimlets")]
        Zimlets,
        [XmlEnum(Name = "props")]
        Properties,
        [XmlEnum(Name = "idents")]
        Identities,
        [XmlEnum(Name = "sigs")]
        Signatures,
        [XmlEnum(Name = "dsrcs")]
        DataSources,
        [XmlEnum(Name = "children")]
        Children,
    }
}
