USE [GD1C2017]
GO
-- DROP DE TABLAS

IF OBJECT_ID('ROL_POR_USUARIO') IS NOT NULL
DROP TABLE ROL_POR_USUARIO

IF OBJECT_ID('ROL_POR_FUNCIONALIDAD') IS NOT NULL
DROP TABLE ROL_POR_FUNCIONALIDAD

IF OBJECT_ID('FUNCIONALIDAD') IS NOT NULL
DROP TABLE FUNCIONALIDAD

IF OBJECT_ID('USUARIO') IS NOT NULL
DROP TABLE  USUARIO

IF OBJECT_ID('ADMINISTRADOR') IS NOT NULL
DROP TABLE ADMINISTRADOR

IF OBJECT_ID('ITEM_RENDICION') IS NOT NULL
DROP TABLE ITEM_RENDICION

IF OBJECT_ID('ITEM_FACTURA') IS NOT NULL
DROP TABLE ITEM_FACTURA

IF OBJECT_ID('FACTURA') IS NOT NULL
DROP TABLE FACTURA

IF OBJECT_ID('VIAJE') IS NOT NULL
DROP TABLE VIAJE

IF OBJECT_ID('RENDICION_VIAJE') IS NOT NULL
DROP TABLE RENDICION_VIAJE

IF OBJECT_ID('TURNO_POR_AUTO_POR_CHOFER') IS NOT NULL
DROP TABLE TURNO_POR_AUTO_POR_CHOFER

IF OBJECT_ID('TURNO') IS NOT NULL
DROP TABLE TURNO

IF OBJECT_ID('CHOFER') IS NOT NULL
DROP TABLE CHOFER

IF OBJECT_ID('AUTOMOVIL') IS NOT NULL
DROP TABLE AUTOMOVIL

IF OBJECT_ID('MARCA') IS NOT NULL
DROP TABLE MARCA

IF OBJECT_ID('CLIENTE') IS NOT NULL
DROP TABLE CLIENTE

IF OBJECT_ID('DIRECCION') IS NOT NULL
DROP TABLE DIRECCION

IF OBJECT_ID('ROL') IS NOT NULL
DROP TABLE ROL

--CREACION DE TABLAS

CREATE TABLE ROL(
	rol_id int PRIMARY KEY IDENTITY(1,1),
	rol_habilitado bit DEFAULT 1, 
	rol_descripcion nvarchar(255) UNIQUE
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
	usua_id int,
	PRIMARY KEY (rol_id, usua_id)
)

CREATE TABLE FUNCIONALIDAD(
	func_id int PRIMARY KEY IDENTITY (1,1),
	func_descripcion nvarchar(255) NOT NULL UNIQUE
)

CREATE TABLE ROL_POR_FUNCIONALIDAD(
	rol_id int,
	func_id int,
	func_habilitada bit DEFAULT 1
	PRIMARY KEY(rol_id, func_id)	
)

CREATE TABLE CLIENTE (
	clie_rol int,
	clie_id int PRIMARY KEY IDENTITY (1,1),
	clie_nombre nvarchar(255) NOT NULL ,
	clie_apellido nvarchar(255) NOT NULL ,
	clie_dni bigint NOT NULL,
	clie_mail nvarchar(255),
	clie_telefono nvarchar(255) NOT NULL ,
	clie_fechaNacimiento datetime NOT NULL,
	clie_direccion int,
	clie_habilitado bit DEFAULT 1
)

CREATE TABLE ADMINISTRADOR(
	admi_rol int,
	admi_id int PRIMARY KEY IDENTITY (1,1)
	)

CREATE TABLE CHOFER(
	chof_rol int,
	chof_id int PRIMARY KEY IDENTITY (1,1),
	chof_nombre nvarchar(255) NOT NULL ,
	chof_apellido nvarchar(255) NOT NULL ,
	chof_dni  bigint NOT NULL,
	chof_telefono nvarchar(255) NOT NULL,
	chof_mail nvarchar(255) NOT NULL ,
	chof_fechaNacimiento datetime NOT NULL,
	chof_direccion int NOT NULL,
	chof_habilitado bit DEFAULT 1
)

CREATE TABLE DIRECCION(
	dire_id int PRIMARY KEY IDENTITY (1,1),
	dire_calle nvarchar(255) NOT NULL ,
	dire_depto  nvarchar(255) ,
	dire_piso  nvarchar(255) ,
	dire_localidad nvarchar(255) NOT NULL ,
	dire_cp nvarchar(50) NOT NULL ,
	)

CREATE TABLE TURNO(
	turn_id int PRIMARY KEY IDENTITY (1,1),
	turn_hora_inicio int NOT NULL,
	turn_hora_fin int NOT NULL,
	turn_descripcion nvarchar(255) NOT NULL UNIQUE,
	turn_valor_km decimal(12,2),
	turn_precio_base decimal(12,2),
	turn_habilitado bit DEFAULT 1
)

CREATE TABLE VIAJE(
	viaj_id int PRIMARY KEY IDENTITY (1,1),
	viaj_cantidad_km decimal(10,2),
	viaj_pago_id int,
	viaj_fyh_inicio datetime,
	viaj_fyh_fin datetime,
	viaj_cliente int,
	viaj_turno int,
	viaj_chofer int,
	viaj_auto int
)

CREATE TABLE AUTOMOVIL(
	auto_id int PRIMARY KEY IDENTITY (1,1),
	auto_patente nvarchar(255) NOT NULL UNIQUE,
	auto_marca int,
	auto_modelo nvarchar(255) NOT NULL,
	auto_habilitado bit DEFAULT 1,
)

CREATE TABLE TURNO_POR_AUTO_POR_CHOFER(
	auto_id int,
	chof_id int,
	turn_id int
	PRIMARY KEY(auto_id, chof_id, turn_id)
)

CREATE TABLE MARCA(
	marc_id int PRIMARY KEY IDENTITY (1,1),
	marc_detalle nvarchar(255) NOT NULL UNIQUE
	)

CREATE TABLE RENDICION_VIAJE(
	pago_id int,
	pago_turno int,
	pago_chofer int,
	pago_auto int,
	PRIMARY KEY(pago_id, pago_auto, pago_chofer, pago_turno),
	pago_fecha datetime,
	pago_importe_total decimal(12,2)
)

CREATE TABLE ITEM_RENDICION(
	itemr_id int,
	itemr_turno int,
	itemr_chofer int,
	itemr_auto int,
	itemr_pago int,
	PRIMARY KEY(itemr_id, itemr_pago, itemr_auto, itemr_chofer, itemr_turno),
	itemr_viaje int,
	itemr_precio decimal(12,2)
)

CREATE TABLE FACTURA(
	fact_numero bigint,
	fact_sucursal bigint,
	fact_tipo varchar(1),
	PRIMARY KEY(fact_tipo, fact_sucursal, fact_numero),
	fact_fecha_inicio datetime,
	fact_fecha_fin datetime,
	fact_total decimal(12,2),
	fact_cliente int,
)

CREATE TABLE ITEM_FACTURA(
	item_numero bigint,
	item_sucursal bigint,
	item_tipo varchar(1),
	PRIMARY KEY(item_tipo, item_sucursal, item_numero),
	item_viaje int,
	item_precioViaje decimal(12,2)
)

-- FK

ALTER TABLE ROL_POR_USUARIO ADD FOREIGN KEY (rol_id) REFERENCES ROL
ALTER TABLE ROL_POR_USUARIO ADD FOREIGN KEY (usua_id) REFERENCES USUARIO
ALTER TABLE ROL_POR_FUNCIONALIDAD ADD FOREIGN KEY (rol_id) REFERENCES ROL
ALTER TABLE ROL_POR_FUNCIONALIDAD ADD FOREIGN KEY (func_id) REFERENCES FUNCIONALIDAD
ALTER TABLE CLIENTE ADD FOREIGN KEY (clie_rol) REFERENCES ROL
ALTER TABLE CLIENTE ADD FOREIGN KEY (clie_direccion) REFERENCES DIRECCION
ALTER TABLE ADMINISTRADOR ADD FOREIGN KEY (admi_rol) REFERENCES ROL
ALTER TABLE CHOFER ADD FOREIGN KEY (chof_rol) REFERENCES ROL
ALTER TABLE CHOFER ADD FOREIGN KEY (chof_direccion) REFERENCES DIRECCION
ALTER TABLE VIAJE ADD FOREIGN KEY (viaj_cliente) REFERENCES CLIENTE
ALTER TABLE VIAJE ADD FOREIGN KEY (viaj_auto, viaj_chofer, viaj_turno) REFERENCES TURNO_POR_AUTO_POR_CHOFER
ALTER TABLE AUTOMOVIL ADD FOREIGN KEY (auto_marca) REFERENCES MARCA
ALTER TABLE TURNO_POR_AUTO_POR_CHOFER ADD FOREIGN KEY (auto_id) REFERENCES AUTOMOVIL
ALTER TABLE TURNO_POR_AUTO_POR_CHOFER ADD FOREIGN KEY (turn_id) REFERENCES TURNO
ALTER TABLE TURNO_POR_AUTO_POR_CHOFER ADD FOREIGN KEY (chof_id) REFERENCES CHOFER
ALTER TABLE RENDICION_VIAJE ADD FOREIGN KEY (pago_auto, pago_chofer, pago_turno) REFERENCES TURNO_POR_AUTO_POR_CHOFER
ALTER TABLE ITEM_RENDICION ADD FOREIGN KEY (itemr_pago, itemr_auto, itemr_chofer, itemr_turno) REFERENCES RENDICION_VIAJE
ALTER TABLE ITEM_RENDICION ADD FOREIGN KEY (itemr_viaje) REFERENCES VIAJE
ALTER TABLE FACTURA ADD FOREIGN KEY (fact_cliente) REFERENCES CLIENTE
ALTER TABLE ITEM_FACTURA ADD FOREIGN KEY (item_tipo, item_sucursal, item_numero) REFERENCES FACTURA
ALTER TABLE ITEM_FACTURA ADD FOREIGN KEY (item_viaje) REFERENCES VIAJE

-- Migracion
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

-- USUARIO
INSERT INTO USUARIO(usua_usuario, usua_password) VALUES('admin', 'w23e')

--ADMINISTRADOR
INSERT INTO ADMINISTRADOR(admi_rol) VALUES (1)

--ROL POR USUARIO
INSERT INTO ROL_POR_USUARIO(rol_id, usua_id) VALUES (1,1)

-- MARCA DE AUTOS
INSERT INTO MARCA(marc_detalle) 
	SELECT m.Auto_Marca 
	FROM gd_esquema.Maestra m 
	group by m.Auto_Marca

-- TURNOS
INSERT INTO TURNO(turn_descripcion, turn_hora_inicio, turn_hora_fin,turn_precio_base, turn_valor_km) 
	SELECT m.Turno_Descripcion, m.Turno_Hora_Inicio,m.Turno_Hora_Fin, m.Turno_Precio_Base, m.Turno_Valor_Kilometro
	from gd_esquema.Maestra m 
	group by m.Turno_Descripcion, m.Turno_Hora_Inicio, m.Turno_Hora_Fin, m.Turno_Precio_Base, m.Turno_Valor_Kilometro

