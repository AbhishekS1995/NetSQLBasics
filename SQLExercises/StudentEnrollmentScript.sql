USE [Training]
GO

/****** Object:  Table [dbo].[StudentEnrollment]    Script Date: 6/3/2020 1:34:35 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[StudentEnrollment](
	[StudentID] [int] NULL,
	[CourseID] [int] NULL
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[StudentEnrollment]  WITH CHECK ADD  CONSTRAINT [FK_StudentEnrollment_Course] FOREIGN KEY([CourseID])
REFERENCES [dbo].[Course] ([CourseID])
GO

ALTER TABLE [dbo].[StudentEnrollment] CHECK CONSTRAINT [FK_StudentEnrollment_Course]
GO


