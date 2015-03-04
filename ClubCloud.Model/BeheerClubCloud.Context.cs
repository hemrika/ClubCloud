﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClubCloud.Model
{
    using System;
    using System.Data.Entity.Core;
    using System.Data.Entity.Core.Objects;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Infrastructure.Interception;
    using System.Data.Entity.Validation;
    using System.Diagnostics;
    
    
    public partial class BeheerContainer : DbContext
    {
    	private static string NameOrConnectionString = "name=BeheerContainer";
    
    	static BeheerContainer ()
    	{
            //DbInterception.Add(new BeheerFullTextInterceptor());
        }
    
    	public BeheerContainer()
            : this(false) { }
    
        public BeheerContainer(bool proxyCreationEnabled)
            : base(NameOrConnectionString)
        {
    			
    		this.Configuration.LazyLoadingEnabled = false;
    
    		
    		this.Configuration.AutoDetectChangesEnabled = false;
    		this.Configuration.UseDatabaseNullSemantics = false;
    		this.Configuration.ValidateOnSaveEnabled = true;
    
    				
    		this.Configuration.ProxyCreationEnabled = proxyCreationEnabled;
    
    		if (!Database.Exists(NameOrConnectionString))
    		{
    			Database.SetInitializer<BeheerContainer>(new CreateDatabaseIfNotExists<BeheerContainer>());
    		}
    
    		try
    		{
    			if (!Database.CompatibleWithModel(false))
    			{
    				Database.SetInitializer<BeheerContainer>(new MigrateDatabaseToLatestVersion<BeheerContainer, BeheerConfiguration>());
    			}
    		}
    		catch { }
    
    		Database.Initialize(false);
    
    		//Database.SetInitializer<BeheerContainer>(new CreateDatabaseIfNotExists<BeheerContainer>());
    		//Database.SetInitializer<BeheerContainer>(new MigrateDatabaseToLatestVersion<BeheerContainer, BeheerConfiguration>());
        }
    	
        public BeheerContainer(string connectionString)
          : this(connectionString, false) { NameOrConnectionString = connectionString; }
    	  
        public BeheerContainer(string connectionString, bool proxyCreationEnabled)
            : base(connectionString)
        {
    		NameOrConnectionString = connectionString;
    		
    		this.Configuration.LazyLoadingEnabled = false;
    
    		
    		this.Configuration.AutoDetectChangesEnabled = false;
    		this.Configuration.UseDatabaseNullSemantics = false;
    		this.Configuration.ValidateOnSaveEnabled = true;
    
    		
            this.Configuration.ProxyCreationEnabled = proxyCreationEnabled;
    
    		if (!Database.Exists(NameOrConnectionString))
    		{
    			Database.SetInitializer<BeheerContainer>(new CreateDatabaseIfNotExists<BeheerContainer>());
    		}
    
    		try
    		{
    			if (!Database.CompatibleWithModel(false))
    			{
    				Database.SetInitializer<BeheerContainer>(new MigrateDatabaseToLatestVersion<BeheerContainer, BeheerConfiguration>());
    			}
    		}
    		catch { }
    
    		Database.Initialize(false);
    
    		//Database.SetInitializer<BeheerContainer>(new CreateDatabaseIfNotExists<BeheerContainer>());
    		//Database.SetInitializer<BeheerContainer>(new MigrateDatabaseToLatestVersion<BeheerContainer, BeheerConfiguration>());
    	}	
    	
        public ObjectContext ObjectContext
        {
          get { return ((IObjectContextAdapter)this).ObjectContext; }
        }
    
    	public override int SaveChanges()
        {
    		int count = 0;
            bool saved = false;
    		Stopwatch s = new Stopwatch();
            s.Start();
    
            do
            {
                try
                {
                    count = base.SaveChanges();
                    saved = true;
                }
    			//A database command did not affect the expected number of rows. This usually indicates an optimistic concurrency violation; that is, a row has been changed in the database since it was queried.
        		catch(DbUpdateConcurrencyException dbucex)
        		{
                    foreach (DbEntityEntry entry in dbucex.Entries)
                    {
                        switch (entry.State)
                        {
                            case EntityState.Deleted:
                                entry.Reload();
                                entry.State = EntityState.Deleted;
                                break;
                            case EntityState.Modified:
                                DbPropertyValues currentValues = entry.CurrentValues.Clone();
                                entry.Reload();
                                if (entry.State == EntityState.Detached)
                                    Set(ObjectContext.GetObjectType(entry.Entity.GetType())).Add(entry.Entity);
                                else
                                {
                                    entry.Reload();
                                    entry.CurrentValues.SetValues(currentValues);
                                }
                                break;
                            default:
                                entry.Reload();
                                break;
                        }
                    }
        		}
    			//An error occurred sending updates to the database.
        		catch(DbUpdateException dbuex)
        		{
                    foreach (DbEntityEntry entry in dbuex.Entries)
                    {
                        switch (entry.State)
                        {
                            case EntityState.Deleted:
                                entry.Reload();
                                entry.State = EntityState.Deleted;
                                break;
                            case EntityState.Modified:
                                DbPropertyValues currentValues = entry.CurrentValues.Clone();
                                entry.Reload();
                                if (entry.State == EntityState.Detached)
                                    Set(ObjectContext.GetObjectType(entry.Entity.GetType())).Add(entry.Entity);
                                else
                                {
                                    entry.Reload();
                                    entry.CurrentValues.SetValues(currentValues);
                                }
                                break;
                            default:
                                entry.Reload();
                                break;
                        }
                    }                    
        		}
    			//The save was aborted because validation of entity property values failed.
        		catch(DbEntityValidationException dbevex)
        		{
                    foreach (DbEntityValidationResult result in dbevex.EntityValidationErrors)
                    {
                        switch (result.Entry.State)
                        {
                            case EntityState.Deleted:
                                result.Entry.Reload();
                                result.Entry.State = EntityState.Deleted;
                                break;
                            case EntityState.Modified:
                                DbPropertyValues currentValues = result.Entry.CurrentValues.Clone();
                                result.Entry.Reload();
                                if (result.Entry.State == EntityState.Detached)
                                    Set(ObjectContext.GetObjectType(result.Entry.Entity.GetType())).Add(result.Entry.Entity);
                                else
                                {
                                    result.Entry.Reload();
                                    result.Entry.CurrentValues.SetValues(currentValues);
                                }
                                break;
                            default:
                                result.Entry.Reload();
                                break;
                        }
                    }
        		}
    			//An attempt was made to use unsupported behavior such as executing multiple asynchronous commands concurrently on the same context instance.
        		catch(NotSupportedException nsex)
        		{
    				string message = nsex.Message;
                    //throw nsex;
        		}
    			//The context or connection have been disposed.
        		catch(ObjectDisposedException odex)
        		{
    				string message = odex.Message;
                    //throw odex;
        		}
    			//Some error occurred attempting to process entities in the context either before or after sending commands to the database.
        		catch(InvalidOperationException ioex)
        		{
    				string message = ioex.Message;
                    //throw ioex;
        		}
            	catch (EntityException eex)
            	{
    				string message = eex.Message;
                    //throw eex;
            	}
    
                catch (Exception ex)
                {
                    string message = ex.Message;
    				//throw ex;
                }
            }
            while (!saved && s.Elapsed < TimeSpan.FromSeconds(30));
            s.Stop();
            
    		this.ObjectContext.AcceptAllChanges();
    
            return count;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
    		//modelBuilder.Entity<ClubCloud_Setting>().MapToStoredProcedures();
    
    		modelBuilder.Entity<ClubCloud_Setting>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
    
    		//modelBuilder.Entity<ClubCloud_Vereniging>().MapToStoredProcedures();
    
    		modelBuilder.Entity<ClubCloud_Vereniging>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
    
    		//modelBuilder.Entity<ClubCloud_Gebruiker>().MapToStoredProcedures();
    
    		modelBuilder.Entity<ClubCloud_Gebruiker>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
    
    		//modelBuilder.Entity<ClubCloud_Accommodatie>().MapToStoredProcedures();
    
    		modelBuilder.Entity<ClubCloud_Accommodatie>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
    
    		//modelBuilder.Entity<ClubCloud_Nationaliteit>().MapToStoredProcedures();
    
    		modelBuilder.Entity<ClubCloud_Nationaliteit>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
    
    		//modelBuilder.Entity<ClubCloud_District>().MapToStoredProcedures();
    
    		modelBuilder.Entity<ClubCloud_District>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
    
    		//modelBuilder.Entity<ClubCloud_Functie>().MapToStoredProcedures();
    
    		modelBuilder.Entity<ClubCloud_Functie>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
    
    		//modelBuilder.Entity<ClubCloud_Lidmaatschap>().MapToStoredProcedures();
    
    		modelBuilder.Entity<ClubCloud_Lidmaatschap>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
    
    		//modelBuilder.Entity<ClubCloud_Profiel>().MapToStoredProcedures();
    
    		modelBuilder.Entity<ClubCloud_Profiel>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
    modelBuilder.Entity<ClubCloud_Profiel>().Property(e => e.Datum).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
    
    		//modelBuilder.Entity<ClubCloud_Functionaris>().MapToStoredProcedures();
    
    		modelBuilder.Entity<ClubCloud_Functionaris>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
    
    		//modelBuilder.Entity<ClubCloud_Bestuursorgaan>().MapToStoredProcedures();
    
    		modelBuilder.Entity<ClubCloud_Bestuursorgaan>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
    
    		//modelBuilder.Entity<ClubCloud_Rechtsvorm>().MapToStoredProcedures();
    
    		modelBuilder.Entity<ClubCloud_Rechtsvorm>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
    
    		//modelBuilder.Entity<ClubCloud_Address>().MapToStoredProcedures();
    
    		modelBuilder.Entity<ClubCloud_Address>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
    
    		//modelBuilder.Entity<ClubCloud_Regio>().MapToStoredProcedures();
    
    		modelBuilder.Entity<ClubCloud_Regio>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
    
    		//modelBuilder.Entity<ClubCloud_Baansoort>().MapToStoredProcedures();
    
    		modelBuilder.Entity<ClubCloud_Baansoort>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
    
    		//modelBuilder.Entity<ClubCloud_Baantype>().MapToStoredProcedures();
    
    		modelBuilder.Entity<ClubCloud_Baantype>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
    
    		//modelBuilder.Entity<ClubCloud_Baan>().MapToStoredProcedures();
    
    		modelBuilder.Entity<ClubCloud_Baan>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
    
    		//modelBuilder.Entity<ClubCloud_Bouwaard>().MapToStoredProcedures();
    
    		modelBuilder.Entity<ClubCloud_Bouwaard>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
    
    		//modelBuilder.Entity<ClubCloud_BaanSpeciaal>().MapToStoredProcedures();
    
    		modelBuilder.Entity<ClubCloud_BaanSpeciaal>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
    
    		//modelBuilder.Entity<ClubCloud_Reservering>().MapToStoredProcedures();
    
    		modelBuilder.Entity<ClubCloud_Reservering>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
    
    		//modelBuilder.Entity<ClubCloud_Afhang>().MapToStoredProcedures();
    
    		modelBuilder.Entity<ClubCloud_Afhang>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
    
    		//modelBuilder.Entity<ClubCloud_Baanschema>().MapToStoredProcedures();
    
    		modelBuilder.Entity<ClubCloud_Baanschema>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
    
    		//modelBuilder.Entity<ClubCloud_Foto>().MapToStoredProcedures();
    
    		modelBuilder.Entity<ClubCloud_Foto>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
    
    		//modelBuilder.Entity<ClubCloud_Lidmaatschapsoort>().MapToStoredProcedures();
    
    		modelBuilder.Entity<ClubCloud_Lidmaatschapsoort>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
    
    		//modelBuilder.Entity<ClubCloud_Sponsor>().MapToStoredProcedures();
    
    		modelBuilder.Entity<ClubCloud_Sponsor>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
    
    		//modelBuilder.Entity<ClubCloud_Sponsor_Afbeelding>().MapToStoredProcedures();
    
    		modelBuilder.Entity<ClubCloud_Sponsor_Afbeelding>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
    
    		//modelBuilder.Entity<ClubCloud_Baanblok>().MapToStoredProcedures();
    
    		modelBuilder.Entity<ClubCloud_Baanblok>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
    
    		//modelBuilder.Entity<ClubCloud_Baantoplaag>().MapToStoredProcedures();
    
    		modelBuilder.Entity<ClubCloud_Baantoplaag>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
    
    		base.OnModelCreating(modelBuilder);
        }
    
        public virtual DbSet<ClubCloud_Setting> ClubCloud_Settings { get; set; }
        public virtual DbSet<ClubCloud_Vereniging> ClubCloud_Verenigingen { get; set; }
        public virtual DbSet<ClubCloud_Gebruiker> ClubCloud_Gebruikers { get; set; }
        public virtual DbSet<ClubCloud_Accommodatie> ClubCloud_Accommodaties { get; set; }
        public virtual DbSet<ClubCloud_Nationaliteit> ClubCloud_Nationaliteiten { get; set; }
        public virtual DbSet<ClubCloud_District> ClubCloud_Districten { get; set; }
        public virtual DbSet<ClubCloud_Functie> ClubCloud_Functies { get; set; }
        public virtual DbSet<ClubCloud_Lidmaatschap> ClubCloud_Lidmaatschappen { get; set; }
        public virtual DbSet<ClubCloud_Profiel> ClubCloud_Profielen { get; set; }
        public virtual DbSet<ClubCloud_Functionaris> ClubCloud_Functionarissen { get; set; }
        public virtual DbSet<ClubCloud_Bestuursorgaan> ClubCloud_Bestuursorganen { get; set; }
        public virtual DbSet<ClubCloud_Rechtsvorm> ClubCloud_Rechtsvormen { get; set; }
        public virtual DbSet<ClubCloud_Address> ClubCloud_Addresses { get; set; }
        public virtual DbSet<ClubCloud_Regio> ClubCloud_Regios { get; set; }
        public virtual DbSet<ClubCloud_Baansoort> ClubCloud_Baansoorten { get; set; }
        public virtual DbSet<ClubCloud_Baantype> ClubCloud_Baantypes { get; set; }
        public virtual DbSet<ClubCloud_Baan> ClubCloud_Banen { get; set; }
        public virtual DbSet<ClubCloud_Bouwaard> ClubCloud_Bouwaarden { get; set; }
        public virtual DbSet<ClubCloud_BaanSpeciaal> ClubCloud_BanenSpeciaal { get; set; }
        public virtual DbSet<ClubCloud_Reservering> ClubCloud_Reserveringen { get; set; }
        public virtual DbSet<ClubCloud_Afhang> ClubCloud_Afhangen { get; set; }
        public virtual DbSet<ClubCloud_Baanschema> ClubCloud_Baanschemas { get; set; }
        public virtual DbSet<ClubCloud_Foto> ClubCloud_Fotos { get; set; }
        public virtual DbSet<ClubCloud_Lidmaatschapsoort> ClubCloud_Lidmaatschapsoorten { get; set; }
        public virtual DbSet<ClubCloud_Sponsor> ClubCloud_Sponsoren { get; set; }
        public virtual DbSet<ClubCloud_Sponsor_Afbeelding> ClubCloud_Sponsor_Afbeeldingen { get; set; }
        public virtual DbSet<ClubCloud_Baanblok> ClubCloud_Baanblokken { get; set; }
        public virtual DbSet<ClubCloud_Baantoplaag> ClubCloud_Baantoplagen { get; set; }
    }
}
