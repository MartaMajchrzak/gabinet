USE [bazaGabinetuStomatologicznego]
GO

/****** Object:  Table [dbo].[tablicaZabieg]    Script Date: 15.12.2017 13:49:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tablicaZabieg](
	[rodzajZabiegu] [varchar](100) NOT NULL,
	[cena] [decimal](18, 0) NULL,
	[refundacja] [varchar](10) NOT NULL,
	[opis] [varchar](max) NULL,
 CONSTRAINT [PK_tablicaZabieg] PRIMARY KEY CLUSTERED 
(
	[rodzajZabiegu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

