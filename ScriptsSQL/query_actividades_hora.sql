SET DATEFIRST 1;
SELECT [Id]
      ,[Nombre],
	  Hora
  FROM [ObligatorioP3_GestionClub].[dbo].[Actividad] join 
  Actividadhorario on IdActividad = Id 

  where DATEPART(HOUR,GETDATE())  < Hora
   and DATEPART(WEEKDAY,GETDATE())  = Dia
  order by Hora desc