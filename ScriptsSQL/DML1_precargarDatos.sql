use [ObligatorioP3_GestionClub];
GO

INSERT INTO [dbo].Usuario VALUES
('cecilia@mail.com', '1234a'),
('bernardo@mail.com', '1234a'),
('seba@mail.com', '1234a');

--configuracion
INSERT INTO [dbo].[Configuration]
(Id,[CantActividadesDescuento]
,[DescuentoCuponera]
,[CostoFijo]
,[DescuentoPaseLibre]
,[AntiguedadEstablecida],[MontoUnitarioCuponera])
     VALUES
           (1, '3'
           , '50'
           , '1000'
           , '30'
           , '5','30');

GO
SET IDENTITY_INSERT [dbo].[Actividad] ON 

INSERT [dbo].[Actividad] ([Id], [Nombre], [Minedad], [Maxedad], [Active], [Cupos]) VALUES (3, N'Natacion', 3, 80, 1, 600)
INSERT [dbo].[Actividad] ([Id], [Nombre], [Minedad], [Maxedad], [Active], [Cupos]) VALUES (4, N'Pesas', 12, 40, 1, 300)
INSERT [dbo].[Actividad] ([Id], [Nombre], [Minedad], [Maxedad], [Active], [Cupos]) VALUES (5, N'Crossfit', 15, 77, 1, 100)
INSERT [dbo].[Actividad] ([Id], [Nombre], [Minedad], [Maxedad], [Active], [Cupos]) VALUES (7, N'Spinning', 18, 80, 1, 100)
SET IDENTITY_INSERT [dbo].[Actividad] OFF
GO
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (3, 1, 8)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (3, 3, 10)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (3, 5, 14)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (3, 6, 8)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (4, 1, 8)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (4, 2, 8)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (4, 3, 8)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (4, 4, 8)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (4, 5, 8)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (4, 6, 8)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (5, 1, 18)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (5, 3, 18)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (5, 5, 18)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (7, 2, 19)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (7, 4, 19)
GO
