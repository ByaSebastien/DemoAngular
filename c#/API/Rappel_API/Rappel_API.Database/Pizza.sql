CREATE TABLE [dbo].[Pizza]
(
	[Id] INT NOT NULL IDENTITY,
	[Name] VARCHAR(50) NOT NULL,
	[PizzaTypeId] INT NOT NULL,
	[Price] MONEY NOT NULL

	CONSTRAINT [PK_Pizza] PRIMARY KEY ([Id]),
	CONSTRAINT [CK_Pizza_Price] CHECK ([Price] > 0),
	CONSTRAINT [UK_Pizza_Name] UNIQUE ([NAME]),
	CONSTRAINT [FK_Pizza_PizzaType] FOREIGN KEY ([PizzaTypeId]) REFERENCES [PizzaType]([Id])
)
