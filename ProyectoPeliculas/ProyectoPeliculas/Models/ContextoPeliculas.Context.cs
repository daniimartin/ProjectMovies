﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoPeliculas.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PeliculasEntities : DbContext
    {
        public PeliculasEntities()
            : base("name=PeliculasEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Distribuidoras> Distribuidoras { get; set; }
        public DbSet<Generos> Generos { get; set; }
        public DbSet<Nacionalidad> Nacionalidad { get; set; }
        public DbSet<Peliculas> Peliculas { get; set; }
    }
}
