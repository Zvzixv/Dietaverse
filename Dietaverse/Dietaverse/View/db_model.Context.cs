﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class db_modelContainer : DbContext
    {
        public db_modelContainer()
            : base("name=db_modelContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<users> usersSet { get; set; }
        public virtual DbSet<dishes_gallery> dishes_gallerySet { get; set; }
        public virtual DbSet<daily_summary> daily_summarySet { get; set; }
        public virtual DbSet<months> monthsSet { get; set; }
        public virtual DbSet<smoothies_recipes> smoothies_recipesSet { get; set; }
        public virtual DbSet<smoothies_ingr> smoothies_ingrSet { get; set; }
        public virtual DbSet<body_gallery> body_gallerySet { get; set; }
        public virtual DbSet<recipes_ingredient> recipes_ingredientSet { get; set; }
    }
}
