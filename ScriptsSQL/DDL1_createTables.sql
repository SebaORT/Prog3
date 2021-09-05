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
WHERE object_id = OBJECT_ID(N'[dbo].[Usuario]')) 
Create Table [dbo].[Usuario]
  (
     [Id]              INT Not Null Primary Key Identity(1, 1),
     [Cedula]          NUMERIC(10, 0) Not Null,
     [FechaNacimiento] DATETIME Null,
     [FechaIngreso]    DATETIME Null,
     [Active]          BIT Not Null,
     [Mail]            VARCHAR(100) Null,
     [AdminPassword]   VARCHAR(100) Null
  )

IF  NOT EXISTS (SELECT * FROM sys.objects 
WHERE object_id = OBJECT_ID(N'[dbo].[UsuarioMembresia]')) 
Create Table [dbo].[UsuarioMembresia]
  (
     [IdUsuario]   INT Not Null,
     [IdMembresia] INT Not Null,
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
     CantIngresosMes INT Null,-- mínimo de 8 y un máximo de 60
     Antiguedad      BIT Not Null,
     Tipomembresia   VARCHAR(50) Not Null -- ("cuponera","paselibre")
  )

IF  NOT EXISTS (SELECT * FROM sys.objects 
WHERE object_id = OBJECT_ID(N'[dbo].[MembresiaActividad]')) 
Create Table [dbo].[MembresiaActividad]
  (
     [IdMembresia] INT Not Null,
     [IdActividad] INT Not Null
  )

IF  NOT EXISTS (SELECT * FROM sys.objects 
WHERE object_id = OBJECT_ID(N'[dbo].[Actividad]')) 
Create Table [dbo].[Actividad]
  (
     [Id]      INT Not Null Primary Key Identity(1, 1),
     [Nombre]  VARCHAR(100) Not Null,-- unique constraint
     [Minedad] INT Not Null,
     [Maxedad] INT Not Null,
     [Active]  BIT Not Null
  )

IF  NOT EXISTS (SELECT * FROM sys.objects 
WHERE object_id = OBJECT_ID(N'[dbo].[Actividadhorario]')) 
Create Table [dbo].[Actividadhorario]
  (
     [Idactividad] INT Not Null,
     [Idhorario]   INT Not Null
  )

IF  NOT EXISTS (SELECT * FROM sys.objects 
WHERE object_id = OBJECT_ID(N'[dbo].[Horario]')) 
Create Table [dbo].[Horario]
  (
     [Id]   INT Not Null Primary Key Identity(1, 1),
     [Dia]  INT Not Null,
     [Hora] INT Not Null
  )

Commit Transaction 