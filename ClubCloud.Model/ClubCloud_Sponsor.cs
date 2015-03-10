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
    
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    
    [Serializable]
    [KnownType(typeof(ClubCloud_Vereniging))]
    [KnownType(typeof(ClubCloud_Sponsor_Afbeelding))]
    [DataContract(IsReference = true)]
    
    public partial class ClubCloud_Sponsor : INotifyPropertyChanged, IDataErrorInfo, INotifyDataErrorInfo
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
        public System.Guid VerenigingId 
    	{ 
    		get { return _verenigingId; } 
    		set { SetProperty(ref _verenigingId, value); } 
    	}
    
    	[IgnoreDataMember]
    	private System.Guid _verenigingId;
    
    	[DataMember]
        public Nullable<System.Guid> AfbeeldingId 
    	{ 
    		get { return _afbeeldingId; } 
    		set { SetProperty(ref _afbeeldingId, value); } 
    	}
    
    	[IgnoreDataMember]
    	private Nullable<System.Guid> _afbeeldingId;
    
    	[DataMember]
        public string Naam 
    	{ 
    		get { return _naam; } 
    		set { SetProperty(ref _naam, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _naam;
    
    	[DataMember]
        public string Tekst 
    	{ 
    		get { return _tekst; } 
    		set { SetProperty(ref _tekst, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _tekst;
    
    
    
    	//[DataMember]
    	[IgnoreDataMember]
        public virtual ClubCloud_Vereniging ClubCloud_Vereniging { get; set; }
    
    	//[DataMember]
    	[IgnoreDataMember]
        public virtual ClubCloud_Sponsor_Afbeelding ClubCloud_Sponsor_Afbeelding { get; set; }
    
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
}
