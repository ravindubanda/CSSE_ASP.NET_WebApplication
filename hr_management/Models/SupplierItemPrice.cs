//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace hr_management.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class SupplierItemPrice
    {
        public int SupplierItemPriceId { get; set; }
        public Nullable<int> SupId { get; set; }
        public string ItemName { get; set; }
        public Nullable<double> Price { get; set; }

        [NotMapped]
        public List<Item> ItemCollection { get; set; }
    }
}
