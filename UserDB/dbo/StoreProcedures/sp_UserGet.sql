CREATE PROCEDURE [dbo].[sp_UserGet]
	@id int
AS
BEGIN
	SELECT Id, FirstName, LastName
	FROM dbo.[User] 
	WHERE Id = @id
END
