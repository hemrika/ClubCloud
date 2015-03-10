
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/10/2015 10:53:11
-- Generated from EDMX file: C:\Source\ClubCloud\ClubCloud.Model\StoreClubCloud.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ClubCloudService_Store_Model];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ApplicationOperationRecord_ApplicationInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ApplicationOperationRecords] DROP CONSTRAINT [FK_ApplicationOperationRecord_ApplicationInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_ApplicationProcessorArchitecture_AppVersionInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ApplicationProcessorArchitectures] DROP CONSTRAINT [FK_ApplicationProcessorArchitecture_AppVersionInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_ApplicationVersion_ApplicationInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ApplicationVersions] DROP CONSTRAINT [FK_ApplicationVersion_ApplicationInfo];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ApplicationInfoes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ApplicationInfoes];
GO
IF OBJECT_ID(N'[dbo].[ApplicationOperationRecords]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ApplicationOperationRecords];
GO
IF OBJECT_ID(N'[dbo].[ApplicationProcessorArchitectures]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ApplicationProcessorArchitectures];
GO
IF OBJECT_ID(N'[dbo].[ApplicationVersions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ApplicationVersions];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ApplicationInfoes'
CREATE TABLE [dbo].[ApplicationInfoes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ApplicationName] nvarchar(500)  NOT NULL,
    [MajorVersion] nvarchar(500)  NOT NULL,
    [Status] int  NOT NULL,
    [CreationDate] datetime  NOT NULL,
    [OperationDate] datetime  NOT NULL,
    [IsHidden] bit  NOT NULL,
    [IsValid] bit  NOT NULL
);
GO

-- Creating table 'ApplicationProcessorArchitectures'
CREATE TABLE [dbo].[ApplicationProcessorArchitectures] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ApplicationVersionId] int  NOT NULL,
    [Version] nvarchar(500)  NOT NULL,
    [ProcessorArchitecture] int  NOT NULL,
    [Package] varbinary(max)  NOT NULL,
    [Certificate] varbinary(max)  NOT NULL,
    [Symbols] varbinary(max)  NOT NULL,
    [UploadDate] datetime  NOT NULL
);
GO

-- Creating table 'ApplicationVersions'
CREATE TABLE [dbo].[ApplicationVersions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ApplicationInfoId] int  NOT NULL,
    [IdentityName] nvarchar(500)  NOT NULL,
    [Version] nvarchar(500)  NOT NULL,
    [Publisher] nvarchar(500)  NOT NULL,
    [DisplayName] nvarchar(500)  NOT NULL,
    [PublisherDisplayName] nvarchar(500)  NOT NULL,
    [Description] nvarchar(max)  NULL,
    [ProtocolUrl] nvarchar(50)  NULL,
    [OperationDate] datetime  NOT NULL
);
GO

-- Creating table 'ApplicationOperationRecords'
CREATE TABLE [dbo].[ApplicationOperationRecords] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TimeStamp] datetime  NOT NULL,
    [UserName] nvarchar(255)  NOT NULL,
    [OperationType] int  NOT NULL,
    [ApplicationInfoId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ApplicationInfoes'
ALTER TABLE [dbo].[ApplicationInfoes]
ADD CONSTRAINT [PK_ApplicationInfoes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ApplicationProcessorArchitectures'
ALTER TABLE [dbo].[ApplicationProcessorArchitectures]
ADD CONSTRAINT [PK_ApplicationProcessorArchitectures]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ApplicationVersions'
ALTER TABLE [dbo].[ApplicationVersions]
ADD CONSTRAINT [PK_ApplicationVersions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ApplicationOperationRecords'
ALTER TABLE [dbo].[ApplicationOperationRecords]
ADD CONSTRAINT [PK_ApplicationOperationRecords]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ApplicationInfoId] in table 'ApplicationVersions'
ALTER TABLE [dbo].[ApplicationVersions]
ADD CONSTRAINT [FK_ApplicationVersion_ApplicationInfo]
    FOREIGN KEY ([ApplicationInfoId])
    REFERENCES [dbo].[ApplicationInfoes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ApplicationVersion_ApplicationInfo'
CREATE INDEX [IX_FK_ApplicationVersion_ApplicationInfo]
ON [dbo].[ApplicationVersions]
    ([ApplicationInfoId]);
GO

-- Creating foreign key on [ApplicationInfoId] in table 'ApplicationOperationRecords'
ALTER TABLE [dbo].[ApplicationOperationRecords]
ADD CONSTRAINT [FK_ApplicationOperationRecord_ApplicationInfo]
    FOREIGN KEY ([ApplicationInfoId])
    REFERENCES [dbo].[ApplicationInfoes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ApplicationOperationRecord_ApplicationInfo'
CREATE INDEX [IX_FK_ApplicationOperationRecord_ApplicationInfo]
ON [dbo].[ApplicationOperationRecords]
    ([ApplicationInfoId]);
GO

-- Creating foreign key on [ApplicationVersionId] in table 'ApplicationProcessorArchitectures'
ALTER TABLE [dbo].[ApplicationProcessorArchitectures]
ADD CONSTRAINT [FK_ApplicationProcessorArchitecture_AppVersionInfo]
    FOREIGN KEY ([ApplicationVersionId])
    REFERENCES [dbo].[ApplicationVersions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ApplicationProcessorArchitecture_AppVersionInfo'
CREATE INDEX [IX_FK_ApplicationProcessorArchitecture_AppVersionInfo]
ON [dbo].[ApplicationProcessorArchitectures]
    ([ApplicationVersionId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------