//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineFoodOrder_Website.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int OrderDetailsID { get; set; }
        public string OrderNo { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<int> UserID { get; set; }
        public string Statuss { get; set; }
        public Nullable<int> PaymentID { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
    
        public virtual Payment Payment { get; set; }
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
    }
}
