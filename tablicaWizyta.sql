USE [bazaGabinetuStomatologicznego]
GO

/****** Object:  Table [dbo].[tablicaWizyta]    Script Date: 15.12.2017 13:49:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tablicaWizyta](
	[IDpacjent] [int] NOT NULL,
	[IDlekarz] [int] NOT NULL,
	[IDwizyta] [int] NOT NULL,
	[rodzajZabiegu] [varchar](100) NULL,
	[dataWizyty] [date] NOT NULL,
	[czasWizyty] [time](7) NOT NULL,
	[kosztSuma] [decimal](18, 0) NULL,
	[recepta] [varchar](100) NULL,
 CONSTRAINT [PK_tablicaWizyta] PRIMARY KEY CLUSTERED 
(
	[IDwizyta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

