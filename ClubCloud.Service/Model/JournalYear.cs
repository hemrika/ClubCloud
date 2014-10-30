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
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Collections.Generic;
    
    public partial class JournalYear
    {
        public JournalYear()
        {
            this.JournalEntries = new HashSet<JournalEntry>();
        }
    
    	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public System.Guid Id { get; set; }
    	
        public string Name { get; set; }
    	
        public string Description { get; set; }
    	
        public System.Guid FinancialYearId { get; set; }
    
        public virtual FinancialYear FinancialYear { get; set; }
        public virtual ICollection<JournalEntry> JournalEntries { get; set; }
    }
}
