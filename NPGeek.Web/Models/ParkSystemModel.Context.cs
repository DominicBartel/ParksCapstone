﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NPGeek.Web.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ParkSystemDatabaseEntities : DbContext
    {
        public ParkSystemDatabaseEntities()
            : base("name=ParkSystemDatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<park> parks { get; set; }
        public virtual DbSet<survey_result> survey_result { get; set; }
        public virtual DbSet<weather> weathers { get; set; }
    }
}