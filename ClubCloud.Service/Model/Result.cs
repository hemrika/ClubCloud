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
    
    public partial class Result
    {
    	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public System.Guid Id { get; set; }
    	
        public string Name { get; set; }
    	
        public string Description { get; set; }
    	
        public string AmountCreditstart { get; set; }
    	
        public string AmountDebitStart { get; set; }
    	
        public string AmountCreditBudget { get; set; }
    	
        public string AmountDebitBudget { get; set; }
    	
        public string AmountCreditEnd { get; set; }
    	
        public string AmountDebitEnd { get; set; }
    	
        public System.Guid LedgerId { get; set; }
    	
        public System.Guid FinancialYearId { get; set; }
    	
        public System.Guid CostCenterId { get; set; }
    
        public virtual Ledger Ledger { get; set; }
        public virtual FinancialYear FinancialYear { get; set; }
        public virtual CostCenter CostCenter { get; set; }
    }
}
