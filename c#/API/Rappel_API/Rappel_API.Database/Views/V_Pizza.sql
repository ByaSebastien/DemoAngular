CREATE VIEW [dbo].[V_Pizza]
	AS SELECT P.[Id],P.[Name],P.[Price],PT.[Name] AS [PizzaType]
	FROM Pizza P
	JOIN PizzaType PT ON PizzaTypeId = PT.Id
