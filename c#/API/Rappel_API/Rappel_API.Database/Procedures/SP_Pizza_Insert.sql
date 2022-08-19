CREATE PROCEDURE [dbo].[SP_Pizza_Insert]
	@Name VARCHAR(50),
	@Price MONEY,
	@PizzaType VARCHAR(50)
AS
BEGIN
	DECLARE @PizzaTypeID INT;

	SET @PizzaTypeID = (SELECT [Id] FROM [PizzaType] WHERE [NAME] = @PizzaType)

	IF (@PizzaTypeID IS NOT NULL)
	BEGIN
	RAISERROR ('Type de Pizza inconnu',16,1);
	END;

	INSERT INTO [Pizza]([Name],[PizzaTypeId],[Price])
	OUTPUT [Inserted].Id
	VALUES (@Name,@PizzaTypeID,@Price)
END;
