//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrainerConsultancy.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Projection
    {
        public int ProjectionID { get; set; }
        public Nullable<int> VendorID { get; set; }
        public Nullable<int> TrainerID { get; set; }
        public Nullable<System.DateTime> ProjectFrom { get; set; }
        public Nullable<System.DateTime> ProjectTo { get; set; }
    }
}
