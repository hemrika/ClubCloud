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
    
    public partial class InvoiceEntry
    {
    	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public System.Guid Id { get; set; }
    	
        public string Name { get; set; }
    	
        public string Description { get; set; }
    	
        public string Quantity { get; set; }
    	
        public decimal Amount { get; set; }
    	
        public string AmountTax { get; set; }
    	
        public System.Guid InvoiceId { get; set; }
    	
        public Nullable<System.Guid> ProductId { get; set; }
    	
        public Nullable<System.Guid> ReceivableId { get; set; }
    	
        public Nullable<System.Guid> PayableId { get; set; }
    
        public virtual Invoice Invoice { get; set; }
        public virtual Product Product { get; set; }
        public virtual Receivable Receivable { get; set; }
        public virtual Payable Payable { get; set; }
    }
}
