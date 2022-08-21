
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/17/2022 23:12:28
-- Generated from EDMX file: C:\Users\zuzia\source\repos\Dietaverse\Dietaverse\Dietaverse\View\db_model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Dietaverse_database];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'usersSet'
CREATE TABLE [dbo].[usersSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [imie] nvarchar(max)  NOT NULL,
    [nazwisko] nvarchar(max)  NOT NULL,
    [body_gallery_Id] int  NOT NULL
);
GO

-- Creating table 'dishes_gallerySet'
CREATE TABLE [dbo].[dishes_gallerySet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nazwa] nvarchar(max)  NOT NULL,
    [przepis] nvarchar(max)  NOT NULL,
    [kcal] int  NOT NULL,
    [photo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'body_gallerySet'
CREATE TABLE [dbo].[body_gallerySet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [photo] nvarchar(max)  NOT NULL,
    [weight] nvarchar(max)  NOT NULL,
    [date] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'usersdishes_gallery'
CREATE TABLE [dbo].[usersdishes_gallery] (
    [users_Id] int  NOT NULL,
    [dishes_gallery_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'usersSet'
ALTER TABLE [dbo].[usersSet]
ADD CONSTRAINT [PK_usersSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'dishes_gallerySet'
ALTER TABLE [dbo].[dishes_gallerySet]
ADD CONSTRAINT [PK_dishes_gallerySet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'body_gallerySet'
ALTER TABLE [dbo].[body_gallerySet]
ADD CONSTRAINT [PK_body_gallerySet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [users_Id], [dishes_gallery_Id] in table 'usersdishes_gallery'
ALTER TABLE [dbo].[usersdishes_gallery]
ADD CONSTRAINT [PK_usersdishes_gallery]
    PRIMARY KEY CLUSTERED ([users_Id], [dishes_gallery_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [users_Id] in table 'usersdishes_gallery'
ALTER TABLE [dbo].[usersdishes_gallery]
ADD CONSTRAINT [FK_usersdishes_gallery_users]
    FOREIGN KEY ([users_Id])
    REFERENCES [dbo].[usersSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [dishes_gallery_Id] in table 'usersdishes_gallery'
ALTER TABLE [dbo].[usersdishes_gallery]
ADD CONSTRAINT [FK_usersdishes_gallery_dishes_gallery]
    FOREIGN KEY ([dishes_gallery_Id])
    REFERENCES [dbo].[dishes_gallerySet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_usersdishes_gallery_dishes_gallery'
CREATE INDEX [IX_FK_usersdishes_gallery_dishes_gallery]
ON [dbo].[usersdishes_gallery]
    ([dishes_gallery_Id]);
GO

-- Creating foreign key on [body_gallery_Id] in table 'usersSet'
ALTER TABLE [dbo].[usersSet]
ADD CONSTRAINT [FK_usersbody_gallery]
    FOREIGN KEY ([body_gallery_Id])
    REFERENCES [dbo].[body_gallerySet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_usersbody_gallery'
CREATE INDEX [IX_FK_usersbody_gallery]
ON [dbo].[usersSet]
    ([body_gallery_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------