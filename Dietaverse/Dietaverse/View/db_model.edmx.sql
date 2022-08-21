
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/21/2022 22:36:49
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

IF OBJECT_ID(N'[dbo].[FK_usersdishes_gallery_users]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[usersdishes_gallery] DROP CONSTRAINT [FK_usersdishes_gallery_users];
GO
IF OBJECT_ID(N'[dbo].[FK_usersdishes_gallery_dishes_gallery]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[usersdishes_gallery] DROP CONSTRAINT [FK_usersdishes_gallery_dishes_gallery];
GO
IF OBJECT_ID(N'[dbo].[FK_usersbody_gallery]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[usersSet] DROP CONSTRAINT [FK_usersbody_gallery];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[usersSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[usersSet];
GO
IF OBJECT_ID(N'[dbo].[dishes_gallerySet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[dishes_gallerySet];
GO
IF OBJECT_ID(N'[dbo].[body_gallerySet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[body_gallerySet];
GO
IF OBJECT_ID(N'[dbo].[usersdishes_gallery]', 'U') IS NOT NULL
    DROP TABLE [dbo].[usersdishes_gallery];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'usersSet'
CREATE TABLE [dbo].[usersSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [surname] nvarchar(max)  NOT NULL,
    [body_gallery_Id] int  NOT NULL
);
GO

-- Creating table 'dishes_gallerySet'
CREATE TABLE [dbo].[dishes_gallerySet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [recipe] nvarchar(max)  NOT NULL,
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

-- Creating table 'daily_summarySet'
CREATE TABLE [dbo].[daily_summarySet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [kcal_amount] nvarchar(max)  NOT NULL,
    [weight] nvarchar(max)  NOT NULL,
    [notes] nvarchar(max)  NOT NULL,
    [users_Id] int  NOT NULL,
    [months_Id] int  NOT NULL
);
GO

-- Creating table 'monthsSet'
CREATE TABLE [dbo].[monthsSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [daily_summary] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'smoothies_recipesSet'
CREATE TABLE [dbo].[smoothies_recipesSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [photo] nvarchar(max)  NOT NULL,
    [smoothies_ingr] nvarchar(max)  NOT NULL,
    [kcal] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'smoothies_ingrSet'
CREATE TABLE [dbo].[smoothies_ingrSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [kcal] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'usersdishes_gallery'
CREATE TABLE [dbo].[usersdishes_gallery] (
    [users_Id] int  NOT NULL,
    [dishes_gallery_Id] int  NOT NULL
);
GO

-- Creating table 'smoothies_ingrsmoothies_recipes'
CREATE TABLE [dbo].[smoothies_ingrsmoothies_recipes] (
    [smoothies_ingr1_Id] int  NOT NULL,
    [smoothies_recipes_Id] int  NOT NULL
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

-- Creating primary key on [Id] in table 'daily_summarySet'
ALTER TABLE [dbo].[daily_summarySet]
ADD CONSTRAINT [PK_daily_summarySet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'monthsSet'
ALTER TABLE [dbo].[monthsSet]
ADD CONSTRAINT [PK_monthsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'smoothies_recipesSet'
ALTER TABLE [dbo].[smoothies_recipesSet]
ADD CONSTRAINT [PK_smoothies_recipesSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'smoothies_ingrSet'
ALTER TABLE [dbo].[smoothies_ingrSet]
ADD CONSTRAINT [PK_smoothies_ingrSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [users_Id], [dishes_gallery_Id] in table 'usersdishes_gallery'
ALTER TABLE [dbo].[usersdishes_gallery]
ADD CONSTRAINT [PK_usersdishes_gallery]
    PRIMARY KEY CLUSTERED ([users_Id], [dishes_gallery_Id] ASC);
GO

-- Creating primary key on [smoothies_ingr1_Id], [smoothies_recipes_Id] in table 'smoothies_ingrsmoothies_recipes'
ALTER TABLE [dbo].[smoothies_ingrsmoothies_recipes]
ADD CONSTRAINT [PK_smoothies_ingrsmoothies_recipes]
    PRIMARY KEY CLUSTERED ([smoothies_ingr1_Id], [smoothies_recipes_Id] ASC);
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

-- Creating foreign key on [users_Id] in table 'daily_summarySet'
ALTER TABLE [dbo].[daily_summarySet]
ADD CONSTRAINT [FK_daily_summaryusers]
    FOREIGN KEY ([users_Id])
    REFERENCES [dbo].[usersSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_daily_summaryusers'
CREATE INDEX [IX_FK_daily_summaryusers]
ON [dbo].[daily_summarySet]
    ([users_Id]);
GO

-- Creating foreign key on [months_Id] in table 'daily_summarySet'
ALTER TABLE [dbo].[daily_summarySet]
ADD CONSTRAINT [FK_daily_summarymonths]
    FOREIGN KEY ([months_Id])
    REFERENCES [dbo].[monthsSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_daily_summarymonths'
CREATE INDEX [IX_FK_daily_summarymonths]
ON [dbo].[daily_summarySet]
    ([months_Id]);
GO

-- Creating foreign key on [smoothies_ingr1_Id] in table 'smoothies_ingrsmoothies_recipes'
ALTER TABLE [dbo].[smoothies_ingrsmoothies_recipes]
ADD CONSTRAINT [FK_smoothies_ingrsmoothies_recipes_smoothies_ingr]
    FOREIGN KEY ([smoothies_ingr1_Id])
    REFERENCES [dbo].[smoothies_ingrSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [smoothies_recipes_Id] in table 'smoothies_ingrsmoothies_recipes'
ALTER TABLE [dbo].[smoothies_ingrsmoothies_recipes]
ADD CONSTRAINT [FK_smoothies_ingrsmoothies_recipes_smoothies_recipes]
    FOREIGN KEY ([smoothies_recipes_Id])
    REFERENCES [dbo].[smoothies_recipesSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_smoothies_ingrsmoothies_recipes_smoothies_recipes'
CREATE INDEX [IX_FK_smoothies_ingrsmoothies_recipes_smoothies_recipes]
ON [dbo].[smoothies_ingrsmoothies_recipes]
    ([smoothies_recipes_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------