USE [sms]
GO

/****** Object:  StoredProcedure [dbo].[spGetAllStudents]    Script Date: 31-05-2020 13:48:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spGetAllStudents]
as
Begin
select * from Students order by StudentId DESC
End
GO


