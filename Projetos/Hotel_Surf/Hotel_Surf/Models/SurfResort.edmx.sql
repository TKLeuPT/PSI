
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/24/2018 09:49:34
-- Generated from EDMX file: D:\Programação\Hotel_Surf\Hotel_Surf\Models\SurfResort.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Bungalows];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Reservas_Bungalows]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Reservas] DROP CONSTRAINT [FK_Reservas_Bungalows];
GO
IF OBJECT_ID(N'[dbo].[FK_Reservas_Clientes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Reservas] DROP CONSTRAINT [FK_Reservas_Clientes];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Bungalows]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Bungalows];
GO
IF OBJECT_ID(N'[dbo].[Clientes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Clientes];
GO
IF OBJECT_ID(N'[dbo].[Reservas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Reservas];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Bungalows'
CREATE TABLE [dbo].[Bungalows] (
    [NumBung] int  NOT NULL,
    [TipBung] varchar(60)  NOT NULL,
    [PrecoBung] decimal(18,0)  NOT NULL,
    [Reservado] bit  NOT NULL,
    [NumCamas] int  NULL,
    [NumPessoas] int  NULL
);
GO

-- Creating table 'Clientes'
CREATE TABLE [dbo].[Clientes] (
    [NumCliente] int  NOT NULL,
    [ClTitulo] varchar(5)  NOT NULL,
    [ClNome] varchar(60)  NOT NULL,
    [ClApelido] varchar(60)  NOT NULL,
    [ClEmail] varchar(150)  NOT NULL,
    [NIF] int  NOT NULL
);
GO

-- Creating table 'Reservas'
CREATE TABLE [dbo].[Reservas] (
    [NumReserva] int  NOT NULL,
    [NumCliente] int  NOT NULL,
    [DatEntrada] datetime  NOT NULL,
    [DatSaida] datetime  NOT NULL,
    [NumAdultos] int  NOT NULL,
    [NumCriancas] int  NOT NULL,
    [NumBungRes] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [NumBung] in table 'Bungalows'
ALTER TABLE [dbo].[Bungalows]
ADD CONSTRAINT [PK_Bungalows]
    PRIMARY KEY CLUSTERED ([NumBung] ASC);
GO

-- Creating primary key on [NumCliente] in table 'Clientes'
ALTER TABLE [dbo].[Clientes]
ADD CONSTRAINT [PK_Clientes]
    PRIMARY KEY CLUSTERED ([NumCliente] ASC);
GO

-- Creating primary key on [NumReserva] in table 'Reservas'
ALTER TABLE [dbo].[Reservas]
ADD CONSTRAINT [PK_Reservas]
    PRIMARY KEY CLUSTERED ([NumReserva] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [NumBungRes] in table 'Reservas'
ALTER TABLE [dbo].[Reservas]
ADD CONSTRAINT [FK_Reservas_Bungalows]
    FOREIGN KEY ([NumBungRes])
    REFERENCES [dbo].[Bungalows]
        ([NumBung])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Reservas_Bungalows'
CREATE INDEX [IX_FK_Reservas_Bungalows]
ON [dbo].[Reservas]
    ([NumBungRes]);
GO

-- Creating foreign key on [NumCliente] in table 'Reservas'
ALTER TABLE [dbo].[Reservas]
ADD CONSTRAINT [FK_Reservas_Clientes]
    FOREIGN KEY ([NumCliente])
    REFERENCES [dbo].[Clientes]
        ([NumCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Reservas_Clientes'
CREATE INDEX [IX_FK_Reservas_Clientes]
ON [dbo].[Reservas]
    ([NumCliente]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------