USE [bazaGabinetuStoma]
GO

/****** Object:  Table [dbo].[tablicaWizyta]    Script Date: 30.11.2017 20:36:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tablicaWizyta](
	[IDwizyta] [int] NOT NULL,
	[IDpacjent] [int] NOT NULL,
	[IDlekarz] [int] NOT NULL,
	[rodzajZabiegu] [varchar](100) NULL,
	[dataWizyty] [date] NULL,
	[czasWizyty] [time](7) NULL,
	[kosztSuma] [decimal](18, 0) NULL,
	[recepta] [varchar](100) NULL,
 CONSTRAINT [PK_tablicaWizyta] PRIMARY KEY CLUSTERED 
(
	[IDwizyta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

