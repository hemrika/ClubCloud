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
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    [Serializable]
    [KnownType(typeof(ClubCloud_Functionaris))]
    [KnownType(typeof(ClubCloud_Lidmaatschap))]
    [KnownType(typeof(ClubCloud_Bestuursorgaan))]
    [KnownType(typeof(ClubCloud_District))]
    [KnownType(typeof(ClubCloud_Rechtsvorm))]
    [KnownType(typeof(ClubCloud_Accommodatie))]
    [KnownType(typeof(ClubCloud_Address))]
    [KnownType(typeof(ClubCloud_Regio))]
    [KnownType(typeof(ClubCloud_Gebruiker))]
    [KnownType(typeof(ClubCloud_Afhang))]
    [KnownType(typeof(ClubCloud_Sponsor))]
    [KnownType(typeof(ClubCloud_Setting))]
    [KnownType(typeof(ClubCloud_Baanschema))]
    [KnownType(typeof(ClubCloud_Lidmaatschapsoort))]
    [DataContract]
    [TypeDescriptionProvider(typeof(ClubCloud_Vereniging_TypeDescriptionProvider))]
    public partial class ClubCloud_Vereniging : INotifyPropertyChanged, IDataErrorInfo, INotifyDataErrorInfo, ICloneable
    {
    	public ClubCloud_Vereniging()
    	{
    		this.ClubCloud_Functionaris = new ObservableCollection<ClubCloud_Functionaris>();
    		this.ClubCloud_Lidmaatschap = new ObservableCollection<ClubCloud_Lidmaatschap>();
    		this.ClubCloud_Bestuursorgaan = new ObservableCollection<ClubCloud_Bestuursorgaan>();
    		this.ClubCloud_Address = new ObservableCollection<ClubCloud_Address>();
    		this.ClubCloud_Gebruiker = new ObservableCollection<ClubCloud_Gebruiker>();
    		this.ClubCloud_Afhang = new ObservableCollection<ClubCloud_Afhang>();
    		this.ClubCloud_Sponsor = new ObservableCollection<ClubCloud_Sponsor>();
    		this.ClubCloud_Setting = new ObservableCollection<ClubCloud_Setting>();
    		this.ClubCloud_Baanschema = new ObservableCollection<ClubCloud_Baanschema>();
    		this.ClubCloud_Lidmaatschapsoort = new ObservableCollection<ClubCloud_Lidmaatschapsoort>();
    	}
          
    	//[Key()]
    	[DatabaseGenerated(DatabaseGeneratedOption.None)]
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
    	public string Beschrijving 
    	{ 
    		get { return _beschrijving; } 
    		set { SetProperty(ref _beschrijving, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _beschrijving;
    
    	[DataMember]
    	public string Nummer 
    	{ 
    		get { return _nummer; } 
    		set { SetProperty(ref _nummer, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _nummer;
    
    	[DataMember]
    	public Nullable<System.Guid> DistrictId 
    	{ 
    		get { return _districtId; } 
    		set { SetProperty(ref _districtId, value); } 
    	}
    
    	[IgnoreDataMember]
    	private Nullable<System.Guid> _districtId;
    
    	[DisplayName("Rechtsvorm")]
    	[Description("De rechtsvorm waaronder uw vereniging is ingeschreven bij de KvK.")]	
    	[DataMember]
    	public Nullable<System.Guid> RechtsvormId 
    	{ 
    		get { return _rechtsvormId; } 
    		set { SetProperty(ref _rechtsvormId, value); } 
    	}
    
    	[IgnoreDataMember]
    	private Nullable<System.Guid> _rechtsvormId;
    
    	[DataMember]
    	public Nullable<System.Guid> AccommodatieId 
    	{ 
    		get { return _accommodatieId; } 
    		set { SetProperty(ref _accommodatieId, value); } 
    	}
    
    	[IgnoreDataMember]
    	private Nullable<System.Guid> _accommodatieId;
    
    	[DataMember]
    	public Nullable<System.Guid> RegioId 
    	{ 
    		get { return _regioId; } 
    		set { SetProperty(ref _regioId, value); } 
    	}
    
    	[IgnoreDataMember]
    	private Nullable<System.Guid> _regioId;
    
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
    	public string KvKnummer 
    	{ 
    		get { return _kvKnummer; } 
    		set { SetProperty(ref _kvKnummer, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _kvKnummer;
    
    	[DataMember]
    	public string KvKplaats 
    	{ 
    		get { return _kvKplaats; } 
    		set { SetProperty(ref _kvKplaats, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _kvKplaats;
    
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
    	public string Fax 
    	{ 
    		get { return _fax; } 
    		set { SetProperty(ref _fax, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _fax;
    
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
    	public ActiefSoort Actief 
    	{ 
    		get { return _actief; } 
    		set { SetProperty(ref _actief, value); } 
    	}
    
    	[IgnoreDataMember]
    	private ActiefSoort _actief;
    
    	[DataMember]
    	public Nullable<System.DateTime> Oprichting 
    	{ 
    		get { return _oprichting; } 
    		set { SetProperty(ref _oprichting, value); } 
    	}
    
    	[IgnoreDataMember]
    	private Nullable<System.DateTime> _oprichting;
    
    	[DataMember]
    	public Nullable<System.DateTime> Erkenning 
    	{ 
    		get { return _erkenning; } 
    		set { SetProperty(ref _erkenning, value); } 
    	}
    
    	[IgnoreDataMember]
    	private Nullable<System.DateTime> _erkenning;
    
    	[DataMember]
    	public Nullable<System.DateTime> Gestopt 
    	{ 
    		get { return _gestopt; } 
    		set { SetProperty(ref _gestopt, value); } 
    	}
    
    	[IgnoreDataMember]
    	private Nullable<System.DateTime> _gestopt;
    
    	[DataMember]
    	public int Maanden 
    	{ 
    		get { return _maanden; } 
    		set { SetProperty(ref _maanden, value); } 
    	}
    
    	[IgnoreDataMember]
    	private int _maanden;
    
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
    	public virtual ObservableCollection<ClubCloud_Bestuursorgaan> ClubCloud_Bestuursorgaan { get; set; }
    
    	//[DataMember]
    	[IgnoreDataMember]
    	public virtual ClubCloud_District ClubCloud_District { get; set; }
    
    	//[DataMember]
    	[IgnoreDataMember]
    	public virtual ClubCloud_Rechtsvorm ClubCloud_Rechtsvorm { get; set; }
    
    	//[DataMember]
    	[IgnoreDataMember]
    	public virtual ClubCloud_Accommodatie ClubCloud_Accommodatie { get; set; }
    
    	//[DataMember]
    	[IgnoreDataMember]
    	public virtual ObservableCollection<ClubCloud_Address> ClubCloud_Address { get; set; }
    
    	//[DataMember]
    	[IgnoreDataMember]
    	public virtual ClubCloud_Regio ClubCloud_Regio { get; set; }
    
    	//[DataMember]
    	[IgnoreDataMember]
    	public virtual ObservableCollection<ClubCloud_Gebruiker> ClubCloud_Gebruiker { get; set; }
    
    	//[DataMember]
    	[IgnoreDataMember]
    	public virtual ObservableCollection<ClubCloud_Afhang> ClubCloud_Afhang { get; set; }
    
    	//[DataMember]
    	[IgnoreDataMember]
    	public virtual ObservableCollection<ClubCloud_Sponsor> ClubCloud_Sponsor { get; set; }
    
    	//[DataMember]
    	[IgnoreDataMember]
    	public virtual ObservableCollection<ClubCloud_Setting> ClubCloud_Setting { get; set; }
    
    	//[DataMember]
    	[IgnoreDataMember]
    	public virtual ObservableCollection<ClubCloud_Baanschema> ClubCloud_Baanschema { get; set; }
    
    	//[DataMember]
    	[IgnoreDataMember]
    	public virtual ObservableCollection<ClubCloud_Lidmaatschapsoort> ClubCloud_Lidmaatschapsoort { get; set; }
    
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
    
    	public object Clone()
        {
            return (this.MemberwiseClone());
        }
    }
    
    
    public class ClubCloud_Vereniging_Mapping : EntityTypeConfiguration<ClubCloud_Vereniging>
    {
    	public ClubCloud_Vereniging_Mapping() 
    	{
    		//System.Guid
    		HasKey(m => m.Id);
    	}
    }
    
    public class ClubCloud_Vereniging_TypeDescriptionProvider : TypeDescriptionProvider
    {
    	private ICustomTypeDescriptor td;
    
    	public ClubCloud_Vereniging_TypeDescriptionProvider() : this(TypeDescriptor.GetProvider(typeof(ClubCloud_Vereniging))) {}
    
    	public ClubCloud_Vereniging_TypeDescriptionProvider(TypeDescriptionProvider parent) : base(parent) {}
    
    	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
    	{
    		if (td == null)
    		{
    			td = base.GetTypeDescriptor(objectType, instance);
    			td = new ClubCloud_Vereniging_CustomTypeDescriptor(td);
    		}
    
    		return td;
    	}        
    }
    
    public class ClubCloud_Vereniging_CustomTypeDescriptor : CustomTypeDescriptor
    {       
    	public ClubCloud_Vereniging_CustomTypeDescriptor(ICustomTypeDescriptor parent) : base(parent) {}
    
    	public override PropertyDescriptorCollection GetProperties()
    	{
    		PropertyDescriptorCollection cols = base.GetProperties();
    		
    		List<PropertyDescriptor> extended = new List<PropertyDescriptor>();
    		foreach (PropertyDescriptor item in cols)
    		{
    			extended.Add(item);
    		}
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
    
    
    		//ClubCloud_Rechtsvorm
    		PropertyDescriptor ClubCloud_Rechtsvorm_Columns = cols["ClubCloud_Rechtsvorm"];
    		PropertyDescriptorCollection ClubCloud_Rechtsvorm_Children = ClubCloud_Rechtsvorm_Columns.GetChildProperties();
    
    		PropertyDescriptor ClubCloud_Rechtsvorm_Id = new BeheerPropertyDescriptor(ClubCloud_Rechtsvorm_Columns,ClubCloud_Rechtsvorm_Children["Id"],"ClubCloud_Rechtsvorm_Id");
    		extended.Add(ClubCloud_Rechtsvorm_Id);
    
    		PropertyDescriptor ClubCloud_Rechtsvorm_Naam = new BeheerPropertyDescriptor(ClubCloud_Rechtsvorm_Columns,ClubCloud_Rechtsvorm_Children["Naam"],"ClubCloud_Rechtsvorm_Naam");
    		extended.Add(ClubCloud_Rechtsvorm_Naam);
    
    		PropertyDescriptor ClubCloud_Rechtsvorm_Omschrijving = new BeheerPropertyDescriptor(ClubCloud_Rechtsvorm_Columns,ClubCloud_Rechtsvorm_Children["Omschrijving"],"ClubCloud_Rechtsvorm_Omschrijving");
    		extended.Add(ClubCloud_Rechtsvorm_Omschrijving);
    
    		PropertyDescriptor ClubCloud_Rechtsvorm_Code = new BeheerPropertyDescriptor(ClubCloud_Rechtsvorm_Columns,ClubCloud_Rechtsvorm_Children["Code"],"ClubCloud_Rechtsvorm_Code");
    		extended.Add(ClubCloud_Rechtsvorm_Code);
    
    		PropertyDescriptor ClubCloud_Rechtsvorm_Beschrijving = new BeheerPropertyDescriptor(ClubCloud_Rechtsvorm_Columns,ClubCloud_Rechtsvorm_Children["Beschrijving"],"ClubCloud_Rechtsvorm_Beschrijving");
    		extended.Add(ClubCloud_Rechtsvorm_Beschrijving);
    
    		PropertyDescriptor ClubCloud_Rechtsvorm_Meervoud = new BeheerPropertyDescriptor(ClubCloud_Rechtsvorm_Columns,ClubCloud_Rechtsvorm_Children["Meervoud"],"ClubCloud_Rechtsvorm_Meervoud");
    		extended.Add(ClubCloud_Rechtsvorm_Meervoud);
    
    		PropertyDescriptor ClubCloud_Rechtsvorm_Actief = new BeheerPropertyDescriptor(ClubCloud_Rechtsvorm_Columns,ClubCloud_Rechtsvorm_Children["Actief"],"ClubCloud_Rechtsvorm_Actief");
    		extended.Add(ClubCloud_Rechtsvorm_Actief);
    
    
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
    
    
    		//ClubCloud_Regio
    		PropertyDescriptor ClubCloud_Regio_Columns = cols["ClubCloud_Regio"];
    		PropertyDescriptorCollection ClubCloud_Regio_Children = ClubCloud_Regio_Columns.GetChildProperties();
    
    		PropertyDescriptor ClubCloud_Regio_Id = new BeheerPropertyDescriptor(ClubCloud_Regio_Columns,ClubCloud_Regio_Children["Id"],"ClubCloud_Regio_Id");
    		extended.Add(ClubCloud_Regio_Id);
    
    		PropertyDescriptor ClubCloud_Regio_Naam = new BeheerPropertyDescriptor(ClubCloud_Regio_Columns,ClubCloud_Regio_Children["Naam"],"ClubCloud_Regio_Naam");
    		extended.Add(ClubCloud_Regio_Naam);
    
    		PropertyDescriptor ClubCloud_Regio_EmailKNLTB = new BeheerPropertyDescriptor(ClubCloud_Regio_Columns,ClubCloud_Regio_Children["EmailKNLTB"],"ClubCloud_Regio_EmailKNLTB");
    		extended.Add(ClubCloud_Regio_EmailKNLTB);
    
    		PropertyDescriptor ClubCloud_Regio_TelefoonAvond = new BeheerPropertyDescriptor(ClubCloud_Regio_Columns,ClubCloud_Regio_Children["TelefoonAvond"],"ClubCloud_Regio_TelefoonAvond");
    		extended.Add(ClubCloud_Regio_TelefoonAvond);
    
    		PropertyDescriptor ClubCloud_Regio_TelefoonOverdag = new BeheerPropertyDescriptor(ClubCloud_Regio_Columns,ClubCloud_Regio_Children["TelefoonOverdag"],"ClubCloud_Regio_TelefoonOverdag");
    		extended.Add(ClubCloud_Regio_TelefoonOverdag);
    
    		PropertyDescriptor ClubCloud_Regio_Fax = new BeheerPropertyDescriptor(ClubCloud_Regio_Columns,ClubCloud_Regio_Children["Fax"],"ClubCloud_Regio_Fax");
    		extended.Add(ClubCloud_Regio_Fax);
    
    		PropertyDescriptor ClubCloud_Regio_Actief = new BeheerPropertyDescriptor(ClubCloud_Regio_Columns,ClubCloud_Regio_Children["Actief"],"ClubCloud_Regio_Actief");
    		extended.Add(ClubCloud_Regio_Actief);
    
    
    		if(extended.Count > 0)
    		{
    			PropertyDescriptorCollection newcols = new PropertyDescriptorCollection(extended.ToArray());
    			return newcols;
    		}
    		return cols;            
    	}     
    } 
    
}

