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
    [KnownType(typeof(ClubCloud_Vereniging))]
    
    public partial class ClubCloud_Bestuursorgaan : BeheerBaseModel
    {
        public ClubCloud_Bestuursorgaan()
        {
            this.ClubCloud_Functionaris = new HashSet<ClubCloud_Functionaris>();
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
        private string _beschrijving;
    	public string Beschrijving 
    	{ 
    		get { return _beschrijving; } 
    		set { SetProperty(ref _beschrijving, value); } 
    	}
    
    	[DataMember]
        private Nullable<System.Guid> _verenigingId;
    	public Nullable<System.Guid> VerenigingId 
    	{ 
    		get { return _verenigingId; } 
    		set { SetProperty(ref _verenigingId, value); } 
    	}
    
    	[DataMember]
        private System.Guid _typeId;
    	public System.Guid TypeId 
    	{ 
    		get { return _typeId; } 
    		set { SetProperty(ref _typeId, value); } 
    	}
    
    	[DataMember]
        private string _actief;
    	public string Actief 
    	{ 
    		get { return _actief; } 
    		set { SetProperty(ref _actief, value); } 
    	}
    
    
    	[DataMember]
        public virtual ICollection<ClubCloud_Functionaris> ClubCloud_Functionaris { get; set; }
    	[DataMember]
        public virtual ClubCloud_Vereniging ClubCloud_Vereniging { get; set; }
    }
}
