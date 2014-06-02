
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/02/2014 11:35:37
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


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ClubCloud_Gebruikers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubCloud_Gebruikers];
GO
IF OBJECT_ID(N'[dbo].[ClubCloud_Verenigingen]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubCloud_Verenigingen];
GO
IF OBJECT_ID(N'[dbo].[ClubCloud_TrackingSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubCloud_TrackingSet];
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
    [VerenigingsId] uniqueidentifier  NOT NULL,
    [BanknummerPlaats] nvarchar(max)  NOT NULL,
    [Bezoekadres] nvarchar(max)  NOT NULL,
    [BezoekadresGemeente] nvarchar(max)  NOT NULL,
    [BezoekadresPlaats] nvarchar(max)  NOT NULL,
    [BezoekadresPostcode] nvarchar(max)  NOT NULL,
    [DatumOpgericht] datetime  NOT NULL,
    [District] nvarchar(max)  NOT NULL,
    [Emailadres] nvarchar(max)  NOT NULL,
    [IbanCode] nvarchar(max)  NOT NULL,
    [KvKnummer] nvarchar(max)  NOT NULL,
    [KvKplaats] nvarchar(max)  NOT NULL,
    [Naam] nvarchar(max)  NOT NULL,
    [Postadres] nvarchar(max)  NOT NULL,
    [PostadresGemeente] nvarchar(max)  NOT NULL,
    [PostadresPlaats] nvarchar(max)  NOT NULL,
    [PostadresPostcode] nvarchar(max)  NOT NULL,
    [Regio] nvarchar(max)  NOT NULL,
    [TelefoonnummerAvond] nvarchar(max)  NOT NULL,
    [TelefoonnummerOverdag] nvarchar(max)  NOT NULL,
    [Verenigingsnummer] nvarchar(max)  NOT NULL,
    [Website] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ClubCloud_TrackingSet'
CREATE TABLE [dbo].[ClubCloud_TrackingSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Data] nvarchar(max)  NOT NULL
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

-- Creating primary key on [VerenigingsId] in table 'ClubCloud_Verenigingen'
ALTER TABLE [dbo].[ClubCloud_Verenigingen]
ADD CONSTRAINT [PK_ClubCloud_Verenigingen]
    PRIMARY KEY CLUSTERED ([VerenigingsId] ASC);
GO

-- Creating primary key on [Id] in table 'ClubCloud_TrackingSet'
ALTER TABLE [dbo].[ClubCloud_TrackingSet]
ADD CONSTRAINT [PK_ClubCloud_TrackingSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------