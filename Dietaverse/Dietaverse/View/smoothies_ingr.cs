//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dietaverse.View
{
    using System;
    using System.Collections.Generic;
    
    public partial class smoothies_ingr
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public smoothies_ingr()
        {
            this.recipes_ingredient = new HashSet<recipes_ingredient>();
        }
    
        public int Id { get; set; }
        public string name { get; set; }
        public double kcal { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<recipes_ingredient> recipes_ingredient { get; set; }
    }
}