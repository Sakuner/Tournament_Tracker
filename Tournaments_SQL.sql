USE [Tournaments]
GO
/****** Object:  StoredProcedure [dbo].[spPeople_GetAll]    Script Date: 14.03.2023 21:44:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Tournaments_GetAll]

	
AS
BEGIN

	SET NOCOUNT ON;


	SELECT *
	from dbo.Tournaments
END
