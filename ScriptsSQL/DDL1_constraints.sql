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


ALTER TABLE ActividadHorario
ADD CONSTRAINT FK_ActHorActiidad FOREIGN KEY (IdActividad)  REFERENCES Actividad(Id);   

ALTER TABLE ActividadHorario
add constraint CK_ActHorarioDia CHECK (Dia >=1 and Dia <=7);
ALTER TABLE ActividadHorario
add	 constraint CK_ActHorarioHora CHECK (Hora >=0 and Dia <24);

--agregar constraint unique a usuario
ALTER TABLE Usuario
add constraint UK_Usuario_mail_password unique(Mail,AdminPassword)

/*ALTER TABLE ActividadHorario  
ADD CONSTRAINT FK_ActHorHorario FOREIGN KEY (IdActividad)  REFERENCES Actividad(Id);
*/

GO 
