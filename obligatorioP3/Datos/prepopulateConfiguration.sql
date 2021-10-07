USE[ObligatorioP3_GestionClub]
GO

INSERT INTO [dbo].Usuario VALUES
('cecilia@mail.com', 'IcKjJCVeJiooKTpAfiMnPy8+PC4sfGDCrMKmMTIzNDUhwqMkJV4mKigpOkB+Iyc/Lz48Lix8YMKswqYxMjM0NaOmVRur3yiBeDG4MdzXa67hjtqj8+pUjdJYgKiSYUal'),
('bernardo@mail.com', 'IcKjJCVeJiooKTpAfiMnPy8+PC4sfGDCrMKmMTIzNDUhwqMkJV4mKigpOkB+Iyc/Lz48Lix8YMKswqYxMjM0NaOmVRur3yiBeDG4MdzXa67hjtqj8+pUjdJYgKiSYUal'),
('seba@mail.com', 'IcKjJCVeJiooKTpAfiMnPy8+PC4sfGDCrMKmMTIzNDUhwqMkJV4mKigpOkB+Iyc/Lz48Lix8YMKswqYxMjM0NaOmVRur3yiBeDG4MdzXa67hjtqj8+pUjdJYgKiSYUal');

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