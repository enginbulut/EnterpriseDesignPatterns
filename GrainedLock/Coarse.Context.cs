﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GrainedLock
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CoarseGrainedLockEntities : DbContext
    {
        public CoarseGrainedLockEntities()
            : base("name=CoarseGrainedLockEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Ders> Ders { get; set; }
        public DbSet<Ogrenci> Ogrenci { get; set; }
        public DbSet<Sinif> Sinif { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
