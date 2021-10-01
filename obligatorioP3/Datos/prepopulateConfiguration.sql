USE[ObligatorioP3_GestionClub]
GO

INSERT INTO [dbo].[Configuration]
(Id,[CantActividadesDescuento]
,[DescuentoCuponera]
,[CostoFijo]
,[DescuentoPaseLibre]
,[AntiguedadEstablecida],[MontoUnitarioCupononera])
     VALUES
           (1, '3'
           , '100'
           , '200'
           , '50'
           , '10','3')
GO