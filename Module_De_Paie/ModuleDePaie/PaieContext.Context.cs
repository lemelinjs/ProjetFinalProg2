﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModuleDePaie
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class module_de_paie_entity : DbContext
    {
        public module_de_paie_entity()
            : base("name=module_de_paie_entity")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<compagnies> compagnies { get; set; }
        public DbSet<compagnies_employes> compagnies_employes { get; set; }
        public DbSet<employes> employes { get; set; }
        public DbSet<feries> feries { get; set; }
        public DbSet<jours_travailles> jours_travailles { get; set; }
        public DbSet<paies> paies { get; set; }
        public DbSet<paies_feries> paies_feries { get; set; }
        public DbSet<paies_retenues> paies_retenues { get; set; }
        public DbSet<types_retenues> types_retenues { get; set; }
        public DbSet<types_retenues_employes> types_retenues_employes { get; set; }
        public DbSet<vacances> vacances { get; set; }
    }
}
