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
    
    [Serializable]
    [DataContract(IsReference = true)]
    [KnownType(typeof(ClubCloud_Functionaris))]
    [KnownType(typeof(ClubCloud_Lidmaatschap))]
    [KnownType(typeof(ClubCloud_Address))]
    [KnownType(typeof(ClubCloud_Vereniging))]
    [KnownType(typeof(ClubCloud_Profiel))]
    
    public partial class ClubCloud_Gebruiker
    {
        public ClubCloud_Gebruiker()
        {
            this.ClubCloud_Functionaris = new HashSet<ClubCloud_Functionaris>();
            this.ClubCloud_Lidmaatschap = new HashSet<ClubCloud_Lidmaatschap>();
            this.ClubCloud_Address = new HashSet<ClubCloud_Address>();
            this.ClubCloud_Profiel = new HashSet<ClubCloud_Profiel>();
        }
    
    	[DataMember]
        public System.Guid Id { get; set; }
    	[DataMember]
        public string Beschrijving { get; set; }
    	[DataMember]
        public string Bondsnummer { get; set; }
    	[DataMember]
        public string Roepnaam { get; set; }
    	[DataMember]
        public string Aanhef { get; set; }
    	[DataMember]
        public string Voornaam { get; set; }
    	[DataMember]
        public string Voornamen { get; set; }
    	[DataMember]
        public string Achtervoegsel { get; set; }
    	[DataMember]
        public string Tussenvoegsel { get; set; }
    	[DataMember]
        public string Achternaam { get; set; }
    	[DataMember]
        public string Voorletters { get; set; }
    	[DataMember]
        public bool EmailGeheim { get; set; }
    	[DataMember]
        public string EmailKNLTB { get; set; }
    	[DataMember]
        public string EmailWebSite { get; set; }
    	[DataMember]
        public string EmailOverig { get; set; }
    	[DataMember]
        public bool TelefoonGeheim { get; set; }
    	[DataMember]
        public string TelefoonAvond { get; set; }
    	[DataMember]
        public string TelefoonOverdag { get; set; }
    	[DataMember]
        public string TelefoonOverig { get; set; }
    	[DataMember]
        public string Mobiel { get; set; }
    	[DataMember]
        public string Fax { get; set; }
    	[DataMember]
        public string BankNummer { get; set; }
    	[DataMember]
        public string BankIban { get; set; }
    	[DataMember]
        public string BankPlaats { get; set; }
    	[DataMember]
        public ClubCloud.KNLTB.ServIt.LedenAdministratieService.Geslacht Geslacht { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> Geboortedatum { get; set; }
    	[DataMember]
        public string Geboorteplaats { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> OverlijdensDatum { get; set; }
    	[DataMember]
        public Nullable<System.Guid> NationaliteitId { get; set; }
    	[DataMember]
        public bool AddressGeheim { get; set; }
    	[DataMember]
        public string Website { get; set; }
    	[DataMember]
        public string FTPsite { get; set; }
    	[DataMember]
        public string Actief { get; set; }
    	[DataMember]
        public string Beroep { get; set; }
    	[DataMember]
        public bool Kinderen { get; set; }
    	[DataMember]
        public int KinderenAantal { get; set; }
    	[DataMember]
        public string Partner { get; set; }
    	[DataMember]
        public string AanhefBrief { get; set; }
    	[DataMember]
        public string AanhefAttentie { get; set; }
    	[DataMember]
        public string FotoId { get; set; }
    	[DataMember]
        public Nullable<System.Guid> VerenigingId { get; set; }
    	[DataMember]
        public string Volledigenaam { get; set; }
    
    	[DataMember]
        public virtual ICollection<ClubCloud_Functionaris> ClubCloud_Functionaris { get; set; }
    	[DataMember]
        public virtual ICollection<ClubCloud_Lidmaatschap> ClubCloud_Lidmaatschap { get; set; }
    	[DataMember]
        public virtual ICollection<ClubCloud_Address> ClubCloud_Address { get; set; }
    	[DataMember]
        public virtual ClubCloud_Vereniging ClubCloud_Vereniging { get; set; }
    	[DataMember]
        public virtual ICollection<ClubCloud_Profiel> ClubCloud_Profiel { get; set; }
    }
}
