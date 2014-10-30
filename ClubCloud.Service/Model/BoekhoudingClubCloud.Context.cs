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
    
    public partial class BoekhoudingContainer : DbContext
    {
    	private static string NameOrConnectionString = "name=BoekhoudingContainer";
    
    	public BoekhoudingContainer()
            : this(false) { }
    
        public BoekhoudingContainer(bool proxyCreationEnabled)
            : base(NameOrConnectionString)
        {
    				this.Configuration.ProxyCreationEnabled = proxyCreationEnabled;
    
    		if (!Database.CompatibleWithModel(false))
    		{
    			Database.SetInitializer<BoekhoudingContainer>(new MigrateDatabaseToLatestVersion<BoekhoudingContainer, BoekhoudingConfiguration>());
    		}
    		if (!Database.Exists(NameOrConnectionString))
    		{
    			Database.SetInitializer<BoekhoudingContainer>(new CreateDatabaseIfNotExists<BoekhoudingContainer>());
    		}
    
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
    
    		if (!Database.CompatibleWithModel(false))
    		{
    			Database.SetInitializer<BoekhoudingContainer>(new MigrateDatabaseToLatestVersion<BoekhoudingContainer, BoekhoudingConfiguration>());
    		}
    		if (!Database.Exists(NameOrConnectionString))
    		{
    			Database.SetInitializer<BoekhoudingContainer>(new CreateDatabaseIfNotExists<BoekhoudingContainer>());
    		}
    
    		//Database.SetInitializer<BoekhoudingContainer>(new CreateDatabaseIfNotExists<BoekhoudingContainer>());
    		//Database.SetInitializer<BoekhoudingContainer>(new MigrateDatabaseToLatestVersion<BoekhoudingContainer, BoekhoudingConfiguration>());
    	}	
    	
        public ObjectContext ObjectContext
        {
          get { return ((IObjectContextAdapter)this).ObjectContext; }
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
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
