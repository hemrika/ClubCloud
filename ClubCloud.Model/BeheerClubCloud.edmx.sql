
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/12/2015 07:12:04
-- Generated from EDMX file: C:\Source\ClubCloud\ClubCloud.Model\BeheerClubCloud.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ClubCloudService_Model_DB];
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
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Gebruiker_Functionaris]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Functionarissen] DROP CONSTRAINT [FK_ClubCloud_Gebruiker_Functionaris];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Functionaris_District]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Functionarissen] DROP CONSTRAINT [FK_ClubCloud_Functionaris_District];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Vereniging_Lidmaatschap]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Lidmaatschappen] DROP CONSTRAINT [FK_ClubCloud_Vereniging_Lidmaatschap];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Gebruiker_Lidmaatschap]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Lidmaatschappen] DROP CONSTRAINT [FK_ClubCloud_Gebruiker_Lidmaatschap];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Functionaris_Bestuursorgaan]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Functionarissen] DROP CONSTRAINT [FK_ClubCloud_Functionaris_Bestuursorgaan];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Bestuursorgaan_Vereniging]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Bestuursorganen] DROP CONSTRAINT [FK_ClubCloud_Bestuursorgaan_Vereniging];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Vereniging_District]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Verenigingen] DROP CONSTRAINT [FK_ClubCloud_Vereniging_District];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Vereniging_Rechtsvorm]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Verenigingen] DROP CONSTRAINT [FK_ClubCloud_Vereniging_Rechtsvorm];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Vereniging_Accommodatie]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Verenigingen] DROP CONSTRAINT [FK_ClubCloud_Vereniging_Accommodatie];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Vereniging_Address]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Addressen] DROP CONSTRAINT [FK_ClubCloud_Vereniging_Address];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Vereniging_Regio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Verenigingen] DROP CONSTRAINT [FK_ClubCloud_Vereniging_Regio];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_District_Regio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Districten] DROP CONSTRAINT [FK_ClubCloud_District_Regio];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Gebruiker_Address]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Addressen] DROP CONSTRAINT [FK_ClubCloud_Gebruiker_Address];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Gebruiker_Vereniging]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Gebruikers] DROP CONSTRAINT [FK_ClubCloud_Gebruiker_Vereniging];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Profiel_Gebruiker]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Profielen] DROP CONSTRAINT [FK_ClubCloud_Profiel_Gebruiker];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Baansoort_Baantype]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Baansoorten] DROP CONSTRAINT [FK_ClubCloud_Baansoort_Baantype];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Accommodatie_District]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Accommodaties] DROP CONSTRAINT [FK_ClubCloud_Accommodatie_District];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Accommodatie_Regio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Accommodaties] DROP CONSTRAINT [FK_ClubCloud_Accommodatie_Regio];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Reservering_Baan]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Reserveringen] DROP CONSTRAINT [FK_ClubCloud_Reservering_Baan];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Reservering_Gebruiker_Een]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Reserveringen] DROP CONSTRAINT [FK_ClubCloud_Reservering_Gebruiker_Een];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Reservering_Gebruiker_Twee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Reserveringen] DROP CONSTRAINT [FK_ClubCloud_Reservering_Gebruiker_Twee];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Reservering_Gebruiker_Drie]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Reserveringen] DROP CONSTRAINT [FK_ClubCloud_Reservering_Gebruiker_Drie];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Reservering_Gebruiker_Vier]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Reserveringen] DROP CONSTRAINT [FK_ClubCloud_Reservering_Gebruiker_Vier];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Afhangen_Vereniging]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Afhangen] DROP CONSTRAINT [FK_ClubCloud_Afhangen_Vereniging];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_LidmaatschapSoort_Lidmaatschap]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Lidmaatschappen] DROP CONSTRAINT [FK_ClubCloud_LidmaatschapSoort_Lidmaatschap];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Sponsor_Vereniging]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Sponsoren] DROP CONSTRAINT [FK_ClubCloud_Sponsor_Vereniging];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Sponsor_Sponsor_Afbeelding]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Sponsoren] DROP CONSTRAINT [FK_ClubCloud_Sponsor_Sponsor_Afbeelding];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Baan_Baanblok]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Banen] DROP CONSTRAINT [FK_ClubCloud_Baan_Baanblok];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Baanblok_Accommodatie]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Baanblokken] DROP CONSTRAINT [FK_ClubCloud_Baanblok_Accommodatie];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Baanblok_Baantype]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Baanblokken] DROP CONSTRAINT [FK_ClubCloud_Baanblok_Baantype];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Baanblok_Baansoort]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Baanblokken] DROP CONSTRAINT [FK_ClubCloud_Baanblok_Baansoort];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Baan_Accommodatie]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Banen] DROP CONSTRAINT [FK_ClubCloud_Baan_Accommodatie];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_BaanSpeciaal_Accommodatie]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_BanenSpeciaal] DROP CONSTRAINT [FK_ClubCloud_BaanSpeciaal_Accommodatie];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_BaanSpeciaal_Baantoplaag]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_BanenSpeciaal] DROP CONSTRAINT [FK_ClubCloud_BaanSpeciaal_Baantoplaag];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Regio_Address]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Addressen] DROP CONSTRAINT [FK_ClubCloud_Regio_Address];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Setting_Gebruiker]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Settings] DROP CONSTRAINT [FK_ClubCloud_Setting_Gebruiker];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Setting_Vereniging]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Settings] DROP CONSTRAINT [FK_ClubCloud_Setting_Vereniging];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Accommodatie_Address]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Addressen] DROP CONSTRAINT [FK_ClubCloud_Accommodatie_Address];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Gebruiker_Nationaliteit]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Gebruikers] DROP CONSTRAINT [FK_ClubCloud_Gebruiker_Nationaliteit];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Baanschema_Baan]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Baanschemas] DROP CONSTRAINT [FK_ClubCloud_Baanschema_Baan];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Baanschema_Vereniging]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Baanschemas] DROP CONSTRAINT [FK_ClubCloud_Baanschema_Vereniging];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Vereniging_Lidmaatschapsoort]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Lidmaatschapsoorten] DROP CONSTRAINT [FK_ClubCloud_Vereniging_Lidmaatschapsoort];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubCloud_Address_Land]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClubCloud_Addressen] DROP CONSTRAINT [FK_ClubCloud_Address_Land];
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
    
IF OBJECT_ID(N'[dbo].[ClubCloud_Accommodaties]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubCloud_Accommodaties];
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
    
IF OBJECT_ID(N'[dbo].[ClubCloud_Addressen]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubCloud_Addressen];
GO
    
IF OBJECT_ID(N'[dbo].[ClubCloud_Regios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubCloud_Regios];
GO
    
IF OBJECT_ID(N'[dbo].[ClubCloud_Baansoorten]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubCloud_Baansoorten];
GO
    
IF OBJECT_ID(N'[dbo].[ClubCloud_Baantypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubCloud_Baantypes];
GO
    
IF OBJECT_ID(N'[dbo].[ClubCloud_Banen]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubCloud_Banen];
GO
    
IF OBJECT_ID(N'[dbo].[ClubCloud_Bouwaarden]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubCloud_Bouwaarden];
GO
    
IF OBJECT_ID(N'[dbo].[ClubCloud_BanenSpeciaal]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubCloud_BanenSpeciaal];
GO
    
IF OBJECT_ID(N'[dbo].[ClubCloud_Reserveringen]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubCloud_Reserveringen];
GO
    
IF OBJECT_ID(N'[dbo].[ClubCloud_Afhangen]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubCloud_Afhangen];
GO
    
IF OBJECT_ID(N'[dbo].[ClubCloud_Baanschemas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubCloud_Baanschemas];
GO
    
IF OBJECT_ID(N'[dbo].[ClubCloud_Fotos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubCloud_Fotos];
GO
    
IF OBJECT_ID(N'[dbo].[ClubCloud_Lidmaatschapsoorten]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubCloud_Lidmaatschapsoorten];
GO
    
IF OBJECT_ID(N'[dbo].[ClubCloud_Sponsoren]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubCloud_Sponsoren];
GO
    
IF OBJECT_ID(N'[dbo].[ClubCloud_Sponsor_Afbeeldingen]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubCloud_Sponsor_Afbeeldingen];
GO
    
IF OBJECT_ID(N'[dbo].[ClubCloud_Baanblokken]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubCloud_Baanblokken];
GO
    
IF OBJECT_ID(N'[dbo].[ClubCloud_Baantoplagen]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubCloud_Baantoplagen];
GO
    
IF OBJECT_ID(N'[dbo].[ClubCloud_Landen]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClubCloud_Landen];
GO
    

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ClubCloud_Settings'
CREATE TABLE [dbo].[ClubCloud_Settings] (
    [Id] int  NOT NULL,
    [GebruikerId] uniqueidentifier  NULL,
    [VerenigingId] uniqueidentifier  NULL,
    [Agree] bit  NOT NULL,
    [Access] bit  NOT NULL,
    [Password] nvarchar(max)  NULL,
    [twitter_allow] bit  NOT NULL,
    [twitter_oauth_token] nvarchar(max)  NULL,
    [twitter_oauth_token_secret] nvarchar(max)  NULL,
    [twitter_setting] int  NOT NULL,
    [facebook_allow] bit  NOT NULL,
    [facebook_access_token] nvarchar(max)  NULL,
    [facebook_setting] int  NOT NULL,
    [privacy] int  NOT NULL,
    [financieel] int  NOT NULL,
    [Gewijzigd] datetime  NOT NULL
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
    [AccommodatieId] uniqueidentifier  NULL,
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
    [Actief] int  NOT NULL,
    [Oprichting] datetime  NULL,
    [Erkenning] datetime  NULL,
    [Gestopt] datetime  NULL,
    [Maanden] int  NOT NULL,
    [Gewijzigd] datetime  NOT NULL
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
    [Geboortedatum] datetime  NULL,
    [Geboorteplaats] nvarchar(max)  NOT NULL,
    [OverlijdensDatum] datetime  NULL,
    [AddressGeheim] bit  NOT NULL,
    [NationaliteitId] uniqueidentifier  NULL,
    [Website] nvarchar(max)  NOT NULL,
    [FTPsite] nvarchar(max)  NOT NULL,
    [Actief] int  NOT NULL,
    [Beroep] nvarchar(max)  NOT NULL,
    [Kinderen] bit  NOT NULL,
    [KinderenAantal] int  NOT NULL,
    [Partner] nvarchar(max)  NOT NULL,
    [AanhefBrief] nvarchar(max)  NOT NULL,
    [AanhefAttentie] nvarchar(max)  NOT NULL,
    [FotoId] int  NOT NULL,
    [VerenigingId] uniqueidentifier  NULL,
    [Volledigenaam] nvarchar(max)  NOT NULL,
    [Geslacht] int  NOT NULL,
    [Gewijzigd] datetime  NOT NULL
);
GO

-- Creating table 'ClubCloud_Accommodaties'
CREATE TABLE [dbo].[ClubCloud_Accommodaties] (
    [Id] uniqueidentifier  NOT NULL,
    [Naam] nvarchar(max)  NOT NULL,
    [BanenAantal] int  NOT NULL,
    [BanenAantalBinnen] int  NOT NULL,
    [BanenAantalBuiten] int  NOT NULL,
    [Blaashal] bit  NULL,
    [BlaashalSoort] nvarchar(max)  NULL,
    [BlaashalAantalBanen] int  NULL,
    [Playgrounds] bit  NOT NULL,
    [PlaygroundsAantal] int  NOT NULL,
    [Oefenmuren] bit  NOT NULL,
    [OefenmurenAantal] int  NOT NULL,
    [Minibanen] bit  NOT NULL,
    [MinibanenAantal] int  NOT NULL,
    [Overkapping] bit  NULL,
    [OverkappingSoort] nvarchar(max)  NULL,
    [AantalParkeerplaatsen] int  NOT NULL,
    [AantalParkeerplaatsenMindervalide] int  NOT NULL,
    [MetOVBereikbaar] bit  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Telefoon] nvarchar(max)  NOT NULL,
    [Website] nvarchar(max)  NOT NULL,
    [ClubhuisStatus] nvarchar(max)  NOT NULL,
    [ClubhuisBouwjaar] nvarchar(max)  NULL,
    [ClubhuisBouwaard] nvarchar(max)  NOT NULL,
    [ClubhuisOppervlakte] int  NULL,
    [ClubhuisLigging] nvarchar(max)  NOT NULL,
    [ClubhuisBeveiliging] nvarchar(max)  NOT NULL,
    [HalStatus] nvarchar(max)  NOT NULL,
    [HalBouwjaar] nvarchar(max)  NOT NULL,
    [HalBouwaard] nvarchar(max)  NOT NULL,
    [HalOppervlakte] int  NULL,
    [RolStoeltoegankelijk] bit  NOT NULL,
    [Speeltoestellen] nvarchar(max)  NOT NULL,
    [TotaalAantalWasKleedruimte] int  NULL,
    [ValideParkeerplaatsen] int  NULL,
    [WasruimteClubhuisAanwezig] bit  NOT NULL,
    [DistrictId] uniqueidentifier  NULL,
    [RegioId] uniqueidentifier  NULL,
    [Actief] int  NOT NULL,
    [Gewijzigd] datetime  NOT NULL
);
GO

-- Creating table 'ClubCloud_Nationaliteiten'
CREATE TABLE [dbo].[ClubCloud_Nationaliteiten] (
    [Id] uniqueidentifier  NOT NULL,
    [Naam] nvarchar(max)  NOT NULL,
    [Code] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ClubCloud_Districten'
CREATE TABLE [dbo].[ClubCloud_Districten] (
    [Id] uniqueidentifier  NOT NULL,
    [Naam] nvarchar(max)  NOT NULL,
    [Beschrijving] nvarchar(max)  NOT NULL,
    [Omschrijving] nvarchar(max)  NOT NULL,
    [RegioId] uniqueidentifier  NULL,
    [Actief] int  NOT NULL
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
    [Actief] int  NOT NULL
);
GO

-- Creating table 'ClubCloud_Lidmaatschappen'
CREATE TABLE [dbo].[ClubCloud_Lidmaatschappen] (
    [Id] uniqueidentifier  NOT NULL,
    [Bondsnummer] nvarchar(max)  NULL,
    [LidmaatschapsoortId] uniqueidentifier  NULL,
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
    [Actief] int  NOT NULL,
    [Gewijzigd] datetime  NOT NULL
);
GO

-- Creating table 'ClubCloud_Profielen'
CREATE TABLE [dbo].[ClubCloud_Profielen] (
    [Id] uniqueidentifier  NOT NULL,
    [Datum] datetime  NOT NULL,
    [Bondsnummer] nvarchar(max)  NOT NULL,
    [GebruikerId] uniqueidentifier  NULL,
    [Enkel_Aantal] int  NOT NULL,
    [Dubbel_aantal] int  NOT NULL,
    [Enkel_Speelsterkte] int  NOT NULL,
    [Enkel_Speelsterkte_Vorig] int  NOT NULL,
    [Dubbel_Speelsterkte] int  NOT NULL,
    [Dubbel_Speelsterkte_Vorig] int  NOT NULL,
    [Enkel_Rating_Eindejaar] decimal(18,0)  NOT NULL,
    [Dubbel_Rating_Eindejaar] decimal(18,0)  NOT NULL,
    [Enkel_Rating_Actueel] decimal(18,0)  NOT NULL,
    [Dubbel_Rating_Actueel] decimal(18,0)  NOT NULL,
    [Actief] int  NOT NULL,
    [Gewijzigd] datetime  NOT NULL
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
    [TermijnBegin] datetime  NULL,
    [TermijnEinde] datetime  NULL,
    [Autorisatie] bit  NOT NULL,
    [Actief] int  NOT NULL,
    [Gewijzigd] datetime  NOT NULL
);
GO

-- Creating table 'ClubCloud_Bestuursorganen'
CREATE TABLE [dbo].[ClubCloud_Bestuursorganen] (
    [Id] uniqueidentifier  NOT NULL,
    [Naam] nvarchar(max)  NOT NULL,
    [Beschrijving] nvarchar(max)  NULL,
    [VerenigingId] uniqueidentifier  NULL,
    [Groep] nvarchar(max)  NULL,
    [Actief] int  NOT NULL
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
    [Actief] int  NOT NULL
);
GO

-- Creating table 'ClubCloud_Addressen'
CREATE TABLE [dbo].[ClubCloud_Addressen] (
    [Id] uniqueidentifier  NOT NULL,
    [ParentId] uniqueidentifier  NULL,
    [Stad] nvarchar(max)  NOT NULL,
    [Provincie] nvarchar(max)  NOT NULL,
    [Latitude] float  NULL,
    [Longitude] float  NULL,
    [Naam] int  NOT NULL,
    [Postcode] nvarchar(max)  NOT NULL,
    [Straat] nvarchar(max)  NOT NULL,
    [Nummer] nvarchar(max)  NOT NULL,
    [LandId] uniqueidentifier  NULL,
    [Actief] int  NOT NULL,
    [Fax] nvarchar(max)  NOT NULL,
    [Toevoeging] nvarchar(max)  NOT NULL,
    [Postbus] nvarchar(max)  NOT NULL,
    [TelefoonPrimair] nvarchar(max)  NOT NULL,
    [TelefoonSecundair] nvarchar(max)  NOT NULL,
    [TelefoonTertiair] nvarchar(max)  NOT NULL,
    [GeoLocation] geography  NULL,
    [Gewijzigd] datetime  NOT NULL,
    [Gemeente] nvarchar(max)  NOT NULL,
    [AddressGeheim] bit  NOT NULL
);
GO

-- Creating table 'ClubCloud_Regios'
CREATE TABLE [dbo].[ClubCloud_Regios] (
    [Id] uniqueidentifier  NOT NULL,
    [Naam] nvarchar(max)  NULL,
    [EmailKNLTB] nvarchar(max)  NULL,
    [TelefoonAvond] nvarchar(max)  NULL,
    [TelefoonOverdag] nvarchar(max)  NULL,
    [Fax] nvarchar(max)  NOT NULL,
    [Actief] int  NOT NULL
);
GO

-- Creating table 'ClubCloud_Baansoorten'
CREATE TABLE [dbo].[ClubCloud_Baansoorten] (
    [Id] uniqueidentifier  NOT NULL,
    [Naam] nvarchar(max)  NOT NULL,
    [BaantypeId] uniqueidentifier  NULL,
    [Beschrijving] nvarchar(max)  NOT NULL,
    [Meervoud] nvarchar(max)  NOT NULL,
    [Omschrijving] nvarchar(max)  NOT NULL,
    [Code] nvarchar(max)  NOT NULL,
    [Actief] int  NOT NULL
);
GO

-- Creating table 'ClubCloud_Baantypes'
CREATE TABLE [dbo].[ClubCloud_Baantypes] (
    [Id] uniqueidentifier  NOT NULL,
    [Naam] nvarchar(max)  NOT NULL,
    [Beschrijving] nvarchar(max)  NOT NULL,
    [Meervoud] nvarchar(max)  NOT NULL,
    [Omschrijving] nvarchar(max)  NOT NULL,
    [Code] nvarchar(max)  NOT NULL,
    [Actief] int  NOT NULL
);
GO

-- Creating table 'ClubCloud_Banen'
CREATE TABLE [dbo].[ClubCloud_Banen] (
    [Id] uniqueidentifier  NOT NULL,
    [Naam] nvarchar(max)  NOT NULL,
    [Nummer] int  NOT NULL,
    [BaanblokId] uniqueidentifier  NULL,
    [AccommodatieId] uniqueidentifier  NULL,
    [Status] nvarchar(max)  NOT NULL,
    [Keuring] datetime  NULL,
    [Actief] int  NOT NULL
);
GO

-- Creating table 'ClubCloud_Bouwaarden'
CREATE TABLE [dbo].[ClubCloud_Bouwaarden] (
    [Id] uniqueidentifier  NOT NULL,
    [Naam] nvarchar(max)  NOT NULL,
    [Omschrijving] nvarchar(max)  NOT NULL,
    [Code] nvarchar(max)  NOT NULL,
    [Beschrijving] nvarchar(max)  NOT NULL,
    [Meervoud] nvarchar(max)  NOT NULL,
    [Actief] int  NOT NULL
);
GO

-- Creating table 'ClubCloud_BanenSpeciaal'
CREATE TABLE [dbo].[ClubCloud_BanenSpeciaal] (
    [Id] uniqueidentifier  NOT NULL,
    [Naam] nvarchar(max)  NOT NULL,
    [Baansoort] int  NOT NULL,
    [AccommodatieId] uniqueidentifier  NULL,
    [Actief] int  NOT NULL,
    [BaantoplaagId] uniqueidentifier  NULL
);
GO

-- Creating table 'ClubCloud_Reserveringen'
CREATE TABLE [dbo].[ClubCloud_Reserveringen] (
    [Id] uniqueidentifier  NOT NULL,
    [BaanId] uniqueidentifier  NULL,
    [Datum] datetime  NOT NULL,
    [Tijd] time  NOT NULL,
    [Duur] time  NOT NULL,
    [ReserveringSoort] int  NOT NULL,
    [Beschrijving] nvarchar(max)  NOT NULL,
    [Gebruiker_Een] uniqueidentifier  NULL,
    [Gebruiker_Twee] uniqueidentifier  NULL,
    [Gebruiker_Drie] uniqueidentifier  NULL,
    [Gebruiker_Vier] uniqueidentifier  NULL,
    [Final] bit  NOT NULL
);
GO

-- Creating table 'ClubCloud_Afhangen'
CREATE TABLE [dbo].[ClubCloud_Afhangen] (
    [Id] uniqueidentifier  NOT NULL,
    [VerenigingId] uniqueidentifier  NULL,
    [MaandBegin] int  NOT NULL,
    [MaandEinde] int  NOT NULL,
    [BaanBegin] time  NOT NULL,
    [BaanEinde] time  NOT NULL,
    [Duur_Een] int  NOT NULL,
    [Duur_Twee] int  NOT NULL,
    [Duur_Drie] int  NOT NULL,
    [Duur_Vier] int  NOT NULL,
    [Duur_Precisie] int  NOT NULL
);
GO

-- Creating table 'ClubCloud_Baanschemas'
CREATE TABLE [dbo].[ClubCloud_Baanschemas] (
    [Id] uniqueidentifier  NOT NULL,
    [BaanId] uniqueidentifier  NULL,
    [VerenigingId] uniqueidentifier  NULL,
    [Beschikbaar] bit  NOT NULL,
    [MaandBegin] int  NOT NULL,
    [MaandEinde] int  NOT NULL,
    [Dag] int  NOT NULL,
    [DagBegin] time  NOT NULL,
    [DagEinde] time  NOT NULL
);
GO

-- Creating table 'ClubCloud_Fotos'
CREATE TABLE [dbo].[ClubCloud_Fotos] (
    [Id] uniqueidentifier  NOT NULL,
    [FotoId] int  NOT NULL,
    [ContentData] varbinary(max)  NULL,
    [ContentType] nvarchar(max)  NOT NULL,
    [ContentLength] float  NOT NULL,
    [Gewijzigd] datetime  NOT NULL
);
GO

-- Creating table 'ClubCloud_Lidmaatschapsoorten'
CREATE TABLE [dbo].[ClubCloud_Lidmaatschapsoorten] (
    [Id] uniqueidentifier  NOT NULL,
    [VerenigingId] uniqueidentifier  NULL,
    [Naam] nvarchar(max)  NOT NULL,
    [Beschrijving] nvarchar(max)  NOT NULL,
    [Omschrijving] nvarchar(max)  NOT NULL,
    [Code] nvarchar(max)  NOT NULL,
    [DagBegin] time  NOT NULL,
    [DagEinde] time  NOT NULL,
    [Contributie] bit  NOT NULL,
    [Tarief] nvarchar(max)  NOT NULL,
    [Actief] int  NOT NULL
);
GO

-- Creating table 'ClubCloud_Sponsoren'
CREATE TABLE [dbo].[ClubCloud_Sponsoren] (
    [Id] uniqueidentifier  NOT NULL,
    [VerenigingId] uniqueidentifier  NOT NULL,
    [AfbeeldingId] uniqueidentifier  NULL,
    [Naam] nvarchar(max)  NOT NULL,
    [Tekst] nvarchar(max)  NULL
);
GO

-- Creating table 'ClubCloud_Sponsor_Afbeeldingen'
CREATE TABLE [dbo].[ClubCloud_Sponsor_Afbeeldingen] (
    [Id] uniqueidentifier  NOT NULL,
    [Afbeelding] varbinary(max)  NOT NULL
);
GO

-- Creating table 'ClubCloud_Baanblokken'
CREATE TABLE [dbo].[ClubCloud_Baanblokken] (
    [Id] uniqueidentifier  NOT NULL,
    [Naam] nvarchar(max)  NOT NULL,
    [AccommodatieId] uniqueidentifier  NULL,
    [BaantypeId] uniqueidentifier  NULL,
    [BaansoortId] uniqueidentifier  NULL,
    [Verlichting] bit  NOT NULL,
    [Locatie] nvarchar(max)  NOT NULL,
    [Actief] int  NOT NULL
);
GO

-- Creating table 'ClubCloud_Baantoplagen'
CREATE TABLE [dbo].[ClubCloud_Baantoplagen] (
    [Id] uniqueidentifier  NOT NULL,
    [Naam] nvarchar(max)  NOT NULL,
    [Beschrijving] nvarchar(max)  NOT NULL,
    [Meervoud] nvarchar(max)  NOT NULL,
    [Omschrijving] nvarchar(max)  NOT NULL,
    [Code] nvarchar(max)  NOT NULL,
    [Actief] int  NOT NULL
);
GO

-- Creating table 'ClubCloud_Landen'
CREATE TABLE [dbo].[ClubCloud_Landen] (
    [Id] uniqueidentifier  NOT NULL,
    [Naam] nvarchar(max)  NOT NULL,
    [Code] nvarchar(max)  NOT NULL
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

-- Creating primary key on [Id] in table 'ClubCloud_Accommodaties'
ALTER TABLE [dbo].[ClubCloud_Accommodaties]
ADD CONSTRAINT [PK_ClubCloud_Accommodaties]
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

-- Creating primary key on [Id], [Datum] in table 'ClubCloud_Profielen'
ALTER TABLE [dbo].[ClubCloud_Profielen]
ADD CONSTRAINT [PK_ClubCloud_Profielen]
    PRIMARY KEY CLUSTERED ([Id], [Datum] ASC);
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

-- Creating primary key on [Id] in table 'ClubCloud_Addressen'
ALTER TABLE [dbo].[ClubCloud_Addressen]
ADD CONSTRAINT [PK_ClubCloud_Addressen]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClubCloud_Regios'
ALTER TABLE [dbo].[ClubCloud_Regios]
ADD CONSTRAINT [PK_ClubCloud_Regios]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClubCloud_Baansoorten'
ALTER TABLE [dbo].[ClubCloud_Baansoorten]
ADD CONSTRAINT [PK_ClubCloud_Baansoorten]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClubCloud_Baantypes'
ALTER TABLE [dbo].[ClubCloud_Baantypes]
ADD CONSTRAINT [PK_ClubCloud_Baantypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClubCloud_Banen'
ALTER TABLE [dbo].[ClubCloud_Banen]
ADD CONSTRAINT [PK_ClubCloud_Banen]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClubCloud_Bouwaarden'
ALTER TABLE [dbo].[ClubCloud_Bouwaarden]
ADD CONSTRAINT [PK_ClubCloud_Bouwaarden]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClubCloud_BanenSpeciaal'
ALTER TABLE [dbo].[ClubCloud_BanenSpeciaal]
ADD CONSTRAINT [PK_ClubCloud_BanenSpeciaal]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClubCloud_Reserveringen'
ALTER TABLE [dbo].[ClubCloud_Reserveringen]
ADD CONSTRAINT [PK_ClubCloud_Reserveringen]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClubCloud_Afhangen'
ALTER TABLE [dbo].[ClubCloud_Afhangen]
ADD CONSTRAINT [PK_ClubCloud_Afhangen]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClubCloud_Baanschemas'
ALTER TABLE [dbo].[ClubCloud_Baanschemas]
ADD CONSTRAINT [PK_ClubCloud_Baanschemas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClubCloud_Fotos'
ALTER TABLE [dbo].[ClubCloud_Fotos]
ADD CONSTRAINT [PK_ClubCloud_Fotos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClubCloud_Lidmaatschapsoorten'
ALTER TABLE [dbo].[ClubCloud_Lidmaatschapsoorten]
ADD CONSTRAINT [PK_ClubCloud_Lidmaatschapsoorten]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClubCloud_Sponsoren'
ALTER TABLE [dbo].[ClubCloud_Sponsoren]
ADD CONSTRAINT [PK_ClubCloud_Sponsoren]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClubCloud_Sponsor_Afbeeldingen'
ALTER TABLE [dbo].[ClubCloud_Sponsor_Afbeeldingen]
ADD CONSTRAINT [PK_ClubCloud_Sponsor_Afbeeldingen]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClubCloud_Baanblokken'
ALTER TABLE [dbo].[ClubCloud_Baanblokken]
ADD CONSTRAINT [PK_ClubCloud_Baanblokken]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClubCloud_Baantoplagen'
ALTER TABLE [dbo].[ClubCloud_Baantoplagen]
ADD CONSTRAINT [PK_ClubCloud_Baantoplagen]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClubCloud_Landen'
ALTER TABLE [dbo].[ClubCloud_Landen]
ADD CONSTRAINT [PK_ClubCloud_Landen]
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
ADD CONSTRAINT [FK_ClubCloud_Gebruiker_Functionaris]
    FOREIGN KEY ([GebruikerId])
    REFERENCES [dbo].[ClubCloud_Gebruikers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_Gebruiker_Functionaris'
CREATE INDEX [IX_FK_ClubCloud_Gebruiker_Functionaris]
ON [dbo].[ClubCloud_Functionarissen]
    ([GebruikerId]);
GO

-- Creating foreign key on [DistrictId] in table 'ClubCloud_Functionarissen'
ALTER TABLE [dbo].[ClubCloud_Functionarissen]
ADD CONSTRAINT [FK_ClubCloud_Functionaris_District]
    FOREIGN KEY ([DistrictId])
    REFERENCES [dbo].[ClubCloud_Districten]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_Functionaris_District'
CREATE INDEX [IX_FK_ClubCloud_Functionaris_District]
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
ADD CONSTRAINT [FK_ClubCloud_Gebruiker_Lidmaatschap]
    FOREIGN KEY ([GebruikerId])
    REFERENCES [dbo].[ClubCloud_Gebruikers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_Gebruiker_Lidmaatschap'
CREATE INDEX [IX_FK_ClubCloud_Gebruiker_Lidmaatschap]
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
ADD CONSTRAINT [FK_ClubCloud_Bestuursorgaan_Vereniging]
    FOREIGN KEY ([VerenigingId])
    REFERENCES [dbo].[ClubCloud_Verenigingen]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_Bestuursorgaan_Vereniging'
CREATE INDEX [IX_FK_ClubCloud_Bestuursorgaan_Vereniging]
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
ADD CONSTRAINT [FK_ClubCloud_Vereniging_Rechtsvorm]
    FOREIGN KEY ([RechtsvormId])
    REFERENCES [dbo].[ClubCloud_Rechtsvormen]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_Vereniging_Rechtsvorm'
CREATE INDEX [IX_FK_ClubCloud_Vereniging_Rechtsvorm]
ON [dbo].[ClubCloud_Verenigingen]
    ([RechtsvormId]);
GO

-- Creating foreign key on [AccommodatieId] in table 'ClubCloud_Verenigingen'
ALTER TABLE [dbo].[ClubCloud_Verenigingen]
ADD CONSTRAINT [FK_ClubCloud_Vereniging_Accommodatie]
    FOREIGN KEY ([AccommodatieId])
    REFERENCES [dbo].[ClubCloud_Accommodaties]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_Vereniging_Accommodatie'
CREATE INDEX [IX_FK_ClubCloud_Vereniging_Accommodatie]
ON [dbo].[ClubCloud_Verenigingen]
    ([AccommodatieId]);
GO

-- Creating foreign key on [ParentId] in table 'ClubCloud_Addressen'
ALTER TABLE [dbo].[ClubCloud_Addressen]
ADD CONSTRAINT [FK_ClubCloud_Vereniging_Address]
    FOREIGN KEY ([ParentId])
    REFERENCES [dbo].[ClubCloud_Verenigingen]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_Vereniging_Address'
CREATE INDEX [IX_FK_ClubCloud_Vereniging_Address]
ON [dbo].[ClubCloud_Addressen]
    ([ParentId]);
GO

-- Creating foreign key on [RegioId] in table 'ClubCloud_Verenigingen'
ALTER TABLE [dbo].[ClubCloud_Verenigingen]
ADD CONSTRAINT [FK_ClubCloud_Vereniging_Regio]
    FOREIGN KEY ([RegioId])
    REFERENCES [dbo].[ClubCloud_Regios]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_Vereniging_Regio'
CREATE INDEX [IX_FK_ClubCloud_Vereniging_Regio]
ON [dbo].[ClubCloud_Verenigingen]
    ([RegioId]);
GO

-- Creating foreign key on [RegioId] in table 'ClubCloud_Districten'
ALTER TABLE [dbo].[ClubCloud_Districten]
ADD CONSTRAINT [FK_ClubCloud_District_Regio]
    FOREIGN KEY ([RegioId])
    REFERENCES [dbo].[ClubCloud_Regios]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_District_Regio'
CREATE INDEX [IX_FK_ClubCloud_District_Regio]
ON [dbo].[ClubCloud_Districten]
    ([RegioId]);
GO

-- Creating foreign key on [ParentId] in table 'ClubCloud_Addressen'
ALTER TABLE [dbo].[ClubCloud_Addressen]
ADD CONSTRAINT [FK_ClubCloud_Gebruiker_Address]
    FOREIGN KEY ([ParentId])
    REFERENCES [dbo].[ClubCloud_Gebruikers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_Gebruiker_Address'
CREATE INDEX [IX_FK_ClubCloud_Gebruiker_Address]
ON [dbo].[ClubCloud_Addressen]
    ([ParentId]);
GO

-- Creating foreign key on [VerenigingId] in table 'ClubCloud_Gebruikers'
ALTER TABLE [dbo].[ClubCloud_Gebruikers]
ADD CONSTRAINT [FK_ClubCloud_Gebruiker_Vereniging]
    FOREIGN KEY ([VerenigingId])
    REFERENCES [dbo].[ClubCloud_Verenigingen]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_Gebruiker_Vereniging'
CREATE INDEX [IX_FK_ClubCloud_Gebruiker_Vereniging]
ON [dbo].[ClubCloud_Gebruikers]
    ([VerenigingId]);
GO

-- Creating foreign key on [GebruikerId] in table 'ClubCloud_Profielen'
ALTER TABLE [dbo].[ClubCloud_Profielen]
ADD CONSTRAINT [FK_ClubCloud_Profiel_Gebruiker]
    FOREIGN KEY ([GebruikerId])
    REFERENCES [dbo].[ClubCloud_Gebruikers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_Profiel_Gebruiker'
CREATE INDEX [IX_FK_ClubCloud_Profiel_Gebruiker]
ON [dbo].[ClubCloud_Profielen]
    ([GebruikerId]);
GO

-- Creating foreign key on [BaantypeId] in table 'ClubCloud_Baansoorten'
ALTER TABLE [dbo].[ClubCloud_Baansoorten]
ADD CONSTRAINT [FK_ClubCloud_Baansoort_Baantype]
    FOREIGN KEY ([BaantypeId])
    REFERENCES [dbo].[ClubCloud_Baantypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_Baansoort_Baantype'
CREATE INDEX [IX_FK_ClubCloud_Baansoort_Baantype]
ON [dbo].[ClubCloud_Baansoorten]
    ([BaantypeId]);
GO

-- Creating foreign key on [DistrictId] in table 'ClubCloud_Accommodaties'
ALTER TABLE [dbo].[ClubCloud_Accommodaties]
ADD CONSTRAINT [FK_ClubCloud_Accommodatie_District]
    FOREIGN KEY ([DistrictId])
    REFERENCES [dbo].[ClubCloud_Districten]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_Accommodatie_District'
CREATE INDEX [IX_FK_ClubCloud_Accommodatie_District]
ON [dbo].[ClubCloud_Accommodaties]
    ([DistrictId]);
GO

-- Creating foreign key on [RegioId] in table 'ClubCloud_Accommodaties'
ALTER TABLE [dbo].[ClubCloud_Accommodaties]
ADD CONSTRAINT [FK_ClubCloud_Accommodatie_Regio]
    FOREIGN KEY ([RegioId])
    REFERENCES [dbo].[ClubCloud_Regios]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_Accommodatie_Regio'
CREATE INDEX [IX_FK_ClubCloud_Accommodatie_Regio]
ON [dbo].[ClubCloud_Accommodaties]
    ([RegioId]);
GO

-- Creating foreign key on [BaanId] in table 'ClubCloud_Reserveringen'
ALTER TABLE [dbo].[ClubCloud_Reserveringen]
ADD CONSTRAINT [FK_ClubCloud_Reservering_Baan]
    FOREIGN KEY ([BaanId])
    REFERENCES [dbo].[ClubCloud_Banen]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_Reservering_Baan'
CREATE INDEX [IX_FK_ClubCloud_Reservering_Baan]
ON [dbo].[ClubCloud_Reserveringen]
    ([BaanId]);
GO

-- Creating foreign key on [Gebruiker_Een] in table 'ClubCloud_Reserveringen'
ALTER TABLE [dbo].[ClubCloud_Reserveringen]
ADD CONSTRAINT [FK_ClubCloud_Reservering_Gebruiker_Een]
    FOREIGN KEY ([Gebruiker_Een])
    REFERENCES [dbo].[ClubCloud_Gebruikers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_Reservering_Gebruiker_Een'
CREATE INDEX [IX_FK_ClubCloud_Reservering_Gebruiker_Een]
ON [dbo].[ClubCloud_Reserveringen]
    ([Gebruiker_Een]);
GO

-- Creating foreign key on [Gebruiker_Twee] in table 'ClubCloud_Reserveringen'
ALTER TABLE [dbo].[ClubCloud_Reserveringen]
ADD CONSTRAINT [FK_ClubCloud_Reservering_Gebruiker_Twee]
    FOREIGN KEY ([Gebruiker_Twee])
    REFERENCES [dbo].[ClubCloud_Gebruikers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_Reservering_Gebruiker_Twee'
CREATE INDEX [IX_FK_ClubCloud_Reservering_Gebruiker_Twee]
ON [dbo].[ClubCloud_Reserveringen]
    ([Gebruiker_Twee]);
GO

-- Creating foreign key on [Gebruiker_Drie] in table 'ClubCloud_Reserveringen'
ALTER TABLE [dbo].[ClubCloud_Reserveringen]
ADD CONSTRAINT [FK_ClubCloud_Reservering_Gebruiker_Drie]
    FOREIGN KEY ([Gebruiker_Drie])
    REFERENCES [dbo].[ClubCloud_Gebruikers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_Reservering_Gebruiker_Drie'
CREATE INDEX [IX_FK_ClubCloud_Reservering_Gebruiker_Drie]
ON [dbo].[ClubCloud_Reserveringen]
    ([Gebruiker_Drie]);
GO

-- Creating foreign key on [Gebruiker_Vier] in table 'ClubCloud_Reserveringen'
ALTER TABLE [dbo].[ClubCloud_Reserveringen]
ADD CONSTRAINT [FK_ClubCloud_Reservering_Gebruiker_Vier]
    FOREIGN KEY ([Gebruiker_Vier])
    REFERENCES [dbo].[ClubCloud_Gebruikers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_Reservering_Gebruiker_Vier'
CREATE INDEX [IX_FK_ClubCloud_Reservering_Gebruiker_Vier]
ON [dbo].[ClubCloud_Reserveringen]
    ([Gebruiker_Vier]);
GO

-- Creating foreign key on [VerenigingId] in table 'ClubCloud_Afhangen'
ALTER TABLE [dbo].[ClubCloud_Afhangen]
ADD CONSTRAINT [FK_ClubCloud_Afhangen_Vereniging]
    FOREIGN KEY ([VerenigingId])
    REFERENCES [dbo].[ClubCloud_Verenigingen]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_Afhangen_Vereniging'
CREATE INDEX [IX_FK_ClubCloud_Afhangen_Vereniging]
ON [dbo].[ClubCloud_Afhangen]
    ([VerenigingId]);
GO

-- Creating foreign key on [LidmaatschapsoortId] in table 'ClubCloud_Lidmaatschappen'
ALTER TABLE [dbo].[ClubCloud_Lidmaatschappen]
ADD CONSTRAINT [FK_ClubCloud_LidmaatschapSoort_Lidmaatschap]
    FOREIGN KEY ([LidmaatschapsoortId])
    REFERENCES [dbo].[ClubCloud_Lidmaatschapsoorten]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_LidmaatschapSoort_Lidmaatschap'
CREATE INDEX [IX_FK_ClubCloud_LidmaatschapSoort_Lidmaatschap]
ON [dbo].[ClubCloud_Lidmaatschappen]
    ([LidmaatschapsoortId]);
GO

-- Creating foreign key on [VerenigingId] in table 'ClubCloud_Sponsoren'
ALTER TABLE [dbo].[ClubCloud_Sponsoren]
ADD CONSTRAINT [FK_ClubCloud_Sponsor_Vereniging]
    FOREIGN KEY ([VerenigingId])
    REFERENCES [dbo].[ClubCloud_Verenigingen]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_Sponsor_Vereniging'
CREATE INDEX [IX_FK_ClubCloud_Sponsor_Vereniging]
ON [dbo].[ClubCloud_Sponsoren]
    ([VerenigingId]);
GO

-- Creating foreign key on [AfbeeldingId] in table 'ClubCloud_Sponsoren'
ALTER TABLE [dbo].[ClubCloud_Sponsoren]
ADD CONSTRAINT [FK_ClubCloud_Sponsor_Sponsor_Afbeelding]
    FOREIGN KEY ([AfbeeldingId])
    REFERENCES [dbo].[ClubCloud_Sponsor_Afbeeldingen]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_Sponsor_Sponsor_Afbeelding'
CREATE INDEX [IX_FK_ClubCloud_Sponsor_Sponsor_Afbeelding]
ON [dbo].[ClubCloud_Sponsoren]
    ([AfbeeldingId]);
GO

-- Creating foreign key on [BaanblokId] in table 'ClubCloud_Banen'
ALTER TABLE [dbo].[ClubCloud_Banen]
ADD CONSTRAINT [FK_ClubCloud_Baan_Baanblok]
    FOREIGN KEY ([BaanblokId])
    REFERENCES [dbo].[ClubCloud_Baanblokken]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_Baan_Baanblok'
CREATE INDEX [IX_FK_ClubCloud_Baan_Baanblok]
ON [dbo].[ClubCloud_Banen]
    ([BaanblokId]);
GO

-- Creating foreign key on [AccommodatieId] in table 'ClubCloud_Baanblokken'
ALTER TABLE [dbo].[ClubCloud_Baanblokken]
ADD CONSTRAINT [FK_ClubCloud_Baanblok_Accommodatie]
    FOREIGN KEY ([AccommodatieId])
    REFERENCES [dbo].[ClubCloud_Accommodaties]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_Baanblok_Accommodatie'
CREATE INDEX [IX_FK_ClubCloud_Baanblok_Accommodatie]
ON [dbo].[ClubCloud_Baanblokken]
    ([AccommodatieId]);
GO

-- Creating foreign key on [BaantypeId] in table 'ClubCloud_Baanblokken'
ALTER TABLE [dbo].[ClubCloud_Baanblokken]
ADD CONSTRAINT [FK_ClubCloud_Baanblok_Baantype]
    FOREIGN KEY ([BaantypeId])
    REFERENCES [dbo].[ClubCloud_Baantypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_Baanblok_Baantype'
CREATE INDEX [IX_FK_ClubCloud_Baanblok_Baantype]
ON [dbo].[ClubCloud_Baanblokken]
    ([BaantypeId]);
GO

-- Creating foreign key on [BaansoortId] in table 'ClubCloud_Baanblokken'
ALTER TABLE [dbo].[ClubCloud_Baanblokken]
ADD CONSTRAINT [FK_ClubCloud_Baanblok_Baansoort]
    FOREIGN KEY ([BaansoortId])
    REFERENCES [dbo].[ClubCloud_Baansoorten]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_Baanblok_Baansoort'
CREATE INDEX [IX_FK_ClubCloud_Baanblok_Baansoort]
ON [dbo].[ClubCloud_Baanblokken]
    ([BaansoortId]);
GO

-- Creating foreign key on [AccommodatieId] in table 'ClubCloud_Banen'
ALTER TABLE [dbo].[ClubCloud_Banen]
ADD CONSTRAINT [FK_ClubCloud_Baan_Accommodatie]
    FOREIGN KEY ([AccommodatieId])
    REFERENCES [dbo].[ClubCloud_Accommodaties]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_Baan_Accommodatie'
CREATE INDEX [IX_FK_ClubCloud_Baan_Accommodatie]
ON [dbo].[ClubCloud_Banen]
    ([AccommodatieId]);
GO

-- Creating foreign key on [AccommodatieId] in table 'ClubCloud_BanenSpeciaal'
ALTER TABLE [dbo].[ClubCloud_BanenSpeciaal]
ADD CONSTRAINT [FK_ClubCloud_BaanSpeciaal_Accommodatie]
    FOREIGN KEY ([AccommodatieId])
    REFERENCES [dbo].[ClubCloud_Accommodaties]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_BaanSpeciaal_Accommodatie'
CREATE INDEX [IX_FK_ClubCloud_BaanSpeciaal_Accommodatie]
ON [dbo].[ClubCloud_BanenSpeciaal]
    ([AccommodatieId]);
GO

-- Creating foreign key on [BaantoplaagId] in table 'ClubCloud_BanenSpeciaal'
ALTER TABLE [dbo].[ClubCloud_BanenSpeciaal]
ADD CONSTRAINT [FK_ClubCloud_BaanSpeciaal_Baantoplaag]
    FOREIGN KEY ([BaantoplaagId])
    REFERENCES [dbo].[ClubCloud_Baantoplagen]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_BaanSpeciaal_Baantoplaag'
CREATE INDEX [IX_FK_ClubCloud_BaanSpeciaal_Baantoplaag]
ON [dbo].[ClubCloud_BanenSpeciaal]
    ([BaantoplaagId]);
GO

-- Creating foreign key on [ParentId] in table 'ClubCloud_Addressen'
ALTER TABLE [dbo].[ClubCloud_Addressen]
ADD CONSTRAINT [FK_ClubCloud_Regio_Address]
    FOREIGN KEY ([ParentId])
    REFERENCES [dbo].[ClubCloud_Regios]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_Regio_Address'
CREATE INDEX [IX_FK_ClubCloud_Regio_Address]
ON [dbo].[ClubCloud_Addressen]
    ([ParentId]);
GO

-- Creating foreign key on [GebruikerId] in table 'ClubCloud_Settings'
ALTER TABLE [dbo].[ClubCloud_Settings]
ADD CONSTRAINT [FK_ClubCloud_Setting_Gebruiker]
    FOREIGN KEY ([GebruikerId])
    REFERENCES [dbo].[ClubCloud_Gebruikers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_Setting_Gebruiker'
CREATE INDEX [IX_FK_ClubCloud_Setting_Gebruiker]
ON [dbo].[ClubCloud_Settings]
    ([GebruikerId]);
GO

-- Creating foreign key on [VerenigingId] in table 'ClubCloud_Settings'
ALTER TABLE [dbo].[ClubCloud_Settings]
ADD CONSTRAINT [FK_ClubCloud_Setting_Vereniging]
    FOREIGN KEY ([VerenigingId])
    REFERENCES [dbo].[ClubCloud_Verenigingen]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_Setting_Vereniging'
CREATE INDEX [IX_FK_ClubCloud_Setting_Vereniging]
ON [dbo].[ClubCloud_Settings]
    ([VerenigingId]);
GO

-- Creating foreign key on [ParentId] in table 'ClubCloud_Addressen'
ALTER TABLE [dbo].[ClubCloud_Addressen]
ADD CONSTRAINT [FK_ClubCloud_Accommodatie_Address]
    FOREIGN KEY ([ParentId])
    REFERENCES [dbo].[ClubCloud_Accommodaties]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_Accommodatie_Address'
CREATE INDEX [IX_FK_ClubCloud_Accommodatie_Address]
ON [dbo].[ClubCloud_Addressen]
    ([ParentId]);
GO

-- Creating foreign key on [NationaliteitId] in table 'ClubCloud_Gebruikers'
ALTER TABLE [dbo].[ClubCloud_Gebruikers]
ADD CONSTRAINT [FK_ClubCloud_Gebruiker_Nationaliteit]
    FOREIGN KEY ([NationaliteitId])
    REFERENCES [dbo].[ClubCloud_Nationaliteiten]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_Gebruiker_Nationaliteit'
CREATE INDEX [IX_FK_ClubCloud_Gebruiker_Nationaliteit]
ON [dbo].[ClubCloud_Gebruikers]
    ([NationaliteitId]);
GO

-- Creating foreign key on [BaanId] in table 'ClubCloud_Baanschemas'
ALTER TABLE [dbo].[ClubCloud_Baanschemas]
ADD CONSTRAINT [FK_ClubCloud_Baanschema_Baan]
    FOREIGN KEY ([BaanId])
    REFERENCES [dbo].[ClubCloud_Banen]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_Baanschema_Baan'
CREATE INDEX [IX_FK_ClubCloud_Baanschema_Baan]
ON [dbo].[ClubCloud_Baanschemas]
    ([BaanId]);
GO

-- Creating foreign key on [VerenigingId] in table 'ClubCloud_Baanschemas'
ALTER TABLE [dbo].[ClubCloud_Baanschemas]
ADD CONSTRAINT [FK_ClubCloud_Baanschema_Vereniging]
    FOREIGN KEY ([VerenigingId])
    REFERENCES [dbo].[ClubCloud_Verenigingen]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_Baanschema_Vereniging'
CREATE INDEX [IX_FK_ClubCloud_Baanschema_Vereniging]
ON [dbo].[ClubCloud_Baanschemas]
    ([VerenigingId]);
GO

-- Creating foreign key on [VerenigingId] in table 'ClubCloud_Lidmaatschapsoorten'
ALTER TABLE [dbo].[ClubCloud_Lidmaatschapsoorten]
ADD CONSTRAINT [FK_ClubCloud_Vereniging_Lidmaatschapsoort]
    FOREIGN KEY ([VerenigingId])
    REFERENCES [dbo].[ClubCloud_Verenigingen]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_Vereniging_Lidmaatschapsoort'
CREATE INDEX [IX_FK_ClubCloud_Vereniging_Lidmaatschapsoort]
ON [dbo].[ClubCloud_Lidmaatschapsoorten]
    ([VerenigingId]);
GO

-- Creating foreign key on [LandId] in table 'ClubCloud_Addressen'
ALTER TABLE [dbo].[ClubCloud_Addressen]
ADD CONSTRAINT [FK_ClubCloud_Address_Land]
    FOREIGN KEY ([LandId])
    REFERENCES [dbo].[ClubCloud_Landen]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubCloud_Address_Land'
CREATE INDEX [IX_FK_ClubCloud_Address_Land]
ON [dbo].[ClubCloud_Addressen]
    ([LandId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------