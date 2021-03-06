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
    [KnownType(typeof(ClubCloud_Baantype))]
    [KnownType(typeof(ClubCloud_Baanblok))]
    [DataContract]
    [TypeDescriptionProvider(typeof(ClubCloud_Baansoort_TypeDescriptionProvider))]
    public partial class ClubCloud_Baansoort : INotifyPropertyChanged, IDataErrorInfo, INotifyDataErrorInfo, ICloneable
    {
    	public ClubCloud_Baansoort()
    	{
    		this.ClubCloud_Baanblok = new ObservableCollection<ClubCloud_Baanblok>();
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
    	public Nullable<System.Guid> BaantypeId 
    	{ 
    		get { return _baantypeId; } 
    		set { SetProperty(ref _baantypeId, value); } 
    	}
    
    	[IgnoreDataMember]
    	private Nullable<System.Guid> _baantypeId;
    
    	[DataMember]
    	public string Beschrijving 
    	{ 
    		get { return _beschrijving; } 
    		set { SetProperty(ref _beschrijving, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _beschrijving;
    
    	[DataMember]
    	public string Meervoud 
    	{ 
    		get { return _meervoud; } 
    		set { SetProperty(ref _meervoud, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _meervoud;
    
    	[DataMember]
    	public string Omschrijving 
    	{ 
    		get { return _omschrijving; } 
    		set { SetProperty(ref _omschrijving, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _omschrijving;
    
    	[DataMember]
    	public string Code 
    	{ 
    		get { return _code; } 
    		set { SetProperty(ref _code, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _code;
    
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
    	public virtual ClubCloud_Baantype ClubCloud_Baantype { get; set; }
    
    	//[DataMember]
    	[IgnoreDataMember]
    	public virtual ObservableCollection<ClubCloud_Baanblok> ClubCloud_Baanblok { get; set; }
    
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
    
    
    public class ClubCloud_Baansoort_Mapping : EntityTypeConfiguration<ClubCloud_Baansoort>
    {
    	public ClubCloud_Baansoort_Mapping() 
    	{
    		//System.Guid
    		HasKey(m => m.Id);
    	}
    }
    
    public class ClubCloud_Baansoort_TypeDescriptionProvider : TypeDescriptionProvider
    {
    	private ICustomTypeDescriptor td;
    
    	public ClubCloud_Baansoort_TypeDescriptionProvider() : this(TypeDescriptor.GetProvider(typeof(ClubCloud_Baansoort))) {}
    
    	public ClubCloud_Baansoort_TypeDescriptionProvider(TypeDescriptionProvider parent) : base(parent) {}
    
    	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
    	{
    		if (td == null)
    		{
    			td = base.GetTypeDescriptor(objectType, instance);
    			td = new ClubCloud_Baansoort_CustomTypeDescriptor(td);
    		}
    
    		return td;
    	}        
    }
    
    public class ClubCloud_Baansoort_CustomTypeDescriptor : CustomTypeDescriptor
    {       
    	public ClubCloud_Baansoort_CustomTypeDescriptor(ICustomTypeDescriptor parent) : base(parent) {}
    
    	public override PropertyDescriptorCollection GetProperties()
    	{
    		PropertyDescriptorCollection cols = base.GetProperties();
    		
    		List<PropertyDescriptor> extended = new List<PropertyDescriptor>();
    		foreach (PropertyDescriptor item in cols)
    		{
    			extended.Add(item);
    		}
    		//ClubCloud_Baantype
    		PropertyDescriptor ClubCloud_Baantype_Columns = cols["ClubCloud_Baantype"];
    		PropertyDescriptorCollection ClubCloud_Baantype_Children = ClubCloud_Baantype_Columns.GetChildProperties();
    
    		PropertyDescriptor ClubCloud_Baantype_Id = new BeheerPropertyDescriptor(ClubCloud_Baantype_Columns,ClubCloud_Baantype_Children["Id"],"ClubCloud_Baantype_Id");
    		extended.Add(ClubCloud_Baantype_Id);
    
    		PropertyDescriptor ClubCloud_Baantype_Naam = new BeheerPropertyDescriptor(ClubCloud_Baantype_Columns,ClubCloud_Baantype_Children["Naam"],"ClubCloud_Baantype_Naam");
    		extended.Add(ClubCloud_Baantype_Naam);
    
    		PropertyDescriptor ClubCloud_Baantype_Beschrijving = new BeheerPropertyDescriptor(ClubCloud_Baantype_Columns,ClubCloud_Baantype_Children["Beschrijving"],"ClubCloud_Baantype_Beschrijving");
    		extended.Add(ClubCloud_Baantype_Beschrijving);
    
    		PropertyDescriptor ClubCloud_Baantype_Meervoud = new BeheerPropertyDescriptor(ClubCloud_Baantype_Columns,ClubCloud_Baantype_Children["Meervoud"],"ClubCloud_Baantype_Meervoud");
    		extended.Add(ClubCloud_Baantype_Meervoud);
    
    		PropertyDescriptor ClubCloud_Baantype_Omschrijving = new BeheerPropertyDescriptor(ClubCloud_Baantype_Columns,ClubCloud_Baantype_Children["Omschrijving"],"ClubCloud_Baantype_Omschrijving");
    		extended.Add(ClubCloud_Baantype_Omschrijving);
    
    		PropertyDescriptor ClubCloud_Baantype_Code = new BeheerPropertyDescriptor(ClubCloud_Baantype_Columns,ClubCloud_Baantype_Children["Code"],"ClubCloud_Baantype_Code");
    		extended.Add(ClubCloud_Baantype_Code);
    
    		PropertyDescriptor ClubCloud_Baantype_Actief = new BeheerPropertyDescriptor(ClubCloud_Baantype_Columns,ClubCloud_Baantype_Children["Actief"],"ClubCloud_Baantype_Actief");
    		extended.Add(ClubCloud_Baantype_Actief);
    
    
    		if(extended.Count > 0)
    		{
    			PropertyDescriptorCollection newcols = new PropertyDescriptorCollection(extended.ToArray());
    			return newcols;
    		}
    		return cols;            
    	}     
    } 
    
}
