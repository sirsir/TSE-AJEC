USE [bcs_development]
GO

/****** Object:  Table [dbo].[MATERIAL_MASTER]    Script Date: 06/12/2012 22:11:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[MATERIAL_MASTER](
	[MATERIAL_ID] [int] IDENTITY(1,1) NOT NULL,
	[MATERIAL_CODE] [int] NOT NULL,
	[RM_ID] [int] NOT NULL,
	[BIN_ID] [int] NOT NULL,
	[FINAL_VALUE] [numeric](10, 2) NOT NULL,
	[OVER_VALUE] [numeric](10, 2) NOT NULL,
	[UNDER_VALUE] [numeric](10, 2) NOT NULL,
	[SP1_VALUE] [numeric](10, 2) NOT NULL,
	[SP2_VALUE] [numeric](10, 2) NOT NULL,
	[CPS_VALUE] [numeric](10, 2) NOT NULL,
 CONSTRAINT [PK_MATERIAL_MASTER] PRIMARY KEY CLUSTERED 
(
	[MATERIAL_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[MATERIAL_MASTER]  WITH CHECK ADD  CONSTRAINT [FK_MATERIAL_MASTER_BIN_MASTER] FOREIGN KEY([BIN_ID])
REFERENCES [dbo].[BIN_MASTER] ([BIN_ID])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[MATERIAL_MASTER] CHECK CONSTRAINT [FK_MATERIAL_MASTER_BIN_MASTER]
GO

ALTER TABLE [dbo].[MATERIAL_MASTER]  WITH CHECK ADD  CONSTRAINT [FK_MATERIAL_MASTER_RM_MASTER] FOREIGN KEY([RM_ID])
REFERENCES [dbo].[RM_MASTER] ([RM_ID])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[MATERIAL_MASTER] CHECK CONSTRAINT [FK_MATERIAL_MASTER_RM_MASTER]
GO

