﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentManagementApplication.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class coursesEntities : DbContext
    {
        public coursesEntities()
            : base("name=coursesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<course> courses { get; set; }
        public virtual DbSet<registration> registrations { get; set; }
        public virtual DbSet<section> sections { get; set; }
        public virtual DbSet<user> users { get; set; }
    }
}