USE master;
GO

create database Gestion__Com
go

use Gestion__Com
go

/*==============================================================*/
/* Table : ADRESSE                                              */
/*==============================================================*/
create table ADRESSE (
   ID_ADRESSE           int identity(1,1)                 not null,
   ADRESSE              nvarchar(50)                 not null,
   CODE_POSTAL          nvarchar(5)                 not null,
   VILLE                nvarchar(50)                not null,
   constraint PK_ADRESSE PRIMARY KEY CLUSTERED (ID_ADRESSE),
   CONSTRAINT UNIQUE_ADRESSE_CODE_POSTAL_VILLE unique(ADRESSE,CODE_POSTAL,VILLE),
)
go


/*==============================================================*/
/* Table : CLIENT                                               */
/*==============================================================*/
create table CLIENT (
   NO_CLIENT            int   identity(1,1)                not null,
    ID_ADRESSE           int						not null,
   NOM                  nvarchar(50)                 not null,
   PRENOM               nvarchar(50)                 not null,
   constraint PK_CLIENT PRIMARY KEY CLUSTERED (NO_CLIENT),
)
go

/*==============================================================*/
/* Table : COMMANDE                                             */
/*==============================================================*/
create table COMMANDE (
   NO_COMMANDE          int      identity(1,1)             not null,
   NO_CLIENT            int                  not null,
   ID_ADRESSE           int                  not null,
   DATE_COM                 datetime             not null,
   constraint PK_COMMANDE PRIMARY KEY CLUSTERED (NO_COMMANDE),
)
go
/*==============================================================*/
/* Table : LIGNE COMMANDE                                            */
/*==============================================================*/
create table LIGNECOMMANDE  (
	ID_LIGNE           int  identity(1,1)                not null,
	NO_COMMANDE          int                   not null,
	 CODE_PRODUIT         int                  not null,
	QTE_PRODUIT			int						not null,
   constraint PK_LIGNECOMMANDE PRIMARY KEY CLUSTERED (ID_LIGNE,NO_COMMANDE),
)
go
/*==============================================================*/
/* Table : PRODUIT                                              */
/*==============================================================*/
create table PRODUIT (
   CODE_PRODUIT         int   identity(1,1)                not null,
   LIBELLE              nvarchar(50)                not null,
   PRIX_U               decimal(20,2)        not null,
   constraint PK_PRODUIT PRIMARY KEY CLUSTERED (CODE_PRODUIT),
)
go


alter table COMMANDE  WITH CHECK ADD CONSTRAINT FK_COMMANDE_CLIENT
FOREIGN KEY(NO_CLIENT)
REFERENCES CLIENT (NO_CLIENT)
GO 
alter table COMMANDE  WITH CHECK ADD CONSTRAINT FK_COMMANDE_ADRESSE
FOREIGN KEY(ID_ADRESSE)
REFERENCES ADRESSE  (ID_ADRESSE)
GO 
alter table CLIENT  WITH CHECK ADD CONSTRAINT FK_CLIENT_ADRESSE
FOREIGN KEY(ID_ADRESSE)
REFERENCES ADRESSE  (ID_ADRESSE)
GO 

alter table LIGNECOMMANDE  WITH CHECK ADD CONSTRAINT FK_LIGNECOMMANDE_COMMANDE
FOREIGN KEY(NO_COMMANDE)
REFERENCES COMMANDE  (NO_COMMANDE)
GO 

alter table LIGNECOMMANDE  WITH CHECK ADD CONSTRAINT FK_LIGNECOMMANDE_PRODUIT
FOREIGN KEY(CODE_PRODUIT)
REFERENCES PRODUIT  (CODE_PRODUIT)
GO 

