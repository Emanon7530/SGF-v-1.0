USE [SGF]
GO
/****** Object:  Table [dbo].[CierreLog]    Script Date: 01/14/2011 22:29:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CierreLog](
	[IDLog] [int] IDENTITY(1,1) NOT NULL,
	[FechaEjecucion] [smalldatetime] NULL,
	[Mes] [int] NULL,
	[Ano] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDLog] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
