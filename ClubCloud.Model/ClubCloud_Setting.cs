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
    [KnownType(typeof(ClubCloud_Gebruiker))]
    [KnownType(typeof(ClubCloud_Vereniging))]
    [DataContract(IsReference = true)]
    
    public partial class ClubCloud_Setting : INotifyPropertyChanged, IDataErrorInfo, INotifyDataErrorInfo
    {
        public ClubCloud_Setting()
        {
            this.Agree = false;
            this.Access = false;
            this.twitter_allow = false;
            this.facebook_allow = false;
        }
    
    	[DataMember]
        public int Id 
    	{ 
    		get { return _id; } 
    		set { SetProperty(ref _id, value); } 
    	}
    
    	[IgnoreDataMember]
    	private int _id;
    
    	[DataMember]
        public Nullable<System.Guid> GebruikerId 
    	{ 
    		get { return _gebruikerId; } 
    		set { SetProperty(ref _gebruikerId, value); } 
    	}
    
    	[IgnoreDataMember]
    	private Nullable<System.Guid> _gebruikerId;
    
    	[DataMember]
        public Nullable<System.Guid> VerenigingId 
    	{ 
    		get { return _verenigingId; } 
    		set { SetProperty(ref _verenigingId, value); } 
    	}
    
    	[IgnoreDataMember]
    	private Nullable<System.Guid> _verenigingId;
    
    	[DataMember]
        public bool Agree 
    	{ 
    		get { return _agree; } 
    		set { SetProperty(ref _agree, value); } 
    	}
    
    	[IgnoreDataMember]
    	private bool _agree;
    
    	[DataMember]
        public bool Access 
    	{ 
    		get { return _access; } 
    		set { SetProperty(ref _access, value); } 
    	}
    
    	[IgnoreDataMember]
    	private bool _access;
    
    	[DataMember]
        public string Password 
    	{ 
    		get { return _password; } 
    		set { SetProperty(ref _password, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _password;
    
    	[DataMember]
        public bool twitter_allow 
    	{ 
    		get { return _twitter_allow; } 
    		set { SetProperty(ref _twitter_allow, value); } 
    	}
    
    	[IgnoreDataMember]
    	private bool _twitter_allow;
    
    	[DataMember]
        public string twitter_oauth_token 
    	{ 
    		get { return _twitter_oauth_token; } 
    		set { SetProperty(ref _twitter_oauth_token, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _twitter_oauth_token;
    
    	[DataMember]
        public string twitter_oauth_token_secret 
    	{ 
    		get { return _twitter_oauth_token_secret; } 
    		set { SetProperty(ref _twitter_oauth_token_secret, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _twitter_oauth_token_secret;
    
    	[DataMember]
        public Twitter twitter_setting 
    	{ 
    		get { return _twitter_setting; } 
    		set { SetProperty(ref _twitter_setting, value); } 
    	}
    
    	[IgnoreDataMember]
    	private Twitter _twitter_setting;
    
    	[DataMember]
        public bool facebook_allow 
    	{ 
    		get { return _facebook_allow; } 
    		set { SetProperty(ref _facebook_allow, value); } 
    	}
    
    	[IgnoreDataMember]
    	private bool _facebook_allow;
    
    	[DataMember]
        public string facebook_access_token 
    	{ 
    		get { return _facebook_access_token; } 
    		set { SetProperty(ref _facebook_access_token, value); } 
    	}
    
    	[IgnoreDataMember]
    	private string _facebook_access_token;
    
    	[DataMember]
        public Facebook facebook_setting 
    	{ 
    		get { return _facebook_setting; } 
    		set { SetProperty(ref _facebook_setting, value); } 
    	}
    
    	[IgnoreDataMember]
    	private Facebook _facebook_setting;
    
    	[DataMember]
        public Privacy privacy 
    	{ 
    		get { return _privacy; } 
    		set { SetProperty(ref _privacy, value); } 
    	}
    
    	[IgnoreDataMember]
    	private Privacy _privacy;
    
    	[DataMember]
        public Financieel financieel 
    	{ 
    		get { return _financieel; } 
    		set { SetProperty(ref _financieel, value); } 
    	}
    
    	[IgnoreDataMember]
    	private Financieel _financieel;
    
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
        public virtual ClubCloud_Gebruiker ClubCloud_Gebruiker { get; set; }
    
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