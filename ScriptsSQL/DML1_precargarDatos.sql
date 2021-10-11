use [ObligatorioP3_GestionClub];
GO
INSERT INTO [dbo].Usuario VALUES
('cecilia@mail.com', 'IcKjJCVeJiooKTpAfiMnPy8+PC4sfGDCrMKmMTIzNDUhwqMkJV4mKigpOkB+Iyc/Lz48Lix8YMKswqYxMjM0NaOmVRur3yiBeDG4MdzXa67hjtqj8+pUjdJYgKiSYUal'),
('bernardo@mail.com', 'IcKjJCVeJiooKTpAfiMnPy8+PC4sfGDCrMKmMTIzNDUhwqMkJV4mKigpOkB+Iyc/Lz48Lix8YMKswqYxMjM0NaOmVRur3yiBeDG4MdzXa67hjtqj8+pUjdJYgKiSYUal'),
('seba@mail.com', 'IcKjJCVeJiooKTpAfiMnPy8+PC4sfGDCrMKmMTIzNDUhwqMkJV4mKigpOkB+Iyc/Lz48Lix8YMKswqYxMjM0NaOmVRur3yiBeDG4MdzXa67hjtqj8+pUjdJYgKiSYUal');

--configuracion
INSERT INTO [dbo].[Configuration]
(Id,[CantActividadesDescuento]
,[DescuentoCuponera]
,[CostoFijo]
,[DescuentoPaseLibre]
,[AntiguedadEstablecida],[MontoUnitarioCuponera])
     VALUES
           (1, '10'
           , '15'
           , '1000'
           , '25'
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
--kids
INSERT [dbo].[Actividad] ([Id], [Nombre], [Minedad], [Maxedad], [Active], [Cupos]) VALUES (16, N'Futbol Kids', 5, 16, 1, 200)-- Futbol KIDS
INSERT [dbo].[Actividad] ([Id], [Nombre], [Minedad], [Maxedad], [Active], [Cupos]) VALUES (17, N'Handball Kids', 8, 16, 1, 140)-- Handball KIDS
INSERT [dbo].[Actividad] ([Id], [Nombre], [Minedad], [Maxedad], [Active], [Cupos]) VALUES (18, N'Voleyball Kids', 8, 16, 1, 160)-- Voleyball KIDS
INSERT [dbo].[Actividad] ([Id], [Nombre], [Minedad], [Maxedad], [Active], [Cupos]) VALUES (19, N'Basketball Kids', 8, 16, 1, 175)-- Basketball KIDS

SET IDENTITY_INSERT [dbo].[Actividad] OFF
GO
--INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (3, 1, 8)
--INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (3, 3, 10)
--INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (3, 5, 14)
--INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (3, 6, 8)
--INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (4, 1, 8)
--INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (4, 2, 8)
--INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (4, 3, 8)
--INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (4, 4, 8)
--INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (4, 5, 8)
--INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (4, 6, 8)
--INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (5, 1, 18)
--INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (5, 3, 18)
--INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (5, 5, 18)
--INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (7, 2, 19)
--INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (7, 4, 19)

----nuevas actividades desde el 8 hasta el 15
--INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (8, 1, 10)
--INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (9, 2, 12)
--INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (10, 3, 14)
--INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (11, 4, 16)
--INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (12, 5, 18)
--INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (13, 6, 20)
--INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (14, 7, 22)
--INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (15, 1, 13)
--INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (8, 3, 8)
--INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (9, 4, 9)
--INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (10, 5, 17)
--INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (11, 6, 13)
--INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (12, 7, 11)
--INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (13, 1, 19)
--INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (14, 2, 21)
--INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (15, 3, 22)
----KIDS
--INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (16, 1, 9)
--INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (17, 2, 10)
--INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (18, 3, 18)
--INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (19, 4, 19)

--INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (16, 2, 18)
--INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (17, 3, 19)
--INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (18, 4, 9)
--INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (19, 5, 10)


--Horarios de Actividades 
--Lunes
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (3, 1, 8)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (4, 1, 9)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (5, 1, 10)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (7, 1, 11)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (8, 1, 12)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (9, 1, 13)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (10, 1, 14)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (11, 1, 15)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (12, 1, 16)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (13, 1, 17)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (14, 1, 18)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (15, 1, 19)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (16, 1, 20)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (17, 1, 21)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (18, 1, 22)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (19, 1, 22)
--Martes
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (3, 2, 8)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (4, 2, 9)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (5, 2, 10)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (7, 2, 11)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (8, 2, 12)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (9, 2, 12)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (10, 2, 14)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (11, 2, 15)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (12, 2, 16)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (13, 2, 17)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (14, 2, 18)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (15, 2, 19)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (16, 2, 20)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (17, 2, 21)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (18, 2, 22)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (19, 2, 20)
--Miercoles
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (3, 3, 8)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (4, 3, 9)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (5, 3, 10)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (7, 3, 11)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (8, 3, 12)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (9, 3, 12)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (10, 3, 14)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (11, 3, 15)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (12, 3, 16)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (13, 3, 17)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (14, 3, 18)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (15, 3, 19)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (16, 3, 20)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (17, 3, 21)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (18, 3, 22)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (19, 3, 20)
--Jueves
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (3, 4, 8)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (4, 4, 9)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (5, 4, 10)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (7, 4, 11)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (8, 4, 12)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (9, 4, 12)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (10, 4, 14)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (11, 4, 15)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (12, 4, 16)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (13, 4, 17)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (14, 4, 18)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (15, 4, 19)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (16, 4, 20)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (17, 4, 21)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (18, 4, 22)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (19, 4, 20)
--Viernes
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (3, 5, 8)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (4, 5, 9)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (5, 5, 10)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (7, 5, 11)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (8, 5, 12)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (9, 5, 12)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (10, 5, 14)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (11, 5, 15)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (12, 5, 16)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (13, 5, 17)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (14, 5, 18)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (15, 5, 19)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (16, 5, 20)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (17, 5, 21)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (18, 5, 22)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (19, 5, 20)
--Sábado
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (3, 6, 8)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (4, 6, 9)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (5, 6, 10)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (7, 6, 11)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (8, 6, 12)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (9, 6, 12)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (10, 6, 14)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (11, 6, 15)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (12, 6, 16)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (13, 6, 17)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (14, 6, 18)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (15, 6, 19)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (16, 6, 20)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (17, 6, 21)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (18, 6, 22)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (19, 6, 20)
--Domingo
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (3, 7, 8)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (4, 7, 9)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (5, 7, 10)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (7, 7, 11)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (8, 7, 12)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (9, 7, 12)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (10, 7, 14)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (11, 7, 15)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (12, 7, 16)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (13, 7, 17)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (14, 7, 18)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (15, 7, 19)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (16, 7, 20)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (17, 7, 21)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (18, 7, 22)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (19, 7, 18)
GO
