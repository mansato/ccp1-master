USE [Gestion__Com]
GO

/****** Object:  UserDefinedFunction [dbo].[select_produit]    Script Date: 18/12/2015 12:05:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE FUNCTION  [dbo].[select_produit]
(	

)
RETURNS TABLE 
AS
RETURN 
(
	select * from produit
)

GO


