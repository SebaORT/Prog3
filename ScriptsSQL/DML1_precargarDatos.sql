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

INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (3, 1, 21)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (4, 1, 21)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (5, 1, 22)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (7, 1, 22)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (8, 1, 20)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (9, 1, 21)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (10, 1, 20)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (11, 1, 21)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (12, 1, 22)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (13, 1, 22)

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
--de noche
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (3, 2, 22)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (4, 2, 21)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (5, 2, 22)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (7, 2, 22)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (8, 2, 21)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (9, 2, 22)
--
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
--de noche
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (3, 3, 22)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (4, 3, 21)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (5, 3, 22)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (7, 3, 21)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (8, 3, 22)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (9, 3, 21)

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
-- de noche
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (3, 4, 21)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (4, 4, 22)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (5, 4, 21)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (7, 4, 21)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (8, 4, 22)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (9, 4, 21)

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
--de noche
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (3, 5, 22)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (4, 5, 21)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (5, 5, 22)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (7, 5, 21)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (8, 5, 22)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (9, 5, 21)

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
--de noche
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (3, 6, 22)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (4, 6, 21)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (5, 6, 22)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (7, 6, 22)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (8, 6, 21)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (9, 6, 21)

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
--de noche
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (3, 7, 22)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (4, 7, 21)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (5, 7, 22)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (7, 7, 21)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (8, 7, 22)
INSERT [dbo].[Actividadhorario] ([IdActividad], [Dia], [Hora]) VALUES (9, 7, 21)

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
