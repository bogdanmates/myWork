//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nike.DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Nike_Category
    {
        public Nike_Category()
        {
            this.Nike_Product = new HashSet<Nike_Product>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Nike_Product> Nike_Product { get; set; }
    }
}
