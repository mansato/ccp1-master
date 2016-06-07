USE [Gestion__Com]
GO

/****** Object:  StoredProcedure [dbo].[insertion_commande2]    Script Date: 18/12/2015 12:04:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[insertion_commande2]
@nom nvarchar(50),
@date date,
@adresse nvarchar(50),
@codepostal varchar(5),
@ville nvarchar(50)
AS
BEGIN
declare @id int;
declare @id_cli int;
insert into ADRESSE (ADRESSE, CODE_POSTAL, VILLE)
values(@adresse,@codepostal,@ville)
set @id =(select ID_ADRESSE from ADRESSE where ADRESSE like '%'+@adresse+'%' and code_postal like '%'+ @codepostal+ '%' and ville like'%'+ @ville+'%');
set @id_cli = (select NO_CLIENT from CLIENT where nom = @nom);
insert into commande(NO_CLIENT, ID_ADRESSE, DATE_COM)
values(@id_cli,@id,@date)


	
END
GO


