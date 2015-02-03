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
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Infrastructure.Interception;
    
    public partial class SignalRContainer : DbContext
    {
    	private static string NameOrConnectionString = "name=SignalRContainer";
    
    	static SignalRContainer ()
    	{
            DbInterception.Add(new BeheerFullTextInterceptor());
        }
    
    	public SignalRContainer()
            : this(false) { }
    
        public SignalRContainer(bool proxyCreationEnabled)
            : base(NameOrConnectionString)
        {
    				this.Configuration.LazyLoadingEnabled = false;
    		this.Configuration.AutoDetectChangesEnabled = true;
    		this.Configuration.UseDatabaseNullSemantics = false;
    		this.Configuration.ValidateOnSaveEnabled = false;
    				this.Configuration.ProxyCreationEnabled = proxyCreationEnabled;
    
    		if (!Database.Exists(NameOrConnectionString))
    		{
    			Database.SetInitializer<SignalRContainer>(new CreateDatabaseIfNotExists<SignalRContainer>());
    		}
    
    		try
    		{
    			if (!Database.CompatibleWithModel(false))
    			{
    				Database.SetInitializer<SignalRContainer>(new MigrateDatabaseToLatestVersion<SignalRContainer, SignalRConfiguration>());
    			}
    		}
    		catch { }
    
    		Database.Initialize(true);
    
    		//Database.SetInitializer<SignalRContainer>(new CreateDatabaseIfNotExists<SignalRContainer>());
    		//Database.SetInitializer<SignalRContainer>(new MigrateDatabaseToLatestVersion<SignalRContainer, SignalRConfiguration>());
        }
    	
        public SignalRContainer(string connectionString)
          : this(connectionString, false) { NameOrConnectionString = connectionString; }
    	  
        public SignalRContainer(string connectionString, bool proxyCreationEnabled)
            : base(connectionString)
        {
    			NameOrConnectionString = connectionString;
    				this.Configuration.LazyLoadingEnabled = false;
    		this.Configuration.AutoDetectChangesEnabled = true;
    		this.Configuration.UseDatabaseNullSemantics = false;
    		this.Configuration.ValidateOnSaveEnabled = false;
    		        this.Configuration.ProxyCreationEnabled = proxyCreationEnabled;
    
    		if (!Database.Exists(NameOrConnectionString))
    		{
    			Database.SetInitializer<SignalRContainer>(new CreateDatabaseIfNotExists<SignalRContainer>());
    		}
    
    		try
    		{
    			if (!Database.CompatibleWithModel(false))
    			{
    				Database.SetInitializer<SignalRContainer>(new MigrateDatabaseToLatestVersion<SignalRContainer, SignalRConfiguration>());
    			}
    		}
    		catch { }
    
    		Database.Initialize(false);
    
    		//Database.SetInitializer<SignalRContainer>(new CreateDatabaseIfNotExists<SignalRContainer>());
    		//Database.SetInitializer<SignalRContainer>(new MigrateDatabaseToLatestVersion<SignalRContainer, SignalRConfiguration>());
    	}	
    	
        public ObjectContext ObjectContext
        {
          get { return ((IObjectContextAdapter)this).ObjectContext; }
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
    		//modelBuilder.Entity<Messages_0>().MapToStoredProcedures();
    
    		modelBuilder.Entity<Messages_0>().Property(e => e.PayloadId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
    
    		//modelBuilder.Entity<Messages_0_Id>().MapToStoredProcedures();
    
    		modelBuilder.Entity<Messages_0_Id>().Property(e => e.PayloadId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
    
    		//modelBuilder.Entity<Schema>().MapToStoredProcedures();
    
    		modelBuilder.Entity<Schema>().Property(e => e.SchemaVersion).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
    
    		base.OnModelCreating(modelBuilder);
        }
    
        public virtual DbSet<Messages_0> Messages_0 { get; set; }
        public virtual DbSet<Messages_0_Id> Messages_0_Id { get; set; }
        public virtual DbSet<Schema> Schemata { get; set; }
    }
}
