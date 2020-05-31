USE [sms]
GO

/****** Object:  StoredProcedure [dbo].[spGetStudentById]    Script Date: 31-05-2020 13:48:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[spGetStudentById]
(
	@StudentId INT
)
AS
BEGIN
Select * from Students WHERE StudentId = @StudentId
END

GO


