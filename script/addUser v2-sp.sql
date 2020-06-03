USE [sms]
GO

/****** Object:  StoredProcedure [dbo].[spAddUser]    Script Date: 02-06-2020 20:16:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [dbo].[spAddUser]
(
	@UserId int,
	@FirstName varchar(100),
	@LastName varchar(100),
	@Email varchar(100),
	@Password varchar(200),
	@IsActive varchar(100),
	@ReturnCode varchar(200) output
)
as
BEGIN
	SET @ReturnCode = '0'
	IF(@UserId <> 0)
	BEGIN
		IF EXISTS (SELECT 1 FROM Users Where Email = @Email AND UserId <> @UserId)
		BEGIN
			SET @ReturnCode = '2'
			RETURN
		END

		UPDATE Users SET
		FirstName=@FirstName,
		LastName=@LastName,
		Email=@Email,
		UserName = @Email,
		Password=@Password,
		IsActive=@IsActive
		WHERE UserId = @UserId

		SET @ReturnCode = '0'  
	END
	ELSE
	BEGIN
		IF EXISTS (SELECT 1 FROM Users WHERE Email = @Email)  
        BEGIN  
            SET @ReturnCode = '2'  
            RETURN  
        END  

		INSERT INTO 
		Users(FirstName, LastName, Email, UserName, Password, IsActive)
		VALUES (@FirstName, @LastName, @Email, @Email, @Password, @IsActive)
		SET @ReturnCode = '0' 
	END

END	

GO


