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
    
    [Flags]
    public enum InvoiceType : int
    {
        Payable = 0,
        Receivable = 1
    }
}