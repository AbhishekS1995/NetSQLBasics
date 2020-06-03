USE [Training]
GO

/****** Object:  Table [dbo].[Course]    Script Date: 6/3/2020 1:32:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Course](
	[CourseID] [int] NOT NULL,
	[Title] [varchar](50) NULL,
	[Credits] [varchar](50) NULL,
	[Technology] [int] NULL,
 CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED 
(
	[CourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Course]  WITH CHECK ADD  CONSTRAINT [FK_Course_Technology] FOREIGN KEY([Technology])
REFERENCES [dbo].[Technology] ([TechnologyID])
GO

ALTER TABLE [dbo].[Course] CHECK CONSTRAINT [FK_Course_Technology]
GO


