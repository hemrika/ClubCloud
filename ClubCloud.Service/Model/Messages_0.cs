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
    
    public partial class Messages_0
    {
    	[DataMember]
        public long PayloadId { get; set; }
    	[DataMember]
        public byte[] Payload { get; set; }
    	[DataMember]
        public System.DateTime InsertedOn { get; set; }
    }
}
