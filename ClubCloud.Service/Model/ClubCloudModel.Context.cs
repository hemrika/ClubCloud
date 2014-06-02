﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClubCloud.Service.Model
{
    using System;
    using System.Data.Entity.Core.Objects;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.ComponentModel.DataAnnotations.Schema;
    
    
    public partial class ClubCloudModelContainer : DbContext
    {
    	public ClubCloudModelContainer()
            : this(false) { }
    
        public ClubCloudModelContainer(bool proxyCreationEnabled)
            : base("name=ClubCloudModelContainer")
        {
    				this.Configuration.LazyLoadingEnabled = false;
    		this.Configuration.AutoDetectChangesEnabled = true;
    		this.Configuration.UseDatabaseNullSemantics = false;
    		this.Configuration.ValidateOnSaveEnabled = false;
    		        this.Configuration.ProxyCreationEnabled = proxyCreationEnabled;
        }
    	
        public ClubCloudModelContainer(string connectionString)
          : this(connectionString, false) { }
    	  
        public ClubCloudModelContainer(string connectionString, bool proxyCreationEnabled)
            : base(connectionString)
        {
    				this.Configuration.LazyLoadingEnabled = false;
    		this.Configuration.AutoDetectChangesEnabled = true;
    		this.Configuration.UseDatabaseNullSemantics = false;
    		this.Configuration.ValidateOnSaveEnabled = false;
    		        this.Configuration.ProxyCreationEnabled = proxyCreationEnabled;
        }	
    	
        public ObjectContext ObjectContext
        {
          get { return ((IObjectContextAdapter)this).ObjectContext; }
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
                modelBuilder.Entity<ClubCloud_Gebruiker>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
                modelBuilder.Entity<ClubCloud_Vereniging>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
                modelBuilder.Entity<ClubCloud_Tracking>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
                modelBuilder.Entity<ClubCloud_Setting>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               //throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ClubCloud_Gebruiker> ClubCloud_Gebruikers { get; set; }
        public virtual DbSet<ClubCloud_Vereniging> ClubCloud_Verenigingen { get; set; }
        public virtual DbSet<ClubCloud_Tracking> ClubCloud_TrackingSet { get; set; }
        public virtual DbSet<ClubCloud_Setting> ClubCloud_Settings { get; set; }
    }
}
