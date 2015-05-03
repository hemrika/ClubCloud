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
    [KnownType(typeof(ClubCloud_Functie))]
    [KnownType(typeof(ClubCloud_Vereniging))]
    [KnownType(typeof(ClubCloud_Gebruiker))]
    [KnownType(typeof(ClubCloud_District))]
    [KnownType(typeof(ClubCloud_Bestuursorgaan))]
    [DataContract(IsReference = true)]
    [TypeDescriptionProvider(typeof(ClubCloud_Functionaris_TypeDescriptionProvider))]
    public partial class ClubCloud_Functionaris : INotifyPropertyChanged, IDataErrorInfo, INotifyDataErrorInfo
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
        public Nullable<System.Guid> FunctieId 
    	{ 
    		get { return _functieId; } 
    		set { SetProperty(ref _functieId, value); } 
    	}
    
    	[IgnoreDataMember]
    	private Nullable<System.Guid> _functieId;
    
    	[DataMember]
        public Nullable<System.Guid> VerenigingId 
    	{ 
    		get { return _verenigingId; } 
    		set { SetProperty(ref _verenigingId, value); } 
    	}
    
    	[IgnoreDataMember]
    	private Nullable<System.Guid> _verenigingId;
    
    	[DataMember]
        public Nullable<System.Guid> GebruikerId 
    	{ 
    		get { return _gebruikerId; } 
    		set { SetProperty(ref _gebruikerId, value); } 
    	}
    
    	[IgnoreDataMember]
    	private Nullable<System.Guid> _gebruikerId;
    
    	[DataMember]
        public Nullable<System.Guid> BestuursorgaanId 
    	{ 
    		get { return _bestuursorgaanId; } 
    		set { SetProperty(ref _bestuursorgaanId, value); } 
    	}
    
    	[IgnoreDataMember]
    	private Nullable<System.Guid> _bestuursorgaanId;
    
    	[DataMember]
        public Nullable<System.Guid> DistrictId 
    	{ 
    		get { return _districtId; } 
    		set { SetProperty(ref _districtId, value); } 
    	}
    
    	[IgnoreDataMember]
    	private Nullable<System.Guid> _districtId;
    
    	[DataMember]
        public Nullable<System.DateTime> TermijnBegin 
    	{ 
    		get { return _termijnBegin; } 
    		set { SetProperty(ref _termijnBegin, value); } 
    	}
    
    	[IgnoreDataMember]
    	private Nullable<System.DateTime> _termijnBegin;
    
    	[DataMember]
        public Nullable<System.DateTime> TermijnEinde 
    	{ 
    		get { return _termijnEinde; } 
    		set { SetProperty(ref _termijnEinde, value); } 
    	}
    
    	[IgnoreDataMember]
    	private Nullable<System.DateTime> _termijnEinde;
    
    	[DataMember]
        public bool Autorisatie 
    	{ 
    		get { return _autorisatie; } 
    		set { SetProperty(ref _autorisatie, value); } 
    	}
    
    	[IgnoreDataMember]
    	private bool _autorisatie;
    
    	[DataMember]
        public string Actief 
    	{ 
    		get { return _actief; } 
    		set { SetProperty(ref _actief, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _actief;
    
    	[DataMember]
        public System.DateTime Gewijzigd 
    	{ 
    		get { return _gewijzigd; } 
    		set { SetProperty(ref _gewijzigd, value); } 
    	}
    
    	[IgnoreDataMember]
    	private System.DateTime _gewijzigd;
    
    
    
    	//[DataMember]
    	[IgnoreDataMember]
        public virtual ClubCloud_Functie ClubCloud_Functie { get; set; }
    
    	//[DataMember]
    	[IgnoreDataMember]
        public virtual ClubCloud_Vereniging ClubCloud_Vereniging { get; set; }
    
    	//[DataMember]
    	[IgnoreDataMember]
        public virtual ClubCloud_Gebruiker ClubCloud_Gebruiker { get; set; }
    
    	//[DataMember]
    	[IgnoreDataMember]
        public virtual ClubCloud_District ClubCloud_District { get; set; }
    
    	//[DataMember]
    	[IgnoreDataMember]
        public virtual ClubCloud_Bestuursorgaan ClubCloud_Bestuursorgaan { get; set; }
    
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
    
    
    public class ClubCloud_Functionaris_Mapping : EntityTypeConfiguration<ClubCloud_Functionaris>
    {
    	public ClubCloud_Functionaris_Mapping() 
    	{			
    		HasKey(m => m.Id);
    	}
    }
    
    public class ClubCloud_Functionaris_TypeDescriptionProvider : TypeDescriptionProvider
    {
        private ICustomTypeDescriptor td;
    
        public ClubCloud_Functionaris_TypeDescriptionProvider() : this(TypeDescriptor.GetProvider(typeof(ClubCloud_Functionaris))) {}
    
        public ClubCloud_Functionaris_TypeDescriptionProvider(TypeDescriptionProvider parent) : base(parent) {}
    
        public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
        {
            if (td == null)
            {
                td = base.GetTypeDescriptor(objectType, instance);
                td = new ClubCloud_Functionaris_CustomTypeDescriptor(td);
            }
    
            return td;
        }        
    }
    
    public class ClubCloud_Functionaris_CustomTypeDescriptor : CustomTypeDescriptor
    {       
        public ClubCloud_Functionaris_CustomTypeDescriptor(ICustomTypeDescriptor parent) : base(parent) {}
    
        public override PropertyDescriptorCollection GetProperties()
        {
            PropertyDescriptorCollection cols = base.GetProperties();
    		
    		List<PropertyDescriptor> extended = new List<PropertyDescriptor>();
            foreach (PropertyDescriptor item in cols)
            {
                extended.Add(item);
            }
    		//ClubCloud_Functie
    		PropertyDescriptor ClubCloud_Functie_Columns = cols["ClubCloud_Functie"];
    		PropertyDescriptorCollection ClubCloud_Functie_Children = ClubCloud_Functie_Columns.GetChildProperties();
    
    		PropertyDescriptor ClubCloud_Functie_Id = new BeheerPropertyDescriptor(ClubCloud_Functie_Columns,ClubCloud_Functie_Children["Id"],"ClubCloud_Functie_Id");
    		extended.Add(ClubCloud_Functie_Id);
    
    		PropertyDescriptor ClubCloud_Functie_Naam = new BeheerPropertyDescriptor(ClubCloud_Functie_Columns,ClubCloud_Functie_Children["Naam"],"ClubCloud_Functie_Naam");
    		extended.Add(ClubCloud_Functie_Naam);
    
    		PropertyDescriptor ClubCloud_Functie_Beschrijving = new BeheerPropertyDescriptor(ClubCloud_Functie_Columns,ClubCloud_Functie_Children["Beschrijving"],"ClubCloud_Functie_Beschrijving");
    		extended.Add(ClubCloud_Functie_Beschrijving);
    
    		PropertyDescriptor ClubCloud_Functie_Meervoud = new BeheerPropertyDescriptor(ClubCloud_Functie_Columns,ClubCloud_Functie_Children["Meervoud"],"ClubCloud_Functie_Meervoud");
    		extended.Add(ClubCloud_Functie_Meervoud);
    
    		PropertyDescriptor ClubCloud_Functie_Omschrijving = new BeheerPropertyDescriptor(ClubCloud_Functie_Columns,ClubCloud_Functie_Children["Omschrijving"],"ClubCloud_Functie_Omschrijving");
    		extended.Add(ClubCloud_Functie_Omschrijving);
    
    		PropertyDescriptor ClubCloud_Functie_Toegang = new BeheerPropertyDescriptor(ClubCloud_Functie_Columns,ClubCloud_Functie_Children["Toegang"],"ClubCloud_Functie_Toegang");
    		extended.Add(ClubCloud_Functie_Toegang);
    
    		PropertyDescriptor ClubCloud_Functie_Code = new BeheerPropertyDescriptor(ClubCloud_Functie_Columns,ClubCloud_Functie_Children["Code"],"ClubCloud_Functie_Code");
    		extended.Add(ClubCloud_Functie_Code);
    
    		PropertyDescriptor ClubCloud_Functie_Actief = new BeheerPropertyDescriptor(ClubCloud_Functie_Columns,ClubCloud_Functie_Children["Actief"],"ClubCloud_Functie_Actief");
    		extended.Add(ClubCloud_Functie_Actief);
    
    
    		//ClubCloud_Vereniging
    		PropertyDescriptor ClubCloud_Vereniging_Columns = cols["ClubCloud_Vereniging"];
    		PropertyDescriptorCollection ClubCloud_Vereniging_Children = ClubCloud_Vereniging_Columns.GetChildProperties();
    
    		PropertyDescriptor ClubCloud_Vereniging_Id = new BeheerPropertyDescriptor(ClubCloud_Vereniging_Columns,ClubCloud_Vereniging_Children["Id"],"ClubCloud_Vereniging_Id");
    		extended.Add(ClubCloud_Vereniging_Id);
    
    		PropertyDescriptor ClubCloud_Vereniging_Naam = new BeheerPropertyDescriptor(ClubCloud_Vereniging_Columns,ClubCloud_Vereniging_Children["Naam"],"ClubCloud_Vereniging_Naam");
    		extended.Add(ClubCloud_Vereniging_Naam);
    
    		PropertyDescriptor ClubCloud_Vereniging_Beschrijving = new BeheerPropertyDescriptor(ClubCloud_Vereniging_Columns,ClubCloud_Vereniging_Children["Beschrijving"],"ClubCloud_Vereniging_Beschrijving");
    		extended.Add(ClubCloud_Vereniging_Beschrijving);
    
    		PropertyDescriptor ClubCloud_Vereniging_Nummer = new BeheerPropertyDescriptor(ClubCloud_Vereniging_Columns,ClubCloud_Vereniging_Children["Nummer"],"ClubCloud_Vereniging_Nummer");
    		extended.Add(ClubCloud_Vereniging_Nummer);
    
    		PropertyDescriptor ClubCloud_Vereniging_DistrictId = new BeheerPropertyDescriptor(ClubCloud_Vereniging_Columns,ClubCloud_Vereniging_Children["DistrictId"],"ClubCloud_Vereniging_DistrictId");
    		extended.Add(ClubCloud_Vereniging_DistrictId);
    
    		PropertyDescriptor ClubCloud_Vereniging_RechtsvormId = new BeheerPropertyDescriptor(ClubCloud_Vereniging_Columns,ClubCloud_Vereniging_Children["RechtsvormId"],"ClubCloud_Vereniging_RechtsvormId");
    		extended.Add(ClubCloud_Vereniging_RechtsvormId);
    
    		PropertyDescriptor ClubCloud_Vereniging_AccommodatieId = new BeheerPropertyDescriptor(ClubCloud_Vereniging_Columns,ClubCloud_Vereniging_Children["AccommodatieId"],"ClubCloud_Vereniging_AccommodatieId");
    		extended.Add(ClubCloud_Vereniging_AccommodatieId);
    
    		PropertyDescriptor ClubCloud_Vereniging_RegioId = new BeheerPropertyDescriptor(ClubCloud_Vereniging_Columns,ClubCloud_Vereniging_Children["RegioId"],"ClubCloud_Vereniging_RegioId");
    		extended.Add(ClubCloud_Vereniging_RegioId);
    
    		PropertyDescriptor ClubCloud_Vereniging_BankNummer = new BeheerPropertyDescriptor(ClubCloud_Vereniging_Columns,ClubCloud_Vereniging_Children["BankNummer"],"ClubCloud_Vereniging_BankNummer");
    		extended.Add(ClubCloud_Vereniging_BankNummer);
    
    		PropertyDescriptor ClubCloud_Vereniging_BankIban = new BeheerPropertyDescriptor(ClubCloud_Vereniging_Columns,ClubCloud_Vereniging_Children["BankIban"],"ClubCloud_Vereniging_BankIban");
    		extended.Add(ClubCloud_Vereniging_BankIban);
    
    		PropertyDescriptor ClubCloud_Vereniging_BankPlaats = new BeheerPropertyDescriptor(ClubCloud_Vereniging_Columns,ClubCloud_Vereniging_Children["BankPlaats"],"ClubCloud_Vereniging_BankPlaats");
    		extended.Add(ClubCloud_Vereniging_BankPlaats);
    
    		PropertyDescriptor ClubCloud_Vereniging_KvKnummer = new BeheerPropertyDescriptor(ClubCloud_Vereniging_Columns,ClubCloud_Vereniging_Children["KvKnummer"],"ClubCloud_Vereniging_KvKnummer");
    		extended.Add(ClubCloud_Vereniging_KvKnummer);
    
    		PropertyDescriptor ClubCloud_Vereniging_KvKplaats = new BeheerPropertyDescriptor(ClubCloud_Vereniging_Columns,ClubCloud_Vereniging_Children["KvKplaats"],"ClubCloud_Vereniging_KvKplaats");
    		extended.Add(ClubCloud_Vereniging_KvKplaats);
    
    		PropertyDescriptor ClubCloud_Vereniging_EmailKNLTB = new BeheerPropertyDescriptor(ClubCloud_Vereniging_Columns,ClubCloud_Vereniging_Children["EmailKNLTB"],"ClubCloud_Vereniging_EmailKNLTB");
    		extended.Add(ClubCloud_Vereniging_EmailKNLTB);
    
    		PropertyDescriptor ClubCloud_Vereniging_EmailWebSite = new BeheerPropertyDescriptor(ClubCloud_Vereniging_Columns,ClubCloud_Vereniging_Children["EmailWebSite"],"ClubCloud_Vereniging_EmailWebSite");
    		extended.Add(ClubCloud_Vereniging_EmailWebSite);
    
    		PropertyDescriptor ClubCloud_Vereniging_EmailOverig = new BeheerPropertyDescriptor(ClubCloud_Vereniging_Columns,ClubCloud_Vereniging_Children["EmailOverig"],"ClubCloud_Vereniging_EmailOverig");
    		extended.Add(ClubCloud_Vereniging_EmailOverig);
    
    		PropertyDescriptor ClubCloud_Vereniging_Fax = new BeheerPropertyDescriptor(ClubCloud_Vereniging_Columns,ClubCloud_Vereniging_Children["Fax"],"ClubCloud_Vereniging_Fax");
    		extended.Add(ClubCloud_Vereniging_Fax);
    
    		PropertyDescriptor ClubCloud_Vereniging_TelefoonAvond = new BeheerPropertyDescriptor(ClubCloud_Vereniging_Columns,ClubCloud_Vereniging_Children["TelefoonAvond"],"ClubCloud_Vereniging_TelefoonAvond");
    		extended.Add(ClubCloud_Vereniging_TelefoonAvond);
    
    		PropertyDescriptor ClubCloud_Vereniging_TelefoonOverdag = new BeheerPropertyDescriptor(ClubCloud_Vereniging_Columns,ClubCloud_Vereniging_Children["TelefoonOverdag"],"ClubCloud_Vereniging_TelefoonOverdag");
    		extended.Add(ClubCloud_Vereniging_TelefoonOverdag);
    
    		PropertyDescriptor ClubCloud_Vereniging_TelefoonOverig = new BeheerPropertyDescriptor(ClubCloud_Vereniging_Columns,ClubCloud_Vereniging_Children["TelefoonOverig"],"ClubCloud_Vereniging_TelefoonOverig");
    		extended.Add(ClubCloud_Vereniging_TelefoonOverig);
    
    		PropertyDescriptor ClubCloud_Vereniging_Website = new BeheerPropertyDescriptor(ClubCloud_Vereniging_Columns,ClubCloud_Vereniging_Children["Website"],"ClubCloud_Vereniging_Website");
    		extended.Add(ClubCloud_Vereniging_Website);
    
    		PropertyDescriptor ClubCloud_Vereniging_FTPsite = new BeheerPropertyDescriptor(ClubCloud_Vereniging_Columns,ClubCloud_Vereniging_Children["FTPsite"],"ClubCloud_Vereniging_FTPsite");
    		extended.Add(ClubCloud_Vereniging_FTPsite);
    
    		PropertyDescriptor ClubCloud_Vereniging_Actief = new BeheerPropertyDescriptor(ClubCloud_Vereniging_Columns,ClubCloud_Vereniging_Children["Actief"],"ClubCloud_Vereniging_Actief");
    		extended.Add(ClubCloud_Vereniging_Actief);
    
    		PropertyDescriptor ClubCloud_Vereniging_Oprichting = new BeheerPropertyDescriptor(ClubCloud_Vereniging_Columns,ClubCloud_Vereniging_Children["Oprichting"],"ClubCloud_Vereniging_Oprichting");
    		extended.Add(ClubCloud_Vereniging_Oprichting);
    
    		PropertyDescriptor ClubCloud_Vereniging_Erkenning = new BeheerPropertyDescriptor(ClubCloud_Vereniging_Columns,ClubCloud_Vereniging_Children["Erkenning"],"ClubCloud_Vereniging_Erkenning");
    		extended.Add(ClubCloud_Vereniging_Erkenning);
    
    		PropertyDescriptor ClubCloud_Vereniging_Gestopt = new BeheerPropertyDescriptor(ClubCloud_Vereniging_Columns,ClubCloud_Vereniging_Children["Gestopt"],"ClubCloud_Vereniging_Gestopt");
    		extended.Add(ClubCloud_Vereniging_Gestopt);
    
    		PropertyDescriptor ClubCloud_Vereniging_Maanden = new BeheerPropertyDescriptor(ClubCloud_Vereniging_Columns,ClubCloud_Vereniging_Children["Maanden"],"ClubCloud_Vereniging_Maanden");
    		extended.Add(ClubCloud_Vereniging_Maanden);
    
    		PropertyDescriptor ClubCloud_Vereniging_Gewijzigd = new BeheerPropertyDescriptor(ClubCloud_Vereniging_Columns,ClubCloud_Vereniging_Children["Gewijzigd"],"ClubCloud_Vereniging_Gewijzigd");
    		extended.Add(ClubCloud_Vereniging_Gewijzigd);
    
    
    		//ClubCloud_Gebruiker
    		PropertyDescriptor ClubCloud_Gebruiker_Columns = cols["ClubCloud_Gebruiker"];
    		PropertyDescriptorCollection ClubCloud_Gebruiker_Children = ClubCloud_Gebruiker_Columns.GetChildProperties();
    
    		PropertyDescriptor ClubCloud_Gebruiker_Id = new BeheerPropertyDescriptor(ClubCloud_Gebruiker_Columns,ClubCloud_Gebruiker_Children["Id"],"ClubCloud_Gebruiker_Id");
    		extended.Add(ClubCloud_Gebruiker_Id);
    
    		PropertyDescriptor ClubCloud_Gebruiker_Beschrijving = new BeheerPropertyDescriptor(ClubCloud_Gebruiker_Columns,ClubCloud_Gebruiker_Children["Beschrijving"],"ClubCloud_Gebruiker_Beschrijving");
    		extended.Add(ClubCloud_Gebruiker_Beschrijving);
    
    		PropertyDescriptor ClubCloud_Gebruiker_Bondsnummer = new BeheerPropertyDescriptor(ClubCloud_Gebruiker_Columns,ClubCloud_Gebruiker_Children["Bondsnummer"],"ClubCloud_Gebruiker_Bondsnummer");
    		extended.Add(ClubCloud_Gebruiker_Bondsnummer);
    
    		PropertyDescriptor ClubCloud_Gebruiker_Roepnaam = new BeheerPropertyDescriptor(ClubCloud_Gebruiker_Columns,ClubCloud_Gebruiker_Children["Roepnaam"],"ClubCloud_Gebruiker_Roepnaam");
    		extended.Add(ClubCloud_Gebruiker_Roepnaam);
    
    		PropertyDescriptor ClubCloud_Gebruiker_Aanhef = new BeheerPropertyDescriptor(ClubCloud_Gebruiker_Columns,ClubCloud_Gebruiker_Children["Aanhef"],"ClubCloud_Gebruiker_Aanhef");
    		extended.Add(ClubCloud_Gebruiker_Aanhef);
    
    		PropertyDescriptor ClubCloud_Gebruiker_Voornaam = new BeheerPropertyDescriptor(ClubCloud_Gebruiker_Columns,ClubCloud_Gebruiker_Children["Voornaam"],"ClubCloud_Gebruiker_Voornaam");
    		extended.Add(ClubCloud_Gebruiker_Voornaam);
    
    		PropertyDescriptor ClubCloud_Gebruiker_Voornamen = new BeheerPropertyDescriptor(ClubCloud_Gebruiker_Columns,ClubCloud_Gebruiker_Children["Voornamen"],"ClubCloud_Gebruiker_Voornamen");
    		extended.Add(ClubCloud_Gebruiker_Voornamen);
    
    		PropertyDescriptor ClubCloud_Gebruiker_Achtervoegsel = new BeheerPropertyDescriptor(ClubCloud_Gebruiker_Columns,ClubCloud_Gebruiker_Children["Achtervoegsel"],"ClubCloud_Gebruiker_Achtervoegsel");
    		extended.Add(ClubCloud_Gebruiker_Achtervoegsel);
    
    		PropertyDescriptor ClubCloud_Gebruiker_Tussenvoegsel = new BeheerPropertyDescriptor(ClubCloud_Gebruiker_Columns,ClubCloud_Gebruiker_Children["Tussenvoegsel"],"ClubCloud_Gebruiker_Tussenvoegsel");
    		extended.Add(ClubCloud_Gebruiker_Tussenvoegsel);
    
    		PropertyDescriptor ClubCloud_Gebruiker_Achternaam = new BeheerPropertyDescriptor(ClubCloud_Gebruiker_Columns,ClubCloud_Gebruiker_Children["Achternaam"],"ClubCloud_Gebruiker_Achternaam");
    		extended.Add(ClubCloud_Gebruiker_Achternaam);
    
    		PropertyDescriptor ClubCloud_Gebruiker_Voorletters = new BeheerPropertyDescriptor(ClubCloud_Gebruiker_Columns,ClubCloud_Gebruiker_Children["Voorletters"],"ClubCloud_Gebruiker_Voorletters");
    		extended.Add(ClubCloud_Gebruiker_Voorletters);
    
    		PropertyDescriptor ClubCloud_Gebruiker_EmailGeheim = new BeheerPropertyDescriptor(ClubCloud_Gebruiker_Columns,ClubCloud_Gebruiker_Children["EmailGeheim"],"ClubCloud_Gebruiker_EmailGeheim");
    		extended.Add(ClubCloud_Gebruiker_EmailGeheim);
    
    		PropertyDescriptor ClubCloud_Gebruiker_EmailKNLTB = new BeheerPropertyDescriptor(ClubCloud_Gebruiker_Columns,ClubCloud_Gebruiker_Children["EmailKNLTB"],"ClubCloud_Gebruiker_EmailKNLTB");
    		extended.Add(ClubCloud_Gebruiker_EmailKNLTB);
    
    		PropertyDescriptor ClubCloud_Gebruiker_EmailWebSite = new BeheerPropertyDescriptor(ClubCloud_Gebruiker_Columns,ClubCloud_Gebruiker_Children["EmailWebSite"],"ClubCloud_Gebruiker_EmailWebSite");
    		extended.Add(ClubCloud_Gebruiker_EmailWebSite);
    
    		PropertyDescriptor ClubCloud_Gebruiker_EmailOverig = new BeheerPropertyDescriptor(ClubCloud_Gebruiker_Columns,ClubCloud_Gebruiker_Children["EmailOverig"],"ClubCloud_Gebruiker_EmailOverig");
    		extended.Add(ClubCloud_Gebruiker_EmailOverig);
    
    		PropertyDescriptor ClubCloud_Gebruiker_TelefoonGeheim = new BeheerPropertyDescriptor(ClubCloud_Gebruiker_Columns,ClubCloud_Gebruiker_Children["TelefoonGeheim"],"ClubCloud_Gebruiker_TelefoonGeheim");
    		extended.Add(ClubCloud_Gebruiker_TelefoonGeheim);
    
    		PropertyDescriptor ClubCloud_Gebruiker_TelefoonAvond = new BeheerPropertyDescriptor(ClubCloud_Gebruiker_Columns,ClubCloud_Gebruiker_Children["TelefoonAvond"],"ClubCloud_Gebruiker_TelefoonAvond");
    		extended.Add(ClubCloud_Gebruiker_TelefoonAvond);
    
    		PropertyDescriptor ClubCloud_Gebruiker_TelefoonOverdag = new BeheerPropertyDescriptor(ClubCloud_Gebruiker_Columns,ClubCloud_Gebruiker_Children["TelefoonOverdag"],"ClubCloud_Gebruiker_TelefoonOverdag");
    		extended.Add(ClubCloud_Gebruiker_TelefoonOverdag);
    
    		PropertyDescriptor ClubCloud_Gebruiker_TelefoonOverig = new BeheerPropertyDescriptor(ClubCloud_Gebruiker_Columns,ClubCloud_Gebruiker_Children["TelefoonOverig"],"ClubCloud_Gebruiker_TelefoonOverig");
    		extended.Add(ClubCloud_Gebruiker_TelefoonOverig);
    
    		PropertyDescriptor ClubCloud_Gebruiker_Mobiel = new BeheerPropertyDescriptor(ClubCloud_Gebruiker_Columns,ClubCloud_Gebruiker_Children["Mobiel"],"ClubCloud_Gebruiker_Mobiel");
    		extended.Add(ClubCloud_Gebruiker_Mobiel);
    
    		PropertyDescriptor ClubCloud_Gebruiker_Fax = new BeheerPropertyDescriptor(ClubCloud_Gebruiker_Columns,ClubCloud_Gebruiker_Children["Fax"],"ClubCloud_Gebruiker_Fax");
    		extended.Add(ClubCloud_Gebruiker_Fax);
    
    		PropertyDescriptor ClubCloud_Gebruiker_BankNummer = new BeheerPropertyDescriptor(ClubCloud_Gebruiker_Columns,ClubCloud_Gebruiker_Children["BankNummer"],"ClubCloud_Gebruiker_BankNummer");
    		extended.Add(ClubCloud_Gebruiker_BankNummer);
    
    		PropertyDescriptor ClubCloud_Gebruiker_BankIban = new BeheerPropertyDescriptor(ClubCloud_Gebruiker_Columns,ClubCloud_Gebruiker_Children["BankIban"],"ClubCloud_Gebruiker_BankIban");
    		extended.Add(ClubCloud_Gebruiker_BankIban);
    
    		PropertyDescriptor ClubCloud_Gebruiker_BankPlaats = new BeheerPropertyDescriptor(ClubCloud_Gebruiker_Columns,ClubCloud_Gebruiker_Children["BankPlaats"],"ClubCloud_Gebruiker_BankPlaats");
    		extended.Add(ClubCloud_Gebruiker_BankPlaats);
    
    		PropertyDescriptor ClubCloud_Gebruiker_Geboortedatum = new BeheerPropertyDescriptor(ClubCloud_Gebruiker_Columns,ClubCloud_Gebruiker_Children["Geboortedatum"],"ClubCloud_Gebruiker_Geboortedatum");
    		extended.Add(ClubCloud_Gebruiker_Geboortedatum);
    
    		PropertyDescriptor ClubCloud_Gebruiker_Geboorteplaats = new BeheerPropertyDescriptor(ClubCloud_Gebruiker_Columns,ClubCloud_Gebruiker_Children["Geboorteplaats"],"ClubCloud_Gebruiker_Geboorteplaats");
    		extended.Add(ClubCloud_Gebruiker_Geboorteplaats);
    
    		PropertyDescriptor ClubCloud_Gebruiker_OverlijdensDatum = new BeheerPropertyDescriptor(ClubCloud_Gebruiker_Columns,ClubCloud_Gebruiker_Children["OverlijdensDatum"],"ClubCloud_Gebruiker_OverlijdensDatum");
    		extended.Add(ClubCloud_Gebruiker_OverlijdensDatum);
    
    		PropertyDescriptor ClubCloud_Gebruiker_AddressGeheim = new BeheerPropertyDescriptor(ClubCloud_Gebruiker_Columns,ClubCloud_Gebruiker_Children["AddressGeheim"],"ClubCloud_Gebruiker_AddressGeheim");
    		extended.Add(ClubCloud_Gebruiker_AddressGeheim);
    
    		PropertyDescriptor ClubCloud_Gebruiker_NationaliteitId = new BeheerPropertyDescriptor(ClubCloud_Gebruiker_Columns,ClubCloud_Gebruiker_Children["NationaliteitId"],"ClubCloud_Gebruiker_NationaliteitId");
    		extended.Add(ClubCloud_Gebruiker_NationaliteitId);
    
    		PropertyDescriptor ClubCloud_Gebruiker_Website = new BeheerPropertyDescriptor(ClubCloud_Gebruiker_Columns,ClubCloud_Gebruiker_Children["Website"],"ClubCloud_Gebruiker_Website");
    		extended.Add(ClubCloud_Gebruiker_Website);
    
    		PropertyDescriptor ClubCloud_Gebruiker_FTPsite = new BeheerPropertyDescriptor(ClubCloud_Gebruiker_Columns,ClubCloud_Gebruiker_Children["FTPsite"],"ClubCloud_Gebruiker_FTPsite");
    		extended.Add(ClubCloud_Gebruiker_FTPsite);
    
    		PropertyDescriptor ClubCloud_Gebruiker_Actief = new BeheerPropertyDescriptor(ClubCloud_Gebruiker_Columns,ClubCloud_Gebruiker_Children["Actief"],"ClubCloud_Gebruiker_Actief");
    		extended.Add(ClubCloud_Gebruiker_Actief);
    
    		PropertyDescriptor ClubCloud_Gebruiker_Beroep = new BeheerPropertyDescriptor(ClubCloud_Gebruiker_Columns,ClubCloud_Gebruiker_Children["Beroep"],"ClubCloud_Gebruiker_Beroep");
    		extended.Add(ClubCloud_Gebruiker_Beroep);
    
    		PropertyDescriptor ClubCloud_Gebruiker_Kinderen = new BeheerPropertyDescriptor(ClubCloud_Gebruiker_Columns,ClubCloud_Gebruiker_Children["Kinderen"],"ClubCloud_Gebruiker_Kinderen");
    		extended.Add(ClubCloud_Gebruiker_Kinderen);
    
    		PropertyDescriptor ClubCloud_Gebruiker_KinderenAantal = new BeheerPropertyDescriptor(ClubCloud_Gebruiker_Columns,ClubCloud_Gebruiker_Children["KinderenAantal"],"ClubCloud_Gebruiker_KinderenAantal");
    		extended.Add(ClubCloud_Gebruiker_KinderenAantal);
    
    		PropertyDescriptor ClubCloud_Gebruiker_Partner = new BeheerPropertyDescriptor(ClubCloud_Gebruiker_Columns,ClubCloud_Gebruiker_Children["Partner"],"ClubCloud_Gebruiker_Partner");
    		extended.Add(ClubCloud_Gebruiker_Partner);
    
    		PropertyDescriptor ClubCloud_Gebruiker_AanhefBrief = new BeheerPropertyDescriptor(ClubCloud_Gebruiker_Columns,ClubCloud_Gebruiker_Children["AanhefBrief"],"ClubCloud_Gebruiker_AanhefBrief");
    		extended.Add(ClubCloud_Gebruiker_AanhefBrief);
    
    		PropertyDescriptor ClubCloud_Gebruiker_AanhefAttentie = new BeheerPropertyDescriptor(ClubCloud_Gebruiker_Columns,ClubCloud_Gebruiker_Children["AanhefAttentie"],"ClubCloud_Gebruiker_AanhefAttentie");
    		extended.Add(ClubCloud_Gebruiker_AanhefAttentie);
    
    		PropertyDescriptor ClubCloud_Gebruiker_FotoId = new BeheerPropertyDescriptor(ClubCloud_Gebruiker_Columns,ClubCloud_Gebruiker_Children["FotoId"],"ClubCloud_Gebruiker_FotoId");
    		extended.Add(ClubCloud_Gebruiker_FotoId);
    
    		PropertyDescriptor ClubCloud_Gebruiker_VerenigingId = new BeheerPropertyDescriptor(ClubCloud_Gebruiker_Columns,ClubCloud_Gebruiker_Children["VerenigingId"],"ClubCloud_Gebruiker_VerenigingId");
    		extended.Add(ClubCloud_Gebruiker_VerenigingId);
    
    		PropertyDescriptor ClubCloud_Gebruiker_Volledigenaam = new BeheerPropertyDescriptor(ClubCloud_Gebruiker_Columns,ClubCloud_Gebruiker_Children["Volledigenaam"],"ClubCloud_Gebruiker_Volledigenaam");
    		extended.Add(ClubCloud_Gebruiker_Volledigenaam);
    
    		PropertyDescriptor ClubCloud_Gebruiker_Geslacht = new BeheerPropertyDescriptor(ClubCloud_Gebruiker_Columns,ClubCloud_Gebruiker_Children["Geslacht"],"ClubCloud_Gebruiker_Geslacht");
    		extended.Add(ClubCloud_Gebruiker_Geslacht);
    
    		PropertyDescriptor ClubCloud_Gebruiker_Gewijzigd = new BeheerPropertyDescriptor(ClubCloud_Gebruiker_Columns,ClubCloud_Gebruiker_Children["Gewijzigd"],"ClubCloud_Gebruiker_Gewijzigd");
    		extended.Add(ClubCloud_Gebruiker_Gewijzigd);
    
    
    		//ClubCloud_District
    		PropertyDescriptor ClubCloud_District_Columns = cols["ClubCloud_District"];
    		PropertyDescriptorCollection ClubCloud_District_Children = ClubCloud_District_Columns.GetChildProperties();
    
    		PropertyDescriptor ClubCloud_District_Id = new BeheerPropertyDescriptor(ClubCloud_District_Columns,ClubCloud_District_Children["Id"],"ClubCloud_District_Id");
    		extended.Add(ClubCloud_District_Id);
    
    		PropertyDescriptor ClubCloud_District_Naam = new BeheerPropertyDescriptor(ClubCloud_District_Columns,ClubCloud_District_Children["Naam"],"ClubCloud_District_Naam");
    		extended.Add(ClubCloud_District_Naam);
    
    		PropertyDescriptor ClubCloud_District_Beschrijving = new BeheerPropertyDescriptor(ClubCloud_District_Columns,ClubCloud_District_Children["Beschrijving"],"ClubCloud_District_Beschrijving");
    		extended.Add(ClubCloud_District_Beschrijving);
    
    		PropertyDescriptor ClubCloud_District_Omschrijving = new BeheerPropertyDescriptor(ClubCloud_District_Columns,ClubCloud_District_Children["Omschrijving"],"ClubCloud_District_Omschrijving");
    		extended.Add(ClubCloud_District_Omschrijving);
    
    		PropertyDescriptor ClubCloud_District_RegioId = new BeheerPropertyDescriptor(ClubCloud_District_Columns,ClubCloud_District_Children["RegioId"],"ClubCloud_District_RegioId");
    		extended.Add(ClubCloud_District_RegioId);
    
    		PropertyDescriptor ClubCloud_District_Actief = new BeheerPropertyDescriptor(ClubCloud_District_Columns,ClubCloud_District_Children["Actief"],"ClubCloud_District_Actief");
    		extended.Add(ClubCloud_District_Actief);
    
    
    		//ClubCloud_Bestuursorgaan
    		PropertyDescriptor ClubCloud_Bestuursorgaan_Columns = cols["ClubCloud_Bestuursorgaan"];
    		PropertyDescriptorCollection ClubCloud_Bestuursorgaan_Children = ClubCloud_Bestuursorgaan_Columns.GetChildProperties();
    
    		PropertyDescriptor ClubCloud_Bestuursorgaan_Id = new BeheerPropertyDescriptor(ClubCloud_Bestuursorgaan_Columns,ClubCloud_Bestuursorgaan_Children["Id"],"ClubCloud_Bestuursorgaan_Id");
    		extended.Add(ClubCloud_Bestuursorgaan_Id);
    
    		PropertyDescriptor ClubCloud_Bestuursorgaan_Naam = new BeheerPropertyDescriptor(ClubCloud_Bestuursorgaan_Columns,ClubCloud_Bestuursorgaan_Children["Naam"],"ClubCloud_Bestuursorgaan_Naam");
    		extended.Add(ClubCloud_Bestuursorgaan_Naam);
    
    		PropertyDescriptor ClubCloud_Bestuursorgaan_Beschrijving = new BeheerPropertyDescriptor(ClubCloud_Bestuursorgaan_Columns,ClubCloud_Bestuursorgaan_Children["Beschrijving"],"ClubCloud_Bestuursorgaan_Beschrijving");
    		extended.Add(ClubCloud_Bestuursorgaan_Beschrijving);
    
    		PropertyDescriptor ClubCloud_Bestuursorgaan_VerenigingId = new BeheerPropertyDescriptor(ClubCloud_Bestuursorgaan_Columns,ClubCloud_Bestuursorgaan_Children["VerenigingId"],"ClubCloud_Bestuursorgaan_VerenigingId");
    		extended.Add(ClubCloud_Bestuursorgaan_VerenigingId);
    
    		PropertyDescriptor ClubCloud_Bestuursorgaan_Groep = new BeheerPropertyDescriptor(ClubCloud_Bestuursorgaan_Columns,ClubCloud_Bestuursorgaan_Children["Groep"],"ClubCloud_Bestuursorgaan_Groep");
    		extended.Add(ClubCloud_Bestuursorgaan_Groep);
    
    		PropertyDescriptor ClubCloud_Bestuursorgaan_Actief = new BeheerPropertyDescriptor(ClubCloud_Bestuursorgaan_Columns,ClubCloud_Bestuursorgaan_Children["Actief"],"ClubCloud_Bestuursorgaan_Actief");
    		extended.Add(ClubCloud_Bestuursorgaan_Actief);
    
    
    		if(extended.Count > 0)
    		{
    			PropertyDescriptorCollection newcols = new PropertyDescriptorCollection(extended.ToArray());
    			return newcols;
    		}
            return cols;            
        }     
    } 
    
}
