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
    
    [DataContract]
    [Flags]
    public enum Privacy : int
    {
    	[EnumMember]
    	None = 0,
    	[EnumMember]
    	leden_club = 1,
    	[EnumMember]
    	leden_clubcloud = 2,
    	[EnumMember]
    	competitie_club = 4,
    	[EnumMember]
    	competitie_leden = 8,
    	[EnumMember]
    	toernooi_club = 16,
    	[EnumMember]
    	toernooi_leden = 32
    }
}
