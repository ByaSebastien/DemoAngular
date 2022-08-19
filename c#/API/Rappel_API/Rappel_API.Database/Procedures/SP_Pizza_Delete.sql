CREATE PROCEDURE [dbo].[SP_Pizza_Delete]
	@Id int = 0
AS
BEGIN
	DELETE FROM [Pizza]
	WHERE [Id] = @Id;
END;
