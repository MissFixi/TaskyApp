USE [TaskyAppDB]
GO
/****** Object:  StoredProcedure [dbo].[getStatisticsForManager]    Script Date: 01.12.2024 00:51:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Oliwia Leszczyńska
-- Create date: 30.11.2024
-- Description:	Show employees statistics for manager
-- =============================================
ALTER PROCEDURE [dbo].[getStatisticsForManager] 
	@Manager int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT MONTH(t.EndDate), u.FirstName, u.LastName, COUNT(t.IdTask) FROM Users u
	LEFT JOIN Tasks t ON u.IdUser=t.IdUser
	WHERE IdManager=@Manager AND t.EndDate IS NOT NULL
	GROUP BY MONTH(t.EndDate), u.FirstName, u.LastName;

END
