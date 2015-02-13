
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/12/2015 18:08:13
-- Generated from EDMX file: C:\Source\ClubCloud\ClubCloud.Model\BoekhoudingClubCloud.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ClubCloudService_Boekhouding_DB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_JournalJournalType]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Journals] DROP CONSTRAINT [FK_JournalJournalType];
GO
IF OBJECT_ID(N'[dbo].[FK_JournalLedger]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Journals] DROP CONSTRAINT [FK_JournalLedger];
GO
IF OBJECT_ID(N'[dbo].[FK_JournalBankAccount]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Journals] DROP CONSTRAINT [FK_JournalBankAccount];
GO
IF OBJECT_ID(N'[dbo].[FK_JournalYearFinancialYear]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[JournalYears] DROP CONSTRAINT [FK_JournalYearFinancialYear];
GO
IF OBJECT_ID(N'[dbo].[FK_JournalEntryJournal]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[JournalEntries] DROP CONSTRAINT [FK_JournalEntryJournal];
GO
IF OBJECT_ID(N'[dbo].[FK_InvoiceJournalEntry]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[JournalEntries] DROP CONSTRAINT [FK_InvoiceJournalEntry];
GO
IF OBJECT_ID(N'[dbo].[FK_LedgerLedgerCategory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Ledgers] DROP CONSTRAINT [FK_LedgerLedgerCategory];
GO
IF OBJECT_ID(N'[dbo].[FK_JournalTransactionLedger]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[JournalTransactions] DROP CONSTRAINT [FK_JournalTransactionLedger];
GO
IF OBJECT_ID(N'[dbo].[FK_JournalTransactionJournalEntry]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[JournalTransactions] DROP CONSTRAINT [FK_JournalTransactionJournalEntry];
GO
IF OBJECT_ID(N'[dbo].[FK_JournalTransactionCostCenter]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[JournalTransactions] DROP CONSTRAINT [FK_JournalTransactionCostCenter];
GO
IF OBJECT_ID(N'[dbo].[FK_InvoiceEntryInvoice]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InvoiceEntries] DROP CONSTRAINT [FK_InvoiceEntryInvoice];
GO
IF OBJECT_ID(N'[dbo].[FK_InvoiceRelation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Invoices] DROP CONSTRAINT [FK_InvoiceRelation];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductTax]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Products] DROP CONSTRAINT [FK_ProductTax];
GO
IF OBJECT_ID(N'[dbo].[FK_InvoiceEntryProduct]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InvoiceEntries] DROP CONSTRAINT [FK_InvoiceEntryProduct];
GO
IF OBJECT_ID(N'[dbo].[FK_InvoiceTerm_Invoice]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InvoiceTerms] DROP CONSTRAINT [FK_InvoiceTerm_Invoice];
GO
IF OBJECT_ID(N'[dbo].[FK_InvoiceTerm_Term]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InvoiceTerms] DROP CONSTRAINT [FK_InvoiceTerm_Term];
GO
IF OBJECT_ID(N'[dbo].[FK_InvoiceEntryReceivable]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InvoiceEntries] DROP CONSTRAINT [FK_InvoiceEntryReceivable];
GO
IF OBJECT_ID(N'[dbo].[FK_InvoiceEntryPayable]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InvoiceEntries] DROP CONSTRAINT [FK_InvoiceEntryPayable];
GO
IF OBJECT_ID(N'[dbo].[FK_JournalEntryJournalYear]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[JournalEntries] DROP CONSTRAINT [FK_JournalEntryJournalYear];
GO
IF OBJECT_ID(N'[dbo].[FK_JournalEntryLedger]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[JournalEntries] DROP CONSTRAINT [FK_JournalEntryLedger];
GO
IF OBJECT_ID(N'[dbo].[FK_JournalEntryCostCenter]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[JournalEntries] DROP CONSTRAINT [FK_JournalEntryCostCenter];
GO
IF OBJECT_ID(N'[dbo].[FK_LedgerCostCenter]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Ledgers] DROP CONSTRAINT [FK_LedgerCostCenter];
GO
IF OBJECT_ID(N'[dbo].[FK_PayableCostCenter]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Payables] DROP CONSTRAINT [FK_PayableCostCenter];
GO
IF OBJECT_ID(N'[dbo].[FK_BalanceLedger]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Balances] DROP CONSTRAINT [FK_BalanceLedger];
GO
IF OBJECT_ID(N'[dbo].[FK_BalanceFinancialYear]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Balances] DROP CONSTRAINT [FK_BalanceFinancialYear];
GO
IF OBJECT_ID(N'[dbo].[FK_BalanceCostCenter]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Balances] DROP CONSTRAINT [FK_BalanceCostCenter];
GO
IF OBJECT_ID(N'[dbo].[FK_ResultLedger]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Results] DROP CONSTRAINT [FK_ResultLedger];
GO
IF OBJECT_ID(N'[dbo].[FK_ResultFinancialYear]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Results] DROP CONSTRAINT [FK_ResultFinancialYear];
GO
IF OBJECT_ID(N'[dbo].[FK_ResultCostCenter]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Results] DROP CONSTRAINT [FK_ResultCostCenter];
GO
IF OBJECT_ID(N'[dbo].[FK_ReceivableLedger]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Receivables] DROP CONSTRAINT [FK_ReceivableLedger];
GO
IF OBJECT_ID(N'[dbo].[FK_ReceivableFinancialYear]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Receivables] DROP CONSTRAINT [FK_ReceivableFinancialYear];
GO
IF OBJECT_ID(N'[dbo].[FK_ReceivableCostCenter]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Receivables] DROP CONSTRAINT [FK_ReceivableCostCenter];
GO
IF OBJECT_ID(N'[dbo].[FK_PayableLedger]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Payables] DROP CONSTRAINT [FK_PayableLedger];
GO
IF OBJECT_ID(N'[dbo].[FK_PayableFinancialYear]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Payables] DROP CONSTRAINT [FK_PayableFinancialYear];
GO
IF OBJECT_ID(N'[dbo].[FK_PayableCostCenter1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Payables] DROP CONSTRAINT [FK_PayableCostCenter1];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Ledgers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Ledgers];
GO
IF OBJECT_ID(N'[dbo].[LedgerCategories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LedgerCategories];
GO
IF OBJECT_ID(N'[dbo].[Invoices]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Invoices];
GO
IF OBJECT_ID(N'[dbo].[CostCenters]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CostCenters];
GO
IF OBJECT_ID(N'[dbo].[FinancialYears]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FinancialYears];
GO
IF OBJECT_ID(N'[dbo].[JournalEntries]', 'U') IS NOT NULL
    DROP TABLE [dbo].[JournalEntries];
GO
IF OBJECT_ID(N'[dbo].[JournalTransactions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[JournalTransactions];
GO
IF OBJECT_ID(N'[dbo].[JournalTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[JournalTypes];
GO
IF OBJECT_ID(N'[dbo].[JournalYears]', 'U') IS NOT NULL
    DROP TABLE [dbo].[JournalYears];
GO
IF OBJECT_ID(N'[dbo].[Journals]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Journals];
GO
IF OBJECT_ID(N'[dbo].[Taxes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Taxes];
GO
IF OBJECT_ID(N'[dbo].[BankAccounts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BankAccounts];
GO
IF OBJECT_ID(N'[dbo].[InvoiceEntries]', 'U') IS NOT NULL
    DROP TABLE [dbo].[InvoiceEntries];
GO
IF OBJECT_ID(N'[dbo].[Relations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Relations];
GO
IF OBJECT_ID(N'[dbo].[Products]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Products];
GO
IF OBJECT_ID(N'[dbo].[Payables]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Payables];
GO
IF OBJECT_ID(N'[dbo].[Receivables]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Receivables];
GO
IF OBJECT_ID(N'[dbo].[Terms]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Terms];
GO
IF OBJECT_ID(N'[dbo].[Balances]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Balances];
GO
IF OBJECT_ID(N'[dbo].[Results]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Results];
GO
IF OBJECT_ID(N'[dbo].[InvoiceTerms]', 'U') IS NOT NULL
    DROP TABLE [dbo].[InvoiceTerms];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Ledgers'
CREATE TABLE [dbo].[Ledgers] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Number] int  NOT NULL,
    [Direction] int  NOT NULL,
    [Blocked] bit  NOT NULL,
    [Dropped] bit  NOT NULL,
    [LedgerCategoryId] uniqueidentifier  NOT NULL,
    [LedgerType] int  NOT NULL,
    [ResultType] int  NOT NULL,
    [CostCenterId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'LedgerCategories'
CREATE TABLE [dbo].[LedgerCategories] (
    [Id] uniqueidentifier  NOT NULL,
    [ParentId] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [LedgerType] int  NOT NULL
);
GO

-- Creating table 'Invoices'
CREATE TABLE [dbo].[Invoices] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Date] datetime  NOT NULL,
    [DateDue] datetime  NOT NULL,
    [Number] nvarchar(max)  NOT NULL,
    [Direction] int  NOT NULL,
    [RelationId] uniqueidentifier  NOT NULL,
    [Amount] nvarchar(max)  NOT NULL,
    [AmountTax] nvarchar(max)  NOT NULL,
    [AmountState] decimal(18,0)  NOT NULL,
    [State] int  NOT NULL
);
GO

-- Creating table 'CostCenters'
CREATE TABLE [dbo].[CostCenters] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'FinancialYears'
CREATE TABLE [dbo].[FinancialYears] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [DateStart] datetime  NOT NULL,
    [DateEnd] datetime  NOT NULL,
    [Current] bit  NOT NULL,
    [Closed] bit  NOT NULL
);
GO

-- Creating table 'JournalEntries'
CREATE TABLE [dbo].[JournalEntries] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Date] nvarchar(max)  NOT NULL,
    [Number] nvarchar(max)  NOT NULL,
    [LedgerId] uniqueidentifier  NOT NULL,
    [JournalId] uniqueidentifier  NOT NULL,
    [InvoiceId] uniqueidentifier  NULL,
    [JournalYearId] uniqueidentifier  NOT NULL,
    [CostCenterId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'JournalTransactions'
CREATE TABLE [dbo].[JournalTransactions] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Date] nvarchar(max)  NOT NULL,
    [Amount] nvarchar(max)  NOT NULL,
    [Direction] int  NOT NULL,
    [LedgerId] uniqueidentifier  NOT NULL,
    [JournalEntryId] uniqueidentifier  NOT NULL,
    [CostCenterId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'JournalTypes'
CREATE TABLE [dbo].[JournalTypes] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'JournalYears'
CREATE TABLE [dbo].[JournalYears] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [FinancialYearId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Journals'
CREATE TABLE [dbo].[Journals] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Code] nvarchar(max)  NOT NULL,
    [Number] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [JournalTypeId] uniqueidentifier  NOT NULL,
    [LedgerId] uniqueidentifier  NOT NULL,
    [BankAccountId] uniqueidentifier  NULL
);
GO

-- Creating table 'Taxes'
CREATE TABLE [dbo].[Taxes] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Rate] decimal(2,0)  NOT NULL
);
GO

-- Creating table 'BankAccounts'
CREATE TABLE [dbo].[BankAccounts] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [IBAN] nvarchar(max)  NOT NULL,
    [BIC] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'InvoiceEntries'
CREATE TABLE [dbo].[InvoiceEntries] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Quantity] nvarchar(max)  NOT NULL,
    [Amount] decimal(18,0)  NOT NULL,
    [AmountTax] nvarchar(max)  NOT NULL,
    [InvoiceId] uniqueidentifier  NOT NULL,
    [ProductId] uniqueidentifier  NULL,
    [ReceivableId] uniqueidentifier  NULL,
    [PayableId] uniqueidentifier  NULL
);
GO

-- Creating table 'Relations'
CREATE TABLE [dbo].[Relations] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Number] int  NOT NULL
);
GO

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Amount] decimal(18,0)  NOT NULL,
    [TaxId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Payables'
CREATE TABLE [dbo].[Payables] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Date] nvarchar(max)  NOT NULL,
    [InvoiceId] uniqueidentifier  NULL,
    [CostCenterId] uniqueidentifier  NOT NULL,
    [LedgerId] uniqueidentifier  NOT NULL,
    [FinancialYearId] uniqueidentifier  NOT NULL,
    [CostCenterId1] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Receivables'
CREATE TABLE [dbo].[Receivables] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Date] nvarchar(max)  NOT NULL,
    [Amount] decimal(18,0)  NOT NULL,
    [InvoiceId] uniqueidentifier  NULL,
    [LedgerId] uniqueidentifier  NOT NULL,
    [FinancialYearId] uniqueidentifier  NOT NULL,
    [CostCenterId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Terms'
CREATE TABLE [dbo].[Terms] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Condition] nvarchar(max)  NOT NULL,
    [Span] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Balances'
CREATE TABLE [dbo].[Balances] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [AmountCreditstart] nvarchar(max)  NOT NULL,
    [AmountDebitStart] nvarchar(max)  NOT NULL,
    [AmountCreditBudget] nvarchar(max)  NOT NULL,
    [AmountDebitBudget] nvarchar(max)  NOT NULL,
    [AmountCreditEnd] nvarchar(max)  NOT NULL,
    [AmountDebitEnd] nvarchar(max)  NOT NULL,
    [LedgerId] uniqueidentifier  NOT NULL,
    [FinancialYearId] uniqueidentifier  NOT NULL,
    [CostCenterId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Results'
CREATE TABLE [dbo].[Results] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [AmountCreditstart] nvarchar(max)  NOT NULL,
    [AmountDebitStart] nvarchar(max)  NOT NULL,
    [AmountCreditBudget] nvarchar(max)  NOT NULL,
    [AmountDebitBudget] nvarchar(max)  NOT NULL,
    [AmountCreditEnd] nvarchar(max)  NOT NULL,
    [AmountDebitEnd] nvarchar(max)  NOT NULL,
    [LedgerId] uniqueidentifier  NOT NULL,
    [FinancialYearId] uniqueidentifier  NOT NULL,
    [CostCenterId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'InvoiceTerms'
CREATE TABLE [dbo].[InvoiceTerms] (
    [Invoices_Id] uniqueidentifier  NOT NULL,
    [Terms_Id] uniqueidentifier  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Ledgers'
ALTER TABLE [dbo].[Ledgers]
ADD CONSTRAINT [PK_Ledgers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'LedgerCategories'
ALTER TABLE [dbo].[LedgerCategories]
ADD CONSTRAINT [PK_LedgerCategories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Invoices'
ALTER TABLE [dbo].[Invoices]
ADD CONSTRAINT [PK_Invoices]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CostCenters'
ALTER TABLE [dbo].[CostCenters]
ADD CONSTRAINT [PK_CostCenters]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FinancialYears'
ALTER TABLE [dbo].[FinancialYears]
ADD CONSTRAINT [PK_FinancialYears]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'JournalEntries'
ALTER TABLE [dbo].[JournalEntries]
ADD CONSTRAINT [PK_JournalEntries]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'JournalTransactions'
ALTER TABLE [dbo].[JournalTransactions]
ADD CONSTRAINT [PK_JournalTransactions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'JournalTypes'
ALTER TABLE [dbo].[JournalTypes]
ADD CONSTRAINT [PK_JournalTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'JournalYears'
ALTER TABLE [dbo].[JournalYears]
ADD CONSTRAINT [PK_JournalYears]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Journals'
ALTER TABLE [dbo].[Journals]
ADD CONSTRAINT [PK_Journals]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Taxes'
ALTER TABLE [dbo].[Taxes]
ADD CONSTRAINT [PK_Taxes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BankAccounts'
ALTER TABLE [dbo].[BankAccounts]
ADD CONSTRAINT [PK_BankAccounts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'InvoiceEntries'
ALTER TABLE [dbo].[InvoiceEntries]
ADD CONSTRAINT [PK_InvoiceEntries]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Relations'
ALTER TABLE [dbo].[Relations]
ADD CONSTRAINT [PK_Relations]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [PK_Products]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Payables'
ALTER TABLE [dbo].[Payables]
ADD CONSTRAINT [PK_Payables]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Receivables'
ALTER TABLE [dbo].[Receivables]
ADD CONSTRAINT [PK_Receivables]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Terms'
ALTER TABLE [dbo].[Terms]
ADD CONSTRAINT [PK_Terms]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Balances'
ALTER TABLE [dbo].[Balances]
ADD CONSTRAINT [PK_Balances]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Results'
ALTER TABLE [dbo].[Results]
ADD CONSTRAINT [PK_Results]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Invoices_Id], [Terms_Id] in table 'InvoiceTerms'
ALTER TABLE [dbo].[InvoiceTerms]
ADD CONSTRAINT [PK_InvoiceTerms]
    PRIMARY KEY CLUSTERED ([Invoices_Id], [Terms_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [JournalTypeId] in table 'Journals'
ALTER TABLE [dbo].[Journals]
ADD CONSTRAINT [FK_JournalJournalType]
    FOREIGN KEY ([JournalTypeId])
    REFERENCES [dbo].[JournalTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_JournalJournalType'
CREATE INDEX [IX_FK_JournalJournalType]
ON [dbo].[Journals]
    ([JournalTypeId]);
GO

-- Creating foreign key on [LedgerId] in table 'Journals'
ALTER TABLE [dbo].[Journals]
ADD CONSTRAINT [FK_JournalLedger]
    FOREIGN KEY ([LedgerId])
    REFERENCES [dbo].[Ledgers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_JournalLedger'
CREATE INDEX [IX_FK_JournalLedger]
ON [dbo].[Journals]
    ([LedgerId]);
GO

-- Creating foreign key on [BankAccountId] in table 'Journals'
ALTER TABLE [dbo].[Journals]
ADD CONSTRAINT [FK_JournalBankAccount]
    FOREIGN KEY ([BankAccountId])
    REFERENCES [dbo].[BankAccounts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_JournalBankAccount'
CREATE INDEX [IX_FK_JournalBankAccount]
ON [dbo].[Journals]
    ([BankAccountId]);
GO

-- Creating foreign key on [FinancialYearId] in table 'JournalYears'
ALTER TABLE [dbo].[JournalYears]
ADD CONSTRAINT [FK_JournalYearFinancialYear]
    FOREIGN KEY ([FinancialYearId])
    REFERENCES [dbo].[FinancialYears]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_JournalYearFinancialYear'
CREATE INDEX [IX_FK_JournalYearFinancialYear]
ON [dbo].[JournalYears]
    ([FinancialYearId]);
GO

-- Creating foreign key on [JournalId] in table 'JournalEntries'
ALTER TABLE [dbo].[JournalEntries]
ADD CONSTRAINT [FK_JournalEntryJournal]
    FOREIGN KEY ([JournalId])
    REFERENCES [dbo].[Journals]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_JournalEntryJournal'
CREATE INDEX [IX_FK_JournalEntryJournal]
ON [dbo].[JournalEntries]
    ([JournalId]);
GO

-- Creating foreign key on [InvoiceId] in table 'JournalEntries'
ALTER TABLE [dbo].[JournalEntries]
ADD CONSTRAINT [FK_InvoiceJournalEntry]
    FOREIGN KEY ([InvoiceId])
    REFERENCES [dbo].[Invoices]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_InvoiceJournalEntry'
CREATE INDEX [IX_FK_InvoiceJournalEntry]
ON [dbo].[JournalEntries]
    ([InvoiceId]);
GO

-- Creating foreign key on [LedgerCategoryId] in table 'Ledgers'
ALTER TABLE [dbo].[Ledgers]
ADD CONSTRAINT [FK_LedgerLedgerCategory]
    FOREIGN KEY ([LedgerCategoryId])
    REFERENCES [dbo].[LedgerCategories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LedgerLedgerCategory'
CREATE INDEX [IX_FK_LedgerLedgerCategory]
ON [dbo].[Ledgers]
    ([LedgerCategoryId]);
GO

-- Creating foreign key on [LedgerId] in table 'JournalTransactions'
ALTER TABLE [dbo].[JournalTransactions]
ADD CONSTRAINT [FK_JournalTransactionLedger]
    FOREIGN KEY ([LedgerId])
    REFERENCES [dbo].[Ledgers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_JournalTransactionLedger'
CREATE INDEX [IX_FK_JournalTransactionLedger]
ON [dbo].[JournalTransactions]
    ([LedgerId]);
GO

-- Creating foreign key on [JournalEntryId] in table 'JournalTransactions'
ALTER TABLE [dbo].[JournalTransactions]
ADD CONSTRAINT [FK_JournalTransactionJournalEntry]
    FOREIGN KEY ([JournalEntryId])
    REFERENCES [dbo].[JournalEntries]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_JournalTransactionJournalEntry'
CREATE INDEX [IX_FK_JournalTransactionJournalEntry]
ON [dbo].[JournalTransactions]
    ([JournalEntryId]);
GO

-- Creating foreign key on [CostCenterId] in table 'JournalTransactions'
ALTER TABLE [dbo].[JournalTransactions]
ADD CONSTRAINT [FK_JournalTransactionCostCenter]
    FOREIGN KEY ([CostCenterId])
    REFERENCES [dbo].[CostCenters]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_JournalTransactionCostCenter'
CREATE INDEX [IX_FK_JournalTransactionCostCenter]
ON [dbo].[JournalTransactions]
    ([CostCenterId]);
GO

-- Creating foreign key on [InvoiceId] in table 'InvoiceEntries'
ALTER TABLE [dbo].[InvoiceEntries]
ADD CONSTRAINT [FK_InvoiceEntryInvoice]
    FOREIGN KEY ([InvoiceId])
    REFERENCES [dbo].[Invoices]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_InvoiceEntryInvoice'
CREATE INDEX [IX_FK_InvoiceEntryInvoice]
ON [dbo].[InvoiceEntries]
    ([InvoiceId]);
GO

-- Creating foreign key on [RelationId] in table 'Invoices'
ALTER TABLE [dbo].[Invoices]
ADD CONSTRAINT [FK_InvoiceRelation]
    FOREIGN KEY ([RelationId])
    REFERENCES [dbo].[Relations]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_InvoiceRelation'
CREATE INDEX [IX_FK_InvoiceRelation]
ON [dbo].[Invoices]
    ([RelationId]);
GO

-- Creating foreign key on [TaxId] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [FK_ProductTax]
    FOREIGN KEY ([TaxId])
    REFERENCES [dbo].[Taxes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductTax'
CREATE INDEX [IX_FK_ProductTax]
ON [dbo].[Products]
    ([TaxId]);
GO

-- Creating foreign key on [ProductId] in table 'InvoiceEntries'
ALTER TABLE [dbo].[InvoiceEntries]
ADD CONSTRAINT [FK_InvoiceEntryProduct]
    FOREIGN KEY ([ProductId])
    REFERENCES [dbo].[Products]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_InvoiceEntryProduct'
CREATE INDEX [IX_FK_InvoiceEntryProduct]
ON [dbo].[InvoiceEntries]
    ([ProductId]);
GO

-- Creating foreign key on [Invoices_Id] in table 'InvoiceTerms'
ALTER TABLE [dbo].[InvoiceTerms]
ADD CONSTRAINT [FK_InvoiceTerm_Invoice]
    FOREIGN KEY ([Invoices_Id])
    REFERENCES [dbo].[Invoices]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Terms_Id] in table 'InvoiceTerms'
ALTER TABLE [dbo].[InvoiceTerms]
ADD CONSTRAINT [FK_InvoiceTerm_Term]
    FOREIGN KEY ([Terms_Id])
    REFERENCES [dbo].[Terms]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_InvoiceTerm_Term'
CREATE INDEX [IX_FK_InvoiceTerm_Term]
ON [dbo].[InvoiceTerms]
    ([Terms_Id]);
GO

-- Creating foreign key on [ReceivableId] in table 'InvoiceEntries'
ALTER TABLE [dbo].[InvoiceEntries]
ADD CONSTRAINT [FK_InvoiceEntryReceivable]
    FOREIGN KEY ([ReceivableId])
    REFERENCES [dbo].[Receivables]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_InvoiceEntryReceivable'
CREATE INDEX [IX_FK_InvoiceEntryReceivable]
ON [dbo].[InvoiceEntries]
    ([ReceivableId]);
GO

-- Creating foreign key on [PayableId] in table 'InvoiceEntries'
ALTER TABLE [dbo].[InvoiceEntries]
ADD CONSTRAINT [FK_InvoiceEntryPayable]
    FOREIGN KEY ([PayableId])
    REFERENCES [dbo].[Payables]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_InvoiceEntryPayable'
CREATE INDEX [IX_FK_InvoiceEntryPayable]
ON [dbo].[InvoiceEntries]
    ([PayableId]);
GO

-- Creating foreign key on [JournalYearId] in table 'JournalEntries'
ALTER TABLE [dbo].[JournalEntries]
ADD CONSTRAINT [FK_JournalEntryJournalYear]
    FOREIGN KEY ([JournalYearId])
    REFERENCES [dbo].[JournalYears]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_JournalEntryJournalYear'
CREATE INDEX [IX_FK_JournalEntryJournalYear]
ON [dbo].[JournalEntries]
    ([JournalYearId]);
GO

-- Creating foreign key on [LedgerId] in table 'JournalEntries'
ALTER TABLE [dbo].[JournalEntries]
ADD CONSTRAINT [FK_JournalEntryLedger]
    FOREIGN KEY ([LedgerId])
    REFERENCES [dbo].[Ledgers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_JournalEntryLedger'
CREATE INDEX [IX_FK_JournalEntryLedger]
ON [dbo].[JournalEntries]
    ([LedgerId]);
GO

-- Creating foreign key on [CostCenterId] in table 'JournalEntries'
ALTER TABLE [dbo].[JournalEntries]
ADD CONSTRAINT [FK_JournalEntryCostCenter]
    FOREIGN KEY ([CostCenterId])
    REFERENCES [dbo].[CostCenters]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_JournalEntryCostCenter'
CREATE INDEX [IX_FK_JournalEntryCostCenter]
ON [dbo].[JournalEntries]
    ([CostCenterId]);
GO

-- Creating foreign key on [CostCenterId] in table 'Ledgers'
ALTER TABLE [dbo].[Ledgers]
ADD CONSTRAINT [FK_LedgerCostCenter]
    FOREIGN KEY ([CostCenterId])
    REFERENCES [dbo].[CostCenters]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LedgerCostCenter'
CREATE INDEX [IX_FK_LedgerCostCenter]
ON [dbo].[Ledgers]
    ([CostCenterId]);
GO

-- Creating foreign key on [CostCenterId] in table 'Payables'
ALTER TABLE [dbo].[Payables]
ADD CONSTRAINT [FK_PayableCostCenter]
    FOREIGN KEY ([CostCenterId])
    REFERENCES [dbo].[CostCenters]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PayableCostCenter'
CREATE INDEX [IX_FK_PayableCostCenter]
ON [dbo].[Payables]
    ([CostCenterId]);
GO

-- Creating foreign key on [LedgerId] in table 'Balances'
ALTER TABLE [dbo].[Balances]
ADD CONSTRAINT [FK_BalanceLedger]
    FOREIGN KEY ([LedgerId])
    REFERENCES [dbo].[Ledgers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BalanceLedger'
CREATE INDEX [IX_FK_BalanceLedger]
ON [dbo].[Balances]
    ([LedgerId]);
GO

-- Creating foreign key on [FinancialYearId] in table 'Balances'
ALTER TABLE [dbo].[Balances]
ADD CONSTRAINT [FK_BalanceFinancialYear]
    FOREIGN KEY ([FinancialYearId])
    REFERENCES [dbo].[FinancialYears]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BalanceFinancialYear'
CREATE INDEX [IX_FK_BalanceFinancialYear]
ON [dbo].[Balances]
    ([FinancialYearId]);
GO

-- Creating foreign key on [CostCenterId] in table 'Balances'
ALTER TABLE [dbo].[Balances]
ADD CONSTRAINT [FK_BalanceCostCenter]
    FOREIGN KEY ([CostCenterId])
    REFERENCES [dbo].[CostCenters]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BalanceCostCenter'
CREATE INDEX [IX_FK_BalanceCostCenter]
ON [dbo].[Balances]
    ([CostCenterId]);
GO

-- Creating foreign key on [LedgerId] in table 'Results'
ALTER TABLE [dbo].[Results]
ADD CONSTRAINT [FK_ResultLedger]
    FOREIGN KEY ([LedgerId])
    REFERENCES [dbo].[Ledgers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ResultLedger'
CREATE INDEX [IX_FK_ResultLedger]
ON [dbo].[Results]
    ([LedgerId]);
GO

-- Creating foreign key on [FinancialYearId] in table 'Results'
ALTER TABLE [dbo].[Results]
ADD CONSTRAINT [FK_ResultFinancialYear]
    FOREIGN KEY ([FinancialYearId])
    REFERENCES [dbo].[FinancialYears]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ResultFinancialYear'
CREATE INDEX [IX_FK_ResultFinancialYear]
ON [dbo].[Results]
    ([FinancialYearId]);
GO

-- Creating foreign key on [CostCenterId] in table 'Results'
ALTER TABLE [dbo].[Results]
ADD CONSTRAINT [FK_ResultCostCenter]
    FOREIGN KEY ([CostCenterId])
    REFERENCES [dbo].[CostCenters]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ResultCostCenter'
CREATE INDEX [IX_FK_ResultCostCenter]
ON [dbo].[Results]
    ([CostCenterId]);
GO

-- Creating foreign key on [LedgerId] in table 'Receivables'
ALTER TABLE [dbo].[Receivables]
ADD CONSTRAINT [FK_ReceivableLedger]
    FOREIGN KEY ([LedgerId])
    REFERENCES [dbo].[Ledgers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ReceivableLedger'
CREATE INDEX [IX_FK_ReceivableLedger]
ON [dbo].[Receivables]
    ([LedgerId]);
GO

-- Creating foreign key on [FinancialYearId] in table 'Receivables'
ALTER TABLE [dbo].[Receivables]
ADD CONSTRAINT [FK_ReceivableFinancialYear]
    FOREIGN KEY ([FinancialYearId])
    REFERENCES [dbo].[FinancialYears]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ReceivableFinancialYear'
CREATE INDEX [IX_FK_ReceivableFinancialYear]
ON [dbo].[Receivables]
    ([FinancialYearId]);
GO

-- Creating foreign key on [CostCenterId] in table 'Receivables'
ALTER TABLE [dbo].[Receivables]
ADD CONSTRAINT [FK_ReceivableCostCenter]
    FOREIGN KEY ([CostCenterId])
    REFERENCES [dbo].[CostCenters]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ReceivableCostCenter'
CREATE INDEX [IX_FK_ReceivableCostCenter]
ON [dbo].[Receivables]
    ([CostCenterId]);
GO

-- Creating foreign key on [LedgerId] in table 'Payables'
ALTER TABLE [dbo].[Payables]
ADD CONSTRAINT [FK_PayableLedger]
    FOREIGN KEY ([LedgerId])
    REFERENCES [dbo].[Ledgers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PayableLedger'
CREATE INDEX [IX_FK_PayableLedger]
ON [dbo].[Payables]
    ([LedgerId]);
GO

-- Creating foreign key on [FinancialYearId] in table 'Payables'
ALTER TABLE [dbo].[Payables]
ADD CONSTRAINT [FK_PayableFinancialYear]
    FOREIGN KEY ([FinancialYearId])
    REFERENCES [dbo].[FinancialYears]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PayableFinancialYear'
CREATE INDEX [IX_FK_PayableFinancialYear]
ON [dbo].[Payables]
    ([FinancialYearId]);
GO

-- Creating foreign key on [CostCenterId1] in table 'Payables'
ALTER TABLE [dbo].[Payables]
ADD CONSTRAINT [FK_PayableCostCenter1]
    FOREIGN KEY ([CostCenterId1])
    REFERENCES [dbo].[CostCenters]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PayableCostCenter1'
CREATE INDEX [IX_FK_PayableCostCenter1]
ON [dbo].[Payables]
    ([CostCenterId1]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------