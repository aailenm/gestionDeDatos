USE [GD1C2017]
GO
/* ================================================
					DROP DE TABLAS
   ================================================
 */
IF OBJECT_ID('RUBIRA_SANTOS.AUTO_POR_TURNO') IS NOT NULL
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

 IF OBJECT_ID('GET_ROLES') IS NOT NULL
 DROP PROCEDURE GET_ROLES

 IF OBJECT_ID('MAYOR_CONSUMO') IS NOT NULL
 drop procedure MAYOR_CONSUMO

  IF OBJECT_ID('MAYOR_RECAUDACION') IS NOT NULL
 drop procedure MAYOR_RECAUDACION

  IF OBJECT_ID('VIAJE_LARGO') IS NOT NULL
 drop procedure VIAJE_LARGO

  IF OBJECT_ID('AUTO_MAS_USADO') IS NOT NULL
 drop procedure AUTO_MAS_USADO

  IF OBJECT_ID('VIAJES_RENDICION') IS NOT NULL
 drop procedure VIAJES_RENDICION

 IF OBJECT_ID('VIAJE_FACTURA') IS NOT NULL
DROP PROCEDURE VIAJE_FACTURA

  IF OBJECT_ID('GET_MARCAS') IS NOT NULL
DROP PROCEDURE GET_MARCAS

 IF OBJECT_ID('GET_FUNCIONALIDADES') IS NOT NULL
DROP PROCEDURE GET_FUNCIONALIDADES

 IF OBJECT_ID('filtro_automovil') IS NOT NULL
DROP PROCEDURE filtro_automovil

IF OBJECT_ID('filtro_cliente') IS NOT NULL
DROP PROCEDURE filtro_cliente

IF OBJECT_ID('filtro_chofer') IS NOT NULL
DROP PROCEDURE filtro_chofer

 IF OBJECT_ID('GET_TURNOS') IS NOT NULL
DROP PROCEDURE GET_TURNOS

 IF OBJECT_ID('GET_TODOS_TURNOS') IS NOT NULL
DROP PROCEDURE GET_TODOS_TURNOS

  IF OBJECT_ID('ALTA_CLIENTE') IS NOT NULL
DROP PROCEDURE ALTA_CLIENTE

  IF OBJECT_ID('ALTA_USUARIO') IS NOT NULL
DROP PROCEDURE ALTA_USUARIO

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

 IF OBJECT_ID('AGREGAR_ROLES') IS NOT NULL
DROP PROCEDURE AGREGAR_ROLES

 IF OBJECT_ID('VIAJE_RENDICION') IS NOT NULL
DROP PROCEDURE VIAJE_RENDICION


 IF OBJECT_ID('filtro_turno') IS NOT NULL
DROP PROCEDURE filtro_turno

/* ================================================
				DROP DE TRIGGERS
   ================================================
 */

IF OBJECT_ID('CIFRAR') IS NOT NULL
DROP TRIGGER CIFRAR

IF OBJECT_ID('VERIFICACION_HABILITADO') IS NOT NULL
DROP TRIGGER VERIFICACION_HABILITADO

IF OBJECT_ID('VIAJE_NO_PAGO') IS NOT NULL
DROP TRIGGER VIAJE_NO_PAGO

IF OBJECT_ID('VIAJE_NO_FACTURADO') IS NOT NULL
DROP TRIGGER VIAJE_NO_FACTURADO

IF OBJECT_ID('VERIFICACION_PAGO') IS NOT NULL
DROP TRIGGER VERIFICACION_PAGO

-- DROP SCHEMA

IF  EXISTS (SELECT * FROM sys.schemas WHERE name = N'RUBIRA_SANTOS')
DROP SCHEMA [RUBIRA_SANTOS]
GO

-- CREATE SCHEMA

CREATE SCHEMA [RUBIRA_SANTOS] AUTHORIZATION [dbo]
GO

/* ================================================
		        CREACION DE TABLAS
   ================================================
 */
 GO
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
	turn_turnoActivo int NOT NULL,
	chof_id int NOT NULL
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
CREATE PROCEDURE GET_MARCAS
AS 
BEGIN 
	SELECT marc_id, marc_detalle
	from MARCA
end

GO
CREATE PROCEDURE GET_ROLES(@DESCRIPCION NVARCHAR(250))
AS
BEGIN
	SELECT rol_id, rol_habilitado,rol_descripcion
	FROM ROL
	WHERE rol_descripcion = '' OR rol_descripcion LIKE '%'+ @DESCRIPCION + '%'
END
GO
CREATE PROCEDURE GET_TODOS_TURNOS
AS
BEGIN
	SELECT turn_id, turn_descripcion
	from TURNO
	WHERE turn_habilitado = 1
end

GO 
CREATE PROCEDURE GET_TURNOS
AS 
BEGIN 
	SELECT turn_id, turn_descripcion
	from TURNO
	WHERE turn_habilitado = 1
end

GO
CREATE PROCEDURE GET_FUNCIONALIDADES
AS
BEGIN
	SELECT func_id, func_descripcion 
	FROM FUNCIONALIDAD
END

GO
CREATE PROCEDURE VIAJES_RENDICION(@CHOFER INT, @TURNO INT, @FECHA SMALLDATETIME)
AS
BEGIN
	SELECT distinct v.viaj_id, c.clie_nombre + ' ' + c.clie_apellido CLIENTE, v.viaj_fyh_inicio INICIO, v.viaj_fyh_fin FIN, t.turn_descripcion TURNO, v.viaj_cantidad_km CANTIDAD_KM, a.auto_patente AUTO_PATENTE,v.viaj_precio VIAJE_PRECIO
	FROM VIAJE v
	JOIN AUTO_POR_TURNO apt on apt.turn_turnoActivo = v.viaj_turno and v.viaj_chofer = apt.chof_id and v.viaj_auto = apt.auto_id
	JOIN CLIENTE c on v.viaj_cliente = c.clie_id
	JOIN TURNO t ON t.turn_id = v.viaj_turno
	JOIN AUTOMOVIL a on a.auto_id = apt.auto_id
	WHERE viaj_chofer = @CHOFER
	AND viaj_turno = @TURNO
	AND YEAR(viaj_fyh_fin) = YEAR(@FECHA) 
	AND MONTH(viaj_fyh_fin) = MONTH(@FECHA)
	AND DAY(viaj_fyh_fin) = DAY(@FECHA)
END
select * from AUTO_POR_TURNO
GO
CREATE PROCEDURE ALTA_CLIENTE(@NOMBRE nvarchar(255), @APELLIDO nvarchar(255), @DNI bigint, @TELEFONO bigint, @MAIL nvarchar(255), @FECHA_NACIMIENTO smalldatetime, @CALLE nvarchar(255), @PISO nvarchar(255), @DPTO nvarchar(255), @LOCALIDAD nvarchar(255), @CP nvarchar(255))
AS
BEGIN
DECLARE @iddirec int
DECLARE @USUA INT
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
			VALUES(@nombre,UPPER(@APELLIDO), @DNI, CAST(@FECHA_NACIMIENTO as smalldatetime), @MAIL, @TELEFONO, @iddirec)

			IF(NOT EXISTS(SELECT * FROM USUARIO WHERE usua_usuario = @TELEFONO))
				INSERT INTO USUARIO(usua_usuario, usua_password)
				VALUES(@TELEFONO, @TELEFONO)
			
			SELECT usua_id = @USUA FROM USUARIO WHERE usua_usuario = @TELEFONO
			INSERT INTO ROL_POR_USUARIO(rol_id, usua_id)
			values((select rol_id from ROL where rol_descripcion like '%Cliente%'),@USUA)
		END
	ELSE
		RAISERROR ('El cliente ya existe', 16, 217) WITH SETERROR
END

GO
CREATE PROCEDURE ALTA_CHOFER(@NOMBRE nvarchar(255), @APELLIDO nvarchar(255), @DNI bigint, @MAIL nvarchar(255), @TELEFONO bigint, @FECHA_NACIMIENTO smalldatetime, @CALLE nvarchar(255), @PISO nvarchar(255), @DPTO nvarchar(255), @LOCALIDAD nvarchar(255), @CP nvarchar(255))
AS
BEGIN
DECLARE @iddirec int
DECLARE @USUA INT
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
			VALUES(@NOMBRE, UPPER(@APELLIDO), @DNI, @MAIL, @TELEFONO, CAST(@FECHA_NACIMIENTO AS SMALLDATETIME),@iddirec)
			
			IF(NOT EXISTS(SELECT * FROM USUARIO WHERE usua_usuario = @TELEFONO))
				INSERT INTO USUARIO(usua_usuario, usua_password)
				VALUES(@TELEFONO, @TELEFONO)
			
			SELECT usua_id = @USUA FROM USUARIO WHERE usua_usuario = @TELEFONO

			INSERT INTO ROL_POR_USUARIO(rol_id, usua_id)
			values((select rol_id from ROL where rol_descripcion like '%Chofer%'),@USUA)
		END
	ELSE
		 RAISERROR ('El chofer ya existe', 16, 217) WITH SETERROR
END

GO
CREATE PROCEDURE ALTA_AUTOMOVIL(@MARCA INT, @MODELO nvarchar(255), @PATENTE nvarchar(255), @TURNO int, @CHOFER INT)
AS 
BEGIN 
DECLARE @AUTOID int
	IF(NOT EXISTS(SELECT * FROM AUTOMOVIL WHERE auto_patente = @PATENTE))
		IF(NOT EXISTS(SELECT * FROM AUTO_POR_TURNO apt JOIN AUTOMOVIL a on apt.auto_id = a.auto_id
					 WHERE chof_id = @CHOFER and a.auto_habilitado = 1))
			BEGIN
				INSERT INTO AUTOMOVIL(auto_patente, auto_modelo, auto_marca)
				VALUES(@PATENTE, @MODELO, @MARCA)
				
				SELECT @AUTOID = auto_id FROM AUTOMOVIL where auto_patente = @PATENTE
				
				INSERT INTO AUTO_POR_TURNO(auto_id, chof_id, turn_id, turn_turnoActivo)
				VALUES(@AUTOID,@CHOFER,@TURNO, @TURNO)
			END
		ELSE
			RAISERROR ('El chofer ya tiene asignado un auto habilitado', 16, 217) WITH SETERROR
	ELSE
		RAISERROR ('El auto ya existe', 16, 217) WITH SETERROR
END

GO
CREATE PROCEDURE ALTA_VIAJE(@CANTIDADKM INT,@FECHAINICIO smalldatetime ,@FECHAFIN smalldatetime, @TURNO INT, @AUTO INT, @CHOFER INT, @CLIENTE INT)
AS
BEGIN
	IF(NOT EXISTS(SELECT * FROM VIAJE WHERE viaj_cliente = @CLIENTE and viaj_fyh_inicio = @FECHAINICIO))
		IF(EXISTS (SELECT auto_id, chof_id, turn_id FROM AUTO_POR_TURNO WHERE auto_id = @AUTO and chof_id = @CHOFER and turn_turnoActivo = @TURNO))
			INSERT INTO VIAJE(viaj_auto, viaj_cantidad_km, viaj_chofer, viaj_cliente, viaj_fyh_inicio, viaj_fyh_fin, viaj_turno, viaj_precio)
			VALUES(@AUTO, @CANTIDADKM, @CHOFER, @CLIENTE,@FECHAINICIO ,@FECHAFIN, @TURNO, (SELECT (@CANTIDADKM * t.turn_valor_km + t.turn_precio_base) FROM TURNO t where t.turn_id = @TURNO))
		ELSE
			RAISERROR ('No existe un chofer con ese auto en ese turno', 16, 217) WITH SETERROR	
	ELSE
		RAISERROR('Ya existe un viaje para este cliente en esta fecha y horario',16,217) WITH SETERROR
END

GO
CREATE PROCEDURE ALTA_ROL(@DESCRIPCION NVARCHAR(255))
AS
BEGIN
	IF(NOT EXISTS (SELECT * FROM ROL WHERE rol_descripcion = @DESCRIPCION))
		BEGIN 
		INSERT INTO ROL(rol_descripcion)
		VALUES(@DESCRIPCION)
		END
	ELSE 
		RAISERROR ('El rol ya existe', 16, 217) WITH SETERROR
END

GO
CREATE PROCEDURE ALTA_USUARIO(@USUARIO nvarchar(255), @CONTRA nvarchar(255))
AS
BEGIN
	IF(NOT EXISTS(SELECT * FROM USUARIO WHERE usua_usuario = @USUARIO))
		INSERT INTO USUARIO(usua_usuario, usua_password)
		VALUES(@USUARIO,@CONTRA)
	ELSE
		RAISERROR('Ya existe ese usuario',16,217) WITH SETERROR
END

GO
CREATE PROCEDURE AGREGAR_ROLES(@USUARIO INT, @ROL INT)
AS
BEGIN
	INSERT INTO ROL_POR_USUARIO(rol_id, usua_id)
	VALUES(@ROL,@USUARIO)
END

GO
CREATE PROCEDURE AGREGAR_FUNCIONALIDAD(@FUNCIONALIDAD int, @ROL int)
AS
BEGIN 
	INSERT INTO ROL_POR_FUNCIONALIDAD(rol_id, func_id) 
	VALUES(@ROL, @FUNCIONALIDAD)
END

GO
CREATE PROCEDURE ALTA_TURNO(@DESCRIPCION NVARCHAR(255), @HORA_INICIO NVARCHAR(255), @HORA_FIN NVARCHAR(255), @PRECIOBASE decimal(12,2), @VALORKM decimal(12,2))
AS
DECLARE C1 CURSOR FOR (SELECT turn_hora_inicio, turn_hora_fin, turn_habilitado FROM TURNO)
DECLARE @INICIO TIME, @FIN TIME, @HABILITADO INT, @NO_PUEDE_EXISTIR INT
BEGIN
	SET @HORA_INICIO = CAST(@HORA_INICIO AS time)
	SET @HORA_FIN = CAST(@HORA_FIN AS time)
	SET @NO_PUEDE_EXISTIR = 0
	IF(@HORA_FIN > @HORA_INICIO)
	BEGIN
		IF(NOT EXISTS(SELECT * FROM TURNO WHERE turn_descripcion =@DESCRIPCION))
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
					INSERT INTO TURNO(turn_descripcion, turn_hora_inicio, turn_hora_fin, turn_precio_base, turn_valor_km)						
					VALUES(@DESCRIPCION,@HORA_INICIO, @HORA_FIN , @PRECIOBASE, @VALORKM)
				ELSE RAISERROR ('Ya existen turnos en esta franja horaria', 16, 217) WITH SETERROR
			END
		ELSE
			RAISERROR ('Ya existe un turno con esa descripción', 16, 217) WITH SETERROR
		END
	ELSE 
		RAISERROR('El turno debe comenzar y finalizar en el mismo día', 16, 217) WITH SETERROR
END

GO
CREATE PROCEDURE CREAR_FACTURA(@CLIENTE INT, @FECHAI SMALLDATETIME, @FECHAF SMALLDATETIME, @TOTAL decimal(12,2))
AS
DECLARE @idFact int
BEGIN
	IF(NOT EXISTS(SELECT * FROM FACTURA WHERE fact_fecha_inicio = @FECHAI AND fact_fecha_fin = @FECHAF AND @CLIENTE = fact_cliente))
		BEGIN
			INSERT INTO FACTURA(fact_cliente, fact_fecha_inicio, fact_fecha_fin, fact_total)
			VALUES (@CLIENTE, @FECHAI, @FECHAF, @TOTAL)
			
			SELECT @idFact = FACT_ID
			FROM FACTURA
			WHERE fact_cliente = @CLIENTE 
			and fact_fecha_inicio = @FECHAI
			and fact_fecha_fin = @FECHAF
			and fact_total = @TOTAL

			INSERT INTO ITEM_FACTURA(itemf_fact, itemf_precioViaje, itemf_viaje)
			SELECT @idFact, viaj_precio, viaj_id
			FROM VIAJE
			WHERE viaj_cliente = @CLIENTE 
			and viaj_fyh_fin between @FECHAI and DATEADD(day,1,@FECHAF)
		END
	ELSE
		RAISERROR ('Ya existe una factura para este cliente en dicha fecha', 16, 217) WITH SETERROR
END

GO
CREATE PROCEDURE CREAR_RENDICION(@CHOFER INT, @TOTAL DECIMAL(12,2), @TURNO INT, @FECHA smalldatetime, @PORCENTAJE decimal(12,2))
AS
DECLARE @REND INT
BEGIN
	IF(EXISTS(SELECT turn_id, chof_id FROM AUTO_POR_TURNO WHERE turn_turnoActivo = @TURNO and chof_id = @CHOFER))
		BEGIN
		INSERT INTO RENDICION_VIAJE(pago_chofer, pago_importe_total, pago_turno, pago_fecha,pago_porcentaje)
		VALUES(@CHOFER, @TOTAL, @TURNO,@FECHA, @PORCENTAJE)

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

/*
=================================================
				BUSQUEDA PROCEDURES
=================================================
*/

GO
CREATE PROCEDURE VIAJE_FACTURA(@FECHAI smalldatetime, @FECHAF smalldatetime, @CLIENTE int)
AS
BEGIN
	select v.viaj_id, v.viaj_fyh_inicio VIAJE_INICIO, v.viaj_fyh_fin VIAJE_FIN, t.turn_descripcion TURNO, c.chof_nombre + ' ' + c.chof_apellido NOMBRE_CHOFER, a.auto_patente AUTO_PATENTE, v.viaj_cantidad_km CANTIDAD_KM,v.viaj_precio PRECIO
	from VIAJE  v 
	JOIN TURNO t on t.turn_id = v.viaj_turno
	JOIN CHOFER c on c.chof_id = v.viaj_chofer
	JOIN AUTOMOVIL a on a.auto_id = v.viaj_auto
	where v.viaj_cliente = @CLIENTE
		and v.viaj_fyh_fin between @FECHAI and @FECHAF
END

GO
Create procedure filtro_cliente(@nombre varchar(255), @apellido varchar(255), @dni bigint)
as
BEGIN
	Select  c.clie_id, c.clie_nombre Nombre, c.clie_apellido Apellido, c.clie_dni DNI, c.clie_fechaNacimiento Fecha_Nacimiento, c.clie_mail Mail, c.clie_telefono Telefono, d.dire_calle Dirección, d.dire_localidad Localidad, d.dire_cp Codigo_Postal, c.clie_habilitado Habilitado
	from Cliente c join DIRECCION d 
	on c.clie_direccion = d.dire_id
	Where (@nombre='' OR c.clie_nombre like '%' + @nombre + '%' ) AND
		(@apellido='' OR c.clie_apellido like '%' + @apellido + '%') AND
		(@dni=0 OR @dni =c.clie_dni)
END

go
Create procedure filtro_automovil (@marca int, @modelo varchar(255), @patente varchar(10) , @chofer int)
as
BEGIN
	Select distinct a.auto_id, a.auto_marca MARCA, a.auto_modelo MODELO, a.auto_patente PATENTE, tu.turn_descripcion TURNO
from Automovil a join AUTO_POR_TURNO t on a.auto_id = t.auto_id
join TURNO tu on tu.turn_id = t.turn_turnoActivo
where (@marca=0 OR @marca=a.auto_marca) AND
	(@modelo='' OR a.auto_modelo like '%' + @modelo + '%'  ) AND
	(@patente='' OR a.auto_patente like '%' + @patente + '%'  ) AND
	(@chofer=0 OR @chofer=t.chof_id)
end

go
Create procedure filtro_turno (@descripcion varchar(255))
as
BEGIN
	Select t.turn_descripcion DESCRIPCION, t.turn_hora_inicio HORA_INICIO , t.turn_hora_fin HORA_FIN, t.turn_precio_base PRECIO_BASE, t.turn_valor_km VALOR_KM
	from Turno t
	Where @descripcion='' OR
		t.turn_descripcion like '%' + @descripcion +'%'
END

go
Create procedure filtro_chofer(@nombre varchar(255), @apellido varchar(255), @dni bigint)
as
BEGIN
	Select distinct c.chof_id, c.chof_nombre Nombre, c.chof_apellido Apellido, c.chof_dni DNI, c.chof_mail Mail, c.chof_telefono Telefono, c.chof_fechaNacimiento Fecha_Nacimiento,
	d.dire_calle Dirección, d.dire_localidad Localidad, d.dire_cp Codigo_Postal, c.chof_habilitado Habilitado,a.turn_turnoActivo,a.auto_id
	from Chofer c
	join DIRECCION d on d.dire_id = c.chof_direccion
	join AUTO_POR_TURNO a on a.chof_id = c.chof_id
	Where (@nombre='' OR c.chof_nombre like '%' + @nombre + '%') AND
		(@apellido='' OR c.chof_apellido like '%' + @apellido + '%') AND
		(@dni=0 OR @dni=c.chof_dni)
end


/* ================================================
			PROCEDURES LISTADOS ESTADISTICOS
   ================================================
 */
GO
CREATE PROCEDURE MAYOR_RECAUDACION(@FECHA_INICIO smalldatetime, @FECHAFIN smalldatetime)
AS
BEGIN
SELECT TOP 5 c.chof_nombre + ' ' + c.chof_apellido CHOFER, c.chof_fechaNacimiento FECHA_NACIMIENTO, c.chof_telefono TELEFONO, c.chof_mail MAIL, DIRE_CALLE DIRECCION, SUM(r.pago_importe_total) RECAUDACION_TOTAL
FROM CHOFER c JOIN DIRECCION ON c.chof_direccion = dire_id
JOIN RENDICION_VIAJE r on r.pago_chofer = c.chof_id
WHERE r.pago_fecha between @FECHA_INICIO and @FECHAFIN
group by c.chof_id, c.chof_nombre ,c.chof_apellido , c.chof_fechaNacimiento , c.chof_telefono , c.chof_mail , DIRE_CALLE 
order by SUM(r.pago_importe_total) desc
END

GO 
CREATE PROCEDURE VIAJE_LARGO(@FECHA_INICIO smalldatetime, @FECHAFIN smalldatetime)
AS
BEGIN
SELECT TOP 5 c.chof_nombre + ' ' + c.chof_apellido CHOFER, c.chof_fechaNacimiento FECHA_NACIMIENTO, c.chof_telefono TELEFONO, c.chof_mail MAIL, dire_calle DIRECCION, viaj_cantidad_km
FROM VIAJE JOIN CHOFER c on viaj_chofer = c.chof_id
JOIN DIRECCION ON c.chof_direccion = dire_id
WHERE viaj_fyh_fin between @FECHA_INICIO AND @FECHAFIN
ORDER BY viaj_cantidad_km desc
END

GO
CREATE PROCEDURE MAYOR_CONSUMO(@FECHA_INICIO smalldatetime, @FECHAFIN smalldatetime)
AS
BEGIN
SELECT TOP 5 C.clie_nombre + ' ' + clie_apellido CLIENTE, C.clie_fechaNacimiento FECHA_NACIMIENTO, c.clie_dni, C.clie_telefono, d.dire_calle, SUM(F.fact_total)
FROM CLIENTE C
JOIN FACTURA  F ON F.fact_cliente = C.clie_id 
JOIN DIRECCION D on D.dire_id = C.clie_direccion
where f.fact_fecha_inicio>= @FECHA_INICIO and fact_fecha_fin <= @FECHAFIN
group by C.clie_id, C.clie_nombre + ' ' + clie_apellido, C.clie_fechaNacimiento , c.clie_dni, C.clie_telefono, d.dire_calle
order by  SUM(F.fact_total)
END

GO
CREATE PROCEDURE AUTO_MAS_USADO(@FECHA_INICIO smalldatetime, @FECHAFIN smalldatetime)
AS
BEGIN
SELECT TOP 5 C.clie_nombre + ' ' + clie_apellido CLIENTE, C.clie_fechaNacimiento FECHA_NACIMIENTO, c.clie_dni DNI, C.clie_telefono TELEFONO, d.dire_calle DIRECCION, A.auto_patente PATENTE_AUTO,COUNT(*) VECES_QUE_USO_MISMO_AUTO
FROM CLIENTE C
JOIN VIAJE V ON V.viaj_cliente = C.clie_id
JOIN DIRECCION D ON D.dire_id = C.clie_direccion
JOIN AUTOMOVIL A ON A.auto_id = V.viaj_auto
WHERE viaj_fyh_fin between @FECHA_INICIO AND @FECHAFIN
group by C.clie_id, C.clie_nombre + ' ' + clie_apellido, C.clie_fechaNacimiento , c.clie_dni, C.clie_telefono, d.dire_calle, A.auto_patente
ORDER BY COUNT(*) DESC
END

/* ================================================
				        MIGRACION
   ================================================
 */
 GO
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
	   UPPER(m.Cliente_Apellido),
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
	   , UPPER(m.Chofer_Apellido)
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

--AUTO_POR_TURNO

INSERT INTO AUTO_POR_TURNO(chof_id,auto_id,turn_id,turn_turnoActivo)
	SELECT distinct c.chof_id 
	, a.auto_id
	, t.turn_id
	,(select top 1 t2.turn_id 
	from gd_esquema.Maestra ma2 join TURNO t2 on t2.turn_descripcion = ma2.Turno_Descripcion
	where ma2.Chofer_Telefono=c.chof_telefono
	and ma2.Viaje_Fecha = 
				(select MAX(ma3.Viaje_Fecha) from gd_esquema.Maestra ma3 where ma3.Chofer_Telefono=ma2.Chofer_Telefono))
	FROM gd_esquema.Maestra ma
	join TURNO t on t.turn_descripcion = ma.Turno_Descripcion
	join AUTOMOVIL a on a.auto_patente = ma.Auto_Patente
	join CHOFER c on c.chof_telefono = ma.Chofer_Telefono 

------ Viajes
insert into VIAJE(viaj_auto, viaj_cantidad_km, viaj_fyh_inicio, viaj_fyh_fin, viaj_turno, viaj_cliente, viaj_chofer, viaj_precio)
		select max(au.auto_id),
			   max(ma.Viaje_Cant_Kilometros),
			   ma.Viaje_Fecha,
			   DATEADD(minute,1*max(ma.Viaje_Cant_Kilometros),ma.Viaje_Fecha),
			   max(tu.turn_id),
			   cli.clie_id,
			   max(cho.chof_id),
			   (select (max(ma.Viaje_Cant_Kilometros) * tu2.turn_valor_km) + tu2.turn_precio_base from TURNO tu2 where tu2.turn_id = max(tu.turn_id))
		from gd_esquema.Maestra ma
		left join Automovil au on au.auto_patente = ma.Auto_Patente
		left join CHOFER cho on chof_telefono = ma.Chofer_Telefono
		left join TURNO tu on tu.turn_descripcion = ma.Turno_Descripcion
		left join CLIENTE cli on clie_telefono = ma.Cliente_Telefono
		group by cli.clie_id,ma.Viaje_Fecha
-- 99660 viajes


-- Facturas
insert into FACTURA(fact_fecha_inicio, fact_fecha_fin, fact_cliente, fact_total)
		select ma.Factura_Fecha_Inicio
		, ma.Factura_Fecha_Fin
		, (select clie_id from CLIENTE where clie_telefono = ma.Cliente_Telefono)
		, SUM(isnull(ma.Turno_Precio_Base,0) * isnull(ma.Turno_Valor_Kilometro,0))
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
/*
======================================
		TRIGGERS AFTER MIGRACION
======================================
*/
GO
CREATE TRIGGER VERIFICACION_PAGO ON RENDICION_VIAJE INSTEAD OF INSERT
AS
DECLARE @FECHA SMALLDATETIME, @CHOFER INT, @TOTAL DECIMAL(12,2), @TURNO INT, @PORCENTAJE DECIMAL(12,2)
BEGIN 
	SELECT @FECHA = I.pago_fecha , @CHOFER = I.pago_chofer
	FROM inserted I 
	IF(NOT EXISTS(SELECT * FROM RENDICION_VIAJE R WHERE R.pago_chofer = @CHOFER AND R.pago_fecha = @FECHA))
		INSERT INTO RENDICION_VIAJE(pago_chofer, pago_fecha, pago_importe_total, pago_turno, pago_porcentaje)
		select i.pago_chofer, i.pago_fecha, i.pago_importe_total, i.pago_turno, i.pago_porcentaje
		from inserted i
	ELSE 
		RAISERROR('Ya existe una rendición para el chofer el día de la fecha', 16, 217) WITH SETERROR
END

GO
CREATE TRIGGER VERIFICACION_HABILITADO ON VIAJE INSTEAD OF INSERT
AS
DECLARE @TUR INT, @AUT INT, @CHOF INT,@CLIE INT
BEGIN

SELECT @TUR = i.viaj_turno ,@AUT= i.viaj_auto, @CHOF= i.viaj_chofer,@CLIE= i.viaj_cliente
FROM inserted i
IF((SELECT turn_habilitado FROM TURNO WHERE turn_id = @TUR) = 0) RAISERROR ('El turno seleccionado no está habilitado', 16, 217) WITH SETERROR
	ELSE
		IF((SELECT auto_habilitado FROM AUTOMOVIL where auto_id = @AUT) = 0) RAISERROR ('El automovil no está habilitado', 16, 217) WITH SETERROR
			ELSE 
				IF((SELECT chof_habilitado FROM CHOFER WHERE chof_id = @CHOF)=0) RAISERROR ('El chofer no está habilitado', 16, 217) WITH SETERROR
					ELSE
						IF((SELECT clie_habilitado FROM CLIENTE WHERE clie_id = @CLIE)=0) RAISERROR ('El cliente no está habilitado', 16, 217) WITH SETERROR
							ELSE
								INSERT INTO VIAJE(viaj_auto, viaj_cantidad_km, viaj_chofer, viaj_cliente, viaj_fyh_fin, viaj_fyh_inicio, viaj_precio, viaj_turno)
								SELECT viaj_auto, viaj_cantidad_km, viaj_chofer, viaj_cliente, viaj_fyh_fin, viaj_fyh_inicio, viaj_precio, viaj_turno
								FROM inserted

END

GO
CREATE TRIGGER VIAJE_NO_FACTURADO ON ITEM_FACTURA INSTEAD OF INSERT
AS
DECLARE @VIAJE INT
DECLARE C1 CURSOR FOR (SELECT itemf_viaje FROM inserted)
BEGIN
OPEN C1
FETCH NEXT FROM C1 INTO @VIAJE 
WHILE @@FETCH_STATUS = 0
	BEGIN
		IF(EXISTS(SELECT * FROM ITEM_FACTURA WHERE itemf_viaje = @VIAJE)) RAISERROR ('El viaje ya fue facturado', 16, 217) WITH SETERROR
		ELSE
			INSERT INTO ITEM_FACTURA(itemf_fact, itemf_precioViaje, itemf_viaje)
			SELECT itemf_fact, itemf_precioViaje, itemf_viaje
			FROM inserted
		FETCH NEXT FROM C1 INTO @VIAJE
	END
CLOSE C1
DEALLOCATE C1
END

GO 
CREATE TRIGGER VIAJE_NO_PAGO ON ITEM_RENDICION INSTEAD OF INSERT
AS
DECLARE @VIAJE INT
DECLARE C1 CURSOR FOR (SELECT itemr_viaje FROM inserted)
BEGIN
OPEN C1
FETCH NEXT FROM C1 INTO @VIAJE 
WHILE @@FETCH_STATUS = 0
	BEGIN
		IF(EXISTS(SELECT * FROM ITEM_RENDICION WHERE itemr_viaje = @VIAJE)) RAISERROR ('El viaje ya fue pagado', 16, 217) WITH SETERROR
		ELSE
			INSERT INTO ITEM_RENDICION(itemr_pago, itemr_precio, itemr_viaje)
			SELECT itemr_pago, itemr_precio, itemr_viaje
			FROM inserted
		FETCH NEXT FROM C1 INTO @VIAJE
	END
CLOSE C1
DEALLOCATE C1
END

