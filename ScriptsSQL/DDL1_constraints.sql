USE ObligatorioP3_GestionClub;   
GO  
ALTER TABLE Socio   
ADD CONSTRAINT UK_Cedulda UNIQUE (Cedula);   
GO 