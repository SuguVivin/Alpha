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
    
    public partial class Trainer
    {
        public int TrainerID { get; set; }
        public string TrainerName { get; set; }
        public Nullable<int> Experience { get; set; }
        public string Location { get; set; }
        public Nullable<System.DateTime> AvailableFrom { get; set; }
        public Nullable<System.DateTime> AvailableTo { get; set; }
    }
}
