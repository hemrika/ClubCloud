using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.KNLTB.DuplicaatPersonen
{
    [DebuggerStepThrough]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    [MessageContract(WrapperName = "DuplicaatpersonenFound", WrapperNamespace = "http://knltb.nl/services", IsWrapped = true)]
    public class DuplicaatpersonenFoundRequest
    {
        [MessageHeader(Namespace = "http://knltb.nl/services")]
        public OrganizationHeader OrganizationHeader;

        [MessageBodyMember(Namespace = "http://knltb.nl/services", Order = 0)]
        public string achternaam;

        [MessageBodyMember(Namespace = "http://knltb.nl/services", Order = 1)]
        public string voorletters;

        [MessageBodyMember(Namespace = "http://knltb.nl/services", Order = 2)]
        public string roepnaam;

        [MessageBodyMember(Namespace = "http://knltb.nl/services", Order = 3)]
        public string geboortedatum;

        [MessageBodyMember(Namespace = "http://knltb.nl/services", Order = 4)]
        public int geslacht;

        [MessageBodyMember(Namespace = "http://knltb.nl/services", Order = 5)]
        public string postcode;

        [MessageBodyMember(Namespace = "http://knltb.nl/services", Order = 6)]
        public string huisnummer;

        [MessageBodyMember(Namespace = "http://knltb.nl/services", Order = 7)]
        public string origin;

        [MessageBodyMember(Namespace = "http://knltb.nl/services", Order = 8)]
        public string type;

        public DuplicaatpersonenFoundRequest()
        {
        }

        public DuplicaatpersonenFoundRequest(OrganizationHeader OrganizationHeader, string achternaam, string voorletters, string roepnaam, string geboortedatum, int geslacht, string postcode, string huisnummer, string origin, string type)
        {
            this.OrganizationHeader = OrganizationHeader;
            this.achternaam = achternaam;
            this.voorletters = voorletters;
            this.roepnaam = roepnaam;
            this.geboortedatum = geboortedatum;
            this.geslacht = geslacht;
            this.postcode = postcode;
            this.huisnummer = huisnummer;
            this.origin = origin;
            this.type = type;
        }
    }
}
