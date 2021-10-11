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

INSERT [dbo].[Actividad] ([Id], [Nombre], [Minedad], [Maxedad], [Active], [Cupos]) VALUES (3, N'Natacion', 3, 80, 1, 600) --NATACION
INSERT [dbo].[Actividad] ([Id], [Nombre], [Minedad], [Maxedad], [Active], [Cupos]) VALUES (4, N'Pesas', 12, 40, 1, 300) --PESAS
INSERT [dbo].[Actividad] ([Id], [Nombre], [Minedad], [Maxedad], [Active], [Cupos]) VALUES (5, N'Crossfit', 15, 77, 1, 100) --CROSSFIT
INSERT [dbo].[Actividad] ([Id], [Nombre], [Minedad], [Maxedad], [Active], [Cupos]) VALUES (7, N'Spinning', 18, 80, 1, 100) --SPINING
--nuevas actividades
INSERT [dbo].[Actividad] ([Id], [Nombre], [Minedad], [Maxedad], [Active], [Cupos]) VALUES (8, N'Karate', 12, 55, 1, 350)-- KARATE
INSERT [dbo].[Actividad] ([Id], [Nombre], [Minedad], [Maxedad], [Active], [Cupos]) VALUES (9, N'Yoga', 15, 80, 1, 250)-- YOGA
INSERT [dbo].[Actividad] ([Id], [Nombre], [Minedad], [Maxedad], [Active], [Cupos]) VALUES (10, N'Pilas', 15, 55, 1, 360)-- Pilas
INSERT [dbo].[Actividad] ([Id], [Nombre], [Minedad], [Maxedad], [Active], [Cupos]) VALUES (11, N'Futbol', 5, 50, 1, 200)-- Futbol
INSERT [dbo].[Actividad] ([Id], [Nombre], [Minedad], [Maxedad], [Active], [Cupos]) VALUES (12, N'Handball', 15, 45, 1, 140)-- Handball
INSERT [dbo].[Actividad] ([Id], [Nombre], [Minedad], [Maxedad], [Active], [Cupos]) VALUES (13, N'Voleyball', 18, 50, 1, 160)-- Voleyball
INSERT [dbo].[Actividad] ([Id], [Nombre], [Minedad], [Maxedad], [Active], [Cupos]) VALUES (14, N'Basketball', 18, 50, 1, 175)-- Basketball
INSERT [dbo].[Actividad] ([Id], [Nombre], [Minedad], [Maxedad], [Active], [Cupos]) VALUES (15, N'Gim.Artistica', 10, 24, 1, 95)-- Basketball
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

--nuevas actividades desde el 8 en adelante
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
