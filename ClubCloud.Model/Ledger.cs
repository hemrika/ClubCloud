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
    
    public partial class Ledger
    {
        public Ledger()
        {
            this.Journals = new HashSet<Journal>();
            this.JournalTransactions = new HashSet<JournalTransaction>();
            this.JournalEntries = new HashSet<JournalEntry>();
            this.Balances = new HashSet<Balance>();
            this.Results = new HashSet<Result>();
            this.Receivables = new HashSet<Receivable>();
            this.Payables = new HashSet<Payable>();
        }
    
    	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public System.Guid Id { get; set; }
    	
        public string Name { get; set; }
    	
        public string Description { get; set; }
    	
        public int Number { get; set; }
    	
        public DirectionType Direction { get; set; }
    	
        public bool Blocked { get; set; }
    	
        public bool Dropped { get; set; }
    	
        public System.Guid LedgerCategoryId { get; set; }
    	
        public LedgerType LedgerType { get; set; }
    	
        public ResultType ResultType { get; set; }
    	
        public System.Guid CostCenterId { get; set; }
    
        public virtual ICollection<Journal> Journals { get; set; }
        public virtual LedgerCategory LedgerCategory { get; set; }
        public virtual ICollection<JournalTransaction> JournalTransactions { get; set; }
        public virtual ICollection<JournalEntry> JournalEntries { get; set; }
        public virtual CostCenter CostCenter { get; set; }
        public virtual ICollection<Balance> Balances { get; set; }
        public virtual ICollection<Result> Results { get; set; }
        public virtual ICollection<Receivable> Receivables { get; set; }
        public virtual ICollection<Payable> Payables { get; set; }
    }
}
