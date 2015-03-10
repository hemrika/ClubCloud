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
    [KnownType(typeof(ClubCloud_Lidmaatschap))]
    [DataContract(IsReference = true)]
    
    public partial class ClubCloud_Lidmaatschapsoort : INotifyPropertyChanged, IDataErrorInfo, INotifyDataErrorInfo
    {
        public ClubCloud_Lidmaatschapsoort()
        {
            this.ClubCloud_Lidmaatschap = new HashSet<ClubCloud_Lidmaatschap>();
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
        public string Code 
    	{ 
    		get { return _code; } 
    		set { SetProperty(ref _code, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _code;
    
    	[DataMember]
        public System.TimeSpan DagBegin 
    	{ 
    		get { return _dagBegin; } 
    		set { SetProperty(ref _dagBegin, value); } 
    	}
    
    	[IgnoreDataMember]
    	private System.TimeSpan _dagBegin;
    
    	[DataMember]
        public System.TimeSpan DagEinde 
    	{ 
    		get { return _dagEinde; } 
    		set { SetProperty(ref _dagEinde, value); } 
    	}
    
    	[IgnoreDataMember]
    	private System.TimeSpan _dagEinde;
    
    	[DataMember]
        public bool Contributie 
    	{ 
    		get { return _contributie; } 
    		set { SetProperty(ref _contributie, value); } 
    	}
    
    	[IgnoreDataMember]
    	private bool _contributie;
    
    	[DataMember]
        public string Tarief 
    	{ 
    		get { return _tarief; } 
    		set { SetProperty(ref _tarief, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _tarief;
    
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
        public virtual ICollection<ClubCloud_Lidmaatschap> ClubCloud_Lidmaatschap { get; set; }
    
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
