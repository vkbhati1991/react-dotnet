USE [sms]
GO

/****** Object:  StoredProcedure [dbo].[spDeleteStudent]    Script Date: 31-05-2020 13:47:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[spDeleteStudent]
(
@StudentId INT,  
@ReturnCode NVARCHAR(20) OUTPUT  
)
as
BEGIN
	SET NOCOUNT ON
	SET @ReturnCode = '0'
	IF NOT EXISTS (SELECT 1 FROM Students WHERE StudentId = @StudentId)
	BEGIN
		SET @ReturnCode = '-1'
		RETURN  
	END
	ELSE
	BEGIN
		DELETE FROM Students WHERE StudentId = @StudentId  
        SET @ReturnCode = '3'  
        RETURN 
	END
END

GO


