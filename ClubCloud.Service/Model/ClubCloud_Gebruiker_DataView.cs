namespace ClubCloud.Service.Model
{
    using System;
    using System.Runtime.Serialization;
    using System.Collections.Generic;

    [Serializable]
    [DataContract(IsReference = true)]
    [KnownType(typeof(ClubCloud_Gebruiker))]
    public partial class ClubCloud_Gebruiker_DataView
    {
        public ClubCloud_Gebruiker_DataView()
        {
            this.ClubCloud_Gebruiker = new HashSet<ClubCloud_Gebruiker>();
        }

        [DataMember]
        public int TotalRowCount { get; set; }

        [DataMember]
        public virtual ICollection<ClubCloud_Gebruiker> ClubCloud_Gebruiker { get; set; }

    }
}