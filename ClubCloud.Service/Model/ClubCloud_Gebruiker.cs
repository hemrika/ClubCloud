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
    using System.Collections.Generic;
    
    public partial class ClubCloud_Gebruiker
    {
        public ClubCloud_Gebruiker()
        {
            this.ClubCloud_Vereniging = new HashSet<ClubCloud_Vereniging>();
        }
    
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string mijnknltb_password { get; set; }
        public string oauth_token { get; set; }
        public string oauth_token_secret { get; set; }
    
        public virtual ICollection<ClubCloud_Vereniging> ClubCloud_Vereniging { get; set; }
    }
}
