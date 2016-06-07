USE [Gestion__Com]
GO

/****** Object:  StoredProcedure [dbo].[insertion_Lignecommande]    Script Date: 18/12/2015 12:04:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[insertion_Lignecommande]
@produit nvarchar(50),
@qte nvarchar(50)
AS
BEGIN
declare @id int;
declare @id_prod int;

set @id =(select max(NO_COMMANDE) from COMMANDE);
set @id_prod =(select CODE_PRODUIT from PRODUIT where LIBELLE=@produit);

insert into lignecommande(NO_COMMANDE, CODE_PRODUIT, QTE_PRODUIT)
values(@id,@id_prod,@qte)
end

GO


