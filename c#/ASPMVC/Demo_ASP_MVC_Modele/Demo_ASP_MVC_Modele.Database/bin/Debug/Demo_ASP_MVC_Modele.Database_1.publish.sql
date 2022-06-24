/*
Script de déploiement pour Demo_ASP_Database

Ce code a été généré par un outil.
La modification de ce fichier peut provoquer un comportement incorrect et sera perdue si
le code est régénéré.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "Demo_ASP_Database"
:setvar DefaultFilePrefix "Demo_ASP_Database"
:setvar DefaultDataPath "C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\"
:setvar DefaultLogPath "C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\"

GO
:on error exit
GO
/*
Détectez le mode SQLCMD et désactivez l'exécution du script si le mode SQLCMD n'est pas pris en charge.
Pour réactiver le script une fois le mode SQLCMD activé, exécutez ce qui suit :
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'Le mode SQLCMD doit être activé de manière à pouvoir exécuter ce script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Suppression de Contrainte par défaut contrainte sans nom sur [dbo].[Game]...';


GO
ALTER TABLE [dbo].[Game] DROP CONSTRAINT [DF__Game__Coop__38996AB5];


GO
PRINT N'Début de la régénération de la table [dbo].[Game]...';


GO
BEGIN TRANSACTION;

SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

SET XACT_ABORT ON;

CREATE TABLE [dbo].[tmp_ms_xx_Game] (
    [Id]            INT             IDENTITY (1, 1) NOT NULL,
    [Name]          NVARCHAR (50)   NULL,
    [Description]   NVARCHAR (1000) NULL,
    [Nb_Player_Min] INT             NOT NULL,
    [Nb_Player_Max] INT             NOT NULL,
    [Age]           INT             NULL,
    [Coop]          BIT             DEFAULT 0 NOT NULL,
    CONSTRAINT [tmp_ms_xx_constraint_PK_Game1] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [tmp_ms_xx_constraint_UK_Game_Name1] UNIQUE NONCLUSTERED ([Name] ASC)
);

IF EXISTS (SELECT TOP 1 1 
           FROM   [dbo].[Game])
    BEGIN
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_Game] ON;
        INSERT INTO [dbo].[tmp_ms_xx_Game] ([Id], [Name], [Description], [Nb_Player_Min], [Nb_Player_Max], [Age], [Coop])
        SELECT   [Id],
                 [Name],
                 [Description],
                 [Nb_Player_Min],
                 [Nb_Player_Max],
                 [Age],
                 [Coop]
        FROM     [dbo].[Game]
        ORDER BY [Id] ASC;
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_Game] OFF;
    END

DROP TABLE [dbo].[Game];

EXECUTE sp_rename N'[dbo].[tmp_ms_xx_Game]', N'Game';

EXECUTE sp_rename N'[dbo].[tmp_ms_xx_constraint_PK_Game1]', N'PK_Game', N'OBJECT';

EXECUTE sp_rename N'[dbo].[tmp_ms_xx_constraint_UK_Game_Name1]', N'UK_Game_Name', N'OBJECT';

COMMIT TRANSACTION;

SET TRANSACTION ISOLATION LEVEL READ COMMITTED;


GO
PRINT N'Création de Contrainte de validation [dbo].[CK_Game_Nb_Player]...';


GO
ALTER TABLE [dbo].[Game] WITH NOCHECK
    ADD CONSTRAINT [CK_Game_Nb_Player] CHECK ([Nb_Player_Max] >= [Nb_Player_Min]);


GO
PRINT N'Création de Contrainte de validation [dbo].[CK_Game_Age]...';


GO
ALTER TABLE [dbo].[Game] WITH NOCHECK
    ADD CONSTRAINT [CK_Game_Age] CHECK ([Age] >= 0);


GO
PRINT N'Vérification de données existantes par rapport aux nouvelles contraintes';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[Game] WITH CHECK CHECK CONSTRAINT [CK_Game_Nb_Player];

ALTER TABLE [dbo].[Game] WITH CHECK CHECK CONSTRAINT [CK_Game_Age];


GO
PRINT N'Mise à jour terminée.';


GO
