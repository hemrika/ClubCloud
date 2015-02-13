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
    [KnownType(typeof(ClubCloud_Baan))]
    [KnownType(typeof(ClubCloud_Accomodatie))]
    [KnownType(typeof(ClubCloud_Baantype))]
    [KnownType(typeof(ClubCloud_Baansoort))]
    
    public partial class ClubCloud_Baanblok : BeheerBaseModel
    {
        public ClubCloud_Baanblok()
        {
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
        private Nullable<System.Guid> _accomodatieId;
    	public Nullable<System.Guid> AccomodatieId 
    	{ 
    		get { return _accomodatieId; } 
    		set { SetProperty(ref _accomodatieId, value); } 
    	}
    
    	[DataMember]
        private Nullable<System.Guid> _baantypeId;
    	public Nullable<System.Guid> BaantypeId 
    	{ 
    		get { return _baantypeId; } 
    		set { SetProperty(ref _baantypeId, value); } 
    	}
    
    	[DataMember]
        private Nullable<System.Guid> _baansoortId;
    	public Nullable<System.Guid> BaansoortId 
    	{ 
    		get { return _baansoortId; } 
    		set { SetProperty(ref _baansoortId, value); } 
    	}
    
    	[DataMember]
        private bool _verlichting;
    	public bool Verlichting 
    	{ 
    		get { return _verlichting; } 
    		set { SetProperty(ref _verlichting, value); } 
    	}
    
    	[DataMember]
        private string _locatie;
    	public string Locatie 
    	{ 
    		get { return _locatie; } 
    		set { SetProperty(ref _locatie, value); } 
    	}
    
    	[DataMember]
        private string _actief;
    	public string Actief 
    	{ 
    		get { return _actief; } 
    		set { SetProperty(ref _actief, value); } 
    	}
    
    
    	[DataMember]
        public virtual ICollection<ClubCloud_Baan> ClubCloud_Baan { get; set; }
    	[DataMember]
        public virtual ClubCloud_Accomodatie ClubCloud_Accomodatie { get; set; }
    	[DataMember]
        public virtual ClubCloud_Baantype ClubCloud_Baantype { get; set; }
    	[DataMember]
        public virtual ClubCloud_Baansoort ClubCloud_Baansoort { get; set; }
    }
}
