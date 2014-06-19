
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/19/2014 22:21:47
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

IF OBJECT_ID(N'[dbo].[ClubCloud_TrackingSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubCloud_TrackingSet];
GO
IF OBJECT_ID(N'[dbo].[ClubCloud_Gebruiker_Abonementen]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubCloud_Gebruiker_Abonementen];
GO
IF OBJECT_ID(N'[dbo].[ClubCloud_Abonnementen]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubCloud_Abonnementen];
GO
IF OBJECT_ID(N'[dbo].[ClubCloud_Vereniging_Accomodaties]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubCloud_Vereniging_Accomodaties];
GO
IF OBJECT_ID(N'[dbo].[ClubCloud_Gebruiker_Verenigingen]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubCloud_Gebruiker_Verenigingen];
GO
IF OBJECT_ID(N'[dbo].[ClubCloud_Vereniging_BestuursLeden]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubCloud_Vereniging_BestuursLeden];
GO
IF OBJECT_ID(N'[dbo].[ClubCloud_Settings]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubCloud_Settings];
GO
IF OBJECT_ID(N'[dbo].[ClubCloud_Verenigingen]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubCloud_Verenigingen];
GO
IF OBJECT_ID(N'[dbo].[ClubCloud_Gebruikers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubCloud_Gebruikers];
GO
IF OBJECT_ID(N'[dbo].[ClubCloud_Accomodaties]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubCloud_Accomodaties];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ClubCloud_TrackingSet'
CREATE TABLE [dbo].[ClubCloud_TrackingSet] (
    [Id] uniqueidentifier  NOT NULL,
    [Data] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ClubCloud_Gebruiker_Abonementen'
CREATE TABLE [dbo].[ClubCloud_Gebruiker_Abonementen] (
    [Id] uniqueidentifier  NOT NULL,
    [UserUpdate] datetime  NULL,
    [ClubUpdate] datetime  NULL,
    [ClubCloudUpdate] datetime  NULL
);
GO

-- Creating table 'ClubCloud_Abonnementen'
CREATE TABLE [dbo].[ClubCloud_Abonnementen] (
    [Id] uniqueidentifier  NOT NULL,
    [UserUpdate] datetime  NULL,
    [ClubUpdate] datetime  NULL,
    [ClubCloudUpdate] datetime  NULL
);
GO

-- Creating table 'ClubCloud_Vereniging_Accomodaties'
CREATE TABLE [dbo].[ClubCloud_Vereniging_Accomodaties] (
    [Id] uniqueidentifier  NOT NULL,
    [AccommodatieNaam] nvarchar(max)  NOT NULL,
    [BezoekAdres_Straat] nvarchar(max)  NOT NULL,
    [BezoekAdres_Huisnummer] nvarchar(max)  NOT NULL,
    [BezoekAdres_Toevoeging] nvarchar(max)  NOT NULL,
    [BezoekAdres_Postcode] nvarchar(max)  NOT NULL,
    [BezoekAdres_Plaats] nvarchar(max)  NOT NULL,
    [BezoekAdres_Gemeente] nvarchar(max)  NOT NULL,
    [Minibanen] nvarchar(max)  NOT NULL,
    [Oefenmuren] nvarchar(max)  NOT NULL,
    [Ondergrond] nvarchar(max)  NOT NULL,
    [Playgrounds] nvarchar(max)  NOT NULL,
    [PostAdres_Straat] nvarchar(max)  NOT NULL,
    [PostAdres_Huisnummer] nvarchar(max)  NOT NULL,
    [PostAdres_Toevoeging] nvarchar(max)  NOT NULL,
    [PostAdres_Postcode] nvarchar(max)  NOT NULL,
    [PostAdres_Plaats] nvarchar(max)  NOT NULL,
    [PostAdres_Gemeente] nvarchar(max)  NOT NULL,
    [Speeltoestellen] nvarchar(max)  NOT NULL,
    [TelefoonNummer] nvarchar(max)  NOT NULL,
    [UserUpdate] datetime  NULL,
    [ClubUpdate] datetime  NULL,
    [ClubCloudUpdate] datetime  NULL
);
GO

-- Creating table 'ClubCloud_Gebruiker_Verenigingen'
CREATE TABLE [dbo].[ClubCloud_Gebruiker_Verenigingen] (
    [Id] uniqueidentifier  NOT NULL,
    [VerenigingId] uniqueidentifier  NOT NULL,
    [VerenigingNaam] nvarchar(max)  NOT NULL,
    [UserUpdate] datetime  NULL,
    [ClubUpdate] datetime  NULL,
    [ClubCloudUpdate] datetime  NULL
);
GO

-- Creating table 'ClubCloud_Vereniging_BestuursLeden'
CREATE TABLE [dbo].[ClubCloud_Vereniging_BestuursLeden] (
    [Id] uniqueidentifier  NOT NULL,
    [VerenigingId] uniqueidentifier  NOT NULL,
    [Emailadres] nvarchar(max)  NOT NULL,
    [Functie] nvarchar(max)  NOT NULL,
    [Orgaan] nvarchar(max)  NOT NULL,
    [Telefoon] nvarchar(max)  NOT NULL,
    [VolledigeNaam] nvarchar(max)  NOT NULL,
    [UserUpdate] datetime  NULL,
    [ClubUpdate] datetime  NULL,
    [ClubCloudUpdate] datetime  NULL
);
GO

-- Creating table 'ClubCloud_Settings'
CREATE TABLE [dbo].[ClubCloud_Settings] (
    [Id] int  NOT NULL,
    [mijnknltb_Id] uniqueidentifier  NULL,
    [mijnknltb_allow] bit  NOT NULL,
    [mijnknltb_password] nvarchar(max)  NULL,
    [mijnknltb_tracking] bit  NOT NULL,
    [twitter_allow] bit  NOT NULL,
    [twitter_oauth_token] nvarchar(max)  NULL,
    [twitter_oauth_token_secret] nvarchar(max)  NULL,
    [twitter_setting] int  NOT NULL,
    [facebook_allow] bit  NOT NULL,
    [facebook_access_token] nvarchar(max)  NULL,
    [facebook_setting] int  NOT NULL,
    [privacy] int  NOT NULL,
    [financieel] int  NOT NULL,
    [UserUpdate] datetime  NULL,
    [ClubUpdate] datetime  NULL,
    [ClubCloudUpdate] datetime  NULL
);
GO

-- Creating table 'ClubCloud_Verenigingen'
CREATE TABLE [dbo].[ClubCloud_Verenigingen] (
    [Id] uniqueidentifier  NOT NULL,
    [BanknummerPlaats] nvarchar(max)  NOT NULL,
    [Bezoekadres] nvarchar(max)  NOT NULL,
    [BezoekadresGemeente] nvarchar(max)  NOT NULL,
    [BezoekadresPlaats] nvarchar(max)  NOT NULL,
    [BezoekadresPostcode] nvarchar(max)  NOT NULL,
    [DatumOpgericht] datetime  NULL,
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
    [Website] nvarchar(max)  NOT NULL,
    [UserUpdate] datetime  NULL,
    [ClubUpdate] datetime  NULL,
    [ClubCloudUpdate] datetime  NULL
);
GO

-- Creating table 'ClubCloud_Gebruikers'
CREATE TABLE [dbo].[ClubCloud_Gebruikers] (
    [Id] uniqueidentifier  NOT NULL,
    [Achternaam] nvarchar(max)  NOT NULL,
    [DistrictNaam] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Geboortedatum] datetime  NULL,
    [Geboorteplaats] nvarchar(max)  NOT NULL,
    [Gemeente] nvarchar(max)  NOT NULL,
    [Geslacht] int  NOT NULL,
    [Huisnummer] nvarchar(max)  NOT NULL,
    [IsLid] bit  NOT NULL,
    [Mobiel] nvarchar(max)  NOT NULL,
    [NationaliteitId] uniqueidentifier  NULL,
    [OrganisatieNummer] nvarchar(max)  NOT NULL,
    [Plaats] nvarchar(max)  NOT NULL,
    [Postcode] nvarchar(max)  NOT NULL,
    [RatingDubbel] decimal(18,0)  NULL,
    [RatingEnkel] decimal(18,0)  NULL,
    [Roepnaam] nvarchar(max)  NOT NULL,
    [SpeelsterkteDubbel] int  NULL,
    [SpeelsterkteEnkel] int  NULL,
    [Straat] nvarchar(max)  NOT NULL,
    [TelefoonAvond] nvarchar(max)  NOT NULL,
    [TelefoonOverdag] nvarchar(max)  NOT NULL,
    [Toevoeging] nvarchar(max)  NOT NULL,
    [Tussenvoegsel] nvarchar(max)  NOT NULL,
    [VolledigeNaam] nvarchar(max)  NOT NULL,
    [Voorletters] nvarchar(max)  NOT NULL,
    [Voornamen] nvarchar(max)  NOT NULL,
    [UserUpdate] datetime  NULL,
    [ClubUpdate] datetime  NULL,
    [ClubCloudUpdate] datetime  NULL
);
GO

-- Creating table 'ClubCloud_Accomodaties'
CREATE TABLE [dbo].[ClubCloud_Accomodaties] (
    [Id] uniqueidentifier  NOT NULL,
    [AccommodatieAdres_Straat] nvarchar(max)  NOT NULL,
    [AccommodatieAdres_Huisnummer] nvarchar(max)  NOT NULL,
    [AccommodatieAdres_Toevoeging] nvarchar(max)  NOT NULL,
    [AccommodatieAdres_Postcode] nvarchar(max)  NOT NULL,
    [AccommodatieAdres_Plaats] nvarchar(max)  NOT NULL,
    [AccommodatieAdres_Gemeente] nvarchar(max)  NOT NULL,
    [AantalBinnenBanen] int  NOT NULL,
    [AantalBuitenBanen] int  NOT NULL,
    [Blaashal] int  NULL,
    [BouwjaarClubhuis] nvarchar(max)  NOT NULL,
    [DatumKeuring] datetime  NULL,
    [DistrictNaam] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Faxnummer] nvarchar(max)  NOT NULL,
    [GekeurdDoor] nvarchar(max)  NOT NULL,
    [HalAanwezig] int  NULL,
    [KleedruimteClubhuisAanwezig] bit  NOT NULL,
    [MetOVBereikbaar] bit  NOT NULL,
    [MinderValideParkeerplaatsen] int  NULL,
    [Minibanen] nvarchar(max)  NOT NULL,
    [Naam] nvarchar(max)  NOT NULL,
    [Oefenmuren] nvarchar(max)  NOT NULL,
    [Ondergrond] nvarchar(max)  NOT NULL,
    [OppervlakteClubhuis] int  NULL,
    [Overkapping] int  NULL,
    [Playgrounds] nvarchar(max)  NOT NULL,
    [PostAdres_Straat] nvarchar(max)  NOT NULL,
    [PostAdres_Huisnummer] nvarchar(max)  NOT NULL,
    [PostAdres_Toevoeging] nvarchar(max)  NOT NULL,
    [PostAdres_Postcode] nvarchar(max)  NOT NULL,
    [PostAdres_Plaats] nvarchar(max)  NOT NULL,
    [PostAdres_Gemeente] nvarchar(max)  NOT NULL,
    [RegioNaam] nvarchar(max)  NOT NULL,
    [Resultaatkeuring] int  NULL,
    [RolStoeltoegankelijk] bit  NOT NULL,
    [SoortClubhuis] nvarchar(max)  NOT NULL,
    [Speeltoestellen] nvarchar(max)  NOT NULL,
    [Telefoonnummer] nvarchar(max)  NOT NULL,
    [TotaalAantalWasKleedruimte] int  NULL,
    [ValideParkeerplaatsen] int  NULL,
    [WasruimteClubhuisAanwezig] bit  NOT NULL,
    [Website] nvarchar(max)  NOT NULL,
    [UserUpdate] datetime  NULL,
    [ClubUpdate] datetime  NULL,
    [ClubCloudUpdate] datetime  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ClubCloud_TrackingSet'
ALTER TABLE [dbo].[ClubCloud_TrackingSet]
ADD CONSTRAINT [PK_ClubCloud_TrackingSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClubCloud_Gebruiker_Abonementen'
ALTER TABLE [dbo].[ClubCloud_Gebruiker_Abonementen]
ADD CONSTRAINT [PK_ClubCloud_Gebruiker_Abonementen]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClubCloud_Abonnementen'
ALTER TABLE [dbo].[ClubCloud_Abonnementen]
ADD CONSTRAINT [PK_ClubCloud_Abonnementen]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClubCloud_Vereniging_Accomodaties'
ALTER TABLE [dbo].[ClubCloud_Vereniging_Accomodaties]
ADD CONSTRAINT [PK_ClubCloud_Vereniging_Accomodaties]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClubCloud_Gebruiker_Verenigingen'
ALTER TABLE [dbo].[ClubCloud_Gebruiker_Verenigingen]
ADD CONSTRAINT [PK_ClubCloud_Gebruiker_Verenigingen]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClubCloud_Vereniging_BestuursLeden'
ALTER TABLE [dbo].[ClubCloud_Vereniging_BestuursLeden]
ADD CONSTRAINT [PK_ClubCloud_Vereniging_BestuursLeden]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClubCloud_Settings'
ALTER TABLE [dbo].[ClubCloud_Settings]
ADD CONSTRAINT [PK_ClubCloud_Settings]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClubCloud_Verenigingen'
ALTER TABLE [dbo].[ClubCloud_Verenigingen]
ADD CONSTRAINT [PK_ClubCloud_Verenigingen]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClubCloud_Gebruikers'
ALTER TABLE [dbo].[ClubCloud_Gebruikers]
ADD CONSTRAINT [PK_ClubCloud_Gebruikers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClubCloud_Accomodaties'
ALTER TABLE [dbo].[ClubCloud_Accomodaties]
ADD CONSTRAINT [PK_ClubCloud_Accomodaties]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------