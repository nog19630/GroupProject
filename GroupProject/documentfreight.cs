//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GroupProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class documentfreight
    {
        public string itemID { get; set; }
        public string name { get; set; }
        public int quantity { get; set; }
        public string serviceType { get; set; }
        public string serviceOtherType { get; set; }
        public string status { get; set; }
        public string centerID { get; set; }
        public string shipmentNo { get; set; }
        public Nullable<float> charge { get; set; }
        public string description { get; set; }
    
        public virtual operationcenter operationcenter { get; set; }
        public virtual frieght frieght { get; set; }
        public virtual shipment shipment { get; set; }
    }
}