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
    public enum ReserveringSoort : int
    {
    	[EnumMember]
    	Afhangen = 1,
    	[EnumMember]
    	Les = 2,
    	[EnumMember]
    	Competitie = 3,
    	[EnumMember]
    	Toernooi = 4,
    	[EnumMember]
    	Evenement = 5,
    	[EnumMember]
    	Onderhoud = 6,
    	[EnumMember]
    	Seizoen = 7,
    	[EnumMember]
    	Mobiel = 8,
    	[EnumMember]
    	Overig = 9,
    	[EnumMember]
    	Onbekend = 0
    }
}