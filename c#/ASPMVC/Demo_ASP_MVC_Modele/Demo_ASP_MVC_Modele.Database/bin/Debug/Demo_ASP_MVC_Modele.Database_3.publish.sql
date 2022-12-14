/*
Deployment script for Demo_ASP_Database

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
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
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Creating Table [dbo].[Favorite]...';


GO
CREATE TABLE [dbo].[Favorite] (
    [Id]       INT IDENTITY (1, 1) NOT NULL,
    [IdGame]   INT NOT NULL,
    [IdMember] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating Foreign Key [dbo].[FK_Game_Favorite]...';


GO
ALTER TABLE [dbo].[Favorite] WITH NOCHECK
    ADD CONSTRAINT [FK_Game_Favorite] FOREIGN KEY ([IdGame]) REFERENCES [dbo].[Game] ([Id]);


GO
PRINT N'Creating Foreign Key [dbo].[FK_Member_Favorite]...';


GO
ALTER TABLE [dbo].[Favorite] WITH NOCHECK
    ADD CONSTRAINT [FK_Member_Favorite] FOREIGN KEY ([IdMember]) REFERENCES [dbo].[Member] ([Id]);


GO
PRINT N'Checking existing data against newly created constraints';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[Favorite] WITH CHECK CHECK CONSTRAINT [FK_Game_Favorite];

ALTER TABLE [dbo].[Favorite] WITH CHECK CHECK CONSTRAINT [FK_Member_Favorite];


GO
PRINT N'Update complete.';


GO
