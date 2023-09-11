CREATE DATABASE HighSchool
USE [HighSchool]
GO

/****** Object: Table [dbo].[StudentGrades] Script Date: 07/09/2023 12:36:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[StudentGrades] (
    [Id]        INT IDENTITY (1, 1) NOT NULL,
    [Score]     INT NULL,
    [StudentId] INT NOT NULL
);


USE [HighSchool]
GO

/****** Object: Table [dbo].[Students] Script Date: 07/09/2023 12:36:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Students] (
    [Id]   INT        IDENTITY (1, 1) NOT NULL,
    [Name] NCHAR (20) NOT NULL
);


