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
    [KnownType(typeof(ClubCloud_Functionaris))]
    [KnownType(typeof(ClubCloud_Lidmaatschap))]
    [KnownType(typeof(ClubCloud_Address))]
    [KnownType(typeof(ClubCloud_Vereniging))]
    [KnownType(typeof(ClubCloud_Profiel))]
    [KnownType(typeof(ClubCloud_Reservering))]
    [KnownType(typeof(ClubCloud_Setting))]
    [KnownType(typeof(ClubCloud_Nationaliteit))]
    [DataContract(IsReference = true)]
    [TypeDescriptionProvider(typeof(ClubCloud_Gebruiker_TypeDescriptionProvider))]
    public partial class ClubCloud_Gebruiker : INotifyPropertyChanged, IDataErrorInfo, INotifyDataErrorInfo
    {
        public ClubCloud_Gebruiker()
        {
            this.ClubCloud_Functionaris = new ObservableCollection<ClubCloud_Functionaris>();
            this.ClubCloud_Lidmaatschap = new ObservableCollection<ClubCloud_Lidmaatschap>();
            this.ClubCloud_Address = new ObservableCollection<ClubCloud_Address>();
            this.ClubCloud_Profiel = new ObservableCollection<ClubCloud_Profiel>();
            this.ClubCloud_Reservering_Een = new ObservableCollection<ClubCloud_Reservering>();
            this.ClubCloud_Reservering_Twee = new ObservableCollection<ClubCloud_Reservering>();
            this.ClubCloud_Reservering_Drie = new ObservableCollection<ClubCloud_Reservering>();
            this.ClubCloud_Reservering_Vier = new ObservableCollection<ClubCloud_Reservering>();
            this.ClubCloud_Setting = new ObservableCollection<ClubCloud_Setting>();
        }
    	[DataMember]
        public System.Guid Id 
    	{ 
    		get { return _id; } 
    		set { SetProperty(ref _id, value); } 
    	}
    
    	[IgnoreDataMember]
    	private System.Guid _id;
    
    	[DataMember]
        public string Beschrijving 
    	{ 
    		get { return _beschrijving; } 
    		set { SetProperty(ref _beschrijving, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _beschrijving;
    
    	[DataMember]
        public string Bondsnummer 
    	{ 
    		get { return _bondsnummer; } 
    		set { SetProperty(ref _bondsnummer, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _bondsnummer;
    
    	[DataMember]
        public string Roepnaam 
    	{ 
    		get { return _roepnaam; } 
    		set { SetProperty(ref _roepnaam, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _roepnaam;
    
    	[DataMember]
        public string Aanhef 
    	{ 
    		get { return _aanhef; } 
    		set { SetProperty(ref _aanhef, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _aanhef;
    
    	[DataMember]
        public string Voornaam 
    	{ 
    		get { return _voornaam; } 
    		set { SetProperty(ref _voornaam, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _voornaam;
    
    	[DataMember]
        public string Voornamen 
    	{ 
    		get { return _voornamen; } 
    		set { SetProperty(ref _voornamen, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _voornamen;
    
    	[DataMember]
        public string Achtervoegsel 
    	{ 
    		get { return _achtervoegsel; } 
    		set { SetProperty(ref _achtervoegsel, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _achtervoegsel;
    
    	[DataMember]
        public string Tussenvoegsel 
    	{ 
    		get { return _tussenvoegsel; } 
    		set { SetProperty(ref _tussenvoegsel, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _tussenvoegsel;
    
    	[DataMember]
        public string Achternaam 
    	{ 
    		get { return _achternaam; } 
    		set { SetProperty(ref _achternaam, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _achternaam;
    
    	[DataMember]
        public string Voorletters 
    	{ 
    		get { return _voorletters; } 
    		set { SetProperty(ref _voorletters, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _voorletters;
    
    	[DataMember]
        public bool EmailGeheim 
    	{ 
    		get { return _emailGeheim; } 
    		set { SetProperty(ref _emailGeheim, value); } 
    	}
    
    	[IgnoreDataMember]
    	private bool _emailGeheim;
    
    	[DataMember]
        public string EmailKNLTB 
    	{ 
    		get { return _emailKNLTB; } 
    		set { SetProperty(ref _emailKNLTB, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _emailKNLTB;
    
    	[DataMember]
        public string EmailWebSite 
    	{ 
    		get { return _emailWebSite; } 
    		set { SetProperty(ref _emailWebSite, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _emailWebSite;
    
    	[DataMember]
        public string EmailOverig 
    	{ 
    		get { return _emailOverig; } 
    		set { SetProperty(ref _emailOverig, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _emailOverig;
    
    	[DataMember]
        public bool TelefoonGeheim 
    	{ 
    		get { return _telefoonGeheim; } 
    		set { SetProperty(ref _telefoonGeheim, value); } 
    	}
    
    	[IgnoreDataMember]
    	private bool _telefoonGeheim;
    
    	[DataMember]
        public string TelefoonAvond 
    	{ 
    		get { return _telefoonAvond; } 
    		set { SetProperty(ref _telefoonAvond, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _telefoonAvond;
    
    	[DataMember]
        public string TelefoonOverdag 
    	{ 
    		get { return _telefoonOverdag; } 
    		set { SetProperty(ref _telefoonOverdag, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _telefoonOverdag;
    
    	[DataMember]
        public string TelefoonOverig 
    	{ 
    		get { return _telefoonOverig; } 
    		set { SetProperty(ref _telefoonOverig, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _telefoonOverig;
    
    	[DataMember]
        public string Mobiel 
    	{ 
    		get { return _mobiel; } 
    		set { SetProperty(ref _mobiel, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _mobiel;
    
    	[DataMember]
        public string Fax 
    	{ 
    		get { return _fax; } 
    		set { SetProperty(ref _fax, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _fax;
    
    	[DataMember]
        public string BankNummer 
    	{ 
    		get { return _bankNummer; } 
    		set { SetProperty(ref _bankNummer, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _bankNummer;
    
    	[DataMember]
        public string BankIban 
    	{ 
    		get { return _bankIban; } 
    		set { SetProperty(ref _bankIban, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _bankIban;
    
    	[DataMember]
        public string BankPlaats 
    	{ 
    		get { return _bankPlaats; } 
    		set { SetProperty(ref _bankPlaats, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _bankPlaats;
    
    	[DataMember]
        public Nullable<System.DateTime> Geboortedatum 
    	{ 
    		get { return _geboortedatum; } 
    		set { SetProperty(ref _geboortedatum, value); } 
    	}
    
    	[IgnoreDataMember]
    	private Nullable<System.DateTime> _geboortedatum;
    
    	[DataMember]
        public string Geboorteplaats 
    	{ 
    		get { return _geboorteplaats; } 
    		set { SetProperty(ref _geboorteplaats, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _geboorteplaats;
    
    	[DataMember]
        public Nullable<System.DateTime> OverlijdensDatum 
    	{ 
    		get { return _overlijdensDatum; } 
    		set { SetProperty(ref _overlijdensDatum, value); } 
    	}
    
    	[IgnoreDataMember]
    	private Nullable<System.DateTime> _overlijdensDatum;
    
    	[DataMember]
        public bool AddressGeheim 
    	{ 
    		get { return _addressGeheim; } 
    		set { SetProperty(ref _addressGeheim, value); } 
    	}
    
    	[IgnoreDataMember]
    	private bool _addressGeheim;
    
    	[DataMember]
        public Nullable<System.Guid> NationaliteitId 
    	{ 
    		get { return _nationaliteitId; } 
    		set { SetProperty(ref _nationaliteitId, value); } 
    	}
    
    	[IgnoreDataMember]
    	private Nullable<System.Guid> _nationaliteitId;
    
    	[DataMember]
        public string Website 
    	{ 
    		get { return _website; } 
    		set { SetProperty(ref _website, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _website;
    
    	[DataMember]
        public string FTPsite 
    	{ 
    		get { return _fTPsite; } 
    		set { SetProperty(ref _fTPsite, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _fTPsite;
    
    	[DataMember]
        public string Actief 
    	{ 
    		get { return _actief; } 
    		set { SetProperty(ref _actief, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _actief;
    
    	[DataMember]
        public string Beroep 
    	{ 
    		get { return _beroep; } 
    		set { SetProperty(ref _beroep, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _beroep;
    
    	[DataMember]
        public bool Kinderen 
    	{ 
    		get { return _kinderen; } 
    		set { SetProperty(ref _kinderen, value); } 
    	}
    
    	[IgnoreDataMember]
    	private bool _kinderen;
    
    	[DataMember]
        public int KinderenAantal 
    	{ 
    		get { return _kinderenAantal; } 
    		set { SetProperty(ref _kinderenAantal, value); } 
    	}
    
    	[IgnoreDataMember]
    	private int _kinderenAantal;
    
    	[DataMember]
        public string Partner 
    	{ 
    		get { return _partner; } 
    		set { SetProperty(ref _partner, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _partner;
    
    	[DataMember]
        public string AanhefBrief 
    	{ 
    		get { return _aanhefBrief; } 
    		set { SetProperty(ref _aanhefBrief, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _aanhefBrief;
    
    	[DataMember]
        public string AanhefAttentie 
    	{ 
    		get { return _aanhefAttentie; } 
    		set { SetProperty(ref _aanhefAttentie, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _aanhefAttentie;
    
    	[DataMember]
        public int FotoId 
    	{ 
    		get { return _fotoId; } 
    		set { SetProperty(ref _fotoId, value); } 
    	}
    
    	[IgnoreDataMember]
    	private int _fotoId;
    
    	[DataMember]
        public Nullable<System.Guid> VerenigingId 
    	{ 
    		get { return _verenigingId; } 
    		set { SetProperty(ref _verenigingId, value); } 
    	}
    
    	[IgnoreDataMember]
    	private Nullable<System.Guid> _verenigingId;
    
    	[DataMember]
        public string Volledigenaam 
    	{ 
    		get { return _volledigenaam; } 
    		set { SetProperty(ref _volledigenaam, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _volledigenaam;
    
    	[DataMember]
        public GeslachtSoort Geslacht 
    	{ 
    		get { return _geslacht; } 
    		set { SetProperty(ref _geslacht, value); } 
    	}
    
    	[IgnoreDataMember]
    	private GeslachtSoort _geslacht;
    
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
        public virtual ObservableCollection<ClubCloud_Functionaris> ClubCloud_Functionaris { get; set; }
    
    	//[DataMember]
    	[IgnoreDataMember]
        public virtual ObservableCollection<ClubCloud_Lidmaatschap> ClubCloud_Lidmaatschap { get; set; }
    
    	//[DataMember]
    	[IgnoreDataMember]
        public virtual ObservableCollection<ClubCloud_Address> ClubCloud_Address { get; set; }
    
    	//[DataMember]
    	[IgnoreDataMember]
        public virtual ClubCloud_Vereniging ClubCloud_Vereniging { get; set; }
    
    	//[DataMember]
    	[IgnoreDataMember]
        public virtual ObservableCollection<ClubCloud_Profiel> ClubCloud_Profiel { get; set; }
    
    	//[DataMember]
    	[IgnoreDataMember]
        public virtual ObservableCollection<ClubCloud_Reservering> ClubCloud_Reservering_Een { get; set; }
    
    	//[DataMember]
    	[IgnoreDataMember]
        public virtual ObservableCollection<ClubCloud_Reservering> ClubCloud_Reservering_Twee { get; set; }
    
    	//[DataMember]
    	[IgnoreDataMember]
        public virtual ObservableCollection<ClubCloud_Reservering> ClubCloud_Reservering_Drie { get; set; }
    
    	//[DataMember]
    	[IgnoreDataMember]
        public virtual ObservableCollection<ClubCloud_Reservering> ClubCloud_Reservering_Vier { get; set; }
    
    	//[DataMember]
    	[IgnoreDataMember]
        public virtual ObservableCollection<ClubCloud_Setting> ClubCloud_Setting { get; set; }
    
    	//[DataMember]
    	[IgnoreDataMember]
        public virtual ClubCloud_Nationaliteit ClubCloud_Nationaliteit { get; set; }
    
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
    
    
    public class ClubCloud_Gebruiker_Mapping : EntityTypeConfiguration<ClubCloud_Gebruiker>
    {
    	public ClubCloud_Gebruiker_Mapping() 
    	{			
    		HasKey(m => m.Id);
    	}
    }
    
    public class ClubCloud_Gebruiker_TypeDescriptionProvider : TypeDescriptionProvider
    {
        private ICustomTypeDescriptor td;
    
        public ClubCloud_Gebruiker_TypeDescriptionProvider() : this(TypeDescriptor.GetProvider(typeof(ClubCloud_Gebruiker))) {}
    
        public ClubCloud_Gebruiker_TypeDescriptionProvider(TypeDescriptionProvider parent) : base(parent) {}
    
        public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
        {
            if (td == null)
            {
                td = base.GetTypeDescriptor(objectType, instance);
                td = new ClubCloud_Gebruiker_CustomTypeDescriptor(td);
            }
    
            return td;
        }        
    }
    
    public class ClubCloud_Gebruiker_CustomTypeDescriptor : CustomTypeDescriptor
    {       
        public ClubCloud_Gebruiker_CustomTypeDescriptor(ICustomTypeDescriptor parent) : base(parent) {}
    
        public override PropertyDescriptorCollection GetProperties()
        {
            PropertyDescriptorCollection cols = base.GetProperties();
    		
    		List<PropertyDescriptor> extended = new List<PropertyDescriptor>();
            foreach (PropertyDescriptor item in cols)
            {
                extended.Add(item);
            }
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
    
    
    		//ClubCloud_Nationaliteit
    		PropertyDescriptor ClubCloud_Nationaliteit_Columns = cols["ClubCloud_Nationaliteit"];
    		PropertyDescriptorCollection ClubCloud_Nationaliteit_Children = ClubCloud_Nationaliteit_Columns.GetChildProperties();
    
    		PropertyDescriptor ClubCloud_Nationaliteit_Id = new BeheerPropertyDescriptor(ClubCloud_Nationaliteit_Columns,ClubCloud_Nationaliteit_Children["Id"],"ClubCloud_Nationaliteit_Id");
    		extended.Add(ClubCloud_Nationaliteit_Id);
    
    		PropertyDescriptor ClubCloud_Nationaliteit_Naam = new BeheerPropertyDescriptor(ClubCloud_Nationaliteit_Columns,ClubCloud_Nationaliteit_Children["Naam"],"ClubCloud_Nationaliteit_Naam");
    		extended.Add(ClubCloud_Nationaliteit_Naam);
    
    		PropertyDescriptor ClubCloud_Nationaliteit_Code = new BeheerPropertyDescriptor(ClubCloud_Nationaliteit_Columns,ClubCloud_Nationaliteit_Children["Code"],"ClubCloud_Nationaliteit_Code");
    		extended.Add(ClubCloud_Nationaliteit_Code);
    
    
    		if(extended.Count > 0)
    		{
    			PropertyDescriptorCollection newcols = new PropertyDescriptorCollection(extended.ToArray());
    			return newcols;
    		}
            return cols;            
        }     
    } 
    
}
