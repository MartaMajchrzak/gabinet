USE [bazaGabinetuStoma]
GO

/****** Object:  Table [dbo].[tablicaPacjent]    Script Date: 30.11.2017 20:35:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tablicaPacjent](
	[pacjentID] [int] NOT NULL,
	[imie] [varchar](20) NOT NULL,
	[nazwisko] [varchar](30) NOT NULL,
	[PESEL] [int] NULL,
	[telefon] [int] NULL,
	[eMail] [varchar](50) NULL,
	[wizyty] [int] NULL,
	[dataUrodzenia] [date] NOT NULL,
	[adresKorespondencyjny] [varchar](100) NULL,
 CONSTRAINT [PK_tablicaPacjent] PRIMARY KEY CLUSTERED 
(
	[pacjentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

