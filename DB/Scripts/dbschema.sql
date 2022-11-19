
USE [BancoTeste]
GO

/****** Object:  Table [dbo].[Lista]    Script Date: 18/11/2022 22:09:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


DROP TABLE Lista


CREATE TABLE [dbo].[Lista](
	[Nome] [nchar](200) NOT NULL,
	[Telefone] [nchar](30) NOT NULL,
	[ListaId] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO


