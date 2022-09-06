
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/06/2022 18:33:45
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

IF OBJECT_ID(N'[dbo].[FK_daily_summaryusers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[daily_summarySet] DROP CONSTRAINT [FK_daily_summaryusers];
GO
IF OBJECT_ID(N'[dbo].[FK_daily_summarymonths]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[daily_summarySet] DROP CONSTRAINT [FK_daily_summarymonths];
GO
IF OBJECT_ID(N'[dbo].[FK_usersusers_dishes_gallery]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[users_dishes_gallerySet] DROP CONSTRAINT [FK_usersusers_dishes_gallery];
GO
IF OBJECT_ID(N'[dbo].[FK_dishes_galleryusers_dishes_gallery]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[users_dishes_gallerySet] DROP CONSTRAINT [FK_dishes_galleryusers_dishes_gallery];
GO
IF OBJECT_ID(N'[dbo].[FK_usersbody_gallery]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[body_gallerySet] DROP CONSTRAINT [FK_usersbody_gallery];
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
IF OBJECT_ID(N'[dbo].[daily_summarySet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[daily_summarySet];
GO
IF OBJECT_ID(N'[dbo].[monthsSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[monthsSet];
GO
IF OBJECT_ID(N'[dbo].[smoothies_recipesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[smoothies_recipesSet];
GO
IF OBJECT_ID(N'[dbo].[smoothies_ingrSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[smoothies_ingrSet];
GO
IF OBJECT_ID(N'[dbo].[users_dishes_gallerySet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[users_dishes_gallerySet];
GO
IF OBJECT_ID(N'[dbo].[body_gallerySet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[body_gallerySet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'usersSet'
CREATE TABLE [dbo].[usersSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [password] nvarchar(max)  NOT NULL,
    [weight] float  NOT NULL
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

-- Creating table 'daily_summarySet'
CREATE TABLE [dbo].[daily_summarySet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [kcal_amount] nvarchar(max)  NULL,
    [weight] float  NULL,
    [notes] nvarchar(max)  NULL,
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

-- Creating table 'users_dishes_gallerySet'
CREATE TABLE [dbo].[users_dishes_gallerySet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [users_Id] int  NOT NULL,
    [dishes_gallery_Id] int  NOT NULL
);
GO

-- Creating table 'body_gallerySet'
CREATE TABLE [dbo].[body_gallerySet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [photo] nvarchar(max)  NOT NULL,
    [weight] float  NOT NULL,
    [date] datetime  NOT NULL,
    [users_Id] int  NOT NULL
);
GO

-- Creating table 'recipes_ingredientSet'
CREATE TABLE [dbo].[recipes_ingredientSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [smoothies_recipes_Id] int  NOT NULL,
    [smoothies_ingr_Id] int  NOT NULL
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

-- Creating primary key on [Id] in table 'users_dishes_gallerySet'
ALTER TABLE [dbo].[users_dishes_gallerySet]
ADD CONSTRAINT [PK_users_dishes_gallerySet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'body_gallerySet'
ALTER TABLE [dbo].[body_gallerySet]
ADD CONSTRAINT [PK_body_gallerySet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'recipes_ingredientSet'
ALTER TABLE [dbo].[recipes_ingredientSet]
ADD CONSTRAINT [PK_recipes_ingredientSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

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

-- Creating foreign key on [users_Id] in table 'users_dishes_gallerySet'
ALTER TABLE [dbo].[users_dishes_gallerySet]
ADD CONSTRAINT [FK_usersusers_dishes_gallery]
    FOREIGN KEY ([users_Id])
    REFERENCES [dbo].[usersSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_usersusers_dishes_gallery'
CREATE INDEX [IX_FK_usersusers_dishes_gallery]
ON [dbo].[users_dishes_gallerySet]
    ([users_Id]);
GO

-- Creating foreign key on [dishes_gallery_Id] in table 'users_dishes_gallerySet'
ALTER TABLE [dbo].[users_dishes_gallerySet]
ADD CONSTRAINT [FK_dishes_galleryusers_dishes_gallery]
    FOREIGN KEY ([dishes_gallery_Id])
    REFERENCES [dbo].[dishes_gallerySet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dishes_galleryusers_dishes_gallery'
CREATE INDEX [IX_FK_dishes_galleryusers_dishes_gallery]
ON [dbo].[users_dishes_gallerySet]
    ([dishes_gallery_Id]);
GO

-- Creating foreign key on [users_Id] in table 'body_gallerySet'
ALTER TABLE [dbo].[body_gallerySet]
ADD CONSTRAINT [FK_usersbody_gallery]
    FOREIGN KEY ([users_Id])
    REFERENCES [dbo].[usersSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_usersbody_gallery'
CREATE INDEX [IX_FK_usersbody_gallery]
ON [dbo].[body_gallerySet]
    ([users_Id]);
GO

-- Creating foreign key on [smoothies_recipes_Id] in table 'recipes_ingredientSet'
ALTER TABLE [dbo].[recipes_ingredientSet]
ADD CONSTRAINT [FK_smoothies_recipesrecipes_ingredient]
    FOREIGN KEY ([smoothies_recipes_Id])
    REFERENCES [dbo].[smoothies_recipesSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_smoothies_recipesrecipes_ingredient'
CREATE INDEX [IX_FK_smoothies_recipesrecipes_ingredient]
ON [dbo].[recipes_ingredientSet]
    ([smoothies_recipes_Id]);
GO

-- Creating foreign key on [smoothies_ingr_Id] in table 'recipes_ingredientSet'
ALTER TABLE [dbo].[recipes_ingredientSet]
ADD CONSTRAINT [FK_smoothies_ingrrecipes_ingredient]
    FOREIGN KEY ([smoothies_ingr_Id])
    REFERENCES [dbo].[smoothies_ingrSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_smoothies_ingrrecipes_ingredient'
CREATE INDEX [IX_FK_smoothies_ingrrecipes_ingredient]
ON [dbo].[recipes_ingredientSet]
    ([smoothies_ingr_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------