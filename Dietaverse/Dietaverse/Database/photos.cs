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
    
    public partial class photos
    {
        public int Id { get; set; }
        public string filename { get; set; }
        public string data { get; set; }
    
        public virtual body_gallery body_gallery { get; set; }
        public virtual dishes_gallery dishes_gallery { get; set; }
        public virtual smoothies_recipes smoothies_recipes { get; set; }
    }
}
