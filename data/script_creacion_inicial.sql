USE [GD1C2017]
GO

/* ================================================
					DROP DE TABLAS
   ================================================
 */
IF OBJECT_ID('RUBIRA_SANTOS.AUTO_POR_TURNO') IS NOT NULL
DROP TABLE RUBIRA_SANTOS.AUTO_POR_TURNO

IF OBJECT_ID('RUBIRA_SANTOS.ROL_POR_USUARIO') IS NOT NULL
DROP TABLE RUBIRA_SANTOS.ROL_POR_USUARIO

IF OBJECT_ID('RUBIRA_SANTOS.ROL_POR_FUNCIONALIDAD') IS NOT NULL
DROP TABLE RUBIRA_SANTOS.ROL_POR_FUNCIONALIDAD

IF OBJECT_ID('RUBIRA_SANTOS.FUNCIONALIDAD') IS NOT NULL
DROP TABLE RUBIRA_SANTOS.FUNCIONALIDAD

IF OBJECT_ID('RUBIRA_SANTOS.ITEM_FACTURA') IS NOT NULL
DROP TABLE RUBIRA_SANTOS.ITEM_FACTURA

IF OBJECT_ID('RUBIRA_SANTOS.ITEM_RENDICION') IS NOT NULL
DROP TABLE RUBIRA_SANTOS.ITEM_RENDICION

IF OBJECT_ID('RUBIRA_SANTOS.VIAJE') IS NOT NULL
DROP TABLE RUBIRA_SANTOS.VIAJE

IF OBJECT_ID('RUBIRA_SANTOS.FACTURA') IS NOT NULL
DROP TABLE RUBIRA_SANTOS.FACTURA

IF OBJECT_ID('RUBIRA_SANTOS.RENDICION_VIAJE') IS NOT NULL
DROP TABLE RUBIRA_SANTOS.RENDICION_VIAJE

IF OBJECT_ID('RUBIRA_SANTOS.CHOFER') IS NOT NULL
DROP TABLE RUBIRA_SANTOS.CHOFER

IF OBJECT_ID('RUBIRA_SANTOS.CLIENTE') IS NOT NULL
DROP TABLE RUBIRA_SANTOS.CLIENTE

IF OBJECT_ID('RUBIRA_SANTOS.ADMINISTRADOR') IS NOT NULL
DROP TABLE RUBIRA_SANTOS.ADMINISTRADOR

IF OBJECT_ID('RUBIRA_SANTOS.USUARIO') IS NOT NULL
DROP TABLE RUBIRA_SANTOS.USUARIO

IF OBJECT_ID('RUBIRA_SANTOS.ROL') IS NOT NULL
DROP TABLE RUBIRA_SANTOS.ROL

IF OBJECT_ID('RUBIRA_SANTOS.DIRECCION') IS NOT NULL
DROP TABLE RUBIRA_SANTOS.DIRECCION

IF OBJECT_ID('RUBIRA_SANTOS.AUTOMOVIL') IS NOT NULL
DROP TABLE RUBIRA_SANTOS.AUTOMOVIL

IF OBJECT_ID('RUBIRA_SANTOS.MARCA') IS NOT NULL
DROP TABLE RUBIRA_SANTOS.MARCA

IF OBJECT_ID('RUBIRA_SANTOS.TURNO') IS NOT NULL
DROP TABLE RUBIRA_SANTOS.TURNO

/* ================================================
				DROP DE PROCEDURES
   ================================================
 */

IF OBJECT_ID('RUBIRA_SANTOS.GET_ROLES') IS NOT NULL
DROP PROCEDURE RUBIRA_SANTOS.GET_ROLES

IF OBJECT_ID('RUBIRA_SANTOS.MAYOR_CONSUMO') IS NOT NULL
DROP PROCEDURE RUBIRA_SANTOS.MAYOR_CONSUMO

IF OBJECT_ID('RUBIRA_SANTOS.MAYOR_RECAUDACION') IS NOT NULL
DROP PROCEDURE RUBIRA_SANTOS.MAYOR_RECAUDACION

IF OBJECT_ID('RUBIRA_SANTOS.VIAJE_LARGO') IS NOT NULL
DROP PROCEDURE RUBIRA_SANTOS.VIAJE_LARGO

IF OBJECT_ID('RUBIRA_SANTOS.AUTO_MAS_USADO') IS NOT NULL
DROP PROCEDURE RUBIRA_SANTOS.AUTO_MAS_USADO

IF OBJECT_ID('RUBIRA_SANTOS.VIAJES_RENDICION') IS NOT NULL
DROP PROCEDURE RUBIRA_SANTOS.VIAJES_RENDICION

IF OBJECT_ID('RUBIRA_SANTOS.VIAJE_FACTURA') IS NOT NULL
DROP PROCEDURE RUBIRA_SANTOS.VIAJE_FACTURA

IF OBJECT_ID('RUBIRA_SANTOS.GET_MARCAS') IS NOT NULL
DROP PROCEDURE RUBIRA_SANTOS.GET_MARCAS

IF OBJECT_ID('RUBIRA_SANTOS.GET_FUNCIONALIDADES') IS NOT NULL
DROP PROCEDURE RUBIRA_SANTOS.GET_FUNCIONALIDADES

IF OBJECT_ID('RUBIRA_SANTOS.filtro_automovil') IS NOT NULL
DROP PROCEDURE RUBIRA_SANTOS.filtro_automovil

IF OBJECT_ID('RUBIRA_SANTOS.filtro_cliente') IS NOT NULL
DROP PROCEDURE RUBIRA_SANTOS.filtro_cliente

IF OBJECT_ID('RUBIRA_SANTOS.filtro_chofer') IS NOT NULL
DROP PROCEDURE RUBIRA_SANTOS.filtro_chofer

IF OBJECT_ID('RUBIRA_SANTOS.GET_TURNOS') IS NOT NULL
DROP PROCEDURE RUBIRA_SANTOS.GET_TURNOS

IF OBJECT_ID('RUBIRA_SANTOS.GET_TODOS_TURNOS') IS NOT NULL
DROP PROCEDURE RUBIRA_SANTOS.GET_TODOS_TURNOS

IF OBJECT_ID('RUBIRA_SANTOS.ALTA_CLIENTE') IS NOT NULL
DROP PROCEDURE RUBIRA_SANTOS.ALTA_CLIENTE

IF OBJECT_ID('RUBIRA_SANTOS.ALTA_USUARIO') IS NOT NULL
DROP PROCEDURE RUBIRA_SANTOS.ALTA_USUARIO

IF OBJECT_ID('RUBIRA_SANTOS.ALTA_CHOFER') IS NOT NULL
DROP PROCEDURE RUBIRA_SANTOS.ALTA_CHOFER

IF OBJECT_ID('RUBIRA_SANTOS.ALTA_AUTOMOVIL') IS NOT NULL
DROP PROCEDURE RUBIRA_SANTOS.ALTA_AUTOMOVIL

IF OBJECT_ID('RUBIRA_SANTOS.ALTA_ROL') IS NOT NULL
DROP PROCEDURE RUBIRA_SANTOS.ALTA_ROL

IF OBJECT_ID('RUBIRA_SANTOS.ALTA_VIAJE') IS NOT NULL
DROP PROCEDURE RUBIRA_SANTOS.ALTA_VIAJE

IF OBJECT_ID('RUBIRA_SANTOS.AGREGAR_FUNCIONALIDAD') IS NOT NULL
DROP PROCEDURE RUBIRA_SANTOS.AGREGAR_FUNCIONALIDAD

IF OBJECT_ID('RUBIRA_SANTOS.CREAR_FACTURA') IS NOT NULL
DROP PROCEDURE RUBIRA_SANTOS.CREAR_FACTURA

IF OBJECT_ID('RUBIRA_SANTOS.CREAR_RENDICION') IS NOT NULL
DROP PROCEDURE RUBIRA_SANTOS.CREAR_RENDICION

IF OBJECT_ID('RUBIRA_SANTOS.ALTA_TURNO') IS NOT NULL
DROP PROCEDURE RUBIRA_SANTOS.ALTA_TURNO

IF OBJECT_ID('RUBIRA_SANTOS.AGREGAR_ROLES') IS NOT NULL
DROP PROCEDURE RUBIRA_SANTOS.AGREGAR_ROLES

IF OBJECT_ID('RUBIRA_SANTOS.VIAJE_RENDICION') IS NOT NULL
DROP PROCEDURE RUBIRA_SANTOS.VIAJE_RENDICION

IF OBJECT_ID('RUBIRA_SANTOS.filtro_turno') IS NOT NULL
DROP PROCEDURE RUBIRA_SANTOS.filtro_turno

/* ================================================
				DROP DE TRIGGERS
   ================================================
 */

IF OBJECT_ID('RUBIRA_SANTOS.CIFRAR') IS NOT NULL
DROP TRIGGER RUBIRA_SANTOS.CIFRAR

IF OBJECT_ID('RUBIRA_SANTOS.VERIFICACION_HABILITADO') IS NOT NULL
DROP TRIGGER RUBIRA_SANTOS.VERIFICACION_HABILITADO

IF OBJECT_ID('RUBIRA_SANTOS.VIAJE_NO_PAGO') IS NOT NULL
DROP TRIGGER RUBIRA_SANTOS.VIAJE_NO_PAGO

IF OBJECT_ID('RUBIRA_SANTOS.VIAJE_NO_FACTURADO') IS NOT NULL
DROP TRIGGER RUBIRA_SANTOS.VIAJE_NO_FACTURADO

IF OBJECT_ID('RUBIRA_SANTOS.VERIFICACION_PAGO') IS NOT NULL
DROP TRIGGER RUBIRA_SANTOS.VERIFICACION_PAGO

-- DROP SCHEMA

IF EXISTS (SELECT * FROM sys.schemas WHERE name = 'RUBIRA_SANTOS')
DROP SCHEMA [RUBIRA_SANTOS]
GO

-- CREATE SCHEMA

CREATE SCHEMA [RUBIRA_SANTOS] AUTHORIZATION [gd]
GO

/* ================================================
		        CREACION DE TABLAS
   ================================================
 */
 GO
CREATE TABLE RUBIRA_SANTOS.ADMINISTRADOR(
	admi_usua int,
	admi_id int PRIMARY KEY IDENTITY (1,1)
)

CREATE TABLE RUBIRA_SANTOS.CLIENTE(
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

CREATE TABLE RUBIRA_SANTOS.CHOFER(
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

CREATE TABLE RUBIRA_SANTOS.DIRECCION(
	dire_id int PRIMARY KEY IDENTITY (1,1),
	dire_calle nvarchar(255) NOT NULL ,
	dire_depto  nvarchar(255) ,
	dire_piso  nvarchar(255) ,
	dire_localidad nvarchar(255) ,
	dire_cp nvarchar(50) ,
)

CREATE TABLE RUBIRA_SANTOS.ITEM_FACTURA(
	itemf_id int PRIMARY KEY IDENTITY (1,1),
	itemf_fact int NOT NULL,
	itemf_viaje int NOT NULL,
	itemf_precioViaje decimal(12,2) NOT NULL
)

CREATE TABLE RUBIRA_SANTOS.ITEM_RENDICION(
	itemr_id int PRIMARY KEY IDENTITY (1,1),
	itemr_pago int NOT NULL,
	itemr_viaje int NOT NULL,
	itemr_precio decimal(12,2) NOT NULL,
)

CREATE TABLE RUBIRA_SANTOS.ROL(
	rol_id int PRIMARY KEY IDENTITY (1,1),
	rol_habilitado bit DEFAULT 1, 
	rol_descripcion nvarchar(255) UNIQUE NOT NULL
)

CREATE TABLE RUBIRA_SANTOS.USUARIO(
	usua_id int PRIMARY KEY IDENTITY (1,1),
	usua_usuario nvarchar(255) NOT NULL UNIQUE,
	usua_password nvarchar(255) NOT NULL,
	usua_intentosFallidos int default 0,
	usua_habilitado bit default 1
)

CREATE TABLE RUBIRA_SANTOS.ROL_POR_USUARIO(
	rol_id int,
	usua_id int NOT NULL,
	PRIMARY KEY (rol_id, usua_id)
)

CREATE TABLE RUBIRA_SANTOS.FUNCIONALIDAD(
	func_id int PRIMARY KEY IDENTITY (1,1),
	func_descripcion nvarchar(255) NOT NULL UNIQUE
)

CREATE TABLE RUBIRA_SANTOS.ROL_POR_FUNCIONALIDAD(
	rol_id int,
	func_id int NOT NULL,
	func_habilitada bit DEFAULT 1,
	PRIMARY KEY(rol_id, func_id)	
)

CREATE TABLE RUBIRA_SANTOS.TURNO(
	turn_id int PRIMARY KEY IDENTITY (1,1),
	turn_hora_inicio time NOT NULL,
	turn_hora_fin time NOT NULL,
	turn_descripcion nvarchar(255) NOT NULL UNIQUE,
	turn_valor_km decimal(12,2) NOT NULL,
	turn_precio_base decimal(12,2) NOT NULL,
	turn_habilitado bit DEFAULT 1 NOT NULL
)

CREATE TABLE RUBIRA_SANTOS.VIAJE(
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

CREATE TABLE RUBIRA_SANTOS.AUTOMOVIL(
	auto_id int PRIMARY KEY IDENTITY (1,1),
	auto_patente nvarchar(255) NOT NULL UNIQUE,
	auto_marca int NOT NULL,
	auto_modelo nvarchar(255) NOT NULL,
	auto_habilitado bit DEFAULT 1
)

CREATE TABLE RUBIRA_SANTOS.AUTO_POR_TURNO(
	auto_id int NOT NULL,
	turn_id int NOT NULL,
	PRIMARY KEY(AUTO_ID, TURN_ID),
	turn_turnoActivo int NOT NULL,
	chof_id int NOT NULL
)

CREATE TABLE RUBIRA_SANTOS.MARCA(
	marc_id int PRIMARY KEY IDENTITY (1,1),
	marc_detalle nvarchar(255) NOT NULL UNIQUE
)

CREATE TABLE RUBIRA_SANTOS.RENDICION_VIAJE(
	pago_id int PRIMARY KEY IDENTITY (1,1),
	pago_fecha smalldatetime NOT NULL,
	pago_importe_total decimal(12,2) NOT NULL,
	pago_turno int NOT NULL,
	pago_chofer int NOT NULL,
	pago_porcentaje decimal(12,2)
)

CREATE TABLE RUBIRA_SANTOS.FACTURA(
	fact_id int PRIMARY KEY IDENTITY (1,1),
	fact_fecha_inicio smalldatetime NOT NULL,
	fact_fecha_fin smalldatetime NOT NULL,
	fact_total decimal(12,2) NOT NULL,
	fact_cliente int NOT NULL
)

/* ================================================
		          AGREGADO DE FKS
   ================================================
 */
ALTER TABLE RUBIRA_SANTOS.ITEM_FACTURA ADD FOREIGN KEY(itemf_fact) REFERENCES RUBIRA_SANTOS.FACTURA
ALTER TABLE RUBIRA_SANTOS.ITEM_FACTURA ADD FOREIGN KEY(itemf_viaje) REFERENCES RUBIRA_SANTOS.VIAJE
ALTER TABLE RUBIRA_SANTOS.ITEM_RENDICION ADD FOREIGN KEY(itemr_pago) REFERENCES RUBIRA_SANTOS.RENDICION_VIAJE
ALTER TABLE RUBIRA_SANTOS.ITEM_RENDICION ADD FOREIGN KEY(itemr_viaje) REFERENCES RUBIRA_SANTOS.VIAJE
ALTER TABLE RUBIRA_SANTOS.ADMINISTRADOR ADD FOREIGN KEY (admi_usua) REFERENCES RUBIRA_SANTOS.USUARIO
ALTER TABLE RUBIRA_SANTOS.CHOFER ADD FOREIGN KEY (chof_usua) REFERENCES RUBIRA_SANTOS.USUARIO
ALTER TABLE RUBIRA_SANTOS.CLIENTE ADD FOREIGN KEY (clie_usua) REFERENCES RUBIRA_SANTOS.USUARIO
ALTER TABLE RUBIRA_SANTOS.CHOFER ADD FOREIGN KEY(chof_direccion) REFERENCES RUBIRA_SANTOS.DIRECCION
ALTER TABLE RUBIRA_SANTOS.CLIENTE ADD FOREIGN KEY(clie_direccion) REFERENCES RUBIRA_SANTOS.DIRECCION
ALTER TABLE RUBIRA_SANTOS.ROL_POR_USUARIO ADD FOREIGN KEY (rol_id) REFERENCES RUBIRA_SANTOS.ROL
ALTER TABLE RUBIRA_SANTOS.ROL_POR_USUARIO ADD FOREIGN KEY (usua_id) REFERENCES RUBIRA_SANTOS.USUARIO
ALTER TABLE RUBIRA_SANTOS.ROL_POR_FUNCIONALIDAD ADD FOREIGN KEY (rol_id) REFERENCES RUBIRA_SANTOS.ROL
ALTER TABLE RUBIRA_SANTOS.ROL_POR_FUNCIONALIDAD ADD FOREIGN KEY (func_id) REFERENCES RUBIRA_SANTOS.FUNCIONALIDAD
ALTER TABLE RUBIRA_SANTOS.VIAJE ADD FOREIGN KEY (viaj_cliente) REFERENCES RUBIRA_SANTOS.USUARIO
ALTER TABLE RUBIRA_SANTOS.VIAJE ADD FOREIGN KEY (viaj_turno) REFERENCES RUBIRA_SANTOS.TURNO
ALTER TABLE RUBIRA_SANTOS.VIAJE ADD FOREIGN KEY (viaj_chofer) REFERENCES RUBIRA_SANTOS.CHOFER
ALTER TABLE RUBIRA_SANTOS.VIAJE ADD FOREIGN KEY (viaj_auto) REFERENCES RUBIRA_SANTOS.AUTOMOVIL
ALTER TABLE RUBIRA_SANTOS.AUTOMOVIL ADD FOREIGN KEY (auto_marca) REFERENCES RUBIRA_SANTOS.MARCA
ALTER TABLE RUBIRA_SANTOS.RENDICION_VIAJE ADD FOREIGN KEY(pago_chofer) REFERENCES RUBIRA_SANTOS.CHOFER
ALTER TABLE RUBIRA_SANTOS.RENDICION_VIAJE ADD FOREIGN KEY (pago_turno) REFERENCES RUBIRA_SANTOS.TURNO
ALTER TABLE RUBIRA_SANTOS.FACTURA ADD FOREIGN KEY (fact_cliente) REFERENCES RUBIRA_SANTOS.USUARIO
ALTER TABLE RUBIRA_SANTOS.AUTO_POR_TURNO ADD FOREIGN KEY (auto_id) REFERENCES RUBIRA_SANTOS.AUTOMOVIL
ALTER TABLE RUBIRA_SANTOS.AUTO_POR_TURNO ADD FOREIGN KEY (turn_id) REFERENCES RUBIRA_SANTOS.TURNO
ALTER TABLE RUBIRA_SANTOS.AUTO_POR_TURNO ADD FOREIGN KEY (chof_id) REFERENCES RUBIRA_SANTOS.CHOFER

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
CREATE PROCEDURE RUBIRA_SANTOS.GET_MARCAS
AS 
BEGIN 
	SELECT marc_id, marc_detalle
	FROM RUBIRA_SANTOS.MARCA
end

GO
CREATE PROCEDURE RUBIRA_SANTOS.GET_ROLES(@DESCRIPCION NVARCHAR(250))
AS
BEGIN
	SELECT rol_id, rol_habilitado,rol_descripcion
	FROM RUBIRA_SANTOS.ROL
	WHERE rol_descripcion = '' OR rol_descripcion LIKE '%'+ @DESCRIPCION + '%'
END
GO
CREATE PROCEDURE RUBIRA_SANTOS.GET_TODOS_TURNOS
AS
BEGIN
	SELECT turn_id, turn_descripcion
	FROM RUBIRA_SANTOS.TURNO
	WHERE turn_habilitado = 1
end

GO 
CREATE PROCEDURE RUBIRA_SANTOS.GET_TURNOS
AS 
BEGIN 
	SELECT turn_id, turn_descripcion
	FROM RUBIRA_SANTOS.TURNO
	WHERE turn_habilitado = 1
end

GO
CREATE PROCEDURE RUBIRA_SANTOS.GET_FUNCIONALIDADES
AS
BEGIN
	SELECT func_id, func_descripcion 
	FROM RUBIRA_SANTOS.FUNCIONALIDAD
END

GO
CREATE PROCEDURE RUBIRA_SANTOS.VIAJES_RENDICION(@CHOFER INT, @TURNO INT, @FECHA SMALLDATETIME)
AS
BEGIN
	SELECT DISTINCT v.viaj_id, c.clie_nombre + ' ' + c.clie_apellido CLIENTE, v.viaj_fyh_inicio INICIO, v.viaj_fyh_fin FIN, t.turn_descripcion TURNO, v.viaj_cantidad_km CANTIDAD_KM, a.auto_patente AUTO_PATENTE,v.viaj_precio VIAJE_PRECIO
	FROM RUBIRA_SANTOS.VIAJE v
	JOIN RUBIRA_SANTOS.AUTO_POR_TURNO apt ON apt.turn_turnoActivo = v.viaj_turno AND v.viaj_chofer = apt.chof_id AND v.viaj_auto = apt.auto_id
	JOIN RUBIRA_SANTOS.CLIENTE c ON v.viaj_cliente = c.clie_id
	JOIN RUBIRA_SANTOS.TURNO t ON t.turn_id = v.viaj_turno
	JOIN RUBIRA_SANTOS.AUTOMOVIL a ON a.auto_id = apt.auto_id
	WHERE viaj_chofer = @CHOFER
	AND viaj_turno = @TURNO
	AND YEAR(viaj_fyh_fin) = YEAR(@FECHA) 
	AND MONTH(viaj_fyh_fin) = MONTH(@FECHA)
	AND DAY(viaj_fyh_fin) = DAY(@FECHA)
END
SELECT * FROM RUBIRA_SANTOS.AUTO_POR_TURNO
GO
CREATE PROCEDURE RUBIRA_SANTOS.ALTA_CLIENTE(@NOMBRE nvarchar(255), @APELLIDO nvarchar(255), @DNI bigint, @TELEFONO bigint, @MAIL nvarchar(255), @FECHA_NACIMIENTO smalldatetime, @CALLE nvarchar(255), @PISO nvarchar(255), @DPTO nvarchar(255), @LOCALIDAD nvarchar(255), @CP nvarchar(255))
AS
BEGIN
	DECLARE @iddirec int
	DECLARE @USUA INT
	IF(NOT EXISTS (SELECT * FROM RUBIRA_SANTOS.CLIENTE WHERE clie_telefono = @TELEFONO))
		BEGIN
			INSERT INTO RUBIRA_SANTOS.DIRECCION(dire_calle, dire_depto, dire_piso, dire_localidad, dire_cp)
			VALUES(@CALLE, @DPTO, @PISO, @LOCALIDAD, @CP)
		
			SELECT @iddirec = dire_id 
			FROM RUBIRA_SANTOS.DIRECCION 
			WHERE dire_calle = @CALLE 
			AND dire_cp= @CP 
			AND dire_depto = @DPTO
			AND dire_localidad = @LOCALIDAD
			AND dire_piso = @PISO
			
			INSERT INTO RUBIRA_SANTOS.CLIENTE(clie_nombre, clie_apellido, clie_dni, clie_fechaNacimiento, clie_mail, clie_telefono,clie_direccion)
			VALUES(@nombre,UPPER(@APELLIDO), @DNI, CAST(@FECHA_NACIMIENTO AS smalldatetime), @MAIL, @TELEFONO, @iddirec)

			IF(NOT EXISTS(SELECT * FROM RUBIRA_SANTOS.USUARIO WHERE usua_usuario = @TELEFONO))
				INSERT INTO RUBIRA_SANTOS.USUARIO(usua_usuario, usua_password)
				VALUES(@TELEFONO, @TELEFONO)
			
			SELECT usua_id = @USUA FROM RUBIRA_SANTOS.USUARIO WHERE usua_usuario = @TELEFONO
			INSERT INTO RUBIRA_SANTOS.ROL_POR_USUARIO(rol_id, usua_id)
			values((SELECT rol_id FROM RUBIRA_SANTOS.ROL WHERE rol_descripcion LIKE '%Cliente%'),@USUA)
		END
	ELSE
		RAISERROR ('El cliente ya existe', 16, 217) WITH SETERROR
END

GO
CREATE PROCEDURE RUBIRA_SANTOS.ALTA_CHOFER(@NOMBRE nvarchar(255), @APELLIDO nvarchar(255), @DNI bigint, @MAIL nvarchar(255), @TELEFONO bigint, @FECHA_NACIMIENTO smalldatetime, @CALLE nvarchar(255), @PISO nvarchar(255), @DPTO nvarchar(255), @LOCALIDAD nvarchar(255), @CP nvarchar(255))
AS
BEGIN
	DECLARE @iddirec int
	DECLARE @USUA INT
	IF (NOT EXISTS (SELECT * FROM RUBIRA_SANTOS.CHOFER WHERE CHOF_TELEFONO = @TELEFONO))
		BEGIN
			INSERT INTO RUBIRA_SANTOS.DIRECCION(dire_calle, dire_cp, dire_depto, dire_localidad, dire_piso)
			VALUES(@CALLE, @CP, @DPTO, @LOCALIDAD, @PISO)
		
			SELECT @iddirec= dire_id 
			FROM RUBIRA_SANTOS.DIRECCION 
			WHERE dire_calle = @CALLE 
			AND dire_cp= @CP 
			AND dire_depto = @DPTO
			AND dire_localidad = @LOCALIDAD
			AND dire_piso = @PISO

			INSERT INTO RUBIRA_SANTOS.CHOFER(chof_nombre, chof_apellido, chof_dni, chof_mail, chof_telefono, chof_fechaNacimiento,chof_direccion) 
			VALUES(@NOMBRE, UPPER(@APELLIDO), @DNI, @MAIL, @TELEFONO, CAST(@FECHA_NACIMIENTO AS SMALLDATETIME),@iddirec)
			
			IF(NOT EXISTS(SELECT * FROM RUBIRA_SANTOS.USUARIO WHERE usua_usuario = @TELEFONO))
				INSERT INTO RUBIRA_SANTOS.USUARIO(usua_usuario, usua_password)
				VALUES(@TELEFONO, @TELEFONO)
			
			SELECT usua_id = @USUA FROM RUBIRA_SANTOS.USUARIO WHERE usua_usuario = @TELEFONO

			INSERT INTO RUBIRA_SANTOS.ROL_POR_USUARIO(rol_id, usua_id)
			values((SELECT rol_id FROM RUBIRA_SANTOS.ROL WHERE rol_descripcion LIKE '%Chofer%'),@USUA)
		END
	ELSE
		 RAISERROR ('El chofer ya existe', 16, 217) WITH SETERROR
END

GO
CREATE PROCEDURE RUBIRA_SANTOS.ALTA_AUTOMOVIL(@MARCA INT, @MODELO nvarchar(255), @PATENTE nvarchar(255), @TURNO int, @CHOFER INT)
AS 
BEGIN 
	DECLARE @AUTOID int
	IF(NOT EXISTS(SELECT * FROM RUBIRA_SANTOS.AUTOMOVIL WHERE auto_patente = @PATENTE))
		IF(NOT EXISTS(SELECT * FROM RUBIRA_SANTOS.AUTO_POR_TURNO apt JOIN RUBIRA_SANTOS.AUTOMOVIL a ON apt.auto_id = a.auto_id
					 WHERE chof_id = @CHOFER AND a.auto_habilitado = 1))
			BEGIN
				INSERT INTO RUBIRA_SANTOS.AUTOMOVIL(auto_patente, auto_modelo, auto_marca)
				VALUES(@PATENTE, @MODELO, @MARCA)
				
				SELECT @AUTOID = auto_id FROM RUBIRA_SANTOS.AUTOMOVIL WHERE auto_patente = @PATENTE
				
				INSERT INTO RUBIRA_SANTOS.AUTO_POR_TURNO(auto_id, chof_id, turn_id, turn_turnoActivo)
				VALUES(@AUTOID, @CHOFER, @TURNO, @TURNO)
			END
		ELSE
			RAISERROR ('El chofer ya tiene asignado un auto habilitado', 16, 217) WITH SETERROR
	ELSE
		RAISERROR ('El auto ya existe', 16, 217) WITH SETERROR
END

GO
CREATE PROCEDURE RUBIRA_SANTOS.ALTA_VIAJE(@CANTIDADKM INT,@FECHAINICIO smalldatetime ,@FECHAFIN smalldatetime, @TURNO INT, @AUTO INT, @CHOFER INT, @CLIENT INT)
AS
BEGIN
	IF(NOT EXISTS(SELECT * FROM RUBIRA_SANTOS.VIAJE WHERE viaj_cliente = @CLIENT AND viaj_fyh_inicio = @FECHAINICIO))
		IF(EXISTS (SELECT auto_id, chof_id, turn_id FROM RUBIRA_SANTOS.AUTO_POR_TURNO WHERE auto_id = @AUTO AND chof_id = @CHOFER AND turn_turnoActivo = @TURNO))
			INSERT INTO RUBIRA_SANTOS.VIAJE(viaj_auto, viaj_cantidad_km, viaj_chofer, viaj_cliente, viaj_fyh_inicio, viaj_fyh_fin, viaj_turno, viaj_precio)
			VALUES(@AUTO, @CANTIDADKM, @CHOFER, @CLIENT, @FECHAINICIO ,@FECHAFIN, @TURNO, (SELECT (@CANTIDADKM * t.turn_valor_km + t.turn_precio_base) FROM RUBIRA_SANTOS.TURNO t WHERE t.turn_id = @TURNO))
		ELSE
			RAISERROR ('No existe un chofer con ese auto en ese turno', 16, 217) WITH SETERROR	
	ELSE
		RAISERROR('Ya existe un viaje para este cliente en esta fecha y horario', 16, 217) WITH SETERROR
END

GO
CREATE PROCEDURE RUBIRA_SANTOS.ALTA_ROL(@DESCRIPCION NVARCHAR(255))
AS
BEGIN
	IF(NOT EXISTS (SELECT * FROM RUBIRA_SANTOS.ROL WHERE rol_descripcion = @DESCRIPCION))
		BEGIN 
		INSERT INTO RUBIRA_SANTOS.ROL(rol_descripcion)
		VALUES(@DESCRIPCION)
		END
	ELSE 
		RAISERROR ('El rol ya existe', 16, 217) WITH SETERROR
END

GO
CREATE PROCEDURE RUBIRA_SANTOS.ALTA_USUARIO(@USUARIO nvarchar(255), @CONTRA nvarchar(255))
AS
BEGIN
	IF(NOT EXISTS(SELECT * FROM RUBIRA_SANTOS.USUARIO WHERE usua_usuario = @USUARIO))
		INSERT INTO RUBIRA_SANTOS.USUARIO(usua_usuario, usua_password)
		VALUES(@USUARIO, @CONTRA)
	ELSE
		RAISERROR('Ya existe ese usuario', 16, 217) WITH SETERROR
END

GO
CREATE PROCEDURE RUBIRA_SANTOS.AGREGAR_ROLES(@USUARIO INT, @ROL INT)
AS
BEGIN
	INSERT INTO RUBIRA_SANTOS.ROL_POR_USUARIO(rol_id, usua_id)
	VALUES(@ROL, @USUARIO)
END

GO
CREATE PROCEDURE RUBIRA_SANTOS.AGREGAR_FUNCIONALIDAD(@FUNCIONALIDAD int, @ROL int)
AS
BEGIN 
	INSERT INTO RUBIRA_SANTOS.ROL_POR_FUNCIONALIDAD(rol_id, func_id) 
	VALUES(@ROL, @FUNCIONALIDAD)
END

GO
CREATE PROCEDURE RUBIRA_SANTOS.ALTA_TURNO(@DESCRIPCION NVARCHAR(255), @HORA_INICIO NVARCHAR(255), @HORA_FIN NVARCHAR(255), @PRECIOBASE decimal(12,2), @VALORKM decimal(12,2))
AS
BEGIN
	DECLARE C1 CURSOR FOR (SELECT turn_hora_inicio, turn_hora_fin, turn_habilitado FROM RUBIRA_SANTOS.TURNO)
	DECLARE @INICIO TIME, @FIN TIME, @HABILITADO INT, @NO_PUEDE_EXISTIR INT
	SET @HORA_INICIO = CAST(@HORA_INICIO AS time)
	SET @HORA_FIN = CAST(@HORA_FIN AS time)
	SET @NO_PUEDE_EXISTIR = 0
	IF(@HORA_FIN > @HORA_INICIO)
	BEGIN
		IF(NOT EXISTS(SELECT * FROM RUBIRA_SANTOS.TURNO WHERE turn_descripcion = @DESCRIPCION))
			BEGIN
				OPEN C1
				FETCH NEXT FROM C1 INTO @INICIO, @FIN, @HABILITADO
				WHILE @@FETCH_STATUS = 0
					BEGIN
						IF(@HABILITADO = 1 
							AND((@HORA_INICIO > @INICIO AND @HORA_FIN < @FIN) -- FRANJA NUEVA ABARCA UNA EXISTENTE
							OR (@HORA_INICIO < @INICIO AND @HORA_FIN > @FIN ) --FRANJA EXISTENTE ABARCA A LA NUEVA
							OR (@HORA_INICIO > @INICIO AND @HORA_INICIO < @FIN) -- SE SOLAPA
							OR (@HORA_FIN > @INICIO AND @HORA_FIN < @FIN) --SE SOLAPA
							))
							SET @NO_PUEDE_EXISTIR = 1
						FETCH NEXT FROM C1 INTO @INICIO, @FIN, @HABILITADO
						END
					CLOSE C1
					DEALLOCATE C1
				IF(@NO_PUEDE_EXISTIR = 0)
					INSERT INTO RUBIRA_SANTOS.TURNO(turn_descripcion, turn_hora_inicio, turn_hora_fin, turn_precio_base, turn_valor_km)						
					VALUES(@DESCRIPCION, @HORA_INICIO, @HORA_FIN, @PRECIOBASE, @VALORKM)
				ELSE RAISERROR ('Ya existen turnos en esta franja horaria', 16, 217) WITH SETERROR
			END
		ELSE
			RAISERROR ('Ya existe un turno con esa descripción', 16, 217) WITH SETERROR
		END
	ELSE 
		RAISERROR('El turno debe comenzar y finalizar en el mismo día', 16, 217) WITH SETERROR
END

GO
CREATE PROCEDURE RUBIRA_SANTOS.CREAR_FACTURA(@CLIENT INT, @FECHAI SMALLDATETIME, @FECHAF SMALLDATETIME, @TOTAL decimal(12,2))
AS
DECLARE @idFact int
BEGIN
	IF(NOT EXISTS(SELECT * FROM RUBIRA_SANTOS.FACTURA WHERE fact_fecha_inicio = @FECHAI AND fact_fecha_fin = @FECHAF AND @CLIENT = fact_cliente))
		BEGIN
			INSERT INTO RUBIRA_SANTOS.FACTURA(fact_cliente, fact_fecha_inicio, fact_fecha_fin, fact_total)
			VALUES (@CLIENT, @FECHAI, @FECHAF, @TOTAL)
			
			SELECT @idFact = FACT_ID
			FROM RUBIRA_SANTOS.FACTURA
			WHERE fact_cliente = @CLIENT 
			AND fact_fecha_inicio = @FECHAI
			AND fact_fecha_fin = @FECHAF
			AND fact_total = @TOTAL

			INSERT INTO RUBIRA_SANTOS.ITEM_FACTURA(itemf_fact, itemf_precioViaje, itemf_viaje)
			SELECT @idFact, viaj_precio, viaj_id
			FROM RUBIRA_SANTOS.VIAJE
			WHERE viaj_cliente = @CLIENT 
			AND viaj_fyh_fin BETWEEN @FECHAI AND DATEADD(day,1,@FECHAF)
		END
	ELSE
		RAISERROR ('Ya existe una factura para este cliente en dicha fecha', 16, 217) WITH SETERROR
END

GO
CREATE PROCEDURE RUBIRA_SANTOS.CREAR_RENDICION(@CHOFER INT, @TOTAL DECIMAL(12,2), @TURNO INT, @FECHA smalldatetime, @PORCENTAJE decimal(12,2))
AS
DECLARE @REND INT
BEGIN
	IF(EXISTS(SELECT turn_id, chof_id FROM RUBIRA_SANTOS.AUTO_POR_TURNO WHERE turn_turnoActivo = @TURNO AND chof_id = @CHOFER))
		BEGIN
		INSERT INTO RUBIRA_SANTOS.RENDICION_VIAJE(pago_chofer, pago_importe_total, pago_turno, pago_fecha,pago_porcentaje)
		VALUES(@CHOFER, @TOTAL, @TURNO,@FECHA, @PORCENTAJE)

		SELECT @REND = pago_id 
		FROM RUBIRA_SANTOS.RENDICION_VIAJE 
		WHERE pago_chofer = @CHOFER
		AND pago_fecha = @FECHA
		AND pago_turno = @TURNO
		AND pago_importe_total = @TOTAL

		INSERT INTO RUBIRA_SANTOS.ITEM_RENDICION(itemr_pago, itemr_precio, itemr_viaje)
		SELECT @REND, viaj_precio, viaj_id
		FROM RUBIRA_SANTOS.VIAJE JOIN RUBIRA_SANTOS.TURNO ON viaj_turno = turn_id
		WHERE viaj_chofer = @CHOFER
		AND viaj_turno = @TURNO
		AND YEAR(viaj_fyh_fin) = YEAR(@FECHA)
		AND MONTH(viaj_fyh_fin) = MONTH(@FECHA) 
		AND DAY(viaj_fyh_fin) = DAY(@FECHA) 
		END
	ELSE
		RAISERROR ('No existe un chofer con ese auto', 16, 217) WITH SETERROR
END

/* ================================================
				  CREACION DE TRIGGERS
   ================================================
 */

GO
CREATE TRIGGER Cifrar ON RUBIRA_SANTOS.Usuario AFTER INSERT AS
BEGIN
	UPDATE RUBIRA_SANTOS.USUARIO 
	SET usua_password = HashBytes('SHA2_256',convert(nvarchar(255), u.usua_password)) 
	FROM RUBIRA_SANTOS.USUARIO u
END

/*
=================================================
				BUSQUEDA PROCEDURES
=================================================
*/

GO
CREATE PROCEDURE RUBIRA_SANTOS.VIAJE_FACTURA(@FECHAI smalldatetime, @FECHAF smalldatetime, @CLIENT int)
AS
BEGIN
	SELECT v.viaj_id, v.viaj_fyh_inicio VIAJE_INICIO, v.viaj_fyh_fin VIAJE_FIN, t.turn_descripcion TURNO, c.chof_nombre + ' ' + c.chof_apellido NOMBRE_CHOFER, a.auto_patente AUTO_PATENTE, v.viaj_cantidad_km CANTIDAD_KM,v.viaj_precio PRECIO
	FROM RUBIRA_SANTOS.VIAJE v 
	JOIN RUBIRA_SANTOS.TURNO t ON t.turn_id = v.viaj_turno
	JOIN RUBIRA_SANTOS.CHOFER c ON c.chof_id = v.viaj_chofer
	JOIN RUBIRA_SANTOS.AUTOMOVIL a ON a.auto_id = v.viaj_auto
	WHERE v.viaj_cliente = @CLIENT
		AND v.viaj_fyh_fin BETWEEN @FECHAI AND @FECHAF
END

GO
CREATE PROCEDURE filtro_cliente(@nombre varchar(255), @apellido varchar(255), @dni bigint)
AS
BEGIN
	SELECT c.clie_id, c.clie_nombre Nombre, c.clie_apellido Apellido, c.clie_dni DNI, c.clie_fechaNacimiento Fecha_Nacimiento, c.clie_mail Mail, c.clie_telefono Tel�fono, d.dire_calle Direcci�n, d.dire_localidad Localidad, d.dire_cp C�digo_Postal, c.clie_habilitado Habilitado
	FROM RUBIRA_SANTOS.CLIENTE c join RUBIRA_SANTOS.DIRECCION d 
	ON c.clie_direccion = d.dire_id
	WHERE (@nombre = '' OR c.clie_nombre LIKE '%' + @nombre + '%') AND
		(@apellido = '' OR c.clie_apellido LIKE '%' + @apellido + '%') AND
		(@dni = 0 OR @dni = c.clie_dni)
END

go
CREATE PROCEDURE RUBIRA_SANTOS.filtro_automovil(@marca int, @modelo varchar(255), @patente varchar(10) , @chofer int)
AS
BEGIN
	SELECT DISTINCT a.auto_id, a.auto_marca MARCA, a.auto_modelo MODELO, a.auto_patente PATENTE, tu.turn_descripcion TURNO
	FROM RUBIRA_SANTOS.AUTOMOVIL a JOIN RUBIRA_SANTOS.AUTO_POR_TURNO t ON a.auto_id = t.auto_id
	JOIN RUBIRA_SANTOS.TURNO tu ON tu.turn_id = t.turn_turnoActivo
	WHERE (@marca = 0 OR @marca = a.auto_marca) AND
		(@modelo = '' OR a.auto_modelo LIKE '%' + @modelo + '%') AND
		(@patente = '' OR a.auto_patente LIKE '%' + @patente + '%') AND
		(@chofer = 0 OR @chofer = t.chof_id)
END

go
CREATE PROCEDURE RUBIRA_SANTOS.filtro_turno(@descripcion varchar(255))
AS
BEGIN
	SELECT t.turn_descripcion DESCRIPCION, t.turn_hora_inicio HORA_INICIO , t.turn_hora_fin HORA_FIN, t.turn_precio_base PRECIO_BASE, t.turn_valor_km VALOR_KM
	FROM RUBIRA_SANTOS.TURNO t
	WHERE @descripcion = '' OR
		t.turn_descripcion LIKE '%' + @descripcion + '%'
END

go
CREATE PROCEDURE filtro_chofer(@nombre varchar(255), @apellido varchar(255), @dni bigint)
AS
BEGIN
	SELECT DISTINCT c.chof_id, c.chof_nombre Nombre, c.chof_apellido Apellido, c.chof_dni DNI, c.chof_mail Mail, c.chof_telefono Tel�fono, c.chof_fechaNacimiento Fecha_Nacimiento,
	d.dire_calle Direcci�n, d.dire_localidad Localidad, d.dire_cp C�digo_Postal, c.chof_habilitado Habilitado, a.turn_turnoActivo, a.auto_id
	FROM RUBIRA_SANTOS.CHOFER c
	JOIN RUBIRA_SANTOS.DIRECCION d ON d.dire_id = c.chof_direccion
	JOIN RUBIRA_SANTOS.AUTO_POR_TURNO a ON a.chof_id = c.chof_id
	WHERE (@nombre = '' OR c.chof_nombre LIKE '%' + @nombre + '%') AND
		(@apellido = '' OR c.chof_apellido LIKE '%' + @apellido + '%') AND
		(@dni = 0 OR @dni = c.chof_dni)
END


/* ================================================
			PROCEDURES LISTADOS ESTADISTICOS
   ================================================
 */
GO
CREATE PROCEDURE RUBIRA_SANTOS.MAYOR_RECAUDACION(@FECHA_INICIO smalldatetime, @FECHAFIN smalldatetime)
AS
BEGIN
	SELECT TOP 5 c.chof_nombre + ' ' + c.chof_apellido CHOFER, c.chof_fechaNacimiento FECHA_NACIMIENTO, c.chof_telefono TELEFONO, c.chof_mail MAIL, DIRE_CALLE DIRECCION, SUM(r.pago_importe_total) RECAUDACION_TOTAL
	FROM RUBIRA_SANTOS.CHOFER c JOIN RUBIRA_SANTOS.DIRECCION ON c.chof_direccion = dire_id
	JOIN RUBIRA_SANTOS.RENDICION_VIAJE r ON r.pago_chofer = c.chof_id
	WHERE r.pago_fecha BETWEEN @FECHA_INICIO AND @FECHAFIN
	GROUP BY c.chof_id, c.chof_nombre ,c.chof_apellido , c.chof_fechaNacimiento , c.chof_telefono , c.chof_mail , DIRE_CALLE 
	ORDER BY SUM(pago_importe_total) desc
END

GO 
CREATE PROCEDURE RUBIRA_SANTOS.VIAJE_LARGO(@FECHA_INICIO smalldatetime, @FECHAFIN smalldatetime)
AS
BEGIN
	SELECT TOP 5 c.chof_nombre + ' ' + c.chof_apellido CHOFER, c.chof_fechaNacimiento FECHA_NACIMIENTO, c.chof_telefono TELEFONO, c.chof_mail MAIL, dire_calle DIRECCION, viaj_cantidad_km
	FROM RUBIRA_SANTOS.VIAJE JOIN RUBIRA_SANTOS.CHOFER c ON viaj_chofer = c.chof_id
	JOIN RUBIRA_SANTOS.DIRECCION ON c.chof_direccion = dire_id
	WHERE viaj_fyh_fin BETWEEN @FECHA_INICIO AND @FECHAFIN
	ORDER BY viaj_cantidad_km desc
END

GO
CREATE PROCEDURE RUBIRA_SANTOS.MAYOR_CONSUMO(@FECHA_INICIO smalldatetime, @FECHAFIN smalldatetime)
AS
BEGIN
	SELECT TOP 5 C.clie_nombre + ' ' + clie_apellido CLIENTE, C.clie_fechaNacimiento FECHA_NACIMIENTO, c.clie_dni, C.clie_telefono, d.dire_calle, SUM(F.fact_total)
	FROM RUBIRA_SANTOS.CLIENTE C
	JOIN RUBIRA_SANTOS.FACTURA  F ON F.fact_cliente = C.clie_id 
	JOIN RUBIRA_SANTOS.DIRECCION D ON D.dire_id = C.clie_direccion
	WHERE f.fact_fecha_inicio>= @FECHA_INICIO AND fact_fecha_fin <= @FECHAFIN
	GROUP BY C.clie_id, C.clie_nombre + ' ' + clie_apellido, C.clie_fechaNacimiento , c.clie_dni, C.clie_telefono, d.dire_calle
	ORDER BY  SUM(F.fact_total)
END

GO
CREATE PROCEDURE RUBIRA_SANTOS.AUTO_MAS_USADO(@FECHA_INICIO smalldatetime, @FECHAFIN smalldatetime)
AS
BEGIN
	SELECT TOP 5 C.clie_nombre + ' ' + clie_apellido CLIENTE, C.clie_fechaNacimiento FECHA_NACIMIENTO, c.clie_dni DNI, C.clie_telefono TELEFONO, d.dire_calle DIRECCION, A.auto_patente PATENTE_AUTO,COUNT(*) VECES_QUE_USO_MISMO_AUTO
	FROM RUBIRA_SANTOS.CLIENTE C
	JOIN RUBIRA_SANTOS.VIAJE V ON V.viaj_cliente = C.clie_id
	JOIN RUBIRA_SANTOS.DIRECCION D ON D.dire_id = C.clie_direccion
	JOIN RUBIRA_SANTOS.AUTOMOVIL A ON A.auto_id = V.viaj_auto
	WHERE viaj_fyh_fin BETWEEN @FECHA_INICIO AND @FECHAFIN
	GROUP BY C.clie_id, C.clie_nombre + ' ' + clie_apellido, C.clie_fechaNacimiento , c.clie_dni, C.clie_telefono, d.dire_calle, A.auto_patente
	ORDER BY COUNT(*) DESC
END

/* ================================================
				        MIGRACION
   ================================================
 */
 GO
-- ROL 
INSERT INTO RUBIRA_SANTOS.ROL(rol_descripcion) values('Administrador')
INSERT INTO RUBIRA_SANTOS.ROL(rol_descripcion) values('Cliente')
INSERT INTO RUBIRA_SANTOS.ROL(rol_descripcion) values('Chofer')

--FUNCIONALIDADES
INSERT INTO RUBIRA_SANTOS.FUNCIONALIDAD(func_descripcion) values('Alta de Rol')
INSERT INTO RUBIRA_SANTOS.FUNCIONALIDAD(func_descripcion) VALUES('Baja de Rol')
INSERT INTO RUBIRA_SANTOS.FUNCIONALIDAD(func_descripcion) VALUES('Modificacion de Rol')
INSERT INTO RUBIRA_SANTOS.FUNCIONALIDAD(func_descripcion) VALUES('Alta de Cliente')
INSERT INTO RUBIRA_SANTOS.FUNCIONALIDAD(func_descripcion) VALUES('Baja de Cliente')
INSERT INTO RUBIRA_SANTOS.FUNCIONALIDAD(func_descripcion) VALUES('Modificadion de Cliente')
INSERT INTO RUBIRA_SANTOS.FUNCIONALIDAD(func_descripcion) VALUES('Alta de Chofer')
INSERT INTO RUBIRA_SANTOS.FUNCIONALIDAD(func_descripcion) VALUES('Baja de Chofer')
INSERT INTO RUBIRA_SANTOS.FUNCIONALIDAD(func_descripcion) VALUES('Modificacion de Chofer')
INSERT INTO RUBIRA_SANTOS.FUNCIONALIDAD(func_descripcion) VALUES('Alta de Automovil')
INSERT INTO RUBIRA_SANTOS.FUNCIONALIDAD(func_descripcion) VALUES('Baja de Automovil')
INSERT INTO RUBIRA_SANTOS.FUNCIONALIDAD(func_descripcion) VALUES('Modificacion de Automovil')
INSERT INTO RUBIRA_SANTOS.FUNCIONALIDAD(func_descripcion) VALUES('Alta de Turno')
INSERT INTO RUBIRA_SANTOS.FUNCIONALIDAD(func_descripcion) VALUES('Baja de Turno')
INSERT INTO RUBIRA_SANTOS.FUNCIONALIDAD(func_descripcion) VALUES('Modificacion de Turno')
INSERT INTO RUBIRA_SANTOS.FUNCIONALIDAD(func_descripcion) VALUES('Registrar Viaje')
INSERT INTO RUBIRA_SANTOS.FUNCIONALIDAD(func_descripcion) VALUES('Rendicion de Viaje')
INSERT INTO RUBIRA_SANTOS.FUNCIONALIDAD(func_descripcion) VALUES('Facturacion')
INSERT INTO RUBIRA_SANTOS.FUNCIONALIDAD(func_descripcion) VALUES('Generar Listados')


-- ROL_POR_FUNCIONALIDAD
INSERT INTO RUBIRA_SANTOS.ROL_POR_FUNCIONALIDAD(rol_id, func_id)
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
INSERT INTO RUBIRA_SANTOS.USUARIO(usua_usuario, usua_password)
	   VALUES('admin', 'w23e')

--ROL POR USUARIO
INSERT INTO RUBIRA_SANTOS.ROL_POR_USUARIO(rol_id, usua_id) VALUES (1,1)

-- MARCA DE AUTOS
INSERT INTO RUBIRA_SANTOS.MARCA(marc_detalle) 
	SELECT DISTINCT m.Auto_Marca 
	FROM gd_esquema.Maestra m

-- TURNOS
INSERT INTO RUBIRA_SANTOS.TURNO(turn_descripcion, turn_hora_inicio, turn_hora_fin,turn_precio_base, turn_valor_km) 
	SELECT m.Turno_Descripcion
	, CAST(RIGHT(RIGHT('00' + CAST(m.Turno_Hora_Inicio AS VARCHAR), 2),2)  + ':00:00' AS TIME)
	,CASE m.Turno_Hora_Fin WHEN 24 THEN CAST(RIGHT(RIGHT('00' + CAST(00 AS VARCHAR), 2),2)  + ':00:00' AS TIME)
						   ELSE CAST(RIGHT(RIGHT('00' + CAST(m.Turno_Hora_Fin AS VARCHAR), 2),2)  + ':00:00' AS TIME)
	 END
	, m.Turno_Precio_Base
	, m.Turno_Valor_Kilometro
	FROM gd_esquema.Maestra m 
	GROUP BY m.Turno_Descripcion, m.Turno_Hora_Inicio, m.Turno_Hora_Fin, m.Turno_Precio_Base, m.Turno_Valor_Kilometro

-- Clientes
INSERT INTO RUBIRA_SANTOS.USUARIO(usua_usuario, usua_password)
	SELECT DISTINCT m.Cliente_Telefono, m.Cliente_Telefono
	   FROM gd_esquema.Maestra m

INSERT INTO RUBIRA_SANTOS.DIRECCION(dire_calle)
	SELECT DISTINCT ma.Cliente_Direccion
	FROM gd_esquema.Maestra ma

INSERT INTO RUBIRA_SANTOS.CLIENTE(clie_telefono, clie_nombre, clie_apellido, clie_fechaNacimiento, clie_dni, clie_mail, clie_usua, clie_direccion)
	SELECT DISTINCT m.Cliente_Telefono,
	m.Cliente_nombre, 
	UPPER(m.Cliente_Apellido),
	m.Cliente_Fecha_Nac, 
	m.Cliente_Dni,
	m.Cliente_Mail,
	(SELECT usua_id FROM RUBIRA_SANTOS.USUARIO WHERE usua_usuario = CAST(m.Cliente_Telefono AS nvarchar(10))),
	(SELECT dire_id FROM RUBIRA_SANTOS.DIRECCION WHERE dire_calle = m.Cliente_Direccion)
	FROM gd_esquema.Maestra m
---- 47 clientes 


---- Choferes
INSERT INTO RUBIRA_SANTOS.USUARIO(usua_usuario, usua_password)
	SELECT DISTINCT m.Chofer_Telefono, m.Chofer_Telefono
	FROM gd_esquema.Maestra m

INSERT INTO RUBIRA_SANTOS.DIRECCION(dire_calle)
	SELECT DISTINCT ma.Chofer_Direccion
	FROM gd_esquema.Maestra ma

INSERT INTO RUBIRA_SANTOS.CHOFER(chof_telefono, chof_nombre, chof_apellido, chof_dni, chof_fechaNacimiento, chof_mail, chof_usua, chof_direccion)
	SELECT DISTINCT m.Chofer_Telefono
	, m.Chofer_Nombre
	, UPPER(m.Chofer_Apellido)
	, m.Chofer_Dni
	, m.Chofer_Fecha_Nac
	, m.Chofer_Mail
	, (SELECT usua_id FROM RUBIRA_SANTOS.USUARIO WHERE usua_usuario = CAST(m.Chofer_Telefono AS nvarchar(10)))
	, (SELECT dire_id FROM RUBIRA_SANTOS.DIRECCION WHERE dire_calle = m.Chofer_Direccion)
	FROM gd_esquema.Maestra m
--41 choferes

-- ROL POR USUARIO
INSERT INTO RUBIRA_SANTOS.ROL_POR_USUARIO(usua_id, rol_id)
	SELECT DISTINCT usua_id, (SELECT rol_id FROM RUBIRA_SANTOS.ROL WHERE rol_descripcion LIKE '%Cliente%')
	FROM RUBIRA_SANTOS.USUARIO JOIN gd_esquema.Maestra 
	ON usua_usuario = CAST(Cliente_Telefono AS nvarchar(10))

INSERT INTO RUBIRA_SANTOS.ROL_POR_USUARIO(usua_id, rol_id)
	SELECT DISTINCT usua_id, (SELECT rol_id FROM RUBIRA_SANTOS.ROL WHERE rol_descripcion LIKE '%Chofer%')
	FROM RUBIRA_SANTOS.USUARIO JOIN gd_esquema.Maestra
	ON usua_usuario = CAST(Chofer_telefono AS nvarchar(10))


-- AUTOS
INSERT INTO RUBIRA_SANTOS.AUTOMOVIL(auto_patente,auto_marca, auto_modelo)
	SELECT DISTINCT m.Auto_patente, (SELECT marc_id FROM RUBIRA_SANTOS.MARCA WHERE m.Auto_Marca = marc_detalle), m.Auto_Modelo
	FROM gd_esquema.Maestra m
-- 41 autos

--AUTO_POR_TURNO

INSERT INTO RUBIRA_SANTOS.AUTO_POR_TURNO(chof_id,auto_id,turn_id,turn_turnoActivo)
	SELECT DISTINCT c.chof_id 
	, a.auto_id
	, t.turn_id
	,(SELECT top 1 t2.turn_id 
	FROM gd_esquema.Maestra ma2 JOIN RUBIRA_SANTOS.TURNO t2 ON t2.turn_descripcion = ma2.Turno_Descripcion
	WHERE ma2.Chofer_Telefono=c.chof_telefono
	AND ma2.Viaje_Fecha = 
				(SELECT MAX(ma3.Viaje_Fecha) FROM gd_esquema.Maestra ma3 WHERE ma3.Chofer_Telefono=ma2.Chofer_Telefono))
	FROM gd_esquema.Maestra ma
	JOIN RUBIRA_SANTOS.TURNO t ON t.turn_descripcion = ma.Turno_Descripcion
	JOIN RUBIRA_SANTOS.AUTOMOVIL a ON a.auto_patente = ma.Auto_Patente
	JOIN RUBIRA_SANTOS.CHOFER c ON c.chof_telefono = ma.Chofer_Telefono 

------ Viajes
INSERT INTO RUBIRA_SANTOS.VIAJE(viaj_auto, viaj_cantidad_km, viaj_fyh_inicio, viaj_fyh_fin, viaj_turno, viaj_cliente, viaj_chofer, viaj_precio)
	SELECT max(au.auto_id),
		   max(ma.Viaje_Cant_Kilometros),
		   ma.Viaje_Fecha,
		   DATEADD(minute,1*max(ma.Viaje_Cant_Kilometros),ma.Viaje_Fecha),
		   max(tu.turn_id),
		   cli.clie_id,
		   max(cho.chof_id),
		   (SELECT (max(ma.Viaje_Cant_Kilometros) * tu2.turn_valor_km) + tu2.turn_precio_base FROM RUBIRA_SANTOS.TURNO tu2 WHERE tu2.turn_id = max(tu.turn_id))
	FROM gd_esquema.Maestra ma
	LEFT JOIN RUBIRA_SANTOS.AUTOMOVIL au ON au.auto_patente = ma.Auto_Patente
	LEFT JOIN RUBIRA_SANTOS.CHOFER cho ON chof_telefono = ma.Chofer_Telefono
	LEFT JOIN RUBIRA_SANTOS.TURNO tu ON tu.turn_descripcion = ma.Turno_Descripcion
	LEFT JOIN RUBIRA_SANTOS.CLIENTE cli ON clie_telefono = ma.Cliente_Telefono
	GROUP BY cli.clie_id,ma.Viaje_Fecha
-- 99660 viajes


-- Facturas
INSERT INTO RUBIRA_SANTOS.FACTURA(fact_fecha_inicio, fact_fecha_fin, fact_cliente, fact_total)
	SELECT ma.Factura_Fecha_Inicio
	, ma.Factura_Fecha_Fin
	, (SELECT clie_id FROM RUBIRA_SANTOS.CLIENTE WHERE clie_telefono = ma.Cliente_Telefono)
	, SUM(ISNULL(ma.Turno_Precio_Base,0) * ISNULL(ma.Turno_Valor_Kilometro,0))
	FROM gd_esquema.Maestra ma
	WHERE ma.Factura_Fecha_Fin IS NOT NULL
	GROUP BY ma.Factura_Nro, ma.Factura_Fecha_Inicio, ma.Factura_Fecha_Fin, ma.Cliente_Telefono
--564 facturas

---- ITEM FACTURA
INSERT INTO RUBIRA_SANTOS.ITEM_FACTURA(itemf_fact, itemf_viaje, itemf_precioViaje)
	SELECT fact_id, viaj_id, viaj_precio
	FROM RUBIRA_SANTOS.FACTURA JOIN RUBIRA_SANTOS.VIAJE ON viaj_cliente = fact_cliente
	WHERE ((viaj_fyh_fin BETWEEN fact_fecha_inicio AND DATEADD(day,1,fact_fecha_fin))
	OR (viaj_fyh_fin = fact_fecha_inicio)
	OR (viaj_fyh_fin = fact_fecha_fin))
	GROUP BY viaj_id, viaj_precio, fact_id

---- Rendiciones
INSERT INTO RUBIRA_SANTOS.RENDICION_VIAJE(pago_turno, pago_fecha, pago_importe_total, pago_chofer)
	SELECT t.turn_id
	, ma.Rendicion_Fecha
	, ISNULL(sum(ma.Rendicion_Importe),0)
	, c.chof_id
	FROM gd_esquema.Maestra ma, RUBIRA_SANTOS.TURNO t, RUBIRA_SANTOS.CHOFER c 
	WHERE c.chof_telefono = ma.Chofer_Telefono
	AND t.turn_descripcion = ma.Turno_Descripcion
	AND rendicion_fecha IS NOT NULL
	GROUP BY ma.Rendicion_Nro, ma.Rendicion_Fecha, t.turn_id, c.chof_id
--40198 rendiciones

--ITEM RENDICION
INSERT INTO RUBIRA_SANTOS.ITEM_RENDICION(itemr_pago, itemr_precio, itemr_viaje)
	SELECT pago_id,viaj_precio, viaj_id
	FROM RUBIRA_SANTOS.VIAJE JOIN RUBIRA_SANTOS.RENDICION_VIAJE 
	ON viaj_chofer = pago_chofer AND viaj_turno = pago_turno 
	JOIN RUBIRA_SANTOS.TURNO ON viaj_turno = turn_id
	WHERE YEAR(viaj_fyh_inicio) = YEAR(pago_fecha)
		AND MONTH(viaj_fyh_inicio) = MONTH(pago_fecha) 
		AND DAY(viaj_fyh_inicio) = DAY(pago_fecha)
	GROUP BY pago_id, viaj_id,viaj_precio

UPDATE RUBIRA_SANTOS.RENDICION_VIAJE SET pago_porcentaje = (R.pago_importe_total/(SELECT SUM(viaj_precio) 
											  FROM RUBIRA_SANTOS.VIAJE 
											  JOIN RUBIRA_SANTOS.TURNO ON turn_id = viaj_turno
											  WHERE viaj_chofer = r.pago_chofer
											  AND viaj_turno = r.pago_turno 
											  AND YEAR(viaj_fyh_inicio) = YEAR(r.pago_fecha)
											  AND MONTH(viaj_fyh_inicio) = MONTH(r.pago_fecha) 
											  AND DAY(viaj_fyh_inicio) = DAY(r.pago_fecha)
											))*100
FROM RUBIRA_SANTOS.RENDICION_VIAJE R
/*
======================================
		TRIGGERS AFTER MIGRACION
======================================
*/
GO
CREATE TRIGGER VERIFICACION_PAGO ON RUBIRA_SANTOS.RENDICION_VIAJE INSTEAD OF INSERT
AS
DECLARE @FECHA SMALLDATETIME, @CHOFER INT, @TOTAL DECIMAL(12,2), @TURNO INT, @PORCENTAJE DECIMAL(12,2)
BEGIN 
	SELECT @FECHA = I.pago_fecha, @CHOFER = I.pago_chofer
	FROM inserted I 
	IF(NOT EXISTS(SELECT * FROM RUBIRA_SANTOS.RENDICION_VIAJE R WHERE R.pago_chofer = @CHOFER AND R.pago_fecha = @FECHA))
		INSERT INTO RUBIRA_SANTOS.RENDICION_VIAJE(pago_chofer, pago_fecha, pago_importe_total, pago_turno, pago_porcentaje)
		SELECT i.pago_chofer, i.pago_fecha, i.pago_importe_total, i.pago_turno, i.pago_porcentaje
		FROM inserted i
	ELSE 
		RAISERROR('Ya existe una rendición para el chofer el día de la fecha', 16, 217) WITH SETERROR
END

GO
CREATE TRIGGER VERIFICACION_HABILITADO ON RUBIRA_SANTOS.VIAJE INSTEAD OF INSERT
AS
DECLARE @TUR INT, @AUT INT, @CHOFER INT,@CLIE INT
BEGIN

SELECT @TUR = i.viaj_turno ,@AUT= i.viaj_auto, @CHOFER= i.viaj_chofer,@CLIE= i.viaj_cliente
FROM inserted i
IF((SELECT turn_habilitado FROM RUBIRA_SANTOS.TURNO WHERE turn_id = @TUR) = 0) RAISERROR ('El turno seleccionado no está habilitado', 16, 217) WITH SETERROR
	ELSE
		IF((SELECT auto_habilitado FROM RUBIRA_SANTOS.AUTOMOVIL WHERE auto_id = @AUT) = 0) RAISERROR ('El automovil no está habilitado', 16, 217) WITH SETERROR
			ELSE 
				IF((SELECT chof_habilitado FROM RUBIRA_SANTOS.CHOFER WHERE chof_id = @CHOFER)=0) RAISERROR ('El chofer no está habilitado', 16, 217) WITH SETERROR
					ELSE
						IF((SELECT clie_habilitado FROM RUBIRA_SANTOS.CLIENTE WHERE clie_id = @CLIE)=0) RAISERROR ('El cliente no está habilitado', 16, 217) WITH SETERROR
							ELSE
								INSERT INTO RUBIRA_SANTOS.VIAJE(viaj_auto, viaj_cantidad_km, viaj_chofer, viaj_cliente, viaj_fyh_fin, viaj_fyh_inicio, viaj_precio, viaj_turno)
								SELECT viaj_auto, viaj_cantidad_km, viaj_chofer, viaj_cliente, viaj_fyh_fin, viaj_fyh_inicio, viaj_precio, viaj_turno
								FROM inserted

END

GO
CREATE TRIGGER VIAJE_NO_FACTURADO ON RUBIRA_SANTOS.ITEM_FACTURA INSTEAD OF INSERT
AS
DECLARE @VIAJE INT
DECLARE C1 CURSOR FOR (SELECT itemf_viaje FROM inserted)
BEGIN
OPEN C1
FETCH NEXT FROM C1 INTO @VIAJE 
WHILE @@FETCH_STATUS = 0
	BEGIN
		IF(EXISTS(SELECT * FROM RUBIRA_SANTOS.ITEM_FACTURA WHERE itemf_viaje = @VIAJE)) RAISERROR ('El viaje ya fue facturado', 16, 217) WITH SETERROR
		ELSE
			INSERT INTO RUBIRA_SANTOS.ITEM_FACTURA(itemf_fact, itemf_precioViaje, itemf_viaje)
			SELECT itemf_fact, itemf_precioViaje, itemf_viaje
			FROM inserted
		FETCH NEXT FROM C1 INTO @VIAJE
	END
CLOSE C1
DEALLOCATE C1
END

GO 
CREATE TRIGGER VIAJE_NO_PAGO ON RUBIRA_SANTOS.ITEM_RENDICION INSTEAD OF INSERT
AS
DECLARE @VIAJE INT
DECLARE C1 CURSOR FOR (SELECT itemr_viaje FROM inserted)
BEGIN
OPEN C1
FETCH NEXT FROM C1 INTO @VIAJE 
WHILE @@FETCH_STATUS = 0
	BEGIN
		IF(EXISTS(SELECT * FROM RUBIRA_SANTOS.ITEM_RENDICION WHERE itemr_viaje = @VIAJE)) RAISERROR ('El viaje ya fue pagado', 16, 217) WITH SETERROR
		ELSE
			INSERT INTO RUBIRA_SANTOS.ITEM_RENDICION(itemr_pago, itemr_precio, itemr_viaje)
			SELECT itemr_pago, itemr_precio, itemr_viaje
			FROM inserted
		FETCH NEXT FROM C1 INTO @VIAJE
	END
CLOSE C1
DEALLOCATE C1
END
