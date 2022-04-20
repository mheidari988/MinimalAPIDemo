CREATE PROCEDURE [dbo].[sp_UserGetAll]
AS
BEGIN
	SELECT Id, FirstName, LastName
	FROM dbo.[User]
END
