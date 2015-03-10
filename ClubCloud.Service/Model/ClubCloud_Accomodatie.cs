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
    [KnownType(typeof(ClubCloud_Vereniging))]
    [KnownType(typeof(ClubCloud_District))]
    [KnownType(typeof(ClubCloud_Regio))]
    [KnownType(typeof(ClubCloud_Baanblok))]
    [KnownType(typeof(ClubCloud_Baan))]
    
    public partial class ClubCloud_Accomodatie : BeheerBaseModel
    {
        public ClubCloud_Accomodatie()
        {
            this.BanenAantal = 0;
            this.BanenAantalBinnen = 0;
            this.Blaashal = false;
            this.Oefenmuren = false;
            this.OefenmurenAantal = 0;
            this.Minibanen = false;
            this.MinibanenAantal = 0;
            this.Overkapping = false;
            this.AantalParkeerplaatsen = 0;
            this.AantalParkeerplaatsenMindervalide = 0;
            this.ClubCloud_Vereniging = new HashSet<ClubCloud_Vereniging>();
            this.ClubCloud_Baanblok = new HashSet<ClubCloud_Baanblok>();
            this.ClubCloud_Baan = new HashSet<ClubCloud_Baan>();
        }
    
    	[DataMember]
        private System.Guid _id;
    	public System.Guid Id 
    	{ 
    		get { return _id; } 
    		set { SetProperty(ref _id, value); } 
    	}
    
    	[DataMember]
        private string _naam;
    	public string Naam 
    	{ 
    		get { return _naam; } 
    		set { SetProperty(ref _naam, value); } 
    	}
    
    	[DataMember]
        private int _banenAantal;
    	public int BanenAantal 
    	{ 
    		get { return _banenAantal; } 
    		set { SetProperty(ref _banenAantal, value); } 
    	}
    
    	[DataMember]
        private int _banenAantalBinnen;
    	public int BanenAantalBinnen 
    	{ 
    		get { return _banenAantalBinnen; } 
    		set { SetProperty(ref _banenAantalBinnen, value); } 
    	}
    
    	[DataMember]
        private int _banenAantalBuiten;
    	public int BanenAantalBuiten 
    	{ 
    		get { return _banenAantalBuiten; } 
    		set { SetProperty(ref _banenAantalBuiten, value); } 
    	}
    
    	[DataMember]
        private Nullable<bool> _blaashal;
    	public Nullable<bool> Blaashal 
    	{ 
    		get { return _blaashal; } 
    		set { SetProperty(ref _blaashal, value); } 
    	}
    
    	[DataMember]
        private string _blaashalSoort;
    	public string BlaashalSoort 
    	{ 
    		get { return _blaashalSoort; } 
    		set { SetProperty(ref _blaashalSoort, value); } 
    	}
    
    	[DataMember]
        private Nullable<int> _blaashalAantalBanen;
    	public Nullable<int> BlaashalAantalBanen 
    	{ 
    		get { return _blaashalAantalBanen; } 
    		set { SetProperty(ref _blaashalAantalBanen, value); } 
    	}
    
    	[DataMember]
        private bool _playgrounds;
    	public bool Playgrounds 
    	{ 
    		get { return _playgrounds; } 
    		set { SetProperty(ref _playgrounds, value); } 
    	}
    
    	[DataMember]
        private int _playgroundsAantal;
    	public int PlaygroundsAantal 
    	{ 
    		get { return _playgroundsAantal; } 
    		set { SetProperty(ref _playgroundsAantal, value); } 
    	}
    
    	[DataMember]
        private bool _oefenmuren;
    	public bool Oefenmuren 
    	{ 
    		get { return _oefenmuren; } 
    		set { SetProperty(ref _oefenmuren, value); } 
    	}
    
    	[DataMember]
        private int _oefenmurenAantal;
    	public int OefenmurenAantal 
    	{ 
    		get { return _oefenmurenAantal; } 
    		set { SetProperty(ref _oefenmurenAantal, value); } 
    	}
    
    	[DataMember]
        private bool _minibanen;
    	public bool Minibanen 
    	{ 
    		get { return _minibanen; } 
    		set { SetProperty(ref _minibanen, value); } 
    	}
    
    	[DataMember]
        private int _minibanenAantal;
    	public int MinibanenAantal 
    	{ 
    		get { return _minibanenAantal; } 
    		set { SetProperty(ref _minibanenAantal, value); } 
    	}
    
    	[DataMember]
        private Nullable<bool> _overkapping;
    	public Nullable<bool> Overkapping 
    	{ 
    		get { return _overkapping; } 
    		set { SetProperty(ref _overkapping, value); } 
    	}
    
    	[DataMember]
        private string _overkappingSoort;
    	public string OverkappingSoort 
    	{ 
    		get { return _overkappingSoort; } 
    		set { SetProperty(ref _overkappingSoort, value); } 
    	}
    
    	[DataMember]
        private int _aantalParkeerplaatsen;
    	public int AantalParkeerplaatsen 
    	{ 
    		get { return _aantalParkeerplaatsen; } 
    		set { SetProperty(ref _aantalParkeerplaatsen, value); } 
    	}
    
    	[DataMember]
        private int _aantalParkeerplaatsenMindervalide;
    	public int AantalParkeerplaatsenMindervalide 
    	{ 
    		get { return _aantalParkeerplaatsenMindervalide; } 
    		set { SetProperty(ref _aantalParkeerplaatsenMindervalide, value); } 
    	}
    
    	[DataMember]
        private bool _metOVBereikbaar;
    	public bool MetOVBereikbaar 
    	{ 
    		get { return _metOVBereikbaar; } 
    		set { SetProperty(ref _metOVBereikbaar, value); } 
    	}
    
    	[DataMember]
        private string _email;
    	public string Email 
    	{ 
    		get { return _email; } 
    		set { SetProperty(ref _email, value); } 
    	}
    
    	[DataMember]
        private string _telefoon;
    	public string Telefoon 
    	{ 
    		get { return _telefoon; } 
    		set { SetProperty(ref _telefoon, value); } 
    	}
    
    	[DataMember]
        private string _website;
    	public string Website 
    	{ 
    		get { return _website; } 
    		set { SetProperty(ref _website, value); } 
    	}
    
    	[DataMember]
        private string _clubhuisStatus;
    	public string ClubhuisStatus 
    	{ 
    		get { return _clubhuisStatus; } 
    		set { SetProperty(ref _clubhuisStatus, value); } 
    	}
    
    	[DataMember]
        private string _clubhuisBouwjaar;
    	public string ClubhuisBouwjaar 
    	{ 
    		get { return _clubhuisBouwjaar; } 
    		set { SetProperty(ref _clubhuisBouwjaar, value); } 
    	}
    
    	[DataMember]
        private string _clubhuisBouwaard;
    	public string ClubhuisBouwaard 
    	{ 
    		get { return _clubhuisBouwaard; } 
    		set { SetProperty(ref _clubhuisBouwaard, value); } 
    	}
    
    	[DataMember]
        private Nullable<int> _clubhuisOppervlakte;
    	public Nullable<int> ClubhuisOppervlakte 
    	{ 
    		get { return _clubhuisOppervlakte; } 
    		set { SetProperty(ref _clubhuisOppervlakte, value); } 
    	}
    
    	[DataMember]
        private string _clubhuisLigging;
    	public string ClubhuisLigging 
    	{ 
    		get { return _clubhuisLigging; } 
    		set { SetProperty(ref _clubhuisLigging, value); } 
    	}
    
    	[DataMember]
        private string _clubhuisBeveiliging;
    	public string ClubhuisBeveiliging 
    	{ 
    		get { return _clubhuisBeveiliging; } 
    		set { SetProperty(ref _clubhuisBeveiliging, value); } 
    	}
    
    	[DataMember]
        private string _halStatus;
    	public string HalStatus 
    	{ 
    		get { return _halStatus; } 
    		set { SetProperty(ref _halStatus, value); } 
    	}
    
    	[DataMember]
        private string _halBouwjaar;
    	public string HalBouwjaar 
    	{ 
    		get { return _halBouwjaar; } 
    		set { SetProperty(ref _halBouwjaar, value); } 
    	}
    
    	[DataMember]
        private string _halBouwaard;
    	public string HalBouwaard 
    	{ 
    		get { return _halBouwaard; } 
    		set { SetProperty(ref _halBouwaard, value); } 
    	}
    
    	[DataMember]
        private Nullable<int> _halOppervlakte;
    	public Nullable<int> HalOppervlakte 
    	{ 
    		get { return _halOppervlakte; } 
    		set { SetProperty(ref _halOppervlakte, value); } 
    	}
    
    	[DataMember]
        private bool _rolStoeltoegankelijk;
    	public bool RolStoeltoegankelijk 
    	{ 
    		get { return _rolStoeltoegankelijk; } 
    		set { SetProperty(ref _rolStoeltoegankelijk, value); } 
    	}
    
    	[DataMember]
        private string _speeltoestellen;
    	public string Speeltoestellen 
    	{ 
    		get { return _speeltoestellen; } 
    		set { SetProperty(ref _speeltoestellen, value); } 
    	}
    
    	[DataMember]
        private Nullable<int> _totaalAantalWasKleedruimte;
    	public Nullable<int> TotaalAantalWasKleedruimte 
    	{ 
    		get { return _totaalAantalWasKleedruimte; } 
    		set { SetProperty(ref _totaalAantalWasKleedruimte, value); } 
    	}
    
    	[DataMember]
        private Nullable<int> _valideParkeerplaatsen;
    	public Nullable<int> ValideParkeerplaatsen 
    	{ 
    		get { return _valideParkeerplaatsen; } 
    		set { SetProperty(ref _valideParkeerplaatsen, value); } 
    	}
    
    	[DataMember]
        private bool _wasruimteClubhuisAanwezig;
    	public bool WasruimteClubhuisAanwezig 
    	{ 
    		get { return _wasruimteClubhuisAanwezig; } 
    		set { SetProperty(ref _wasruimteClubhuisAanwezig, value); } 
    	}
    
    	[DataMember]
        private Nullable<System.Guid> _districtId;
    	public Nullable<System.Guid> DistrictId 
    	{ 
    		get { return _districtId; } 
    		set { SetProperty(ref _districtId, value); } 
    	}
    
    	[DataMember]
        private Nullable<System.Guid> _regioId;
    	public Nullable<System.Guid> RegioId 
    	{ 
    		get { return _regioId; } 
    		set { SetProperty(ref _regioId, value); } 
    	}
    
    	[DataMember]
        private string _actief;
    	public string Actief 
    	{ 
    		get { return _actief; } 
    		set { SetProperty(ref _actief, value); } 
    	}
    
    	[DataMember]
        private System.DateTime _gewijzigd;
    	public System.DateTime Gewijzigd 
    	{ 
    		get { return _gewijzigd; } 
    		set { SetProperty(ref _gewijzigd, value); } 
    	}
    
    
    	[DataMember]
        public virtual ICollection<ClubCloud_Vereniging> ClubCloud_Vereniging { get; set; }
    	[DataMember]
        public virtual ClubCloud_District ClubCloud_District { get; set; }
    	[DataMember]
        public virtual ClubCloud_Regio ClubCloud_Regio { get; set; }
    	[DataMember]
        public virtual ICollection<ClubCloud_Baanblok> ClubCloud_Baanblok { get; set; }
    	[DataMember]
        public virtual ICollection<ClubCloud_Baan> ClubCloud_Baan { get; set; }
    }
}