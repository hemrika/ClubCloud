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
    public enum DaysSoort : int
    {
    	[EnumMember]
    	maandag = 1,
    	[EnumMember]
    	dinsdag = 2,
    	[EnumMember]
    	woensdag = 3,
    	[EnumMember]
    	donderdag = 4,
    	[EnumMember]
    	vrijdag = 5,
    	[EnumMember]
    	zaterdag = 6,
    	[EnumMember]
    	zondag = 0
    }
}
