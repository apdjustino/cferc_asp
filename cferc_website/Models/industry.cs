//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace cferc_website.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class industry
    {
        public industry()
        {
            this.series = new HashSet<series>();
        }
    
        public string industryID { get; set; }
        public string industryName { get; set; }
    
        public virtual ICollection<series> series { get; set; }
    }
}
