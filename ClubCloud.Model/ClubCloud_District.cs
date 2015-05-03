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
    [KnownType(typeof(ClubCloud_Vereniging))]
    [KnownType(typeof(ClubCloud_Regio))]
    [KnownType(typeof(ClubCloud_Accommodatie))]
    [DataContract(IsReference = true)]
    [TypeDescriptionProvider(typeof(ClubCloud_District_TypeDescriptionProvider))]
    public partial class ClubCloud_District : INotifyPropertyChanged, IDataErrorInfo, INotifyDataErrorInfo
    {
        public ClubCloud_District()
        {
            this.ClubCloud_Functionaris = new ObservableCollection<ClubCloud_Functionaris>();
            this.ClubCloud_Vereniging = new ObservableCollection<ClubCloud_Vereniging>();
            this.ClubCloud_Accommodatie = new ObservableCollection<ClubCloud_Accommodatie>();
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
        public string Omschrijving 
    	{ 
    		get { return _omschrijving; } 
    		set { SetProperty(ref _omschrijving, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _omschrijving;
    
    	[DataMember]
        public Nullable<System.Guid> RegioId 
    	{ 
    		get { return _regioId; } 
    		set { SetProperty(ref _regioId, value); } 
    	}
    
    	[IgnoreDataMember]
    	private Nullable<System.Guid> _regioId;
    
    	[DataMember]
        public string Actief 
    	{ 
    		get { return _actief; } 
    		set { SetProperty(ref _actief, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _actief;
    
    
    
    	//[DataMember]
    	[IgnoreDataMember]
        public virtual ObservableCollection<ClubCloud_Functionaris> ClubCloud_Functionaris { get; set; }
    
    	//[DataMember]
    	[IgnoreDataMember]
        public virtual ObservableCollection<ClubCloud_Vereniging> ClubCloud_Vereniging { get; set; }
    
    	//[DataMember]
    	[IgnoreDataMember]
        public virtual ClubCloud_Regio ClubCloud_Regio { get; set; }
    
    	//[DataMember]
    	[IgnoreDataMember]
        public virtual ObservableCollection<ClubCloud_Accommodatie> ClubCloud_Accommodatie { get; set; }
    
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
    
    
    public class ClubCloud_District_Mapping : EntityTypeConfiguration<ClubCloud_District>
    {
    	public ClubCloud_District_Mapping() 
    	{			
    		HasKey(m => m.Id);
    	}
    }
    
    public class ClubCloud_District_TypeDescriptionProvider : TypeDescriptionProvider
    {
        private ICustomTypeDescriptor td;
    
        public ClubCloud_District_TypeDescriptionProvider() : this(TypeDescriptor.GetProvider(typeof(ClubCloud_District))) {}
    
        public ClubCloud_District_TypeDescriptionProvider(TypeDescriptionProvider parent) : base(parent) {}
    
        public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
        {
            if (td == null)
            {
                td = base.GetTypeDescriptor(objectType, instance);
                td = new ClubCloud_District_CustomTypeDescriptor(td);
            }
    
            return td;
        }        
    }
    
    public class ClubCloud_District_CustomTypeDescriptor : CustomTypeDescriptor
    {       
        public ClubCloud_District_CustomTypeDescriptor(ICustomTypeDescriptor parent) : base(parent) {}
    
        public override PropertyDescriptorCollection GetProperties()
        {
            PropertyDescriptorCollection cols = base.GetProperties();
    		
    		List<PropertyDescriptor> extended = new List<PropertyDescriptor>();
            foreach (PropertyDescriptor item in cols)
            {
                extended.Add(item);
            }
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
