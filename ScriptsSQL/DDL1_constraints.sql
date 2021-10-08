USE ObligatorioP3_GestionClub;   
GO  
ALTER TABLE Socio   
ADD CONSTRAINT UK_Cedulda UNIQUE (Cedula);   

ALTER TABLE SocioMembresia  
ADD CONSTRAINT FK_SocioMemSocio FOREIGN KEY (IdSocio)  REFERENCES Socio(IdSocio);   

ALTER TABLE SocioMembresia  
ADD CONSTRAINT FK_SocioMemMembresia FOREIGN KEY (IdMembresia)  REFERENCES Membresia(Id);   


ALTER TABLE SocioActividad
ADD CONSTRAINT FK_SocioActSocio FOREIGN KEY (IdSocio)  REFERENCES Socio(IdSocio);   
ALTER TABLE SocioActividad  
ADD CONSTRAINT FK_SocioActActividad FOREIGN KEY (IdActividad)  REFERENCES Actividad(Id);


GO 
