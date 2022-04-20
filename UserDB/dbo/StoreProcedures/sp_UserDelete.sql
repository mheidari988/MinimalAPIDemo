CREATE PROCEDURE [dbo].[sp_UserDelete]
	@Id Int
AS
BEGIN
	DELETE FROM dbo.[User]
	WHERE Id = @Id
END
