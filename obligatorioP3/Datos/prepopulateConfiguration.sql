USE[ObligatorioP3_GestionClub]
GO

INSERT INTO [dbo].Usuario VALUES
('cecilia@mail.com', 'kTebFGrpXccKXu3LmHeGLVPUbSO+oFxcR/emDGnJkviRN5sUauldxwpe7cuYd4YtU9RtI76gXFxH96YMacmS+IlFMGQ6uU7KVwAeDmVOAkCmYVPSbV8SYvzbgxcGU0Pa'),
('bernardo@mail.com', 'kTebFGrpXccKXu3LmHeGLVPUbSO+oFxcR/emDGnJkviRN5sUauldxwpe7cuYd4YtU9RtI76gXFxH96YMacmS+IlFMGQ6uU7KVwAeDmVOAkCmYVPSbV8SYvzbgxcGU0Pa'),
('seba@mail.com', 'kTebFGrpXccKXu3LmHeGLVPUbSO+oFxcR/emDGnJkviRN5sUauldxwpe7cuYd4YtU9RtI76gXFxH96YMacmS+IlFMGQ6uU7KVwAeDmVOAkCmYVPSbV8SYvzbgxcGU0Pa');

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