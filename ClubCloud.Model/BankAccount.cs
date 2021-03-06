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
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Collections.Generic;
    
    public partial class BankAccount
    {
        public BankAccount()
        {
            this.Journals = new HashSet<Journal>();
        }
    
    	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public System.Guid Id { get; set; }
    	
        public string Name { get; set; }
    	
        public string Description { get; set; }
    	
        public string IBAN { get; set; }
    	
        public string BIC { get; set; }
    
        public virtual ICollection<Journal> Journals { get; set; }
    }
}
