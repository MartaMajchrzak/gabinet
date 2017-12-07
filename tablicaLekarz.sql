USE [bazaGabinetuStoma]
GO

/****** Object:  Table [dbo].[tablicaLekarz]    Script Date: 30.11.2017 20:32:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tablicaLekarz](
	[IDlekarz] [int] NOT NULL,
	[imie] [varchar](20) NOT NULL,
	[nazwisko] [varchar](30) NOT NULL,
	[PESEL] [int] NULL,
	[specjalnosc] [varchar](100) NOT NULL,
	[dataUrodzenia] [date] NOT NULL,
	[eMail] [varchar](100) NULL,
	[pacjent] [varchar](100) NULL,
	[telefon] [int] NULL,
 CONSTRAINT [PK_tablicaLekarz] PRIMARY KEY CLUSTERED 
(
	[IDlekarz] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tablicaLekarz]  WITH CHECK ADD  CONSTRAINT [FK_tablicaLekarz_tablicaLekarz] FOREIGN KEY([IDlekarz])
REFERENCES [dbo].[tablicaLekarz] ([IDlekarz])
GO

ALTER TABLE [dbo].[tablicaLekarz] CHECK CONSTRAINT [FK_tablicaLekarz_tablicaLekarz]
GO

