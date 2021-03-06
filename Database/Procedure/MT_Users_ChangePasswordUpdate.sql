CREATE PROCEDURE [dbo].[MT_Users_ChangePasswordUpdate](
    @UserID int,
    @Login nvarchar(150),
    @Password nvarchar(150)


)
AS


IF NOT EXISTS (SELECT * FROM MT_Users WHERE UserID = @UserID)
BEGIN
    INSERT INTO MT_Users(
        Login, Password )
    VALUES (
        @Login, @Password )
END
ELSE
BEGIN
    UPDATE MT_Users SET
        Login = @Login, Password = @Password 
        WHERE UserID = @UserID
END
