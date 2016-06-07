USE [Gestion__Com]
GO

/****** Object:  StoredProcedure [dbo].[insertion_commande]    Script Date: 18/12/2015 12:04:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[insertion_commande]
@nom nvarchar(50),
@adresse nvarchar(50),
@codepostal varchar(5),
@ville nvarchar(50),
@date date
AS
BEGIN
declare @id int;
declare @id_cli int;

set @id =(select ID_ADRESSE from ADRESSE where ADRESSE like '%'+@adresse+'%' and code_postal like '%'+ @codepostal+ '%' and ville like'%'+ @ville+'%');
set @id_cli = (select NO_CLIENT from CLIENT where nom = @nom);
insert into commande(NO_CLIENT, ID_ADRESSE, DATE_COM)
values(@id_cli,@id,@date)


	
END
GO


