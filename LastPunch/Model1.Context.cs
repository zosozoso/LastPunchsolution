﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LastPunch
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dblastpunchModelEntities : DbContext
    {
        public dblastpunchModelEntities()
            : base("name=dblastpunchModelEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Accountancy> Accountancy { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Engineer> Engineer { get; set; }
        public virtual DbSet<Expense> Expense { get; set; }
        public virtual DbSet<Format> Format { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
    }
}