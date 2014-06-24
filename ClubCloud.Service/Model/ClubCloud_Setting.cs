//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClubCloud.Service.Model
{
    using System;
    using System.Runtime.Serialization;
    using System.Collections.Generic;
    
    [Serializable]
    [DataContract(IsReference = true)]
    
    public partial class ClubCloud_Setting
    {
        public ClubCloud_Setting()
        {
            this.mijnknltb_allow = false;
            this.mijnknltb_tracking = false;
            this.twitter_allow = false;
            this.facebook_allow = false;
        }
    
    	[DataMember]
        public int Id { get; set; }
    	[DataMember]
        public Nullable<System.Guid> mijnknltb_Id { get; set; }
    	[DataMember]
        public bool mijnknltb_allow { get; set; }
    	[DataMember]
        public string mijnknltb_password { get; set; }
    	[DataMember]
        public bool mijnknltb_tracking { get; set; }
    	[DataMember]
        public bool twitter_allow { get; set; }
    	[DataMember]
        public string twitter_oauth_token { get; set; }
    	[DataMember]
        public string twitter_oauth_token_secret { get; set; }
    	[DataMember]
        public Twitter twitter_setting { get; set; }
    	[DataMember]
        public bool facebook_allow { get; set; }
    	[DataMember]
        public string facebook_access_token { get; set; }
    	[DataMember]
        public Facebook facebook_setting { get; set; }
    	[DataMember]
        public Privacy privacy { get; set; }
    	[DataMember]
        public Financieel financieel { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> UserUpdate { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> ClubUpdate { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> ClubCloudUpdate { get; set; }
    }
}
