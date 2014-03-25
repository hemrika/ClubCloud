using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClubCloud.Zimbra.Global
{
    public enum accountBy
    {
        [XmlEnum(Name = "name")]
        Name,

        [XmlEnum(Name = "id")]
        Id,

        [XmlEnum(Name = "adminName")]
        AdministratorName,

        [XmlEnum(Name = "appAdminName")]
        ApplicationAdministratorName,

        [XmlEnum(Name = "foreignPrincipal")]
        ForeignPrincipal,

        [XmlEnum(Name = "krb5Principal")]
        Kerebos5Principal,
    }
}
