//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClubCloud.Service.Model
{
    using System;
    using System.Runtime.Serialization;
    using System.Collections.Generic;
    
    [DataContract(IsReference = true)]
    
    public partial class ClubCloud_Gebruiker
    {
    	[DataMember]
        public System.Guid Id { get; set; }
    	[DataMember]
        public string Achternaam { get; set; }
    	[DataMember]
        public string DistrictNaam { get; set; }
    	[DataMember]
        public string Email { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> Geboortedatum { get; set; }
    	[DataMember]
        public string Geboorteplaats { get; set; }
    	[DataMember]
        public string Gemeente { get; set; }
    	[DataMember]
        public ClubCloud.KNLTB.ServIt.LedenAdministratieService.Geslacht Geslacht { get; set; }
    	[DataMember]
        public string Huisnummer { get; set; }
    	[DataMember]
        public bool IsLid { get; set; }
    	[DataMember]
        public string Mobiel { get; set; }
    	[DataMember]
        public Nullable<System.Guid> NationaliteitId { get; set; }
    	[DataMember]
        public string OrganisatieNummer { get; set; }
    	[DataMember]
        public string Plaats { get; set; }
    	[DataMember]
        public string Postcode { get; set; }
    	[DataMember]
        public Nullable<decimal> RatingDubbel { get; set; }
    	[DataMember]
        public Nullable<decimal> RatingEnkel { get; set; }
    	[DataMember]
        public string Roepnaam { get; set; }
    	[DataMember]
        public Nullable<int> SpeelsterkteDubbel { get; set; }
    	[DataMember]
        public Nullable<int> SpeelsterkteEnkel { get; set; }
    	[DataMember]
        public string Straat { get; set; }
    	[DataMember]
        public string TelefoonAvond { get; set; }
    	[DataMember]
        public string TelefoonOverdag { get; set; }
    	[DataMember]
        public string Toevoeging { get; set; }
    	[DataMember]
        public string Tussenvoegsel { get; set; }
    	[DataMember]
        public string VolledigeNaam { get; set; }
    	[DataMember]
        public string Voorletters { get; set; }
    	[DataMember]
        public string Voornamen { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> UserUpdate { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> ClubUpdate { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> ClubCloudUpdate { get; set; }
    }
}
