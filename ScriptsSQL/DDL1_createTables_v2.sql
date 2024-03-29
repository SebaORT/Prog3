IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'ObligatorioP3_GestionClub')
BEGIN
  CREATE DATABASE [ObligatorioP3_GestionClub];
END;

GO

use [ObligatorioP3_GestionClub];
GO

/*
 -- if a Transact-SQL statement raises a run-time error, 
 the entire transaction is terminated and rolled back
 */
Set xact_abort On

Begin Transaction

IF  NOT EXISTS (SELECT * FROM sys.objects 
WHERE object_id = OBJECT_ID(N'[dbo].[Socio]')) 
  Create Table [dbo].[Socio]
  (
	 [IdSocio]         INT Not Null Primary Key Identity(1, 1),
	 [NombreApellido]  VARCHAR(100) Not null,
     [Cedula]          NUMERIC(10, 0) Not Null,
     [FechaNacimiento] DATETIME Null,
     [FechaIngreso]    DATETIME Null,
     [Active]          BIT Not Null,
	 CONSTRAINT UK_Cedulda UNIQUE (Cedula)
  )

IF  NOT EXISTS (SELECT * FROM sys.objects 
WHERE object_id = OBJECT_ID(N'[dbo].[Usuario]')) 
  Create Table [dbo].[Usuario]
  (
	[IdUsuario]		  INT Not Null Primary Key Identity(1, 1),
	[Mail]            VARCHAR(100) Not Null,
    [AdminPassword]   VARCHAR(500) Not Null,
	constraint UK_Usuario_mail_password unique(Mail,AdminPassword)
  )
IF  NOT EXISTS (SELECT * FROM sys.objects 
WHERE object_id = OBJECT_ID(N'[dbo].[Membresia]')) 
Create Table [dbo].[Membresia]
  (
     [Id]            INT Not Null Primary Key Identity(1, 1),
     [Nombre]        VARCHAR(100) Not Null,
     [Description]   VARCHAR(100) Null,
     [Fechapago]     DATETIME Null,
     [Active]        BIT Not Null,
     CantActividades INT Null,-- m�nimo de 8 y un m�ximo de 60
     Tipomembresia   VARCHAR(50) Not Null -- ("cuponera","paselibre")
  )

IF  NOT EXISTS (SELECT * FROM sys.objects 
WHERE object_id = OBJECT_ID(N'[dbo].[SocioMembresia]')) 
Create Table [dbo].[SocioMembresia]
  (
     [IdSocio]   INT Not Null,
     [IdMembresia] INT Not Null,
	 CONSTRAINT FK_SocioMemSocio FOREIGN KEY (IdSocio)  REFERENCES Socio(IdSocio),
	 CONSTRAINT FK_SocioMemMembresia FOREIGN KEY (IdMembresia)  REFERENCES Membresia(Id)   
  )

IF  NOT EXISTS (SELECT * FROM sys.objects 
WHERE object_id = OBJECT_ID(N'[dbo].[Actividad]')) 
Create Table [dbo].[Actividad]
  (
     [Id]      INT Not Null Primary Key Identity(1, 1),
     [Nombre]  VARCHAR(100) Not Null,-- unique constraint
     [Minedad] INT Not Null,
     [Maxedad] INT Not Null,
     [Active]  BIT Not Null,
	 [Cupos] INT Not Null
  )

IF  NOT EXISTS (SELECT * FROM sys.objects 
WHERE object_id = OBJECT_ID(N'[dbo].[Actividadhorario]')) 
Create Table [dbo].[Actividadhorario]
  (
     [IdActividad] INT Not Null,
     [Dia]  INT Not Null,
     [Hora] INT Not Null
	 primary key (IdActividad, Dia, Hora),
	 constraint FK_ActHorHorario FOREIGN KEY (IdActividad)  REFERENCES Actividad(Id),
	 constraint CK_ActHorarioDia CHECK (Dia >=1 and Dia <=7),
	 constraint CK_ActHorarioHora CHECK (Hora >=0 and Dia <24)
  )

IF  NOT EXISTS (SELECT * FROM sys.objects 
WHERE object_id = OBJECT_ID(N'[dbo].[SocioActividad]')) 
Create Table [dbo].[SocioActividad]
  (
     [IdSocio] INT Not Null,
     [IdActividad] INT Not Null,
	 [Fecha] DateTime not null,

	 Primary Key([IdSocio],[IdActividad],[Fecha]),
     constraint FK_SocioActSocio foreign key ([IdSocio]) references Socio(IdSocio),
	 constraint FK_SocioActActividad foreign key ([IdActividad]) references Actividad(Id)
)

IF  NOT EXISTS (SELECT * FROM sys.objects 
WHERE object_id = OBJECT_ID(N'[dbo].[Configuration]')) 
Create Table [dbo].[Configuration]
  (
     [Id] INT Not Null Primary Key,
     [CantActividadesDescuento] varchar(200) Null,
	 [DescuentoCuponera] varchar(200) null,
	 [CostoFijo] varchar(200) null,
	 [DescuentoPaseLibre] varchar(200) null,
	 [AntiguedadEstablecida] varchar(200) null,
	 [MontoUnitarioCuponera] varchar(200) null
  ) 

Commit Transaction 




