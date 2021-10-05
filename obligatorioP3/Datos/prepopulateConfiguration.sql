USE[ObligatorioP3_GestionClub]
GO

INSERT INTO [dbo].Usuario VALUES
('cecilia@mail.com', '1234a'),
('bernardo@mail.com', '1234a'),
('seba@mail.com', '1234a');

INSERT INTO [dbo].[Configuration]
(Id,[CantActividadesDescuento]
,[DescuentoCuponera]
,[CostoFijo]
,[DescuentoPaseLibre]
,[AntiguedadEstablecida],[MontoUnitarioCuponera])
     VALUES
           (1, '3'
           , '100'
           , '200'
           , '50'
           , '10','3')
GO