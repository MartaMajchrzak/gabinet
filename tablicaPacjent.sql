USE [bazaGabinetuStomatologicznego]
GO

/****** Object:  Table [dbo].[tablicaPacjent]    Script Date: 15.12.2017 13:48:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tablicaPacjent](
	[IDpacjent] [int] NOT NULL,
	[imie] [varchar](20) NOT NULL,
	[nazwisko] [varchar](30) NOT NULL,
	[PESEL] [int] NULL,
	[telefon] [int] NULL,
	[eMail] [varchar](50) NULL,
	[wizyty] [int] NULL,
	[dataUrodzenia] [date] NOT NULL,
	[adresKorespondencyjny] [varchar](max) NULL,
 CONSTRAINT [PK_tablicaPacjent] PRIMARY KEY CLUSTERED 
(
	[IDpacjent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

