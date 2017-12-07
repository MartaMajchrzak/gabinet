USE [bazaGabinetuStoma]
GO

/****** Object:  Table [dbo].[tablicaZabieg]    Script Date: 30.11.2017 20:36:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tablicaZabieg](
	[rodzajZabiegu] [varchar](50) NULL,
	[cena] [decimal](18, 0) NULL,
	[refundacja] [varchar](3) NULL,
	[opis] [varchar](200) NULL
) ON [PRIMARY]
GO

