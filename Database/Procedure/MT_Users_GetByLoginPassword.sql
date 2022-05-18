CREATE PROCEDURE [dbo].[MT_Users_GetByLoginPassword]
	@Login NVarChar(50),
	@Password NVarChar(150)
AS

    SELECT
        UserID, Login, Password

FROM   MT_Users with(nolock)

 WHERE 
	[Login] = @Login
	AND  
	[Password] = @Password 
