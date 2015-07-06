//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MedOfficeWebApplication
{
    using System;
    using System.Collections.Generic;
    
    public partial class ArAp
    {
        public int InvoiceNumber { get; set; }
        public Nullable<int> CheckNumber { get; set; }
        public string PmtType { get; set; }
        public System.DateTime DoP { get; set; }
        public System.DateTime DoS { get; set; }
        public int Payer { get; set; }
        public int Payee { get; set; }
        public decimal Amount { get; set; }
        public Nullable<int> ChartNumber { get; set; }
    
        public virtual Patient Patient { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Insurance Insurance { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Company Company { get; set; }
    }
}