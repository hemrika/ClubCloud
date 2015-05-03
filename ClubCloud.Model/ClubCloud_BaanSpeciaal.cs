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
    using System.Collections.ObjectModel;
    
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Data.Entity.ModelConfiguration;
    using System.Collections.Generic;
    
    [Serializable]
    [KnownType(typeof(ClubCloud_Accommodatie))]
    [KnownType(typeof(ClubCloud_Baantoplaag))]
    [DataContract(IsReference = true)]
    [TypeDescriptionProvider(typeof(ClubCloud_BaanSpeciaal_TypeDescriptionProvider))]
    public partial class ClubCloud_BaanSpeciaal : INotifyPropertyChanged, IDataErrorInfo, INotifyDataErrorInfo
    {
    	[DataMember]
        public System.Guid Id 
    	{ 
    		get { return _id; } 
    		set { SetProperty(ref _id, value); } 
    	}
    
    	[IgnoreDataMember]
    	private System.Guid _id;
    
    	[DataMember]
        public string Naam 
    	{ 
    		get { return _naam; } 
    		set { SetProperty(ref _naam, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _naam;
    
    	[DataMember]
        public string Baansoort 
    	{ 
    		get { return _baansoort; } 
    		set { SetProperty(ref _baansoort, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _baansoort;
    
    	[DataMember]
        public Nullable<System.Guid> AccommodatieId 
    	{ 
    		get { return _accommodatieId; } 
    		set { SetProperty(ref _accommodatieId, value); } 
    	}
    
    	[IgnoreDataMember]
    	private Nullable<System.Guid> _accommodatieId;
    
    	[DataMember]
        public string Actief 
    	{ 
    		get { return _actief; } 
    		set { SetProperty(ref _actief, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _actief;
    
    	[DataMember]
        public Nullable<System.Guid> BaantoplaagId 
    	{ 
    		get { return _baantoplaagId; } 
    		set { SetProperty(ref _baantoplaagId, value); } 
    	}
    
    	[IgnoreDataMember]
    	private Nullable<System.Guid> _baantoplaagId;
    
    
    
    	//[DataMember]
    	[IgnoreDataMember]
        public virtual ClubCloud_Accommodatie ClubCloud_Accommodatie { get; set; }
    
    	//[DataMember]
    	[IgnoreDataMember]
        public virtual ClubCloud_Baantoplaag ClubCloud_Baantoplaag { get; set; }
    
        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;
    
        private Dictionary<string, string> _errors = new Dictionary<string, string>();
    
        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] String propertyName = null)
        {
            if (object.Equals(storage, value)) return false;
    
            try
            {
                storage = value;
                this.OnPropertyChanged(propertyName);
                return true;
            }
            catch (Exception ex)
            {
                _errors.Add(propertyName, ex.Message);
                return false;
            }
                
        }
    
    
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var eventHandler = this.PropertyChanged;
            if (eventHandler != null)
            {
                eventHandler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        protected void OnErrorsChanged(object sender, DataErrorsChangedEventArgs e = null)
        {
            var eventHandler = this.ErrorsChanged;
            if (eventHandler != null)
            {
                eventHandler(this, e);
            }
        }
    
    	[IgnoreDataMember]
        public string Error
        {
            get
            {
                return string.Empty;
            }
        }
    
    	[IgnoreDataMember]
        public string this[string columnName]
        {
            get
            {
                if (_errors.ContainsKey(columnName))
                    return _errors[columnName];
                return string.Empty;
            }
        }
    
            
        public System.Collections.IEnumerable GetErrors(string propertyName)
        {
            return _errors[propertyName];
        }
    
    	[IgnoreDataMember]
        public bool HasErrors
        {
            get 
            { 
                if(_errors != null)
                    return (_errors.Count > 0);
                return false;
            }
        }
    }
    
    
    public class ClubCloud_BaanSpeciaal_Mapping : EntityTypeConfiguration<ClubCloud_BaanSpeciaal>
    {
    	public ClubCloud_BaanSpeciaal_Mapping() 
    	{			
    		HasKey(m => m.Id);
    	}
    }
    
    public class ClubCloud_BaanSpeciaal_TypeDescriptionProvider : TypeDescriptionProvider
    {
        private ICustomTypeDescriptor td;
    
        public ClubCloud_BaanSpeciaal_TypeDescriptionProvider() : this(TypeDescriptor.GetProvider(typeof(ClubCloud_BaanSpeciaal))) {}
    
        public ClubCloud_BaanSpeciaal_TypeDescriptionProvider(TypeDescriptionProvider parent) : base(parent) {}
    
        public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
        {
            if (td == null)
            {
                td = base.GetTypeDescriptor(objectType, instance);
                td = new ClubCloud_BaanSpeciaal_CustomTypeDescriptor(td);
            }
    
            return td;
        }        
    }
    
    public class ClubCloud_BaanSpeciaal_CustomTypeDescriptor : CustomTypeDescriptor
    {       
        public ClubCloud_BaanSpeciaal_CustomTypeDescriptor(ICustomTypeDescriptor parent) : base(parent) {}
    
        public override PropertyDescriptorCollection GetProperties()
        {
            PropertyDescriptorCollection cols = base.GetProperties();
    		
    		List<PropertyDescriptor> extended = new List<PropertyDescriptor>();
            foreach (PropertyDescriptor item in cols)
            {
                extended.Add(item);
            }
    		//ClubCloud_Accommodatie
    		PropertyDescriptor ClubCloud_Accommodatie_Columns = cols["ClubCloud_Accommodatie"];
    		PropertyDescriptorCollection ClubCloud_Accommodatie_Children = ClubCloud_Accommodatie_Columns.GetChildProperties();
    
    		PropertyDescriptor ClubCloud_Accommodatie_Id = new BeheerPropertyDescriptor(ClubCloud_Accommodatie_Columns,ClubCloud_Accommodatie_Children["Id"],"ClubCloud_Accommodatie_Id");
    		extended.Add(ClubCloud_Accommodatie_Id);
    
    		PropertyDescriptor ClubCloud_Accommodatie_Naam = new BeheerPropertyDescriptor(ClubCloud_Accommodatie_Columns,ClubCloud_Accommodatie_Children["Naam"],"ClubCloud_Accommodatie_Naam");
    		extended.Add(ClubCloud_Accommodatie_Naam);
    
    		PropertyDescriptor ClubCloud_Accommodatie_BanenAantal = new BeheerPropertyDescriptor(ClubCloud_Accommodatie_Columns,ClubCloud_Accommodatie_Children["BanenAantal"],"ClubCloud_Accommodatie_BanenAantal");
    		extended.Add(ClubCloud_Accommodatie_BanenAantal);
    
    		PropertyDescriptor ClubCloud_Accommodatie_BanenAantalBinnen = new BeheerPropertyDescriptor(ClubCloud_Accommodatie_Columns,ClubCloud_Accommodatie_Children["BanenAantalBinnen"],"ClubCloud_Accommodatie_BanenAantalBinnen");
    		extended.Add(ClubCloud_Accommodatie_BanenAantalBinnen);
    
    		PropertyDescriptor ClubCloud_Accommodatie_BanenAantalBuiten = new BeheerPropertyDescriptor(ClubCloud_Accommodatie_Columns,ClubCloud_Accommodatie_Children["BanenAantalBuiten"],"ClubCloud_Accommodatie_BanenAantalBuiten");
    		extended.Add(ClubCloud_Accommodatie_BanenAantalBuiten);
    
    		PropertyDescriptor ClubCloud_Accommodatie_Blaashal = new BeheerPropertyDescriptor(ClubCloud_Accommodatie_Columns,ClubCloud_Accommodatie_Children["Blaashal"],"ClubCloud_Accommodatie_Blaashal");
    		extended.Add(ClubCloud_Accommodatie_Blaashal);
    
    		PropertyDescriptor ClubCloud_Accommodatie_BlaashalSoort = new BeheerPropertyDescriptor(ClubCloud_Accommodatie_Columns,ClubCloud_Accommodatie_Children["BlaashalSoort"],"ClubCloud_Accommodatie_BlaashalSoort");
    		extended.Add(ClubCloud_Accommodatie_BlaashalSoort);
    
    		PropertyDescriptor ClubCloud_Accommodatie_BlaashalAantalBanen = new BeheerPropertyDescriptor(ClubCloud_Accommodatie_Columns,ClubCloud_Accommodatie_Children["BlaashalAantalBanen"],"ClubCloud_Accommodatie_BlaashalAantalBanen");
    		extended.Add(ClubCloud_Accommodatie_BlaashalAantalBanen);
    
    		PropertyDescriptor ClubCloud_Accommodatie_Playgrounds = new BeheerPropertyDescriptor(ClubCloud_Accommodatie_Columns,ClubCloud_Accommodatie_Children["Playgrounds"],"ClubCloud_Accommodatie_Playgrounds");
    		extended.Add(ClubCloud_Accommodatie_Playgrounds);
    
    		PropertyDescriptor ClubCloud_Accommodatie_PlaygroundsAantal = new BeheerPropertyDescriptor(ClubCloud_Accommodatie_Columns,ClubCloud_Accommodatie_Children["PlaygroundsAantal"],"ClubCloud_Accommodatie_PlaygroundsAantal");
    		extended.Add(ClubCloud_Accommodatie_PlaygroundsAantal);
    
    		PropertyDescriptor ClubCloud_Accommodatie_Oefenmuren = new BeheerPropertyDescriptor(ClubCloud_Accommodatie_Columns,ClubCloud_Accommodatie_Children["Oefenmuren"],"ClubCloud_Accommodatie_Oefenmuren");
    		extended.Add(ClubCloud_Accommodatie_Oefenmuren);
    
    		PropertyDescriptor ClubCloud_Accommodatie_OefenmurenAantal = new BeheerPropertyDescriptor(ClubCloud_Accommodatie_Columns,ClubCloud_Accommodatie_Children["OefenmurenAantal"],"ClubCloud_Accommodatie_OefenmurenAantal");
    		extended.Add(ClubCloud_Accommodatie_OefenmurenAantal);
    
    		PropertyDescriptor ClubCloud_Accommodatie_Minibanen = new BeheerPropertyDescriptor(ClubCloud_Accommodatie_Columns,ClubCloud_Accommodatie_Children["Minibanen"],"ClubCloud_Accommodatie_Minibanen");
    		extended.Add(ClubCloud_Accommodatie_Minibanen);
    
    		PropertyDescriptor ClubCloud_Accommodatie_MinibanenAantal = new BeheerPropertyDescriptor(ClubCloud_Accommodatie_Columns,ClubCloud_Accommodatie_Children["MinibanenAantal"],"ClubCloud_Accommodatie_MinibanenAantal");
    		extended.Add(ClubCloud_Accommodatie_MinibanenAantal);
    
    		PropertyDescriptor ClubCloud_Accommodatie_Overkapping = new BeheerPropertyDescriptor(ClubCloud_Accommodatie_Columns,ClubCloud_Accommodatie_Children["Overkapping"],"ClubCloud_Accommodatie_Overkapping");
    		extended.Add(ClubCloud_Accommodatie_Overkapping);
    
    		PropertyDescriptor ClubCloud_Accommodatie_OverkappingSoort = new BeheerPropertyDescriptor(ClubCloud_Accommodatie_Columns,ClubCloud_Accommodatie_Children["OverkappingSoort"],"ClubCloud_Accommodatie_OverkappingSoort");
    		extended.Add(ClubCloud_Accommodatie_OverkappingSoort);
    
    		PropertyDescriptor ClubCloud_Accommodatie_AantalParkeerplaatsen = new BeheerPropertyDescriptor(ClubCloud_Accommodatie_Columns,ClubCloud_Accommodatie_Children["AantalParkeerplaatsen"],"ClubCloud_Accommodatie_AantalParkeerplaatsen");
    		extended.Add(ClubCloud_Accommodatie_AantalParkeerplaatsen);
    
    		PropertyDescriptor ClubCloud_Accommodatie_AantalParkeerplaatsenMindervalide = new BeheerPropertyDescriptor(ClubCloud_Accommodatie_Columns,ClubCloud_Accommodatie_Children["AantalParkeerplaatsenMindervalide"],"ClubCloud_Accommodatie_AantalParkeerplaatsenMindervalide");
    		extended.Add(ClubCloud_Accommodatie_AantalParkeerplaatsenMindervalide);
    
    		PropertyDescriptor ClubCloud_Accommodatie_MetOVBereikbaar = new BeheerPropertyDescriptor(ClubCloud_Accommodatie_Columns,ClubCloud_Accommodatie_Children["MetOVBereikbaar"],"ClubCloud_Accommodatie_MetOVBereikbaar");
    		extended.Add(ClubCloud_Accommodatie_MetOVBereikbaar);
    
    		PropertyDescriptor ClubCloud_Accommodatie_Email = new BeheerPropertyDescriptor(ClubCloud_Accommodatie_Columns,ClubCloud_Accommodatie_Children["Email"],"ClubCloud_Accommodatie_Email");
    		extended.Add(ClubCloud_Accommodatie_Email);
    
    		PropertyDescriptor ClubCloud_Accommodatie_Telefoon = new BeheerPropertyDescriptor(ClubCloud_Accommodatie_Columns,ClubCloud_Accommodatie_Children["Telefoon"],"ClubCloud_Accommodatie_Telefoon");
    		extended.Add(ClubCloud_Accommodatie_Telefoon);
    
    		PropertyDescriptor ClubCloud_Accommodatie_Website = new BeheerPropertyDescriptor(ClubCloud_Accommodatie_Columns,ClubCloud_Accommodatie_Children["Website"],"ClubCloud_Accommodatie_Website");
    		extended.Add(ClubCloud_Accommodatie_Website);
    
    		PropertyDescriptor ClubCloud_Accommodatie_ClubhuisStatus = new BeheerPropertyDescriptor(ClubCloud_Accommodatie_Columns,ClubCloud_Accommodatie_Children["ClubhuisStatus"],"ClubCloud_Accommodatie_ClubhuisStatus");
    		extended.Add(ClubCloud_Accommodatie_ClubhuisStatus);
    
    		PropertyDescriptor ClubCloud_Accommodatie_ClubhuisBouwjaar = new BeheerPropertyDescriptor(ClubCloud_Accommodatie_Columns,ClubCloud_Accommodatie_Children["ClubhuisBouwjaar"],"ClubCloud_Accommodatie_ClubhuisBouwjaar");
    		extended.Add(ClubCloud_Accommodatie_ClubhuisBouwjaar);
    
    		PropertyDescriptor ClubCloud_Accommodatie_ClubhuisBouwaard = new BeheerPropertyDescriptor(ClubCloud_Accommodatie_Columns,ClubCloud_Accommodatie_Children["ClubhuisBouwaard"],"ClubCloud_Accommodatie_ClubhuisBouwaard");
    		extended.Add(ClubCloud_Accommodatie_ClubhuisBouwaard);
    
    		PropertyDescriptor ClubCloud_Accommodatie_ClubhuisOppervlakte = new BeheerPropertyDescriptor(ClubCloud_Accommodatie_Columns,ClubCloud_Accommodatie_Children["ClubhuisOppervlakte"],"ClubCloud_Accommodatie_ClubhuisOppervlakte");
    		extended.Add(ClubCloud_Accommodatie_ClubhuisOppervlakte);
    
    		PropertyDescriptor ClubCloud_Accommodatie_ClubhuisLigging = new BeheerPropertyDescriptor(ClubCloud_Accommodatie_Columns,ClubCloud_Accommodatie_Children["ClubhuisLigging"],"ClubCloud_Accommodatie_ClubhuisLigging");
    		extended.Add(ClubCloud_Accommodatie_ClubhuisLigging);
    
    		PropertyDescriptor ClubCloud_Accommodatie_ClubhuisBeveiliging = new BeheerPropertyDescriptor(ClubCloud_Accommodatie_Columns,ClubCloud_Accommodatie_Children["ClubhuisBeveiliging"],"ClubCloud_Accommodatie_ClubhuisBeveiliging");
    		extended.Add(ClubCloud_Accommodatie_ClubhuisBeveiliging);
    
    		PropertyDescriptor ClubCloud_Accommodatie_HalStatus = new BeheerPropertyDescriptor(ClubCloud_Accommodatie_Columns,ClubCloud_Accommodatie_Children["HalStatus"],"ClubCloud_Accommodatie_HalStatus");
    		extended.Add(ClubCloud_Accommodatie_HalStatus);
    
    		PropertyDescriptor ClubCloud_Accommodatie_HalBouwjaar = new BeheerPropertyDescriptor(ClubCloud_Accommodatie_Columns,ClubCloud_Accommodatie_Children["HalBouwjaar"],"ClubCloud_Accommodatie_HalBouwjaar");
    		extended.Add(ClubCloud_Accommodatie_HalBouwjaar);
    
    		PropertyDescriptor ClubCloud_Accommodatie_HalBouwaard = new BeheerPropertyDescriptor(ClubCloud_Accommodatie_Columns,ClubCloud_Accommodatie_Children["HalBouwaard"],"ClubCloud_Accommodatie_HalBouwaard");
    		extended.Add(ClubCloud_Accommodatie_HalBouwaard);
    
    		PropertyDescriptor ClubCloud_Accommodatie_HalOppervlakte = new BeheerPropertyDescriptor(ClubCloud_Accommodatie_Columns,ClubCloud_Accommodatie_Children["HalOppervlakte"],"ClubCloud_Accommodatie_HalOppervlakte");
    		extended.Add(ClubCloud_Accommodatie_HalOppervlakte);
    
    		PropertyDescriptor ClubCloud_Accommodatie_RolStoeltoegankelijk = new BeheerPropertyDescriptor(ClubCloud_Accommodatie_Columns,ClubCloud_Accommodatie_Children["RolStoeltoegankelijk"],"ClubCloud_Accommodatie_RolStoeltoegankelijk");
    		extended.Add(ClubCloud_Accommodatie_RolStoeltoegankelijk);
    
    		PropertyDescriptor ClubCloud_Accommodatie_Speeltoestellen = new BeheerPropertyDescriptor(ClubCloud_Accommodatie_Columns,ClubCloud_Accommodatie_Children["Speeltoestellen"],"ClubCloud_Accommodatie_Speeltoestellen");
    		extended.Add(ClubCloud_Accommodatie_Speeltoestellen);
    
    		PropertyDescriptor ClubCloud_Accommodatie_TotaalAantalWasKleedruimte = new BeheerPropertyDescriptor(ClubCloud_Accommodatie_Columns,ClubCloud_Accommodatie_Children["TotaalAantalWasKleedruimte"],"ClubCloud_Accommodatie_TotaalAantalWasKleedruimte");
    		extended.Add(ClubCloud_Accommodatie_TotaalAantalWasKleedruimte);
    
    		PropertyDescriptor ClubCloud_Accommodatie_ValideParkeerplaatsen = new BeheerPropertyDescriptor(ClubCloud_Accommodatie_Columns,ClubCloud_Accommodatie_Children["ValideParkeerplaatsen"],"ClubCloud_Accommodatie_ValideParkeerplaatsen");
    		extended.Add(ClubCloud_Accommodatie_ValideParkeerplaatsen);
    
    		PropertyDescriptor ClubCloud_Accommodatie_WasruimteClubhuisAanwezig = new BeheerPropertyDescriptor(ClubCloud_Accommodatie_Columns,ClubCloud_Accommodatie_Children["WasruimteClubhuisAanwezig"],"ClubCloud_Accommodatie_WasruimteClubhuisAanwezig");
    		extended.Add(ClubCloud_Accommodatie_WasruimteClubhuisAanwezig);
    
    		PropertyDescriptor ClubCloud_Accommodatie_DistrictId = new BeheerPropertyDescriptor(ClubCloud_Accommodatie_Columns,ClubCloud_Accommodatie_Children["DistrictId"],"ClubCloud_Accommodatie_DistrictId");
    		extended.Add(ClubCloud_Accommodatie_DistrictId);
    
    		PropertyDescriptor ClubCloud_Accommodatie_RegioId = new BeheerPropertyDescriptor(ClubCloud_Accommodatie_Columns,ClubCloud_Accommodatie_Children["RegioId"],"ClubCloud_Accommodatie_RegioId");
    		extended.Add(ClubCloud_Accommodatie_RegioId);
    
    		PropertyDescriptor ClubCloud_Accommodatie_Actief = new BeheerPropertyDescriptor(ClubCloud_Accommodatie_Columns,ClubCloud_Accommodatie_Children["Actief"],"ClubCloud_Accommodatie_Actief");
    		extended.Add(ClubCloud_Accommodatie_Actief);
    
    		PropertyDescriptor ClubCloud_Accommodatie_Gewijzigd = new BeheerPropertyDescriptor(ClubCloud_Accommodatie_Columns,ClubCloud_Accommodatie_Children["Gewijzigd"],"ClubCloud_Accommodatie_Gewijzigd");
    		extended.Add(ClubCloud_Accommodatie_Gewijzigd);
    
    
    		//ClubCloud_Baantoplaag
    		PropertyDescriptor ClubCloud_Baantoplaag_Columns = cols["ClubCloud_Baantoplaag"];
    		PropertyDescriptorCollection ClubCloud_Baantoplaag_Children = ClubCloud_Baantoplaag_Columns.GetChildProperties();
    
    		PropertyDescriptor ClubCloud_Baantoplaag_Id = new BeheerPropertyDescriptor(ClubCloud_Baantoplaag_Columns,ClubCloud_Baantoplaag_Children["Id"],"ClubCloud_Baantoplaag_Id");
    		extended.Add(ClubCloud_Baantoplaag_Id);
    
    		PropertyDescriptor ClubCloud_Baantoplaag_Naam = new BeheerPropertyDescriptor(ClubCloud_Baantoplaag_Columns,ClubCloud_Baantoplaag_Children["Naam"],"ClubCloud_Baantoplaag_Naam");
    		extended.Add(ClubCloud_Baantoplaag_Naam);
    
    		PropertyDescriptor ClubCloud_Baantoplaag_Beschrijving = new BeheerPropertyDescriptor(ClubCloud_Baantoplaag_Columns,ClubCloud_Baantoplaag_Children["Beschrijving"],"ClubCloud_Baantoplaag_Beschrijving");
    		extended.Add(ClubCloud_Baantoplaag_Beschrijving);
    
    		PropertyDescriptor ClubCloud_Baantoplaag_Meervoud = new BeheerPropertyDescriptor(ClubCloud_Baantoplaag_Columns,ClubCloud_Baantoplaag_Children["Meervoud"],"ClubCloud_Baantoplaag_Meervoud");
    		extended.Add(ClubCloud_Baantoplaag_Meervoud);
    
    		PropertyDescriptor ClubCloud_Baantoplaag_Omschrijving = new BeheerPropertyDescriptor(ClubCloud_Baantoplaag_Columns,ClubCloud_Baantoplaag_Children["Omschrijving"],"ClubCloud_Baantoplaag_Omschrijving");
    		extended.Add(ClubCloud_Baantoplaag_Omschrijving);
    
    		PropertyDescriptor ClubCloud_Baantoplaag_Code = new BeheerPropertyDescriptor(ClubCloud_Baantoplaag_Columns,ClubCloud_Baantoplaag_Children["Code"],"ClubCloud_Baantoplaag_Code");
    		extended.Add(ClubCloud_Baantoplaag_Code);
    
    		PropertyDescriptor ClubCloud_Baantoplaag_Actief = new BeheerPropertyDescriptor(ClubCloud_Baantoplaag_Columns,ClubCloud_Baantoplaag_Children["Actief"],"ClubCloud_Baantoplaag_Actief");
    		extended.Add(ClubCloud_Baantoplaag_Actief);
    
    
    		if(extended.Count > 0)
    		{
    			PropertyDescriptorCollection newcols = new PropertyDescriptorCollection(extended.ToArray());
    			return newcols;
    		}
            return cols;            
        }     
    } 
    
}
