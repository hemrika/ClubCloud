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
    [DataContract(IsReference = true)]
    [TypeDescriptionProvider(typeof(ClubCloud_Functie_TypeDescriptionProvider))]
    public partial class ClubCloud_Functie : INotifyPropertyChanged, IDataErrorInfo, INotifyDataErrorInfo
    {
        public ClubCloud_Functie()
        {
            this.ClubCloud_Functionaris = new ObservableCollection<ClubCloud_Functionaris>();
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
        public bool Toegang 
    	{ 
    		get { return _toegang; } 
    		set { SetProperty(ref _toegang, value); } 
    	}
    
    	[IgnoreDataMember]
    	private bool _toegang;
    
    	[DataMember]
        public string Code 
    	{ 
    		get { return _code; } 
    		set { SetProperty(ref _code, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _code;
    
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
    
    
    public class ClubCloud_Functie_Mapping : EntityTypeConfiguration<ClubCloud_Functie>
    {
    	public ClubCloud_Functie_Mapping() 
    	{			
    		HasKey(m => m.Id);
    	}
    }
    
    public class ClubCloud_Functie_TypeDescriptionProvider : TypeDescriptionProvider
    {
        private ICustomTypeDescriptor td;
    
        public ClubCloud_Functie_TypeDescriptionProvider() : this(TypeDescriptor.GetProvider(typeof(ClubCloud_Functie))) {}
    
        public ClubCloud_Functie_TypeDescriptionProvider(TypeDescriptionProvider parent) : base(parent) {}
    
        public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
        {
            if (td == null)
            {
                td = base.GetTypeDescriptor(objectType, instance);
                td = new ClubCloud_Functie_CustomTypeDescriptor(td);
            }
    
            return td;
        }        
    }
    
    public class ClubCloud_Functie_CustomTypeDescriptor : CustomTypeDescriptor
    {       
        public ClubCloud_Functie_CustomTypeDescriptor(ICustomTypeDescriptor parent) : base(parent) {}
    
        public override PropertyDescriptorCollection GetProperties()
        {
            PropertyDescriptorCollection cols = base.GetProperties();
    		
            return cols;            
        }     
    } 
    
}
