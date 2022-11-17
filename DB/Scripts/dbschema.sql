USE [BancoTeste]
GO

/****** Object:  Table [dbo].[Lista]    Script Date: 17/11/2022 00:14:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Lista](
	[ID] [int] NOT NULL,
	[Nome] [nchar](200) NOT NULL,
	[Telefone] [nchar](30) NOT NULL
) ON [PRIMARY]
GO


