--PizzaType
INSERT INTO [PizzaType]([Id],[Name])
VALUES (1,'Base Tomate'),
	   (2,'Base Crème'),
	   (3,'Calzone');

--Pizza
INSERT INTO [Pizza]([Name],[PizzaTypeId],[Price])
VALUES ('Margherita',1,6.95),
	   ('Cacciatore',1,8.50),
	   ('Quatre Fromage',1,7.50),
	   ('Scampi',2,9.50)
GO
