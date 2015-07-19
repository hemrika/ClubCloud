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
    [KnownType(typeof(ClubCloud_Vereniging))]
    [DataContract]
    [TypeDescriptionProvider(typeof(ClubCloud_Bestuursorgaan_TypeDescriptionProvider))]
    public partial class ClubCloud_Bestuursorgaan : INotifyPropertyChanged, IDataErrorInfo, INotifyDataErrorInfo, ICloneable
    {
    	public ClubCloud_Bestuursorgaan()
    	{
    		this.ClubCloud_Functionaris = new ObservableCollection<ClubCloud_Functionaris>();
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
    	public Nullable<System.Guid> VerenigingId 
    	{ 
    		get { return _verenigingId; } 
    		set { SetProperty(ref _verenigingId, value); } 
    	}
    
    	[IgnoreDataMember]
    	private Nullable<System.Guid> _verenigingId;
    
    	[DataMember]
    	public string Groep 
    	{ 
    		get { return _groep; } 
    		set { SetProperty(ref _groep, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _groep;
    
    	[DataMember]
    	public ActiefSoort Actief 
    	{ 
    		get { return _actief; } 
    		set { SetProperty(ref _actief, value); } 
    	}
    
    	[IgnoreDataMember]
    	private ActiefSoort _actief;
    
    
    
    	//[DataMember]
    	[IgnoreDataMember]
    	public virtual ObservableCollection<ClubCloud_Functionaris> ClubCloud_Functionaris { get; set; }
    
    	//[DataMember]
    	[IgnoreDataMember]
    	public virtual ClubCloud_Vereniging ClubCloud_Vereniging { get; set; }
    
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
    
    
    public class ClubCloud_Bestuursorgaan_Mapping : EntityTypeConfiguration<ClubCloud_Bestuursorgaan>
    {
    	public ClubCloud_Bestuursorgaan_Mapping() 
    	{
    		//System.Guid
    		HasKey(m => m.Id);
    	}
    }
    
    public class ClubCloud_Bestuursorgaan_TypeDescriptionProvider : TypeDescriptionProvider
    {
    	private ICustomTypeDescriptor td;
    
    	public ClubCloud_Bestuursorgaan_TypeDescriptionProvider() : this(TypeDescriptor.GetProvider(typeof(ClubCloud_Bestuursorgaan))) {}
    
    	public ClubCloud_Bestuursorgaan_TypeDescriptionProvider(TypeDescriptionProvider parent) : base(parent) {}
    
    	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
    	{
    		if (td == null)
    		{
    			td = base.GetTypeDescriptor(objectType, instance);
    			td = new ClubCloud_Bestuursorgaan_CustomTypeDescriptor(td);
    		}
    
    		return td;
    	}        
    }
    
    public class ClubCloud_Bestuursorgaan_CustomTypeDescriptor : CustomTypeDescriptor
    {       
    	public ClubCloud_Bestuursorgaan_CustomTypeDescriptor(ICustomTypeDescriptor parent) : base(parent) {}
    
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
    
    
    		if(extended.Count > 0)
    		{
    			PropertyDescriptorCollection newcols = new PropertyDescriptorCollection(extended.ToArray());
    			return newcols;
    		}
    		return cols;            
    	}     
    } 
    
}
