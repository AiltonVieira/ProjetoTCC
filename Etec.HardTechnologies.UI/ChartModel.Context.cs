﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Etec.HardTechnologies.UI
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GenesysDBChart : DbContext
    {
        public GenesysDBChart()
            : base("name=GenesysDBChart")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<FINALIZAR_SERVICO> FINALIZAR_SERVICO { get; set; }
        public virtual DbSet<SERVICO> SERVICO { get; set; }
    }
}
