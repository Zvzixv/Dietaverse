//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dietaverse.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class dishes_gallery
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string recipe { get; set; }
        public int kcal { get; set; }
    
        public virtual users users { get; set; }
        public virtual photos photos { get; set; }
    }
}
