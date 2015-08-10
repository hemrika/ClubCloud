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
    [KnownType(typeof(ClubCloud_Gebruiker))]
    [DataContract]
    [TypeDescriptionProvider(typeof(ClubCloud_Nationaliteit_TypeDescriptionProvider))]
    public partial class ClubCloud_Nationaliteit : INotifyPropertyChanged, IDataErrorInfo, INotifyDataErrorInfo, ICloneable
    {
    	public ClubCloud_Nationaliteit()
    	{
    		this.ClubCloud_Gebruiker = new ObservableCollection<ClubCloud_Gebruiker>();
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
    	public string Code 
    	{ 
    		get { return _code; } 
    		set { SetProperty(ref _code, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _code;
    
    
    
    	//[DataMember]
    	[IgnoreDataMember]
    	public virtual ObservableCollection<ClubCloud_Gebruiker> ClubCloud_Gebruiker { get; set; }
    
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
    
    
    public class ClubCloud_Nationaliteit_Mapping : EntityTypeConfiguration<ClubCloud_Nationaliteit>
    {
    	public ClubCloud_Nationaliteit_Mapping() 
    	{
    		//System.Guid
    		HasKey(m => m.Id);
    	}
    }
    
    public class ClubCloud_Nationaliteit_TypeDescriptionProvider : TypeDescriptionProvider
    {
    	private ICustomTypeDescriptor td;
    
    	public ClubCloud_Nationaliteit_TypeDescriptionProvider() : this(TypeDescriptor.GetProvider(typeof(ClubCloud_Nationaliteit))) {}
    
    	public ClubCloud_Nationaliteit_TypeDescriptionProvider(TypeDescriptionProvider parent) : base(parent) {}
    
    	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
    	{
    		if (td == null)
    		{
    			td = base.GetTypeDescriptor(objectType, instance);
    			td = new ClubCloud_Nationaliteit_CustomTypeDescriptor(td);
    		}
    
    		return td;
    	}        
    }
    
    public class ClubCloud_Nationaliteit_CustomTypeDescriptor : CustomTypeDescriptor
    {       
    	public ClubCloud_Nationaliteit_CustomTypeDescriptor(ICustomTypeDescriptor parent) : base(parent) {}
    
    	public override PropertyDescriptorCollection GetProperties()
    	{
    		PropertyDescriptorCollection cols = base.GetProperties();
    		
    		return cols;            
    	}     
    } 
    
}