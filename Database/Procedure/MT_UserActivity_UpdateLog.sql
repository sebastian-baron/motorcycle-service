CREATE PROCEDURE [dbo].[MT_UserActivity_UpdateLog]
(
	@UserID nvarchar(50), 
	@UserLogin nvarchar(50), 
	@Status nvarchar(50),
	@BledneHaslo nvarchar(50),
	@IP nvarchar(50)
)
AS

BEGIN
	INSERT INTO MT_UserActivity
		(
			UserID, UserLogin, LogInDate, Status,
			IP, BledneHaslo
		)
	VALUES
		(
			@UserID, @UserLogin, GETDATE(), @Status, @IP, @BledneHaslo
		)
END