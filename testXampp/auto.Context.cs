﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace testXampp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class autoserviceprojectEntities : DbContext
    {
        public autoserviceprojectEntities()
            : base("name=autoserviceprojectEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<angajat> angajats { get; set; }
        public virtual DbSet<client> clients { get; set; }
        public virtual DbSet<listaoperatiuni> listaoperatiunis { get; set; }
        public virtual DbSet<masina> masinas { get; set; }
        public virtual DbSet<operatiune> operatiunes { get; set; }
        public virtual DbSet<piesa> piesas { get; set; }
        public virtual DbSet<profit> profits { get; set; }
        public virtual DbSet<salar> salars { get; set; }
    }
}