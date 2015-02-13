//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClubCloud.Model
{
    using System;
    using System.Runtime.Serialization;
    using System.Collections.Generic;
    
    [Serializable]
    [DataContract(IsReference = true)]
    [KnownType(typeof(ClubCloud_Vereniging))]
    [KnownType(typeof(ClubCloud_Gebruiker))]
    
    public partial class ClubCloud_Address : BeheerBaseModel
    {
        public ClubCloud_Address()
        {
            this.AddressGeheim = false;
        }
    
    	[DataMember]
        private System.Guid _id;
    	public System.Guid Id 
    	{ 
    		get { return _id; } 
    		set { SetProperty(ref _id, value); } 
    	}
    
    	[DataMember]
        private Nullable<System.Guid> _parentId;
    	public Nullable<System.Guid> ParentId 
    	{ 
    		get { return _parentId; } 
    		set { SetProperty(ref _parentId, value); } 
    	}
    
    	[DataMember]
        private string _stad;
    	public string Stad 
    	{ 
    		get { return _stad; } 
    		set { SetProperty(ref _stad, value); } 
    	}
    
    	[DataMember]
        private string _provincie;
    	public string Provincie 
    	{ 
    		get { return _provincie; } 
    		set { SetProperty(ref _provincie, value); } 
    	}
    
    	[DataMember]
        private Nullable<double> _latitude;
    	public Nullable<double> Latitude 
    	{ 
    		get { return _latitude; } 
    		set { SetProperty(ref _latitude, value); } 
    	}
    
    	[DataMember]
        private Nullable<double> _longitude;
    	public Nullable<double> Longitude 
    	{ 
    		get { return _longitude; } 
    		set { SetProperty(ref _longitude, value); } 
    	}
    
    	[DataMember]
        private string _naam;
    	public string Naam 
    	{ 
    		get { return _naam; } 
    		set { SetProperty(ref _naam, value); } 
    	}
    
    	[DataMember]
        private string _postcode;
    	public string Postcode 
    	{ 
    		get { return _postcode; } 
    		set { SetProperty(ref _postcode, value); } 
    	}
    
    	[DataMember]
        private string _straat;
    	public string Straat 
    	{ 
    		get { return _straat; } 
    		set { SetProperty(ref _straat, value); } 
    	}
    
    	[DataMember]
        private string _nummer;
    	public string Nummer 
    	{ 
    		get { return _nummer; } 
    		set { SetProperty(ref _nummer, value); } 
    	}
    
    	[DataMember]
        private string _actief;
    	public string Actief 
    	{ 
    		get { return _actief; } 
    		set { SetProperty(ref _actief, value); } 
    	}
    
    	[DataMember]
        private string _land;
    	public string Land 
    	{ 
    		get { return _land; } 
    		set { SetProperty(ref _land, value); } 
    	}
    
    	[DataMember]
        private string _fax;
    	public string Fax 
    	{ 
    		get { return _fax; } 
    		set { SetProperty(ref _fax, value); } 
    	}
    
    	[DataMember]
        private string _toevoeging;
    	public string Toevoeging 
    	{ 
    		get { return _toevoeging; } 
    		set { SetProperty(ref _toevoeging, value); } 
    	}
    
    	[DataMember]
        private string _postbus;
    	public string Postbus 
    	{ 
    		get { return _postbus; } 
    		set { SetProperty(ref _postbus, value); } 
    	}
    
    	[DataMember]
        private string _telefoonPrimair;
    	public string TelefoonPrimair 
    	{ 
    		get { return _telefoonPrimair; } 
    		set { SetProperty(ref _telefoonPrimair, value); } 
    	}
    
    	[DataMember]
        private string _telefoonSecundair;
    	public string TelefoonSecundair 
    	{ 
    		get { return _telefoonSecundair; } 
    		set { SetProperty(ref _telefoonSecundair, value); } 
    	}
    
    	[DataMember]
        private string _telefoonTertiair;
    	public string TelefoonTertiair 
    	{ 
    		get { return _telefoonTertiair; } 
    		set { SetProperty(ref _telefoonTertiair, value); } 
    	}
    
    	[DataMember]
        private System.Data.Entity.Spatial.DbGeography _geoLocation;
    	public System.Data.Entity.Spatial.DbGeography GeoLocation 
    	{ 
    		get { return _geoLocation; } 
    		set { SetProperty(ref _geoLocation, value); } 
    	}
    
    	[DataMember]
        private System.DateTime _gewijzigd;
    	public System.DateTime Gewijzigd 
    	{ 
    		get { return _gewijzigd; } 
    		set { SetProperty(ref _gewijzigd, value); } 
    	}
    
    	[DataMember]
        private string _gemeente;
    	public string Gemeente 
    	{ 
    		get { return _gemeente; } 
    		set { SetProperty(ref _gemeente, value); } 
    	}
    
    	[DataMember]
        private bool _addressGeheim;
    	public bool AddressGeheim 
    	{ 
    		get { return _addressGeheim; } 
    		set { SetProperty(ref _addressGeheim, value); } 
    	}
    
    
    	[DataMember]
        public virtual ClubCloud_Vereniging ClubCloud_Vereniging { get; set; }
    	[DataMember]
        public virtual ClubCloud_Gebruiker ClubCloud_Gebruiker { get; set; }
    }
}
