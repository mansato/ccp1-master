USE [Gestion__Com]
GO

/****** Object:  StoredProcedure [dbo].[insertion_client]    Script Date: 18/12/2015 12:04:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[insertion_client]
@nom nvarchar(50),
@prenom nvarchar(50),
@adresse nvarchar(50),
@codepostal varchar(5),
@ville nvarchar(50)
AS
BEGIN
declare @id int;
insert into ADRESSE (ADRESSE, CODE_POSTAL, VILLE)
values(@adresse,@codepostal,@ville)
set @id =(select ID_ADRESSE from ADRESSE where ADRESSE like '%'+@adresse+'%' and code_postal like '%'+ @codepostal+ '%' and ville like'%'+ @ville+'%');
insert into client (ID_ADRESSE, NOM, PRENOM)
values (@id,@nom,@prenom)

	
END

GO


