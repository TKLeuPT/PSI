﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hotel_Surf.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BungalowsEntities1 : DbContext
    {
        public BungalowsEntities1()
            : base("name=BungalowsEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Bungalow> Bungalows { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Reserva> Reservas { get; set; }
    }
}