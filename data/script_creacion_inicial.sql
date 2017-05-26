USE [GD1C2017]
GO
/* ================================================
					DROP DE TABLAS
   ================================================
 */
IF OBJECT_ID('AUTO_POR_TURNO') IS NOT NULL
DROP TABLE AUTO_POR_TURNO

IF OBJECT_ID('ROL_POR_USUARIO') IS NOT NULL
DROP TABLE ROL_POR_USUARIO

IF OBJECT_ID('ROL_POR_FUNCIONALIDAD') IS NOT NULL
DROP TABLE ROL_POR_FUNCIONALIDAD

IF OBJECT_ID('FUNCIONALIDAD') IS NOT NULL
DROP TABLE FUNCIONALIDAD

IF OBJECT_ID('ITEM_FACTURA') IS NOT NULL
DROP TABLE ITEM_FACTURA

IF OBJECT_ID('ITEM_RENDICION') IS NOT NULL
DROP TABLE ITEM_RENDICION

IF OBJECT_ID('VIAJE') IS NOT NULL
DROP TABLE VIAJE

IF OBJECT_ID('FACTURA') IS NOT NULL
DROP TABLE FACTURA

IF OBJECT_ID('RENDICION_VIAJE') IS NOT NULL
DROP TABLE RENDICION_VIAJE

IF OBJECT_ID('CHOFER') IS NOT NULL
DROP TABLE CHOFER

IF OBJECT_ID('CLIENTE') IS NOT NULL
DROP TABLE CLIENTE

IF OBJECT_ID('ADMINISTRADOR') IS NOT NULL
DROP TABLE ADMINISTRADOR

IF OBJECT_ID('USUARIO') IS NOT NULL
DROP TABLE USUARIO

IF OBJECT_ID('ROL') IS NOT NULL
DROP TABLE ROL

IF OBJECT_ID('DIRECCION') IS NOT NULL
DROP TABLE DIRECCION

IF OBJECT_ID('AUTOMOVIL') IS NOT NULL
DROP TABLE AUTOMOVIL

IF OBJECT_ID('MARCA') IS NOT NULL
DROP TABLE MARCA

IF OBJECT_ID('TURNO') IS NOT NULL
DROP TABLE TURNO

/* ================================================
				DROP DE PROCEDURES
   ================================================
 */

  IF OBJECT_ID('ALTA_CLIENTE') IS NOT NULL
DROP PROCEDURE ALTA_CLIENTE

 IF OBJECT_ID('ALTA_CHOFER') IS NOT NULL
DROP PROCEDURE ALTA_CHOFER

 IF OBJECT_ID('ALTA_AUTOMOVIL') IS NOT NULL
DROP PROCEDURE ALTA_AUTOMOVIL

 IF OBJECT_ID('ALTA_ROL') IS NOT NULL
DROP PROCEDURE ALTA_ROL

 IF OBJECT_ID('ALTA_VIAJE') IS NOT NULL
DROP PROCEDURE ALTA_VIAJE

 IF OBJECT_ID('AGREGAR_FUNCIONALIDAD') IS NOT NULL
DROP PROCEDURE AGREGAR_FUNCIONALIDAD

 IF OBJECT_ID('CREAR_FACTURA') IS NOT NULL
DROP PROCEDURE CREAR_FACTURA

 IF OBJECT_ID('CREAR_RENDICION') IS NOT NULL
DROP PROCEDURE CREAR_RENDICION

 IF OBJECT_ID('ALTA_TURNO') IS NOT NULL
DROP PROCEDURE ALTA_TURNO

 IF OBJECT_ID('AGREGAR_FUNCIONALIDAD') IS NOT NULL
DROP PROCEDURE AGREGAR_FUNCIONALIDAD

/* ================================================
				DROP DE TRIGGERS
   ================================================
 */

IF OBJECT_ID('CIFRAR') IS NOT NULL
DROP TRIGGER CIFRAR

/* ================================================
		        CREACION DE TABLAS
   ================================================
 */

CREATE TABLE ADMINISTRADOR(
	admi_usua int,
	admi_id int PRIMARY KEY IDENTITY (1,1)
	)

CREATE TABLE CLIENTE(
	clie_usua int,
	clie_id int PRIMARY KEY IDENTITY (1,1),
	clie_nombre nvarchar(255) NOT NULL ,
	clie_apellido nvarchar(255) NOT NULL ,
	clie_dni bigint NOT NULL,
	clie_mail nvarchar(255),
	clie_telefono bigint NOT NULL UNIQUE ,
	clie_fechaNacimiento smalldatetime NOT NULL,
	clie_direccion int NOT NULL,
	clie_habilitado bit DEFAULT 1
	)

CREATE TABLE CHOFER(
	chof_usua int,
	chof_id int PRIMARY KEY IDENTITY (1,1),
	chof_nombre nvarchar(255) NOT NULL ,
	chof_apellido nvarchar(255) NOT NULL ,
	chof_dni  bigint NOT NULL,
	chof_telefono bigint NOT NULL UNIQUE,
	chof_mail nvarchar(255) NOT NULL ,
	chof_fechaNacimiento smalldatetime NOT NULL,
	chof_direccion int NOT NULL,
	chof_habilitado bit DEFAULT 1
	)

CREATE TABLE DIRECCION(
	dire_id int PRIMARY KEY IDENTITY (1,1),
	dire_calle nvarchar(255) NOT NULL ,
	dire_depto  nvarchar(255) ,
	dire_piso  nvarchar(255) ,
	dire_localidad nvarchar(255) ,
	dire_cp nvarchar(50) ,
	)

CREATE TABLE ITEM_FACTURA(
	itemf_id int PRIMARY KEY IDENTITY (1,1),
	itemf_fact int not null,
	itemf_viaje int not null,
	itemf_precioViaje decimal(12,2) not null
	)

CREATE TABLE ITEM_RENDICION(
	itemr_id int PRIMARY KEY IDENTITY (1,1),
	itemr_pago int NOT NULL,
	itemr_viaje int not null,
	itemr_precio decimal(12,2) not null,
	)

CREATE TABLE ROL(
	rol_id int PRIMARY KEY IDENTITY(1,1),
	rol_habilitado bit DEFAULT 1, 
	rol_descripcion nvarchar(255) UNIQUE not null
	)

CREATE TABLE USUARIO(
	usua_id int PRIMARY KEY IDENTITY(1,1),
	usua_usuario nvarchar(255) NOT NULL UNIQUE,
	usua_password nvarchar(255) NOT NULL,
	usua_intentosFallidos int default 0,
	usua_habilitado bit default 1
)

CREATE TABLE ROL_POR_USUARIO(
	rol_id int,
	usua_id int not null,
	PRIMARY KEY (rol_id, usua_id)
)

CREATE TABLE FUNCIONALIDAD(
	func_id int PRIMARY KEY IDENTITY (1,1),
	func_descripcion nvarchar(255) NOT NULL UNIQUE
)

CREATE TABLE ROL_POR_FUNCIONALIDAD(
	rol_id int,
	func_id int not null,
	func_habilitada bit DEFAULT 1
	PRIMARY KEY(rol_id, func_id)	
)

CREATE TABLE TURNO(
	turn_id int PRIMARY KEY IDENTITY (1,1),
	turn_hora_inicio time NOT NULL,
	turn_hora_fin time NOT NULL,
	turn_descripcion nvarchar(255) NOT NULL UNIQUE,
	turn_valor_km decimal(12,2) NOT NULL,
	turn_precio_base decimal(12,2) NOT NULL,
	turn_habilitado bit DEFAULT 1 NOT NULL
)

CREATE TABLE VIAJE(
	viaj_id int PRIMARY KEY IDENTITY (1,1),
	viaj_cantidad_km decimal(10,2) NOT NULL,
	viaj_fyh_inicio datetime NOT NULL,
	viaj_fyh_fin datetime NOT NULL,
	viaj_cliente int NOT NULL,
	viaj_turno int NOT NULL,
	viaj_auto int NOT NULL,
	viaj_chofer int NOT NULL,
	viaj_precio decimal(12,2) NOT NULL
)

CREATE TABLE AUTOMOVIL(
	auto_id int PRIMARY KEY IDENTITY (1,1),
	auto_patente nvarchar(255) NOT NULL UNIQUE,
	auto_marca int NOT NULL,
	auto_modelo nvarchar(255) NOT NULL,
	auto_habilitado bit DEFAULT 1
)

CREATE TABLE AUTO_POR_TURNO(
	auto_id int NOT NULL,
	turn_id int NOT NULL,
	PRIMARY KEY(AUTO_ID, TURN_ID),
	chof_id int
)

CREATE TABLE MARCA(
	marc_id int PRIMARY KEY IDENTITY (1,1),
	marc_detalle nvarchar(255) NOT NULL UNIQUE
	)

CREATE TABLE RENDICION_VIAJE(
	pago_id int PRIMARY KEY IDENTITY(1,1),
	pago_fecha smalldatetime NOT NULL,
	pago_importe_total decimal(12,2) NOT NULL,
	pago_turno int NOT NULL,
	pago_chofer int NOT NULL,
	pago_porcentaje decimal(12,2)
)

CREATE TABLE FACTURA(
	fact_id int  PRIMARY KEY IDENTITY (1,1),
	fact_fecha_inicio smalldatetime NOT NULL,
	fact_fecha_fin smalldatetime NOT NULL,
	fact_total decimal(12,2) NOT NULL,
	fact_cliente int NOT NULL,
	fact_nro_migracion int
)

/* ================================================
		          AGREGADO DE FKS
   ================================================
 */
ALTER TABLE ITEM_FACTURA ADD FOREIGN KEY(itemf_fact) REFERENCES FACTURA
ALTER TABLE ITEM_FACTURA ADD FOREIGN KEY(itemf_viaje) REFERENCES VIAJE
ALTER TABLE ITEM_RENDICION ADD FOREIGN KEY(itemr_pago) REFERENCES RENDICION_VIAJE
ALTER TABLE ITEM_RENDICION ADD FOREIGN KEY(itemr_viaje) REFERENCES VIAJE
ALTER TABLE ADMINISTRADOR ADD FOREIGN KEY (admi_usua) REFERENCES USUARIO
ALTER TABLE CHOFER ADD FOREIGN KEY (chof_usua) REFERENCES USUARIO
ALTER TABLE CLIENTE ADD FOREIGN KEY (clie_usua) REFERENCES USUARIO
ALTER TABLE CHOFER ADD FOREIGN KEY(chof_direccion) REFERENCES DIRECCION
ALTER TABLE CLIENTE ADD FOREIGN KEY(clie_direccion) REFERENCES DIRECCION
ALTER TABLE ROL_POR_USUARIO ADD FOREIGN KEY (rol_id) REFERENCES ROL
ALTER TABLE ROL_POR_USUARIO ADD FOREIGN KEY (usua_id) REFERENCES USUARIO
ALTER TABLE ROL_POR_FUNCIONALIDAD ADD FOREIGN KEY (rol_id) REFERENCES ROL
ALTER TABLE ROL_POR_FUNCIONALIDAD ADD FOREIGN KEY (func_id) REFERENCES FUNCIONALIDAD
ALTER TABLE VIAJE ADD FOREIGN KEY (viaj_cliente) REFERENCES USUARIO
ALTER TABLE VIAJE ADD FOREIGN KEY (viaj_turno) REFERENCES TURNO
ALTER TABLE VIAJE ADD FOREIGN KEY (viaj_chofer) REFERENCES CHOFER
ALTER TABLE VIAJE ADD FOREIGN KEY (viaj_auto) REFERENCES AUTOMOVIL
ALTER TABLE AUTOMOVIL ADD FOREIGN KEY (auto_marca) REFERENCES MARCA
ALTER TABLE RENDICION_VIAJE ADD FOREIGN KEY(pago_chofer) REFERENCES CHOFER
ALTER TABLE RENDICION_VIAJE ADD FOREIGN KEY (pago_turno) REFERENCES TURNO
ALTER TABLE FACTURA ADD FOREIGN KEY (fact_cliente) REFERENCES USUARIO
ALTER TABLE AUTO_POR_TURNO ADD FOREIGN KEY (auto_id) REFERENCES AUTOMOVIL
ALTER TABLE AUTO_POR_TURNO ADD FOREIGN KEY (turn_id) REFERENCES TURNO
ALTER TABLE AUTO_POR_TURNO ADD FOREIGN KEY (chof_id) REFERENCES CHOFER

/* ================================================
				  CREACION DE PROCEDURES
   ================================================
 */

 --/*
--====================================
--		    ALTA PROCEDURES
--====================================
--*/

GO
CREATE PROCEDURE ALTA_CLIENTE(@NOMBRE nvarchar(255), @APELLIDO nvarchar(255), @DNI bigint, @MAIL nvarchar(255), @TELEFONO bigint, @FECHA_NACIMIENTO nvarchar(255), @CALLE nvarchar(255), @PISO nvarchar(255), @DPTO nvarchar(255), @LOCALIDAD nvarchar(255), @CP nvarchar(255))
AS
BEGIN
DECLARE @iddirec int
	IF(NOT EXISTS (SELECT * FROM CLIENTE WHERE clie_telefono = @TELEFONO))
		BEGIN
			INSERT INTO DIRECCION(dire_calle, dire_depto, dire_piso, dire_localidad, dire_cp)
			VALUES(@CALLE, @DPTO, @PISO, @LOCALIDAD, @CP)
		
			SELECT @iddirec = dire_id 
			FROM Direccion 
			WHERE dire_calle = @CALLE 
			AND dire_cp= @CP 
			AND dire_depto = @DPTO
			AND dire_localidad = @LOCALIDAD
			AND dire_piso = @PISO
			
			INSERT INTO CLIENTE(clie_nombre, clie_apellido, clie_dni, clie_fechaNacimiento, clie_mail, clie_telefono,clie_direccion)
			VALUES(@nombre, @APELLIDO, @DNI, CAST(@FECHA_NACIMIENTO as smalldatetime), @MAIL, @TELEFONO, @iddirec)
		END
	ELSE
		RAISERROR ('El cliente ya existe', 16, 217) WITH SETERROR
END

GO
CREATE PROCEDURE ALTA_CHOFER(@NOMBRE nvarchar(255), @APELLIDO nvarchar(255), @DNI bigint, @MAIL nvarchar(255), @TELEFONO bigint, @FECHA_NACIMIENTO nvarchar(255), @CALLE nvarchar(255), @PISO nvarchar(255), @DPTO nvarchar(255), @LOCALIDAD nvarchar(255), @CP nvarchar(255))
AS
BEGIN
DECLARE @iddirec int
	IF (NOT EXISTS (SELECT * FROM CHOFER WHERE CHOF_TELEFONO = @TELEFONO))
		BEGIN
			INSERT INTO DIRECCION(dire_calle, dire_cp, dire_depto, dire_localidad, dire_piso)
			VALUES(@CALLE, @CP, @DPTO, @LOCALIDAD, @PISO)
		
			SELECT @iddirec= dire_id 
			FROM DIRECCION 
			WHERE dire_calle = @CALLE 
			AND dire_cp= @CP 
			AND dire_depto = @DPTO
			AND dire_localidad = @LOCALIDAD
			AND dire_piso = @PISO

			INSERT INTO CHOFER(chof_nombre, chof_apellido, chof_dni, chof_mail, chof_telefono, chof_fechaNacimiento,chof_direccion) 
			VALUES(@NOMBRE, @APELLIDO, @DNI, @MAIL, @TELEFONO, CAST(@FECHA_NACIMIENTO AS SMALLDATETIME),@iddirec)
		END
	ELSE
		 RAISERROR ('El chofer ya existe', 16, 217) WITH SETERROR
END

GO
CREATE PROCEDURE ALTA_AUTOMOVIL(@MARCA INT, @MODELO nvarchar(255), @PATENTE nvarchar(255))
AS 
BEGIN 
DECLARE @idmarca int
	IF(NOT EXISTS(SELECT * FROM AUTOMOVIL WHERE auto_patente = @PATENTE))
		BEGIN
			INSERT INTO AUTOMOVIL(auto_patente, auto_modelo, auto_marca)
			VALUES(@PATENTE, @MODELO, @idmarca)
		END
	ELSE
		RAISERROR ('El auto ya existe', 16, 217) WITH SETERROR
END

GO
CREATE PROCEDURE ALTA_VIAJE(@CANTIDADKM INT,@FECHAINICIO NVARCHAR(255) ,@FECHAFIN NVARCHAR(255), @TURNO INT, @AUTO INT, @CHOFER INT, @CLIENTE INT)
AS
BEGIN
	IF(EXISTS (SELECT auto_id, chof_id, turn_id 
				FROM AUTO_POR_TURNO 
				WHERE auto_id = @AUTO and chof_id = @CHOFER and turn_id = @TURNO))
		INSERT INTO VIAJE(viaj_auto, viaj_cantidad_km, viaj_chofer, viaj_cliente, viaj_fyh_inicio, viaj_fyh_fin, viaj_turno)
		VALUES(@AUTO, @CANTIDADKM, @CHOFER, @CLIENTE, @FECHAINICIO, @FECHAFIN, @TURNO)
	ELSE
		RAISERROR ('No existe un chofer con ese auto en ese turno', 16, 217) WITH SETERROR	
END

GO
CREATE PROCEDURE ALTA_ROL(@DESCRIPCION NVARCHAR(255))
AS
BEGIN
	IF(NOT EXISTS (SELECT * FROM ROL WHERE rol_descripcion = @DESCRIPCION))
		INSERT INTO ROL(rol_descripcion)
		VALUES(@DESCRIPCION)
	ELSE 
		RAISERROR ('El rol ya existe', 16, 217) WITH SETERROR
END

GO
CREATE PROCEDURE AGREGAR_FUNCIONALIDAD(@FUNCIONALIDAD int, @ROL int)
AS
BEGIN 
	INSERT INTO ROL_POR_FUNCIONALIDAD(rol_id, func_id) 
	VALUES(@ROL, @FUNCIONALIDAD)
END

GO
CREATE PROCEDURE ALTA_TURNO(@DESCRIPCION NVARCHAR(255), @HORA_INICIO time, @HORA_FIN time, @PRECIOBASE decimal(12,2), @VALORKM decimal(12,2))
AS
BEGIN
	IF(NOT EXISTS (SELECT * FROM TURNO WHERE turn_descripcion = @DESCRIPCION))
		BEGIN 
			IF(NOT EXISTS(SELECT * FROM TURNO WHERE (@HORA_INICIO > turn_hora_inicio and @HORA_FIN < turn_hora_fin ) -- un turno mas chico que uno existente
													or (@HORA_INICIO < turn_hora_inicio and @HORA_FIN > turn_hora_fin) -- un turno mas grande que uno existente
													or @HORA_INICIO NOT BETWEEN (SELECT T2.turn_hora_inicio FROM TURNO T2) AND (SELECT T3.turn_hora_fin FROM TURNO T3) -- el inicio de uno entre la frnaja de otro
													or @HORA_FIN NOT BETWEEN (SELECT T4.turn_hora_inicio FROM TURNO T4) AND (SELECT T5.turn_hora_inicio FROM TURNO T5)))  -- el fin de uno entre la franja de otro
				INSERT INTO TURNO(turn_descripcion, turn_hora_inicio, turn_hora_fin, turn_precio_base, turn_valor_km)						
				VALUES(@DESCRIPCION, @HORA_INICIO, @HORA_FIN, @PRECIOBASE, @VALORKM)
			ELSE RAISERROR ('Ya existen turnos en esta franja horaria', 16, 217) WITH SETERROR
		END
	ELSE
		RAISERROR ('Ya existe un turno con esa descripción', 16, 217) WITH SETERROR

END

GO
CREATE PROCEDURE CREAR_FACTURA(@CLIENTE INT, @FECHAI SMALLDATETIME, @FECHAF SMALLDATETIME)
AS
DECLARE @idFact int
DECLARE @total decimal(12,2)
BEGIN
	INSERT INTO FACTURA(fact_cliente, fact_fecha_inicio, fact_fecha_fin)
	VALUES (@CLIENTE, @FECHAI, @FECHAF)
	
	SELECT @idFact = FACT_ID
	FROM FACTURA
	WHERE fact_cliente = @CLIENTE 
	and fact_fecha_inicio = @FECHAI
	and fact_fecha_fin = @FECHAF

	INSERT INTO ITEM_FACTURA(itemf_fact, itemf_precioViaje, itemf_viaje)
	SELECT @idFact, viaj_precio, viaj_id
	FROM VIAJE
	WHERE viaj_cliente = @CLIENTE 
	and viaj_fyh_fin between @FECHAI and DATEADD(day,1,@FECHAF)

	SELECT @total= SUM(itemf_precioViaje) 
	FROM ITEM_FACTURA
	WHERE itemf_fact = @idFact

	UPDATE FACTURA SET fact_total = @total
	where fact_id = @idFact
END

GO
CREATE PROCEDURE CREAR_RENDICION(@CHOFER INT, @TOTAL DECIMAL(12,2), @TURNO INT, @FECHA INT)
AS
DECLARE @SUMA decimal(12,2)
DECLARE @REND INT
BEGIN
	IF(EXISTS(SELECT turn_id, chof_id FROM AUTO_POR_TURNO WHERE turn_id = @TURNO and chof_id = @CHOFER))
		BEGIN
		INSERT INTO RENDICION_VIAJE(pago_chofer, pago_importe_total, pago_turno, pago_fecha)
		VALUES(@CHOFER, @TOTAL, @TURNO,@FECHA)

		SELECT @REND = pago_id 
		FROM RENDICION_VIAJE 
		WHERE pago_chofer = @CHOFER
		AND pago_fecha = @FECHA
		and pago_turno = @TURNO
		and pago_importe_total = @TOTAL

		INSERT INTO ITEM_RENDICION(itemr_pago, itemr_precio, itemr_viaje)
		SELECT @REND, viaj_precio, viaj_id
		FROM VIAJE JOIN TURNO ON viaj_turno = turn_id
		WHERE viaj_chofer = @CHOFER
		AND viaj_turno = @TURNO
		AND YEAR(viaj_fyh_fin) = YEAR(@FECHA)
		and MONTH(viaj_fyh_fin) = MONTH(@FECHA) 
		and DAY(viaj_fyh_fin) = DAY(@FECHA) 
		SELECT @SUMA = SUM(itemr_precio)
		FROM ITEM_RENDICION 
		WHERE itemr_pago = @REND

		UPDATE RENDICION_VIAJE SET pago_porcentaje =  @SUMA/@TOTAL
		WHERE pago_id=@REND
		END
	ELSE
		RAISERROR ('No existe un chofer con ese auto', 16, 217) WITH SETERROR
END


/* ================================================
				  CREACION DE TRIGGERS
   ================================================
 */

GO
CREATE TRIGGER Cifrar ON Usuario AFTER INSERT AS
BEGIN
	 UPDATE USUARIO 
	 SET usua_password = HashBytes('SHA2_256',convert(nvarchar(255), u.usua_password)) 
	 FROM USUARIO u
END

/* ================================================
				        MIGRACION
   ================================================
 */
-- ROL 
INSERT INTO ROL(rol_descripcion) values('Administrador')
INSERT INTO ROL(rol_descripcion) values('Cliente')
INSERT INTO ROL(rol_descripcion) values('Chofer')

--FUNCIONALIDADES
INSERT INTO FUNCIONALIDAD(func_descripcion) values('Alta de Rol')
INSERT INTO FUNCIONALIDAD(func_descripcion) VALUES('Baja de Rol')
INSERT INTO FUNCIONALIDAD(func_descripcion) VALUES('Modificacion de Rol')
INSERT INTO FUNCIONALIDAD(func_descripcion) VALUES('Alta de Cliente')
INSERT INTO FUNCIONALIDAD(func_descripcion) VALUES('Baja de Cliente')
INSERT INTO FUNCIONALIDAD(func_descripcion) VALUES('Modificadion de Cliente')
INSERT INTO FUNCIONALIDAD(func_descripcion) VALUES('Alta de Chofer')
INSERT INTO FUNCIONALIDAD(func_descripcion) VALUES('Baja de Chofer')
INSERT INTO FUNCIONALIDAD(func_descripcion) VALUES('Modificacion de Chofer')
INSERT INTO FUNCIONALIDAD(func_descripcion) VALUES('Alta de Automovil')
INSERT INTO FUNCIONALIDAD(func_descripcion) VALUES('Baja de Automovil')
INSERT INTO FUNCIONALIDAD(func_descripcion) VALUES('Modificacion de Automovil')
INSERT INTO FUNCIONALIDAD(func_descripcion) VALUES('Alta de Turno')
INSERT INTO FUNCIONALIDAD(func_descripcion) VALUES('Baja de Turno')
INSERT INTO FUNCIONALIDAD(func_descripcion) VALUES('Modificacion de Turno')
INSERT INTO FUNCIONALIDAD(func_descripcion) VALUES('Registrar Viaje')
INSERT INTO FUNCIONALIDAD(func_descripcion) VALUES('Rendicion de Viaje')
INSERT INTO FUNCIONALIDAD(func_descripcion) VALUES('Facturacion')
INSERT INTO FUNCIONALIDAD(func_descripcion) VALUES('Generar Listados')


-- ROL_POR_FUNCIONALIDAD
INSERT INTO ROL_POR_FUNCIONALIDAD(rol_id, func_id)
values(1,1)
,(1,2)
,(1,3)
,(1,4)
,(1,5)
,(1,6)
,(1,7)
,(1,8)
,(1,9)
,(1,10)
,(1,11)
,(1,12)
,(1,13)
,(1,14)
,(1,15)
,(1,16)
,(1,17)
,(1,18)
,(1,19)

-- USUARIO
INSERT INTO USUARIO(usua_usuario, usua_password)
	   VALUES('admin', 'w23e')

--ROL POR USUARIO
INSERT INTO ROL_POR_USUARIO(rol_id, usua_id) VALUES (1,1)

-- MARCA DE AUTOS
INSERT INTO MARCA(marc_detalle) 
	SELECT m.Auto_Marca 
	FROM gd_esquema.Maestra m 
	group by m.Auto_Marca

-- TURNOS
INSERT INTO TURNO(turn_descripcion, turn_hora_inicio, turn_hora_fin,turn_precio_base, turn_valor_km) 
	SELECT m.Turno_Descripcion
	, CAST(RIGHT(RIGHT('00' + CAST(m.Turno_Hora_Inicio AS VARCHAR), 2),2)  + ':00:00' AS TIME)
	,CASE m.Turno_Hora_Fin WHEN 24 THEN CAST(RIGHT(RIGHT('00' + CAST(00 AS VARCHAR), 2),2)  + ':00:00' AS TIME)
						   ELSE CAST(RIGHT(RIGHT('00' + CAST(m.Turno_Hora_Fin AS VARCHAR), 2),2)  + ':00:00' AS TIME)
	 END
	, m.Turno_Precio_Base
	, m.Turno_Valor_Kilometro
	from gd_esquema.Maestra m 
	group by m.Turno_Descripcion, m.Turno_Hora_Inicio, m.Turno_Hora_Fin, m.Turno_Precio_Base, m.Turno_Valor_Kilometro

-- Clientes
insert into USUARIO(usua_usuario, usua_password)
	select distinct m.Cliente_Telefono, m.Cliente_Telefono
	   from gd_esquema.Maestra m

insert into DIRECCION(dire_calle)
	select distinct ma.Cliente_Direccion
	from gd_esquema.Maestra ma

insert into CLIENTE(clie_telefono, clie_nombre, clie_apellido, clie_fechaNacimiento, clie_dni, clie_mail, clie_usua, clie_direccion)
	   select distinct m.Cliente_Telefono,
	   m.Cliente_nombre, 
	   m.Cliente_Apellido, 
	   m.Cliente_Fecha_Nac, 
	   m.Cliente_Dni,
	   m.Cliente_Mail,
	  (select usua_id from USUARIO where usua_usuario = CAST(m.Cliente_Telefono as nvarchar(10))),
	  (select dire_id from DIRECCION where dire_calle = m.Cliente_Direccion)
	   from gd_esquema.Maestra m
---- 47 clientes 


---- Choferes
insert into USUARIO(usua_usuario, usua_password)
	select distinct m.Chofer_Telefono, m.Chofer_Telefono
	from gd_esquema.Maestra m

insert into DIRECCION(dire_calle)
	select distinct ma.Chofer_Direccion
	from gd_esquema.Maestra ma

insert into CHOFER(chof_telefono, chof_nombre, chof_apellido, chof_dni, chof_fechaNacimiento, chof_mail, chof_usua, chof_direccion)
	   select distinct m.Chofer_Telefono
	   , m.Chofer_Nombre
	   , m.Chofer_Apellido
	   , m.Chofer_Dni
	   , m.Chofer_Fecha_Nac
	   , m.Chofer_Mail
	   , (select usua_id from USUARIO where usua_usuario = CAST(m.Chofer_Telefono as nvarchar(10)))
	   , (select dire_id from DIRECCION where dire_calle = m.Chofer_Direccion)
	   from gd_esquema.Maestra m
--41 choferes

-- ROL POR USUARIO
insert into ROL_POR_USUARIO(usua_id, rol_id)
	   select distinct usua_id, (select rol_id from ROL where rol_descripcion like '%Cliente%')
	   from USUARIO join gd_esquema.Maestra 
	   on usua_usuario = CAST(Cliente_Telefono as nvarchar(10))

insert into ROL_POR_USUARIO(usua_id, rol_id)
	select distinct usua_id, (select rol_id from ROL where rol_descripcion like '%Chofer%')
	from USUARIO join gd_esquema.Maestra
	on usua_usuario = CAST(Chofer_telefono as nvarchar(10))


-- AUTOS
insert into AUTOMOVIL(auto_patente,auto_marca, auto_modelo)
		select distinct m.Auto_patente, (select marc_id from Marca where m.Auto_Marca = marc_detalle), m.Auto_Modelo
		from gd_esquema.Maestra m
-- 41 autos

------ Viajes
insert into VIAJE(viaj_auto, viaj_cantidad_km, viaj_fyh_inicio, viaj_fyh_fin, viaj_turno, viaj_cliente, viaj_chofer, viaj_precio)
		select isnull(au.auto_id,-1),
			   isnull(ma.Viaje_Cant_Kilometros,0),
			   isnull(ma.Viaje_Fecha, 0),
			   DATEADD(minute,5*ma.Viaje_Cant_Kilometros,ma.Viaje_Fecha),
			   isnull(tu.turn_id,-1),
			   isnull(cli.clie_id,-1),
			   isnull(cho.chof_id,-1),
			   (ma.Viaje_Cant_Kilometros * tu.turn_valor_km) + tu.turn_precio_base
		from gd_esquema.Maestra ma
		left join Automovil au on au.auto_patente = ma.Auto_Patente
		left join CHOFER cho on chof_telefono = ma.Chofer_Telefono
		left join TURNO tu on tu.turn_descripcion = ma.Turno_Descripcion
		left join CLIENTE cli on clie_telefono = ma.Cliente_Telefono
		group by au.auto_id, cho.chof_id, ma.Viaje_Cant_Kilometros, ma.Viaje_Fecha, tu.turn_id, cli.clie_id, tu.turn_valor_km, tu.turn_precio_base
-- 114039 viajes

-- Facturas
insert into FACTURA(fact_fecha_inicio, fact_fecha_fin, fact_cliente, fact_total, fact_nro_migracion)
		select ma.Factura_Fecha_Inicio
		, ma.Factura_Fecha_Fin
		, (select clie_id from CLIENTE where clie_telefono = ma.Cliente_Telefono)
		, SUM(isnull(ma.Turno_Precio_Base,0) * isnull(ma.Turno_Valor_Kilometro,0))
		, ma.Factura_Nro
		from gd_esquema.Maestra ma
		where ma.Factura_Fecha_Fin is not null
		group by ma.Factura_Nro, ma.Factura_Fecha_Inicio, ma.Factura_Fecha_Fin, ma.Cliente_Telefono
--564 facturas

---- ITEM FACTURA
insert into ITEM_FACTURA(itemf_fact, itemf_viaje, itemf_precioViaje)
		select fact_id, viaj_id, viaj_precio
		from FACTURA join VIAJE on viaj_cliente = fact_cliente
		where ((viaj_fyh_fin between fact_fecha_inicio and DATEADD(day,1,fact_fecha_fin))
		or (viaj_fyh_fin = fact_fecha_inicio)
	    or (viaj_fyh_fin = fact_fecha_fin))
		group by viaj_id, viaj_precio, fact_id
		--ver 

---- Rendiciones
insert into RENDICION_VIAJE(pago_turno, pago_fecha, pago_importe_total, pago_chofer)
	   select t.turn_id
	   , ma.Rendicion_Fecha
	   , isnull(sum(ma.Rendicion_Importe),0)
	   , c.chof_id
	   from gd_esquema.Maestra ma, TURNO t, CHOFER c 
	   where c.chof_telefono = ma.Chofer_Telefono
	   and t.turn_descripcion = ma.Turno_Descripcion
	    and rendicion_fecha is not null
	   group by ma.Rendicion_Nro, ma.Rendicion_Fecha, t.turn_id, c.chof_id
	   order by ma.Rendicion_Nro, ma.Rendicion_Fecha, t.turn_id, c.chof_id
--40198 rendiciones

--ITEM RENDICION
insert into ITEM_RENDICION(itemr_pago, itemr_precio, itemr_viaje)
	select pago_id,viaj_precio, viaj_id
	FROM VIAJE join RENDICION_VIAJE 
	on viaj_chofer = pago_chofer and viaj_turno = pago_turno 
	join TURNO on viaj_turno = turn_id
	where YEAR(viaj_fyh_inicio) = YEAR(pago_fecha)
		and MONTH(viaj_fyh_inicio) = MONTH(pago_fecha) 
		and DAY(viaj_fyh_inicio) = DAY(pago_fecha)
	group by  pago_id, viaj_id,viaj_precio
	order by pago_id

UPDATE RENDICION_VIAJE SET pago_porcentaje = (R.pago_importe_total/(Select SUM(viaj_precio) 
											  from VIAJE 
											  join TURNO on turn_id = viaj_turno
											  where viaj_chofer = r.pago_chofer
											  and viaj_turno = r.pago_turno 
											  and YEAR(viaj_fyh_inicio) = YEAR(r.pago_fecha)
											  and MONTH(viaj_fyh_inicio) = MONTH(r.pago_fecha) 
											  and DAY(viaj_fyh_inicio) = DAY(r.pago_fecha)
											))*100
FROM RENDICION_VIAJE R
