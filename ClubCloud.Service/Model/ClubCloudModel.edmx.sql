
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/31/2014 10:21:34
-- Generated from EDMX file: C:\Source\ClubCloud\ClubCloud.Service\Model\ClubCloudModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ClubCloudService_DB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Gebruiker_ClubCloud_Vereniging_ClubCloud_Gebruiker]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Gebruiker_ClubCloud_Vereniging] DROP CONSTRAINT [FK_ClubCloud_Gebruiker_ClubCloud_Vereniging_ClubCloud_Gebruiker];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Gebruiker_ClubCloud_Vereniging_ClubCloud_Vereniging]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Gebruiker_ClubCloud_Vereniging] DROP CONSTRAINT [FK_ClubCloud_Gebruiker_ClubCloud_Vereniging_ClubCloud_Vereniging];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Vereniging_ClubCloud_Accomodatie_ClubCloud_Vereniging]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Vereniging_ClubCloud_Accomodatie] DROP CONSTRAINT [FK_ClubCloud_Vereniging_ClubCloud_Accomodatie_ClubCloud_Vereniging];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Vereniging_ClubCloud_Accomodatie_ClubCloud_Accomodatie]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Vereniging_ClubCloud_Accomodatie] DROP CONSTRAINT [FK_ClubCloud_Vereniging_ClubCloud_Accomodatie_ClubCloud_Accomodatie];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ClubCloud_Gebruikers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubCloud_Gebruikers];
GO
IF OBJECT_ID(N'[dbo].[ClubCloud_Verenigingen]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubCloud_Verenigingen];
GO
IF OBJECT_ID(N'[dbo].[ClubCloud_Accomodaties]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubCloud_Accomodaties];
GO
IF OBJECT_ID(N'[dbo].[ClubCloud_Gebruiker_ClubCloud_Vereniging]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubCloud_Gebruiker_ClubCloud_Vereniging];
GO
IF OBJECT_ID(N'[dbo].[ClubCloud_Vereniging_ClubCloud_Accomodatie]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubCloud_Vereniging_ClubCloud_Accomodatie];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ClubCloud_Gebruikers'
CREATE TABLE [dbo].[ClubCloud_Gebruikers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] varchar(max)  NULL,
    [MiddleName] varchar(max)  NULL,
    [LastName] varchar(max)  NULL,
    [mijnknltb_password] varchar(max)  NULL,
    [oauth_token] varchar(max)  NULL,
    [oauth_token_secret] varchar(max)  NULL
);
GO

-- Creating table 'ClubCloud_Verenigingen'
CREATE TABLE [dbo].[ClubCloud_Verenigingen] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [mijnknltb_id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'ClubCloud_Accomodaties'
CREATE TABLE [dbo].[ClubCloud_Accomodaties] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [mijnknltb_id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'ClubCloud_Gebruiker_ClubCloud_Vereniging'
CREATE TABLE [dbo].[ClubCloud_Gebruiker_ClubCloud_Vereniging] (
    [ClubCloud_Gebruiker_Id] int  NOT NULL,
    [ClubCloud_Vereniging_Id] int  NOT NULL
);
GO

-- Creating table 'ClubCloud_Vereniging_ClubCloud_Accomodatie'
CREATE TABLE [dbo].[ClubCloud_Vereniging_ClubCloud_Accomodatie] (
    [ClubCloud_Vereniging_Id] int  NOT NULL,
    [ClubCloud_Accomodatie_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ClubCloud_Gebruikers'
ALTER TABLE [dbo].[ClubCloud_Gebruikers]
ADD CONSTRAINT [PK_ClubCloud_Gebruikers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClubCloud_Verenigingen'
ALTER TABLE [dbo].[ClubCloud_Verenigingen]
ADD CONSTRAINT [PK_ClubCloud_Verenigingen]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClubCloud_Accomodaties'
ALTER TABLE [dbo].[ClubCloud_Accomodaties]
ADD CONSTRAINT [PK_ClubCloud_Accomodaties]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [ClubCloud_Gebruiker_Id], [ClubCloud_Vereniging_Id] in table 'ClubCloud_Gebruiker_ClubCloud_Vereniging'
ALTER TABLE [dbo].[ClubCloud_Gebruiker_ClubCloud_Vereniging]
ADD CONSTRAINT [PK_ClubCloud_Gebruiker_ClubCloud_Vereniging]
    PRIMARY KEY CLUSTERED ([ClubCloud_Gebruiker_Id], [ClubCloud_Vereniging_Id] ASC);
GO

-- Creating primary key on [ClubCloud_Vereniging_Id], [ClubCloud_Accomodatie_Id] in table 'ClubCloud_Vereniging_ClubCloud_Accomodatie'
ALTER TABLE [dbo].[ClubCloud_Vereniging_ClubCloud_Accomodatie]
ADD CONSTRAINT [PK_ClubCloud_Vereniging_ClubCloud_Accomodatie]
    PRIMARY KEY CLUSTERED ([ClubCloud_Vereniging_Id], [ClubCloud_Accomodatie_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ClubCloud_Gebruiker_Id] in table 'ClubCloud_Gebruiker_ClubCloud_Vereniging'
ALTER TABLE [dbo].[ClubCloud_Gebruiker_ClubCloud_Vereniging]
ADD CONSTRAINT [FK_ClubCloud_Gebruiker_ClubCloud_Vereniging_ClubCloud_Gebruiker]
    FOREIGN KEY ([ClubCloud_Gebruiker_Id])
    REFERENCES [dbo].[ClubCloud_Gebruikers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ClubCloud_Vereniging_Id] in table 'ClubCloud_Gebruiker_ClubCloud_Vereniging'
ALTER TABLE [dbo].[ClubCloud_Gebruiker_ClubCloud_Vereniging]
ADD CONSTRAINT [FK_ClubCloud_Gebruiker_ClubCloud_Vereniging_ClubCloud_Vereniging]
    FOREIGN KEY ([ClubCloud_Vereniging_Id])
    REFERENCES [dbo].[ClubCloud_Verenigingen]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_Gebruiker_ClubCloud_Vereniging_ClubCloud_Vereniging'
CREATE INDEX [IX_FK_ClubCloud_Gebruiker_ClubCloud_Vereniging_ClubCloud_Vereniging]
ON [dbo].[ClubCloud_Gebruiker_ClubCloud_Vereniging]
    ([ClubCloud_Vereniging_Id]);
GO

-- Creating foreign key on [ClubCloud_Vereniging_Id] in table 'ClubCloud_Vereniging_ClubCloud_Accomodatie'
ALTER TABLE [dbo].[ClubCloud_Vereniging_ClubCloud_Accomodatie]
ADD CONSTRAINT [FK_ClubCloud_Vereniging_ClubCloud_Accomodatie_ClubCloud_Vereniging]
    FOREIGN KEY ([ClubCloud_Vereniging_Id])
    REFERENCES [dbo].[ClubCloud_Verenigingen]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ClubCloud_Accomodatie_Id] in table 'ClubCloud_Vereniging_ClubCloud_Accomodatie'
ALTER TABLE [dbo].[ClubCloud_Vereniging_ClubCloud_Accomodatie]
ADD CONSTRAINT [FK_ClubCloud_Vereniging_ClubCloud_Accomodatie_ClubCloud_Accomodatie]
    FOREIGN KEY ([ClubCloud_Accomodatie_Id])
    REFERENCES [dbo].[ClubCloud_Accomodaties]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_Vereniging_ClubCloud_Accomodatie_ClubCloud_Accomodatie'
CREATE INDEX [IX_FK_ClubCloud_Vereniging_ClubCloud_Accomodatie_ClubCloud_Accomodatie]
ON [dbo].[ClubCloud_Vereniging_ClubCloud_Accomodatie]
    ([ClubCloud_Accomodatie_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------