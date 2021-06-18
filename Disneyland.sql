USE master;
GO

IF DB_ID (N'Disneyland')IS NOT NULL

DROP DATABASE Disneyland;
GO

 

CREATE DATABASE Disneyland
ON
(
NAME = Disneyland_dat,
FILENAME= 'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Disneyland.mdf', 
SIZE = 10,
MAXSIZE = 50,
FILEGROWTH = 5
)
LOG ON
(
NAME = Disneyland_log,
FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Disneyland.ldf',
SIZE = 5MB,
MAXSIZE = 25,
FILEGROWTH = 5
);
GO

 

USE Disneyland;

 
 GO
 ----------------------------TABLAS---------------------------------------
  
	GO
CREATE TABLE Atracción(
	idAtraccion int IDENTITY(1,1) NOT NULL,
	nombre varchar(50) NOT NULL,
	horaApertura time NOT NULL,
	horaCierre time NOT NULL,
	precio float NOT NULL,
	estatus BIT NOT NULL DEFAULT 1,
	idDisneyland int NOT NULL
 CONSTRAINT PK_idAtraccion PRIMARY KEY (idAtraccion) 
 );


CREATE TABLE Boleto(
	idBoleto int IDENTITY(1,1) NOT NULL,
	nombre varchar(50) NOT NULL,
	tipo varchar(25) NOT NULL,
	precio float NOT NULL,
	estatus BIT NOT NULL DEFAULT 1,
	idTurista int NOT NULL

 CONSTRAINT PK_idBoleto PRIMARY KEY (idBoleto) 
 );

CREATE TABLE Ciudad(
	idCiudad int IDENTITY(1,1) NOT NULL,
	nombre varchar(25) NOT NULL,
	superficie FLOAT(25) NOT NULL,
	poblacion FLOAT NOT NULL,
	estatus BIT NOT NULL DEFAULT 1

 CONSTRAINT PK_idCiudad PRIMARY KEY (idCiudad) 
);

CREATE TABLE EmpleadoRestaurante(
	idEmpleadoRestaurante int IDENTITY(1,1) NOT NULL,
	nombres varchar(25) NOT NULL,
	apellidoPaterno varchar(25) NOT NULL,
	apellidoMaterno varchar(25) NOT NULL,
	estatus BIT NOT NULL DEFAULT 1,
	idRestaurante int NOT NULL
 CONSTRAINT PK_idEmpleadoRestaurante PRIMARY KEY (idEmpleadoRestaurante) 
);

CREATE TABLE EmpleadoTienda(
	idEmpleadoTienda int IDENTITY(1,1) NOT NULL,
	nombres varchar(25) NOT NULL,
	apellidoPaterno varchar(25) NOT NULL,
	apellidoMaterno varchar(25) NOT NULL,
	estatus BIT NOT NULL DEFAULT 1,
	idTienda int NOT NULL,
 CONSTRAINT PK_idEmpleadoTienda PRIMARY KEY (idEmpleadoTienda) 
);

CREATE TABLE Estado(
	idEstado int IDENTITY(1,1) NOT NULL,
	nombre varchar(25) NOT NULL,
	superficie FLOAT NOT NULL,
	poblacion FLOAT NOT NULL,
	estatus BIT NOT NULL DEFAULT 1,
	idCiudad int NOT NULL,
 CONSTRAINT PK_idEstado PRIMARY KEY (idEstado) 
);

CREATE TABLE Evento(
	idEvento int IDENTITY(1,1) NOT NULL,
	nombre varchar(50) NOT NULL,
	fecha date NOT NULL,
	precio float NOT NULL,
	estatus BIT NOT NULL DEFAULT 1,
	idDisneyland int NOT NULL,
 CONSTRAINT PK_idEvento PRIMARY KEY (idEvento) 
);

CREATE TABLE Horario(
	idHorario int IDENTITY(1,1) NOT NULL,
	horaApertura time NOT NULL,
	horaCierre time NOT NULL,
	dia VARCHAR(25) NOT NULL,
	estatus BIT NOT NULL DEFAULT 1,
	 CONSTRAINT PK_idHorario PRIMARY KEY (idHorario)
);

CREATE TABLE Hotel(
	idHotel int IDENTITY(1,1) NOT NULL,
	nombre varchar(50) NOT NULL,
	horaApertura time NOT NULL,
	horaCierre time NOT NULL,
	estatus BIT NOT NULL DEFAULT 1,
 CONSTRAINT PK_idHotel PRIMARY KEY (idHotel) 
);

CREATE TABLE ParqueDisneyland(
	idDisneyland int IDENTITY(1,1) NOT NULL,
	nombre varchar(25) NOT NULL,
	pais varchar(25) NOT NULL,
	telefono varchar(10) NOT NULL,
	estatus BIT NOT NULL DEFAULT 1,
	idHorario int NOT NULL,
	idEstado int NOT NULL,
 CONSTRAINT PK_idDisneyland PRIMARY KEY (idDisneyland) 
);

CREATE TABLE Platillo(
	idPlatillo int IDENTITY(1,1) NOT NULL,
	nombre varchar(25) NOT NULL,
	sabor varchar(25) NOT NULL,
	precio float NOT NULL,
	estatus BIT NOT NULL DEFAULT 1,
	idRestaurante int NOT NULL,
	idTurista int NOT NULL,
 CONSTRAINT PK_idPlatillo PRIMARY KEY (idPlatillo) 
);

CREATE TABLE Producto(
	idProducto int IDENTITY(1,1) NOT NULL,
	nombre varchar(25) NOT NULL,
	tipo varchar(25) NOT NULL,
	precio float NOT NULL,
	estatus BIT NOT NULL DEFAULT 1,
	idTienda int NOT NULL,
	idTurista int NOT NULL,
 CONSTRAINT PK_idProducto PRIMARY KEY (idProducto) 
);
CREATE TABLE Restaurante(
	idRestaurante int IDENTITY(1,1) NOT NULL,
	nombre varchar(50) NOT NULL,
	capacidad int NOT NULL,
	ubicacion varchar(25) NOT NULL,
	estatus BIT NOT NULL DEFAULT 1,
	idDisneyland int NOT NULL,
 CONSTRAINT PK_idRestaurante PRIMARY KEY (idRestaurante) 
);
CREATE TABLE Tienda(
	idTienda int IDENTITY(1,1) NOT NULL,
	nombre varchar(50) NOT NULL,
	tipo varchar(25) NOT NULL,
	ubicacion varchar(50) NOT NULL,
	estatus BIT NOT NULL DEFAULT 1,
	idDisneyland int NOT NULL,
 CONSTRAINT PK_idTienda PRIMARY KEY (idTienda) 
);

CREATE TABLE TipoEvento(
	idTipoEvento int IDENTITY(1,1) NOT NULL,
	nombre varchar(25) NOT NULL,
	duracionDias int NOT NULL,
	clasificacion varchar(25) NOT NULL,
	estatus BIT NOT NULL DEFAULT 1,
 CONSTRAINT PK_idTipoEvento PRIMARY KEY (idTipoEvento) 
);

CREATE TABLE TipoEventoEvento(
	idTipoEventoEvento int IDENTITY(1,1) NOT NULL,
	idEvento int NOT NULL,
	idTipoEvento int NOT NULL,
 CONSTRAINT PK_idTipoEventoEvento PRIMARY KEY (idTipoEventoEvento) 
);

CREATE TABLE Turista(
	idTurista int IDENTITY(1,1) NOT NULL,
	nombres varchar(25) NOT NULL,
	apellidoPaterno varchar(25) NOT NULL,
	apellidoMaterno varchar(25) NOT NULL,
	telefono varchar(10) NOT NULL,
	genero varchar(25) NOT NULL,
	nacionalidad varchar(50) NOT NULL,
	estatus BIT NOT NULL DEFAULT 1,
	CONSTRAINT PK_idTurista PRIMARY KEY (idTurista)
);

CREATE TABLE TuristaHotel(
	idTuristaHotel int IDENTITY(1,1) NOT NULL,
	idTurista int NOT NULL,
	idHotel int NOT NULL,
 CONSTRAINT PK_idTuristaHotel PRIMARY KEY (idTuristaHotel) 
 );

CREATE TABLE TuristaParqueDisneyland(
	idTuristaParqueDisneyland int IDENTITY(1,1) NOT NULL,
	idTurista int NOT NULL,
	idDisneyland int NOT NULL,
 CONSTRAINT PK_idTuristaParqueDisneyland PRIMARY KEY (idTuristaParqueDisneyland) 
);

GO
---------------------------------------INDEX-----------------------------------------------
CREATE INDEX IX_Turista ON Turista (idTurista);
CREATE INDEX IX_Atracción ON Atracción (idAtraccion);
CREATE INDEX IX_Boleto ON Boleto (idBoleto);
CREATE INDEX IX_Ciudad ON Ciudad (idCiudad);
CREATE INDEX IX_EmpleadoRestaurante ON EmpleadoRestaurante (idEmpleadoRestaurante);
CREATE INDEX IX_EmpleadoTienda ON EmpleadoTienda (idEmpleadoTienda);
CREATE INDEX IX_Estado ON Estado (idEstado);
CREATE INDEX IX_Evento ON Evento (idEvento);
CREATE INDEX IX_Horario ON Horario (idHorario);
CREATE INDEX IX_Hotel ON Hotel (idHotel);
CREATE INDEX IX_ParqueDisneyland ON ParqueDisneyland (idDisneyland);
CREATE INDEX IX_Platillo ON Platillo (idPlatillo);
CREATE INDEX IX_Producto ON Producto (idProducto);
CREATE INDEX IX_Restaurante ON Restaurante (idRestaurante);
CREATE INDEX IX_Tienda ON Tienda (idTienda);
CREATE INDEX IX_TipoEvento ON TipoEvento (idTipoEvento);
CREATE INDEX IX_TipoEventoEvento ON TipoEventoEvento (idTipoEventoEvento);
CREATE INDEX IX_TuristaHotel ON TuristaHotel (idTuristaHotel);
CREATE INDEX IX_TuristaParqueDisneyland ON TuristaParqueDisneyland (idTuristaParqueDisneyland);


---------------------------------------RELACIONES-----------------------------------------------
	ALTER TABLE Atracción
    ADD CONSTRAINT FK_AtracciónParqueDisneyland
    FOREIGN KEY (idDisneyland) REFERENCES ParqueDisneyland(idDisneyland);
	GO

	ALTER TABLE Boleto
    ADD CONSTRAINT FK_BoletoTurista
    FOREIGN KEY (idTurista) REFERENCES Turista(idTurista);
	GO

	ALTER TABLE EmpleadoRestaurante
    ADD CONSTRAINT FK_EmpleadoRestauranteRestaurante
    FOREIGN KEY (idRestaurante) REFERENCES Restaurante(idRestaurante);
	GO

	ALTER TABLE EmpleadoTienda
    ADD CONSTRAINT FK_EmpleadoTiendaTienda
    FOREIGN KEY (idTienda) REFERENCES Tienda(idTienda);
	GO

	ALTER TABLE Estado
    ADD CONSTRAINT FK_EstadoCiudad
    FOREIGN KEY (idCiudad) REFERENCES Ciudad(idCiudad);
	GO

	ALTER TABLE Evento
    ADD CONSTRAINT FK_EventoParqueDisneyland
    FOREIGN KEY (idDisneyland) REFERENCES ParqueDisneyland(idDisneyland);
	GO

	ALTER TABLE ParqueDisneyland
    ADD CONSTRAINT FK_ParqueDisneylandEstado
    FOREIGN KEY (idEstado) REFERENCES Estado(idEstado);
	GO

	ALTER TABLE ParqueDisneyland
    ADD CONSTRAINT FK_ParqueDisneylandHorario
    FOREIGN KEY (idHorario) REFERENCES Horario(idHorario);
	GO

	ALTER TABLE Platillo
    ADD CONSTRAINT FK_PlatilloRestaurante
    FOREIGN KEY (idRestaurante) REFERENCES Restaurante(idRestaurante);
	GO

	ALTER TABLE Platillo
    ADD CONSTRAINT FK_PlatilloTurista
    FOREIGN KEY (idTurista) REFERENCES Turista(idTurista);
	GO

	ALTER TABLE Producto
    ADD CONSTRAINT FK_ProductoTienda
    FOREIGN KEY (idTienda) REFERENCES Tienda(idTienda);
	GO

	ALTER TABLE Producto
    ADD CONSTRAINT FK_ProductoTurista
    FOREIGN KEY (idTurista) REFERENCES Turista(idTurista);
	GO

	ALTER TABLE Restaurante
    ADD CONSTRAINT FK_RestauranteDisneyland
    FOREIGN KEY (idDisneyland) REFERENCES ParqueDisneyland(idDisneyland);
	GO

	ALTER TABLE Tienda
    ADD CONSTRAINT FK_TiendaDisneyland
    FOREIGN KEY (idDisneyland) REFERENCES ParqueDisneyland(idDisneyland);
	GO

	ALTER TABLE TipoEventoEvento
    ADD CONSTRAINT FK_TipoEventoEventoEvento
    FOREIGN KEY (idEvento) REFERENCES Evento(idEvento);
	GO

	ALTER TABLE TipoEventoEvento
    ADD CONSTRAINT FK_TipoEventoEventoTipoEvento
    FOREIGN KEY (idTipoEvento) REFERENCES TipoEvento(idTipoEvento);
	GO

	ALTER TABLE TuristaHotel
    ADD CONSTRAINT FK_TuristaHotelHotel
    FOREIGN KEY (idHotel) REFERENCES Hotel(idHotel);
	GO

	ALTER TABLE TuristaHotel
    ADD CONSTRAINT FK_TuristaHotelTurista
    FOREIGN KEY (idTurista) REFERENCES Turista(idTurista);
	GO

	ALTER TABLE TuristaParqueDisneyland
    ADD CONSTRAINT FK_TuristaParqueDisneylandParqueDisneyland
    FOREIGN KEY (idDisneyland) REFERENCES ParqueDisneyland(idDisneyland);
	GO

	ALTER TABLE TuristaParqueDisneyland
    ADD CONSTRAINT FK_TuristaParqueDisneylandTurista
    FOREIGN KEY (idDisneyland) REFERENCES ParqueDisneyland(idDisneyland);
	GO
	
	----------Insertar--------------------------------------

	----Turista------
	INSERT INTO Turista(nombres,apellidoPaterno,apellidoMaterno,telefono,genero,nacionalidad)
	VALUES('Josue Gilberto','Rivera','Sandoval','8666347341','Masculino','Mexicana'),
	('LUIS MIGUEL','BORREGO','MORATA','8666347342','Masculino','Mexicana'),
	('FERNANDO','CAÑELLAS','SEBASTIA','8666347343','Masculino','Mexicana'),
	('MARCOS','Rivera','Sandoval','8666347344','Masculino','Mexicana'),
	('Josue Gilberto','Rivera','Sandoval','8666347345','Masculino','Mexicana')
	----Ciudad------
	INSERT INTO Ciudad(nombre,superficie,poblacion)
	VALUES('Urayasu',17.29,164024),
	('Orlando',294.6,280832),
	('Anaheim',131.8,349964),
	('París',105.4,2.161),
	('Shanghái',6340,26.32)

	----Estado-------

	INSERT INTO Estado(nombre,superficie,poblacion,idCiudad)
	VALUES('chiba',271.8,6.278,1),
	('Florida',170312,21.48,2),
	('California',423970,39.51,3),
	('Isla de Francia',12012,12.21,4),
	('Delta del río Yangtsé',211700, 2.182,5)

	-----Hoteles------
	INSERT INTO Hotel(nombre,horaApertura,horaCierre)
	VALUES('Bay Lake Tower','07:00:00','23:00:00'),
	('Boulder Ridge Villas','07:00:00','23:00:00'),
	('Disneys All-Star Movies Resort','07:00:00','23:00:00'),
	('Disneys Pop Century Resort','07:00:00','23:00:00'),
	('Disneys Beach Club Resort','07:00:00','23:00:00')

	---Horario------
	INSERT INTO Horario(horaApertura,horaCierre,dia)
	VALUES('07:00:00','23:00:00','Lunes'),
	('07:00:00','23:00:00','Martes'),
	('07:00:00','23:00:00','Miercoles'),
	('07:00:00','23:00:00','Jueves'),
	('07:00:00','23:00:00','Viernes')

	----Tipo de Evento------
		INSERT INTO TipoEvento(nombre,duracionDias,clasificacion)
	VALUES('Especial',4,'Preescolar'),
	('Recorrido',5,'Ninos'),
	('Deportivo',3,'Adolescentes'),
	('Experiencias especiales',10,'Adultos'),
	('Temporada',15,'Todos')

	----Boleto---
		INSERT INTO Boleto(nombre,tipo,precio,idTurista)
	VALUES('Estándar para Parque Temático','1 dia',2144.65,1),
	('Estándar para Parque Temático','2 dias',2105.29,2),
	('Estándar para Parque Acuatico','3 dias',2065.94,3),
	('Estándar para Parque Temático','4 dias',2026.59,4),
	('Estándar para Parque Acuatico','5 dias',1731.46,5)

	--Disneyland------
		INSERT INTO ParqueDisneyland(nombre,pais,telefono,idHorario,idEstado)
	VALUES('Walt Disney World Resort','USA','1407939527',1,2),
	('Disneyland Resort','USA','1714781463',2,3),
	('Disneyland Paris','Francia','3382530050',3,4),
	('Shanghai Disneyland Park','China','8145330521',4,5),
	('Tokyo Disneyland','Japon','8145330521',5,1)

	---Atraccion----------
	INSERT INTO Atracción(nombre,horaApertura,horaCierre,precio,idDisneyland)
	VALUES('Guardians of the Galaxy Mission: Breakout!','07:00:00','23:00:00',1225,1),
	('Luigis Rollickin Roadsters','07:00:00','23:00:00',1200,2),
	('Big Thunder Mountain Railroad','07:00:00','23:00:00',995,3),
	('Radiator Springs Racers','07:00:00','23:00:00',775,4),
	('Monsters, Inc. Mike & Sulley to the Rescue!','07:00:00','23:00:00',1555,5)

	----Evento-------
	INSERT INTO Evento(nombre,fecha,precio,idDisneyland)
	VALUES('Halloween Time en Disneyland Resort','2021-08-31',1250,1),
	('Mickeys Halloween Party','2021-08-31',1250,2),
	('Día de los Muertos','2021-06-20',750,3),
	('Disney Festival of Holidays','2021-04-14',800,4),
	('The Grand Circle','2021-06-20',900,5)

	---Restaurante----
		INSERT INTO Restaurante(nombre,capacidad,ubicacion,idDisneyland)
	VALUES('Adorable Snowman Frosted Treats',50,'Pixar Pier',1),
	('Alien Pizza Planet',45,'Tomorrowland',2),
	('Angry Dogs',30,'Pixar Pier',3),
	('Award Wieners',20,'Hollywood Land',4),
	('Ballast Point Brewing Co',100,'Downtown Disney District',5)

		---Tienda----
		INSERT INTO Tienda(nombre,tipo,ubicacion,idDisneyland)
	VALUES('20th Century Music Company','Camera and Media','Main Street',1),
	('Acorns Gifts & Goods','Gifts and HouseWares','Disneys Grand Californian Hotel & Spa',2),
	('Alamo Rent A Car','Services',' Disneys Paradise Pier Hotel',3),
	('Black Spire Outfitters','Apparel & Accessories','Star Wars: Galaxys Edge',4),
	('Disneys Pin Traders','Pins','Downtown Disney District',5)

			---EmpleadoRestaurante----
		INSERT INTO EmpleadoRestaurante(nombres,apellidoPaterno,apellidoMaterno,idRestaurante)
	VALUES('EUGENIO','AYALA','CASTELLANOS',1),
	('RAFAEL ','CAÑAS','ESCALONA',2),
	('EMILIO ','BOZA','ALSINA',3),
	('EUGENIO','SALVADOR','PERNAS',4),
	('DIEGO','IRIGOYEN','URBANO',5)

				---EmpleadoTienda----
		INSERT INTO EmpleadoTienda(nombres,apellidoPaterno,apellidoMaterno,idTienda)
	VALUES('MIGUEL ANGEL','FERRERA','FALCO',1),
	('JAVIER','MEGIAS','GILABERT',2),
	('ANTONIO','BARO','ALMANSA',3),
	('DOMINGO','PAZOS','PERNAS',4),
	('DIEGO','IRIGOYEN','CUTILLAS',5)


					---Platillo----
		INSERT INTO Platillo(nombre,sabor,precio,idRestaurante,idTurista)
	VALUES('Malteada','Fresa',80,1,1),
	('Pizza','Chesse',250,2,2),
	('Hot dog','Pollo',250,3,3),
	('Banderilla','Pollo',250,4,4),
	('Pretzel Bites','salado',250,5,5)


						---Producto----
		INSERT INTO Producto(nombre,tipo,precio,idTienda,idTurista)
	VALUES('Guitarra de Goofy','musica',4000,1,1),
	('Gorra de Mickey','Regalo',700,2,2),
	('Carro de Sulivan','Coches',500,3,3),
	('Playera de woody','Ropa',650,4,4),
	('Pin de Obi wan','Pins',100,5,5)


							---TipoEventoEvento----
		INSERT INTO TipoEventoEvento(idEvento,idTipoEvento)
	VALUES(1,3),
	(2,4),
	(5,2),
	(4,1),
	(3,5)

								---TuristaHotel----
		INSERT INTO TuristaHotel(idTurista,idHotel)
	VALUES(1,1),
	(2,2),
	(3,3),
	(4,4),
	(5,5)

									---TuristaParqueDisneyland----
		INSERT INTO TuristaParqueDisneyland(idTurista,idDisneyland)
	VALUES(1,1),
	(2,2),
	(3,3),
	(4,4),
	(5,5)
	
	SELECT* FROM Atracción;
	SELECT* FROM Boleto;
	SELECT* FROM Ciudad;
	SELECT* FROM EmpleadoRestaurante;
	SELECT* FROM EmpleadoTienda;
	SELECT* FROM Estado;
	SELECT* FROM Evento;
	SELECT* FROM TipoEvento;
    SELECT* FROM TipoEventoEvento;
	SELECT* FROM Horario;
	SELECT* FROM Turista;
	SELECT* FROM Hotel;
	SELECT* FROM TuristaHotel;
	SELECT* FROM ParqueDisneyland;
	SELECT* FROM Platillo;
	SELECT* FROM Producto;
	SELECT* FROM Restaurante;
	SELECT* FROM Tienda;
	SELECT* FROM TuristaParqueDisneyland;
	
	---Procedimientos Almacenados-------
	GO
      CREATE PROC SP_Descuento

	  AS
	  
	   Declare @Count float=(Select count(precio) from Producto  
	    ), @i int =0, @a float;
	  while @Count>@i
	  begin
	   set @i+= 1;
	  set @a = (Select precio from Producto  
	  WHERE precio>=700 AND idProducto=@i );
	  if @a>=700
	  Select precio=@a-@a*.20,nombre from Producto  
	  WHERE precio>=700 AND idProducto=@i and precio=@a
	
	  end
	  GO
	   EXEC SP_Descuento
	   
	   GO
      CREATE PROC SP_Iva
	  AS
	  Declare @Count float=(Select count(precio) from Producto  
	    ), @i int =0, @a float;
	  while @Count>@i
	  begin
	   set @i+= 1;
	  set @a = (Select precio from Producto  
	  WHERE  idProducto=@i  );
	  Select precio=@a+@a*.16,nombre from Producto  
	  WHERE idProducto=@i and precio=@a
	  end
	  GO
	   EXEC SP_Iva

	     
	   GO
      CREATE PROC SP_Tablas

	  AS
	  Select TABLE_NAME from INFORMATION_SCHEMA.TABLES;
	  GO
	   EXEC SP_Tablas

	   GO
	   CREATE PROC SP_Producto

	  AS
	  Select nombre,precio From Producto;
	  GO
	   EXEC SP_Producto

	 
	     	  GO
	  CREATE PROC SP_Disneyland
	  as select nombre,pais from ParqueDisneyland;
	    GO
	   EXEC SP_Disneyland

	     	  GO
	  CREATE PROC SP_Atraccion
	  as select nombre,precio from Atracción;
	    GO
	  EXEC SP_Atraccion

	     	  GO
	  CREATE PROC SP_Turista
	  as select nombres,nacionalidad from Turista;
	  GO
	   EXEC SP_Turista
	   GO
	   	  GO
	  CREATE PROC SP_Tienda
	  as select nombre from Tienda;
	  GO
	   EXEC SP_Tienda
	   GO
	   	 GO
	  CREATE PROC SP_Restaurante
	  as select nombre from Restaurante;
	  GO
	   EXEC SP_Restaurante
	   GO
	   CREATE PROC SP_Suma
	  AS
	  Declare @Count float=(Select count(precio) from Producto  
	    ), @i int =0, @a float=0,@b float=0;
	  while @Count>@i
	  begin
	   set @i+= 1;
	 
	  set @a = (Select precio from Producto  
	  WHERE  idProducto=@i );
	    set @b+= @a;
	  if @count = @i
	  Select @b; 
	  end
	  GO
	   EXEC SP_Suma
	   ----Triggers----
	   go
	   create trigger Descuento 
	   on Producto for Insert
	   as   Declare @Count float=(Select count(precio) from Producto  
	    ), @i int =0, @a float;
	  while @Count>@i
	  begin
	   set @i+= 1;
	  set @a = (Select precio from Producto  
	  WHERE precio>=700 AND idProducto=@i );
	  if @a>=700
	  Select precio=@a-@a*.20,nombre from Producto  
	  WHERE precio>=700 AND idProducto=@i and precio=@a
	  end
	  GO
	   create trigger Iva 
	   on Producto for Insert
	   as  Declare @Count float=(Select count(precio) from Producto  
	    ), @i int =0, @a float;
	  while @Count>@i
	  begin
	   set @i+= 1;
	  set @a = (Select precio from Producto  
	  WHERE  idProducto=@i );
	  Select precio=@a+@a*.16,nombre from Producto  
	  WHERE idProducto=@i and precio=@a
	  end

	  GO 
	  create trigger MostrarProducto
	  on Producto for Insert
	  as Select nombre,precio From Producto;

	   GO 
	  create trigger Insertar
	  on Producto for Insert
	  as Print N'Se ha insertado en la tabla Producto'

	  GO
	  create trigger Modificar
	  on Producto for Update
	  as Print N'Se ha modificado en la tabla Producto'

	  	  GO
	  create trigger Borrar
	  on Producto for delete
	  as Print N'Se ha borrado en la tabla Producto'

	   	  GO
	  create trigger NoagregarDisneyland
	  on ParqueDisneyland instead of Insert
	  as Print N'Se ha agregado en la tabla ParqueDisneyland'

	     	  GO
	  create trigger Disneyland
	  on ParqueDisneyland for Insert
	  as select nombre,pais from ParqueDisneyland;

	     	  GO
	  create trigger Atraccion
	  on Atracción for Insert
	  as select nombre,precio from Atracción;

	     	  GO
	  create trigger _Turista
	  on Turista for Insert
	  as select nombres,nacionalidad from Turista;
	  
	GO
	-----Aggregate Functions--------
	Select Avg(precio) as 'Promedio del costo de platillos' from Platillo;
	 Select Count(idProducto) as 'Productos totales' from Producto;
	 Select Count_Big(idPlatillo) as 'Platillos totales' from Platillo;
	 Select Sum(precio) as 'Precio total de las atracciones'from Atracción;
	 Select Min(precio) as 'Precio minimo de las atracciones'from Atracción;
	 Select Max(precio) as 'Precio maximo de las atracciones'from Atracción;
	 SELECT CHECKSUM_AGG(CAST(precio AS INT)) as 'suma de comprobacion 'FROM Producto; 
SELECT  precio as 'Precios diferentes de platillos' FROM Platillo group by precio;
      select var(precio) as 'Varianza de precio total de platillos' from Producto;
	  select stdev(precio) as 'desviacion estandar de precio total de platillos' from Producto;
   