CREATE TABLE [dbo].[Chars] (
    [Id]   NCHAR (5) NOT NULL,
    [Name] NCHAR (15) NOT NULL,
    [Set]  NCHAR (20) NOT NULL,
    [Gender] NCHAR(1) NOT NULL, 
    [Race] NCHAR(15) NULL, 
    [Class] NCHAR(15) NULL, 
    [Weapon] INT NULL, 
    [Spell] INT NULL, 
    [Armor] INT NULL, 
    [Item] INT NULL, 
    [Ally] INT NULL, 
    [Blessing] INT NULL, 
    [Favorite] NCHAR(10) NULL, 
    [Str] INT NOT NULL, 
    [Dex] INT NOT NULL, 
    [Con] INT NOT NULL, 
    [Int] INT NOT NULL, 
    [Wis] INT NOT NULL, 
    [Cha] INT NOT NULL, 
    [Hand] INT NOT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

