﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FootballApplication.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FootballAppDB : DbContext
    {
        public FootballAppDB()
            : base("name=FootballAppDB")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ChangingRooms> ChangingRooms { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Rezervations> Rezervations { get; set; }
        public virtual DbSet<RezervationToRooms> RezervationToRooms { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Stadiums> Stadiums { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Users_> Users_ { get; set; }
        public virtual DbSet<Admins> Admins { get; set; }
    }
}