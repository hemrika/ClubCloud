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
    
    public partial class ClubCloud_BaanSpeciaal : BeheerBaseModel
    {
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
        private string _baansoortId;
    	public string BaansoortId 
    	{ 
    		get { return _baansoortId; } 
    		set { SetProperty(ref _baansoortId, value); } 
    	}
    
    }
}