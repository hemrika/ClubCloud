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
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Data.Entity.Core;
    using System.Data.Entity.Core.Objects;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Data.Entity.Validation;
    using System.Diagnostics;
    
    public partial class BoekhoudingContainer : DbContext
    {
    	private static string NameOrConnectionString = "name=BoekhoudingContainer";
    	
    	static BoekhoudingContainer ()
    	{
            //DbInterception.Add(new BeheerFullTextInterceptor());
        }
    
    	public BoekhoudingContainer()
            : this(false) { }
    
        public BoekhoudingContainer(bool proxyCreationEnabled)
            : base(NameOrConnectionString)
        {
    		
    		this.Configuration.ProxyCreationEnabled = proxyCreationEnabled;
    
    		bool initialize = true;
    		if (!Database.Exists(NameOrConnectionString))
    		{
    			Database.SetInitializer<BoekhoudingContainer>(new CreateDatabaseIfNotExists<BoekhoudingContainer>());
    			initialize = false;
    		}
    
    		try
    		{
    			if (!Database.CompatibleWithModel(false))
    			{
    				Database.SetInitializer<BoekhoudingContainer>(new MigrateDatabaseToLatestVersion<BoekhoudingContainer, BoekhoudingConfiguration>());
    				initialize = false;
    			}
    		}
    		catch { }
    
    		Database.Initialize(initialize);
    
    		//Database.SetInitializer<BoekhoudingContainer>(new CreateDatabaseIfNotExists<BoekhoudingContainer>());
    		//Database.SetInitializer<BoekhoudingContainer>(new MigrateDatabaseToLatestVersion<BoekhoudingContainer, BoekhoudingConfiguration>());
        }
    	
        public BoekhoudingContainer(string connectionString)
          : this(connectionString, false) { NameOrConnectionString = connectionString; }
    	  
        public BoekhoudingContainer(string connectionString, bool proxyCreationEnabled)
            : base(connectionString)
        {
    			NameOrConnectionString = connectionString;
    		        this.Configuration.ProxyCreationEnabled = proxyCreationEnabled;
    
    		if (!Database.Exists(NameOrConnectionString))
    		{
    			Database.SetInitializer<BoekhoudingContainer>(new CreateDatabaseIfNotExists<BoekhoudingContainer>());
    		}
    
    		try
    		{
    			if (!Database.CompatibleWithModel(false))
    			{
    				Database.SetInitializer<BoekhoudingContainer>(new MigrateDatabaseToLatestVersion<BoekhoudingContainer, BoekhoudingConfiguration>());
    			}
    		}
    		catch { }
    
    		Database.Initialize(false);
    
    		//Database.SetInitializer<BoekhoudingContainer>(new CreateDatabaseIfNotExists<BoekhoudingContainer>());
    		//Database.SetInitializer<BoekhoudingContainer>(new MigrateDatabaseToLatestVersion<BoekhoudingContainer, BoekhoudingConfiguration>());
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
                                //entry.Reload();
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
                                //entry.Reload();
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
                                //result.Entry.Reload();
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
    		modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
    		//modelBuilder.Entity<Ledger>().MapToStoredProcedures();
    
    		modelBuilder.Entity<Ledger>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
    
    		//modelBuilder.Entity<LedgerCategory>().MapToStoredProcedures();
    
    		modelBuilder.Entity<LedgerCategory>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
    
    		//modelBuilder.Entity<Invoice>().MapToStoredProcedures();
    
    		modelBuilder.Entity<Invoice>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
    
    		//modelBuilder.Entity<CostCenter>().MapToStoredProcedures();
    
    		modelBuilder.Entity<CostCenter>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
    
    		//modelBuilder.Entity<FinancialYear>().MapToStoredProcedures();
    
    		modelBuilder.Entity<FinancialYear>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
    
    		//modelBuilder.Entity<JournalEntry>().MapToStoredProcedures();
    
    		modelBuilder.Entity<JournalEntry>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
    
    		//modelBuilder.Entity<JournalTransaction>().MapToStoredProcedures();
    
    		modelBuilder.Entity<JournalTransaction>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
    
    		//modelBuilder.Entity<JournalType>().MapToStoredProcedures();
    
    		modelBuilder.Entity<JournalType>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
    
    		//modelBuilder.Entity<JournalYear>().MapToStoredProcedures();
    
    		modelBuilder.Entity<JournalYear>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
    
    		//modelBuilder.Entity<Journal>().MapToStoredProcedures();
    
    		modelBuilder.Entity<Journal>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
    
    		//modelBuilder.Entity<Tax>().MapToStoredProcedures();
    
    		modelBuilder.Entity<Tax>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
    
    		//modelBuilder.Entity<BankAccount>().MapToStoredProcedures();
    
    		modelBuilder.Entity<BankAccount>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
    
    		//modelBuilder.Entity<InvoiceEntry>().MapToStoredProcedures();
    
    		modelBuilder.Entity<InvoiceEntry>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
    
    		//modelBuilder.Entity<Relation>().MapToStoredProcedures();
    
    		modelBuilder.Entity<Relation>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
    
    		//modelBuilder.Entity<Product>().MapToStoredProcedures();
    
    		modelBuilder.Entity<Product>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
    
    		//modelBuilder.Entity<Payable>().MapToStoredProcedures();
    
    		modelBuilder.Entity<Payable>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
    
    		//modelBuilder.Entity<Receivable>().MapToStoredProcedures();
    
    		modelBuilder.Entity<Receivable>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
    
    		//modelBuilder.Entity<Term>().MapToStoredProcedures();
    
    		modelBuilder.Entity<Term>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
    
    		//modelBuilder.Entity<Balance>().MapToStoredProcedures();
    
    		modelBuilder.Entity<Balance>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
    
    		//modelBuilder.Entity<Result>().MapToStoredProcedures();
    
    		modelBuilder.Entity<Result>().Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
    
    		base.OnModelCreating(modelBuilder);
        }
    
        public virtual DbSet<Ledger> Ledgers { get; set; }
        public virtual DbSet<LedgerCategory> LedgerCategories { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<CostCenter> CostCenters { get; set; }
        public virtual DbSet<FinancialYear> FinancialYears { get; set; }
        public virtual DbSet<JournalEntry> JournalEntries { get; set; }
        public virtual DbSet<JournalTransaction> JournalTransactions { get; set; }
        public virtual DbSet<JournalType> JournalTypes { get; set; }
        public virtual DbSet<JournalYear> JournalYears { get; set; }
        public virtual DbSet<Journal> Journals { get; set; }
        public virtual DbSet<Tax> Taxes { get; set; }
        public virtual DbSet<BankAccount> BankAccounts { get; set; }
        public virtual DbSet<InvoiceEntry> InvoiceEntries { get; set; }
        public virtual DbSet<Relation> Relations { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Payable> Payables { get; set; }
        public virtual DbSet<Receivable> Receivables { get; set; }
        public virtual DbSet<Term> Terms { get; set; }
        public virtual DbSet<Balance> Balances { get; set; }
        public virtual DbSet<Result> Results { get; set; }
    }
}
