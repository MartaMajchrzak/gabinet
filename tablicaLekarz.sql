USE [bazaGabinetuStomatologicznego]
GO

/****** Object:  Table [dbo].[tablicaLekarz]    Script Date: 15.12.2017 13:48:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tablicaLekarz](
	[IDlekarz] [int] NOT NULL,
	[imie] [varchar](20) NOT NULL,
	[nazwisko] [varchar](30) NOT NULL,
	[PESEL] [int] NULL,
	[specjalnosc] [varchar](max) NOT NULL,
	[dataUrodzenia] [date] NOT NULL,
	[eMail] [varchar](50) NULL,
	[pacjent] [int] NULL,
	[telefon] [int] NULL,
 CONSTRAINT [PK_tablicaLekarz] PRIMARY KEY CLUSTERED 
(
	[IDlekarz] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

