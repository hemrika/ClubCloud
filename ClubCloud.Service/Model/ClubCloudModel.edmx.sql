
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/16/2014 10:31:28
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

IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Functie_Functionaris]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Functionarissen] DROP CONSTRAINT [FK_ClubCloud_Functie_Functionaris];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Functionaris_Vereniging]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Functionarissen] DROP CONSTRAINT [FK_ClubCloud_Functionaris_Vereniging];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_GebruikerClubCloud_Functionaris]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Functionarissen] DROP CONSTRAINT [FK_ClubCloud_GebruikerClubCloud_Functionaris];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_FunctionarisClubCloud_District]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Functionarissen] DROP CONSTRAINT [FK_ClubCloud_FunctionarisClubCloud_District];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Vereniging_Lidmaatschap]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Lidmaatschappen] DROP CONSTRAINT [FK_ClubCloud_Vereniging_Lidmaatschap];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_GebruikerClubCloud_Lidmaatschap]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Lidmaatschappen] DROP CONSTRAINT [FK_ClubCloud_GebruikerClubCloud_Lidmaatschap];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Functionaris_Bestuursorgaan]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Functionarissen] DROP CONSTRAINT [FK_ClubCloud_Functionaris_Bestuursorgaan];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_BestuursorgaanClubCloud_Vereniging]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Bestuursorganen] DROP CONSTRAINT [FK_ClubCloud_BestuursorgaanClubCloud_Vereniging];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Vereniging_District]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Verenigingen] DROP CONSTRAINT [FK_ClubCloud_Vereniging_District];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_VerenigingClubCloud_Rechtsvorm]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Verenigingen] DROP CONSTRAINT [FK_ClubCloud_VerenigingClubCloud_Rechtsvorm];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_VerenigingClubCloud_Accomodatie]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Verenigingen] DROP CONSTRAINT [FK_ClubCloud_VerenigingClubCloud_Accomodatie];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_VerenigingClubCloud_Address]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Addresses] DROP CONSTRAINT [FK_ClubCloud_VerenigingClubCloud_Address];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_VerenigingClubCloud_Regio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Verenigingen] DROP CONSTRAINT [FK_ClubCloud_VerenigingClubCloud_Regio];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_DistrictClubCloud_Regio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Districten] DROP CONSTRAINT [FK_ClubCloud_DistrictClubCloud_Regio];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

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
IF OBJECT_ID(N'[dbo].[ClubCloud_Nationaliteiten]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubCloud_Nationaliteiten];
GO
IF OBJECT_ID(N'[dbo].[ClubCloud_Districten]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubCloud_Districten];
GO
IF OBJECT_ID(N'[dbo].[ClubCloud_Functies]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubCloud_Functies];
GO
IF OBJECT_ID(N'[dbo].[ClubCloud_Lidmaatschappen]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubCloud_Lidmaatschappen];
GO
IF OBJECT_ID(N'[dbo].[ClubCloud_Profielen]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubCloud_Profielen];
GO
IF OBJECT_ID(N'[dbo].[ClubCloud_Functionarissen]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubCloud_Functionarissen];
GO
IF OBJECT_ID(N'[dbo].[ClubCloud_Bestuursorganen]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubCloud_Bestuursorganen];
GO
IF OBJECT_ID(N'[dbo].[ClubCloud_Rechtsvormen]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubCloud_Rechtsvormen];
GO
IF OBJECT_ID(N'[dbo].[ClubCloud_Addresses]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubCloud_Addresses];
GO
IF OBJECT_ID(N'[dbo].[ClubCloud_Regios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubCloud_Regios];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

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
    [Naam] nvarchar(max)  NOT NULL,
    [Beschrijving] nvarchar(max)  NOT NULL,
    [Nummer] nvarchar(max)  NOT NULL,
    [DistrictId] uniqueidentifier  NULL,
    [RechtsvormId] uniqueidentifier  NULL,
    [AccomodatieId] uniqueidentifier  NULL,
    [RegioId] uniqueidentifier  NULL,
    [BankNummer] nvarchar(max)  NOT NULL,
    [BankIban] nvarchar(max)  NOT NULL,
    [BankPlaats] nvarchar(max)  NOT NULL,
    [KvKnummer] nvarchar(max)  NOT NULL,
    [KvKplaats] nvarchar(max)  NOT NULL,
    [EmailKNLTB] nvarchar(max)  NOT NULL,
    [EmailWebSite] nvarchar(max)  NOT NULL,
    [EmailOverig] nvarchar(max)  NOT NULL,
    [Fax] nvarchar(max)  NOT NULL,
    [TelefoonAvond] nvarchar(max)  NOT NULL,
    [TelefoonOverdag] nvarchar(max)  NOT NULL,
    [TelefoonOverig] nvarchar(max)  NOT NULL,
    [Website] nvarchar(max)  NOT NULL,
    [FTPsite] nvarchar(max)  NOT NULL,
    [Actief] nvarchar(max)  NOT NULL,
    [Oprichting] datetime  NULL,
    [Erkenning] datetime  NULL,
    [Gestopt] datetime  NULL,
    [Maanden] int  NOT NULL
);
GO

-- Creating table 'ClubCloud_Gebruikers'
CREATE TABLE [dbo].[ClubCloud_Gebruikers] (
    [Id] uniqueidentifier  NOT NULL,
    [Beschrijving] nvarchar(max)  NOT NULL,
    [Bondsnummer] nvarchar(max)  NOT NULL,
    [Roepnaam] nvarchar(max)  NOT NULL,
    [Aanhef] nvarchar(max)  NOT NULL,
    [Voornaam] nvarchar(max)  NOT NULL,
    [Voornamen] nvarchar(max)  NOT NULL,
    [Achtervoegsel] nvarchar(max)  NOT NULL,
    [Tussenvoegsel] nvarchar(max)  NOT NULL,
    [Achternaam] nvarchar(max)  NOT NULL,
    [Voorletters] nvarchar(max)  NOT NULL,
    [EmailGeheim] bit  NOT NULL,
    [EmailKNLTB] nvarchar(max)  NOT NULL,
    [EmailWebSite] nvarchar(max)  NOT NULL,
    [EmailOverig] nvarchar(max)  NOT NULL,
    [TelefoonGeheim] bit  NOT NULL,
    [TelefoonAvond] nvarchar(max)  NOT NULL,
    [TelefoonOverdag] nvarchar(max)  NOT NULL,
    [TelefoonOverig] nvarchar(max)  NOT NULL,
    [Mobiel] nvarchar(max)  NOT NULL,
    [Fax] nvarchar(max)  NOT NULL,
    [BankNummer] nvarchar(max)  NOT NULL,
    [BankIban] nvarchar(max)  NOT NULL,
    [BankPlaats] nvarchar(max)  NOT NULL,
    [Geslacht] int  NOT NULL,
    [Geboortedatum] datetime  NULL,
    [Geboorteplaats] nvarchar(max)  NOT NULL,
    [OverlijdensDatum] datetime  NULL,
    [NationaliteitId] uniqueidentifier  NULL,
    [AddressGeheim] bit  NOT NULL,
    [Website] nvarchar(max)  NOT NULL,
    [FTPsite] nvarchar(max)  NOT NULL,
    [Actief] nvarchar(max)  NOT NULL,
    [Beroep] nvarchar(max)  NOT NULL,
    [Kinderen] bit  NOT NULL,
    [KinderenAantal] int  NOT NULL,
    [Partner] nvarchar(max)  NOT NULL,
    [AanhefBrief] nvarchar(max)  NOT NULL,
    [AanhefAttentie] nvarchar(max)  NOT NULL,
    [FotoId] nvarchar(max)  NOT NULL,
    [VerenigingId] uniqueidentifier  NULL,
    [Volledigenaam] nvarchar(max)  NOT NULL
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

-- Creating table 'ClubCloud_Nationaliteiten'
CREATE TABLE [dbo].[ClubCloud_Nationaliteiten] (
    [Id] uniqueidentifier  NOT NULL,
    [Naam] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ClubCloud_Districten'
CREATE TABLE [dbo].[ClubCloud_Districten] (
    [Id] uniqueidentifier  NOT NULL,
    [Naam] nvarchar(max)  NOT NULL,
    [Beschrijving] nvarchar(max)  NOT NULL,
    [Omschrijving] nvarchar(max)  NOT NULL,
    [RegioId] uniqueidentifier  NULL,
    [Actief] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ClubCloud_Functies'
CREATE TABLE [dbo].[ClubCloud_Functies] (
    [Id] uniqueidentifier  NOT NULL,
    [Naam] nvarchar(max)  NOT NULL,
    [Beschrijving] nvarchar(max)  NOT NULL,
    [Meervoud] nvarchar(max)  NOT NULL,
    [Omschrijving] nvarchar(max)  NOT NULL,
    [Toegang] bit  NOT NULL,
    [Code] nvarchar(max)  NOT NULL,
    [Actief] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ClubCloud_Lidmaatschappen'
CREATE TABLE [dbo].[ClubCloud_Lidmaatschappen] (
    [Id] uniqueidentifier  NOT NULL,
    [SoortId] uniqueidentifier  NOT NULL,
    [SoortNaam] nvarchar(max)  NOT NULL,
    [Begin] datetime  NOT NULL,
    [Einde] datetime  NULL,
    [Opzegging] datetime  NULL,
    [InternNummer] nvarchar(max)  NOT NULL,
    [GebruikerId] uniqueidentifier  NULL,
    [VerenigingId] uniqueidentifier  NULL,
    [PasTypeId] uniqueidentifier  NOT NULL,
    [PasTypeNaam] nvarchar(max)  NOT NULL,
    [PasDatum] datetime  NULL,
    [PasNoodDatum] datetime  NULL,
    [PasWedstrijd] bit  NOT NULL,
    [PasNieuw] bit  NOT NULL,
    [PasNood] bit  NOT NULL,
    [PasVolgnummer] nvarchar(max)  NOT NULL,
    [SpeelsterkteDubbel] int  NOT NULL,
    [SpeelsterkteEnkel] int  NOT NULL,
    [Autorisatie] bit  NOT NULL,
    [Actief] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ClubCloud_Profielen'
CREATE TABLE [dbo].[ClubCloud_Profielen] (
    [Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'ClubCloud_Functionarissen'
CREATE TABLE [dbo].[ClubCloud_Functionarissen] (
    [Id] uniqueidentifier  NOT NULL,
    [FunctieId] uniqueidentifier  NULL,
    [VerenigingId] uniqueidentifier  NULL,
    [GebruikerId] uniqueidentifier  NULL,
    [BestuursorgaanId] uniqueidentifier  NULL,
    [DistrictId] uniqueidentifier  NULL,
    [TermijnBegin] datetime  NOT NULL,
    [TermijnEinde] datetime  NULL,
    [Autorisatie] bit  NOT NULL,
    [Actief] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ClubCloud_Bestuursorganen'
CREATE TABLE [dbo].[ClubCloud_Bestuursorganen] (
    [Id] uniqueidentifier  NOT NULL,
    [Naam] nvarchar(max)  NOT NULL,
    [Beschrijving] nvarchar(max)  NOT NULL,
    [VerenigingId] uniqueidentifier  NULL,
    [TypeId] uniqueidentifier  NOT NULL,
    [Actief] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ClubCloud_Rechtsvormen'
CREATE TABLE [dbo].[ClubCloud_Rechtsvormen] (
    [Id] uniqueidentifier  NOT NULL,
    [Naam] nvarchar(max)  NOT NULL,
    [Omschrijving] nvarchar(max)  NOT NULL,
    [Code] nvarchar(max)  NOT NULL,
    [Beschrijving] nvarchar(max)  NOT NULL,
    [Meervoud] nvarchar(max)  NOT NULL,
    [Actief] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ClubCloud_Addresses'
CREATE TABLE [dbo].[ClubCloud_Addresses] (
    [Id] uniqueidentifier  NOT NULL,
    [ParentId] uniqueidentifier  NULL,
    [Stad] nvarchar(max)  NOT NULL,
    [Provincie] nvarchar(max)  NOT NULL,
    [Latitude] float  NULL,
    [Longitude] float  NULL,
    [Naam] nvarchar(max)  NOT NULL,
    [Postcode] nvarchar(max)  NOT NULL,
    [Straat] nvarchar(max)  NOT NULL,
    [Nummer] nvarchar(max)  NOT NULL,
    [Actief] nvarchar(max)  NOT NULL,
    [Land] nvarchar(max)  NOT NULL,
    [Fax] nvarchar(max)  NOT NULL,
    [Toevoeging] nvarchar(max)  NOT NULL,
    [Postbus] nvarchar(max)  NOT NULL,
    [TelefoonPrimair] nvarchar(max)  NOT NULL,
    [TelefoonSecundair] nvarchar(max)  NOT NULL,
    [TelefoonTertiair] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ClubCloud_Regios'
CREATE TABLE [dbo].[ClubCloud_Regios] (
    [Id] uniqueidentifier  NOT NULL,
    [Naam] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

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

-- Creating primary key on [Id] in table 'ClubCloud_Nationaliteiten'
ALTER TABLE [dbo].[ClubCloud_Nationaliteiten]
ADD CONSTRAINT [PK_ClubCloud_Nationaliteiten]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClubCloud_Districten'
ALTER TABLE [dbo].[ClubCloud_Districten]
ADD CONSTRAINT [PK_ClubCloud_Districten]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClubCloud_Functies'
ALTER TABLE [dbo].[ClubCloud_Functies]
ADD CONSTRAINT [PK_ClubCloud_Functies]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClubCloud_Lidmaatschappen'
ALTER TABLE [dbo].[ClubCloud_Lidmaatschappen]
ADD CONSTRAINT [PK_ClubCloud_Lidmaatschappen]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClubCloud_Profielen'
ALTER TABLE [dbo].[ClubCloud_Profielen]
ADD CONSTRAINT [PK_ClubCloud_Profielen]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClubCloud_Functionarissen'
ALTER TABLE [dbo].[ClubCloud_Functionarissen]
ADD CONSTRAINT [PK_ClubCloud_Functionarissen]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClubCloud_Bestuursorganen'
ALTER TABLE [dbo].[ClubCloud_Bestuursorganen]
ADD CONSTRAINT [PK_ClubCloud_Bestuursorganen]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClubCloud_Rechtsvormen'
ALTER TABLE [dbo].[ClubCloud_Rechtsvormen]
ADD CONSTRAINT [PK_ClubCloud_Rechtsvormen]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClubCloud_Addresses'
ALTER TABLE [dbo].[ClubCloud_Addresses]
ADD CONSTRAINT [PK_ClubCloud_Addresses]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClubCloud_Regios'
ALTER TABLE [dbo].[ClubCloud_Regios]
ADD CONSTRAINT [PK_ClubCloud_Regios]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [FunctieId] in table 'ClubCloud_Functionarissen'
ALTER TABLE [dbo].[ClubCloud_Functionarissen]
ADD CONSTRAINT [FK_ClubCloud_Functie_Functionaris]
    FOREIGN KEY ([FunctieId])
    REFERENCES [dbo].[ClubCloud_Functies]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_Functie_Functionaris'
CREATE INDEX [IX_FK_ClubCloud_Functie_Functionaris]
ON [dbo].[ClubCloud_Functionarissen]
    ([FunctieId]);
GO

-- Creating foreign key on [VerenigingId] in table 'ClubCloud_Functionarissen'
ALTER TABLE [dbo].[ClubCloud_Functionarissen]
ADD CONSTRAINT [FK_ClubCloud_Functionaris_Vereniging]
    FOREIGN KEY ([VerenigingId])
    REFERENCES [dbo].[ClubCloud_Verenigingen]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_Functionaris_Vereniging'
CREATE INDEX [IX_FK_ClubCloud_Functionaris_Vereniging]
ON [dbo].[ClubCloud_Functionarissen]
    ([VerenigingId]);
GO

-- Creating foreign key on [GebruikerId] in table 'ClubCloud_Functionarissen'
ALTER TABLE [dbo].[ClubCloud_Functionarissen]
ADD CONSTRAINT [FK_ClubCloud_GebruikerClubCloud_Functionaris]
    FOREIGN KEY ([GebruikerId])
    REFERENCES [dbo].[ClubCloud_Gebruikers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_GebruikerClubCloud_Functionaris'
CREATE INDEX [IX_FK_ClubCloud_GebruikerClubCloud_Functionaris]
ON [dbo].[ClubCloud_Functionarissen]
    ([GebruikerId]);
GO

-- Creating foreign key on [DistrictId] in table 'ClubCloud_Functionarissen'
ALTER TABLE [dbo].[ClubCloud_Functionarissen]
ADD CONSTRAINT [FK_ClubCloud_FunctionarisClubCloud_District]
    FOREIGN KEY ([DistrictId])
    REFERENCES [dbo].[ClubCloud_Districten]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_FunctionarisClubCloud_District'
CREATE INDEX [IX_FK_ClubCloud_FunctionarisClubCloud_District]
ON [dbo].[ClubCloud_Functionarissen]
    ([DistrictId]);
GO

-- Creating foreign key on [VerenigingId] in table 'ClubCloud_Lidmaatschappen'
ALTER TABLE [dbo].[ClubCloud_Lidmaatschappen]
ADD CONSTRAINT [FK_ClubCloud_Vereniging_Lidmaatschap]
    FOREIGN KEY ([VerenigingId])
    REFERENCES [dbo].[ClubCloud_Verenigingen]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_Vereniging_Lidmaatschap'
CREATE INDEX [IX_FK_ClubCloud_Vereniging_Lidmaatschap]
ON [dbo].[ClubCloud_Lidmaatschappen]
    ([VerenigingId]);
GO

-- Creating foreign key on [GebruikerId] in table 'ClubCloud_Lidmaatschappen'
ALTER TABLE [dbo].[ClubCloud_Lidmaatschappen]
ADD CONSTRAINT [FK_ClubCloud_GebruikerClubCloud_Lidmaatschap]
    FOREIGN KEY ([GebruikerId])
    REFERENCES [dbo].[ClubCloud_Gebruikers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_GebruikerClubCloud_Lidmaatschap'
CREATE INDEX [IX_FK_ClubCloud_GebruikerClubCloud_Lidmaatschap]
ON [dbo].[ClubCloud_Lidmaatschappen]
    ([GebruikerId]);
GO

-- Creating foreign key on [BestuursorgaanId] in table 'ClubCloud_Functionarissen'
ALTER TABLE [dbo].[ClubCloud_Functionarissen]
ADD CONSTRAINT [FK_ClubCloud_Functionaris_Bestuursorgaan]
    FOREIGN KEY ([BestuursorgaanId])
    REFERENCES [dbo].[ClubCloud_Bestuursorganen]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_Functionaris_Bestuursorgaan'
CREATE INDEX [IX_FK_ClubCloud_Functionaris_Bestuursorgaan]
ON [dbo].[ClubCloud_Functionarissen]
    ([BestuursorgaanId]);
GO

-- Creating foreign key on [VerenigingId] in table 'ClubCloud_Bestuursorganen'
ALTER TABLE [dbo].[ClubCloud_Bestuursorganen]
ADD CONSTRAINT [FK_ClubCloud_BestuursorgaanClubCloud_Vereniging]
    FOREIGN KEY ([VerenigingId])
    REFERENCES [dbo].[ClubCloud_Verenigingen]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_BestuursorgaanClubCloud_Vereniging'
CREATE INDEX [IX_FK_ClubCloud_BestuursorgaanClubCloud_Vereniging]
ON [dbo].[ClubCloud_Bestuursorganen]
    ([VerenigingId]);
GO

-- Creating foreign key on [DistrictId] in table 'ClubCloud_Verenigingen'
ALTER TABLE [dbo].[ClubCloud_Verenigingen]
ADD CONSTRAINT [FK_ClubCloud_Vereniging_District]
    FOREIGN KEY ([DistrictId])
    REFERENCES [dbo].[ClubCloud_Districten]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_Vereniging_District'
CREATE INDEX [IX_FK_ClubCloud_Vereniging_District]
ON [dbo].[ClubCloud_Verenigingen]
    ([DistrictId]);
GO

-- Creating foreign key on [RechtsvormId] in table 'ClubCloud_Verenigingen'
ALTER TABLE [dbo].[ClubCloud_Verenigingen]
ADD CONSTRAINT [FK_ClubCloud_VerenigingClubCloud_Rechtsvorm]
    FOREIGN KEY ([RechtsvormId])
    REFERENCES [dbo].[ClubCloud_Rechtsvormen]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_VerenigingClubCloud_Rechtsvorm'
CREATE INDEX [IX_FK_ClubCloud_VerenigingClubCloud_Rechtsvorm]
ON [dbo].[ClubCloud_Verenigingen]
    ([RechtsvormId]);
GO

-- Creating foreign key on [AccomodatieId] in table 'ClubCloud_Verenigingen'
ALTER TABLE [dbo].[ClubCloud_Verenigingen]
ADD CONSTRAINT [FK_ClubCloud_VerenigingClubCloud_Accomodatie]
    FOREIGN KEY ([AccomodatieId])
    REFERENCES [dbo].[ClubCloud_Accomodaties]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_VerenigingClubCloud_Accomodatie'
CREATE INDEX [IX_FK_ClubCloud_VerenigingClubCloud_Accomodatie]
ON [dbo].[ClubCloud_Verenigingen]
    ([AccomodatieId]);
GO

-- Creating foreign key on [ParentId] in table 'ClubCloud_Addresses'
ALTER TABLE [dbo].[ClubCloud_Addresses]
ADD CONSTRAINT [FK_ClubCloud_VerenigingClubCloud_Address]
    FOREIGN KEY ([ParentId])
    REFERENCES [dbo].[ClubCloud_Verenigingen]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_VerenigingClubCloud_Address'
CREATE INDEX [IX_FK_ClubCloud_VerenigingClubCloud_Address]
ON [dbo].[ClubCloud_Addresses]
    ([ParentId]);
GO

-- Creating foreign key on [RegioId] in table 'ClubCloud_Verenigingen'
ALTER TABLE [dbo].[ClubCloud_Verenigingen]
ADD CONSTRAINT [FK_ClubCloud_VerenigingClubCloud_Regio]
    FOREIGN KEY ([RegioId])
    REFERENCES [dbo].[ClubCloud_Regios]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_VerenigingClubCloud_Regio'
CREATE INDEX [IX_FK_ClubCloud_VerenigingClubCloud_Regio]
ON [dbo].[ClubCloud_Verenigingen]
    ([RegioId]);
GO

-- Creating foreign key on [RegioId] in table 'ClubCloud_Districten'
ALTER TABLE [dbo].[ClubCloud_Districten]
ADD CONSTRAINT [FK_ClubCloud_DistrictClubCloud_Regio]
    FOREIGN KEY ([RegioId])
    REFERENCES [dbo].[ClubCloud_Regios]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_DistrictClubCloud_Regio'
CREATE INDEX [IX_FK_ClubCloud_DistrictClubCloud_Regio]
ON [dbo].[ClubCloud_Districten]
    ([RegioId]);
GO

-- Creating foreign key on [ParentId] in table 'ClubCloud_Addresses'
ALTER TABLE [dbo].[ClubCloud_Addresses]
ADD CONSTRAINT [FK_ClubCloud_GebruikerClubCloud_Address]
    FOREIGN KEY ([ParentId])
    REFERENCES [dbo].[ClubCloud_Gebruikers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_GebruikerClubCloud_Address'
CREATE INDEX [IX_FK_ClubCloud_GebruikerClubCloud_Address]
ON [dbo].[ClubCloud_Addresses]
    ([ParentId]);
GO

-- Creating foreign key on [VerenigingId] in table 'ClubCloud_Gebruikers'
ALTER TABLE [dbo].[ClubCloud_Gebruikers]
ADD CONSTRAINT [FK_ClubCloud_GebruikerClubCloud_Vereniging]
    FOREIGN KEY ([VerenigingId])
    REFERENCES [dbo].[ClubCloud_Verenigingen]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_GebruikerClubCloud_Vereniging'
CREATE INDEX [IX_FK_ClubCloud_GebruikerClubCloud_Vereniging]
ON [dbo].[ClubCloud_Gebruikers]
    ([VerenigingId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------