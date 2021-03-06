USE [ObligatorioP3_GestionClub]
GO
SET IDENTITY_INSERT [dbo].[Socio] ON 

INSERT [dbo].[Socio] ([IdSocio], [NombreApellido], [Cedula], [FechaNacimiento], [FechaIngreso], [Active]) VALUES (8, N'Mariana Juliana', CAST(1234567 AS Numeric(10, 0)), CAST(N'2016-06-11T16:02:00.000' AS DateTime), CAST(N'2021-10-11T16:02:40.533' AS DateTime), 1)
INSERT [dbo].[Socio] ([IdSocio], [NombreApellido], [Cedula], [FechaNacimiento], [FechaIngreso], [Active]) VALUES (9, N'Mariela Carmela', CAST(7654321 AS Numeric(10, 0)), CAST(N'1986-06-22T16:03:00.000' AS DateTime), CAST(N'2021-10-11T16:03:35.593' AS DateTime), 1)
INSERT [dbo].[Socio] ([IdSocio], [NombreApellido], [Cedula], [FechaNacimiento], [FechaIngreso], [Active]) VALUES (10, N'Carlitos Mariano', CAST(7612354 AS Numeric(10, 0)), CAST(N'2005-06-21T16:04:00.000' AS DateTime), CAST(N'2021-10-11T16:04:25.000' AS DateTime), 1)
INSERT [dbo].[Socio] ([IdSocio], [NombreApellido], [Cedula], [FechaNacimiento], [FechaIngreso], [Active]) VALUES (11, N'Mariano Julio', CAST(7612534 AS Numeric(10, 0)), CAST(N'1991-02-24T16:04:00.000' AS DateTime), CAST(N'2021-10-11T16:05:07.507' AS DateTime), 1)
INSERT [dbo].[Socio] ([IdSocio], [NombreApellido], [Cedula], [FechaNacimiento], [FechaIngreso], [Active]) VALUES (12, N'Juliana Mariana', CAST(6152437 AS Numeric(10, 0)), CAST(N'2004-05-01T16:05:00.000' AS DateTime), CAST(N'2021-10-11T16:05:39.750' AS DateTime), 1)
INSERT [dbo].[Socio] ([IdSocio], [NombreApellido], [Cedula], [FechaNacimiento], [FechaIngreso], [Active]) VALUES (13, N'Carlato Marcos', CAST(1048725 AS Numeric(10, 0)), CAST(N'1990-06-08T16:07:00.000' AS DateTime), CAST(N'2021-10-11T16:07:21.107' AS DateTime), 1)
INSERT [dbo].[Socio] ([IdSocio], [NombreApellido], [Cedula], [FechaNacimiento], [FechaIngreso], [Active]) VALUES (14, N'Marcos Hollin', CAST(1950264 AS Numeric(10, 0)), CAST(N'2015-11-01T16:07:00.000' AS DateTime), CAST(N'2021-10-11T16:07:59.843' AS DateTime), 1)
INSERT [dbo].[Socio] ([IdSocio], [NombreApellido], [Cedula], [FechaNacimiento], [FechaIngreso], [Active]) VALUES (15, N'Marianita Lola', CAST(19527527 AS Numeric(10, 0)), CAST(N'2007-08-14T16:08:00.000' AS DateTime), CAST(N'2021-10-11T16:08:27.277' AS DateTime), 1)
INSERT [dbo].[Socio] ([IdSocio], [NombreApellido], [Cedula], [FechaNacimiento], [FechaIngreso], [Active]) VALUES (16, N'Carlolito Marianito', CAST(19620471 AS Numeric(10, 0)), CAST(N'2014-02-11T16:08:00.000' AS DateTime), CAST(N'2021-10-11T16:08:56.437' AS DateTime), 1)
INSERT [dbo].[Socio] ([IdSocio], [NombreApellido], [Cedula], [FechaNacimiento], [FechaIngreso], [Active]) VALUES (17, N'Marilita Orquilla', CAST(40165389 AS Numeric(10, 0)), CAST(N'1988-03-28T16:09:00.000' AS DateTime), CAST(N'2021-10-11T16:09:59.540' AS DateTime), 1)
INSERT [dbo].[Socio] ([IdSocio], [NombreApellido], [Cedula], [FechaNacimiento], [FechaIngreso], [Active]) VALUES (18, N'carlililitos mariano', CAST(10582742 AS Numeric(10, 0)), CAST(N'2011-07-09T16:10:00.000' AS DateTime), CAST(N'2021-10-11T16:10:59.893' AS DateTime), 0)
INSERT [dbo].[Socio] ([IdSocio], [NombreApellido], [Cedula], [FechaNacimiento], [FechaIngreso], [Active]) VALUES (19, N'sosa marina', CAST(1938459 AS Numeric(10, 0)), CAST(N'1989-01-20T18:13:00.000' AS DateTime), CAST(N'2021-10-11T18:13:56.680' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Socio] OFF
GO
INSERT [dbo].[SocioActividad] ([IdSocio], [IdActividad], [Fecha]) VALUES (9, 7, CAST(N'2021-10-11T22:00:00.000' AS DateTime))
INSERT [dbo].[SocioActividad] ([IdSocio], [IdActividad], [Fecha]) VALUES (10, 16, CAST(N'2021-10-11T20:00:00.000' AS DateTime))
INSERT [dbo].[SocioActividad] ([IdSocio], [IdActividad], [Fecha]) VALUES (12, 8, CAST(N'2021-10-11T20:00:00.000' AS DateTime))
INSERT [dbo].[SocioActividad] ([IdSocio], [IdActividad], [Fecha]) VALUES (13, 13, CAST(N'2021-10-11T18:08:50.530' AS DateTime))
INSERT [dbo].[SocioActividad] ([IdSocio], [IdActividad], [Fecha]) VALUES (15, 17, CAST(N'2021-10-11T21:00:00.000' AS DateTime))
INSERT [dbo].[SocioActividad] ([IdSocio], [IdActividad], [Fecha]) VALUES (17, 11, CAST(N'2021-10-11T21:00:00.000' AS DateTime))
INSERT [dbo].[SocioActividad] ([IdSocio], [IdActividad], [Fecha]) VALUES (17, 13, CAST(N'2021-10-11T18:25:18.133' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Membresia] ON 

INSERT [dbo].[Membresia] ([Id], [Nombre], [Description], [Fechapago], [Active], [CantActividades], [Tipomembresia]) VALUES (45, N'cuponera seria1', N'cuponera seria11', CAST(N'2021-10-10T00:00:00.000' AS DateTime), 1, 16, N'cuponera')
INSERT [dbo].[Membresia] ([Id], [Nombre], [Description], [Fechapago], [Active], [CantActividades], [Tipomembresia]) VALUES (46, N'CUPONERA1', N'CUPONERA1 ejercicio', CAST(N'2021-10-10T00:00:00.000' AS DateTime), 1, 16, N'cuponera')
INSERT [dbo].[Membresia] ([Id], [Nombre], [Description], [Fechapago], [Active], [CantActividades], [Tipomembresia]) VALUES (47, N'cuponera octubre', N'para empezar a ejercitar', CAST(N'2021-10-11T00:00:00.000' AS DateTime), 1, 15, N'cuponera')
INSERT [dbo].[Membresia] ([Id], [Nombre], [Description], [Fechapago], [Active], [CantActividades], [Tipomembresia]) VALUES (48, N'cuponera octubre', N'para seguir con ejercicio potente', CAST(N'2021-10-11T00:00:00.000' AS DateTime), 1, 20, N'cuponera')
INSERT [dbo].[Membresia] ([Id], [Nombre], [Description], [Fechapago], [Active], [CantActividades], [Tipomembresia]) VALUES (49, N'cuponera octubre', N'seguir ejercicio a nivel medio', NULL, 1, 18, N'cuponera')
INSERT [dbo].[Membresia] ([Id], [Nombre], [Description], [Fechapago], [Active], [CantActividades], [Tipomembresia]) VALUES (50, N'cuponera octubre', N'para hacer ejercicio a nivel maximo', CAST(N'2021-10-11T00:00:00.000' AS DateTime), 1, 26, N'cuponera')
INSERT [dbo].[Membresia] ([Id], [Nombre], [Description], [Fechapago], [Active], [CantActividades], [Tipomembresia]) VALUES (51, N'cuponera octubre', N'actividades livianas para recuperacion', CAST(N'2021-10-11T00:00:00.000' AS DateTime), 1, 16, N'cuponera')
INSERT [dbo].[Membresia] ([Id], [Nombre], [Description], [Fechapago], [Active], [CantActividades], [Tipomembresia]) VALUES (52, N'pase libre', N'pase libre para musculacion varias', CAST(N'2021-10-11T00:00:00.000' AS DateTime), 1, 0, N'paselibre')
INSERT [dbo].[Membresia] ([Id], [Nombre], [Description], [Fechapago], [Active], [CantActividades], [Tipomembresia]) VALUES (53, N'pase libre octubre', N'para seguir con el ejercicio medio', CAST(N'2021-10-11T00:00:00.000' AS DateTime), 1, 0, N'paselibre')
INSERT [dbo].[Membresia] ([Id], [Nombre], [Description], [Fechapago], [Active], [CantActividades], [Tipomembresia]) VALUES (54, N'pase libre octubre', N'para seguir con el ejercicio fuerte', CAST(N'2021-10-11T00:00:00.000' AS DateTime), 1, 0, N'paselibre')
INSERT [dbo].[Membresia] ([Id], [Nombre], [Description], [Fechapago], [Active], [CantActividades], [Tipomembresia]) VALUES (55, N'pase libre octubre', N'para hacer recuperacion muscular', CAST(N'2021-10-11T00:00:00.000' AS DateTime), 1, 0, N'paselibre')
INSERT [dbo].[Membresia] ([Id], [Nombre], [Description], [Fechapago], [Active], [CantActividades], [Tipomembresia]) VALUES (56, N'pase libre octubre', N'pase libre maximo', CAST(N'2021-10-11T00:00:00.000' AS DateTime), 1, 0, N'paselibre')
INSERT [dbo].[Membresia] ([Id], [Nombre], [Description], [Fechapago], [Active], [CantActividades], [Tipomembresia]) VALUES (57, N'pase libre octube', N'comenzar con ejercicio liviano ', NULL, 1, 0, N'paselibre')
SET IDENTITY_INSERT [dbo].[Membresia] OFF
GO
INSERT [dbo].[SocioMembresia] ([IdSocio], [IdMembresia]) VALUES (13, 47)
INSERT [dbo].[SocioMembresia] ([IdSocio], [IdMembresia]) VALUES (16, 49)
INSERT [dbo].[SocioMembresia] ([IdSocio], [IdMembresia]) VALUES (12, 50)
INSERT [dbo].[SocioMembresia] ([IdSocio], [IdMembresia]) VALUES (14, 51)
INSERT [dbo].[SocioMembresia] ([IdSocio], [IdMembresia]) VALUES (8, 52)
INSERT [dbo].[SocioMembresia] ([IdSocio], [IdMembresia]) VALUES (19, 57)
INSERT [dbo].[SocioMembresia] ([IdSocio], [IdMembresia]) VALUES (10, 48)
INSERT [dbo].[SocioMembresia] ([IdSocio], [IdMembresia]) VALUES (15, 53)
INSERT [dbo].[SocioMembresia] ([IdSocio], [IdMembresia]) VALUES (11, 54)
INSERT [dbo].[SocioMembresia] ([IdSocio], [IdMembresia]) VALUES (9, 55)
INSERT [dbo].[SocioMembresia] ([IdSocio], [IdMembresia]) VALUES (17, 56)
GO
