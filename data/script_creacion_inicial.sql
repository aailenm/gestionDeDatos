USE [GD1C2017]
GO
-- DROP DE TABLAS

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


--CREACION DE TABLAS

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
	itemr_porcentaje decimal(12,2) not null
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
	turn_hora_inicio int NOT NULL, -- TRIGGER PARA VALIDAR QUE LAS FRANJAS HORARIAS NO SE SOLAPEN
	turn_hora_fin int NOT NULL,
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
	viaj_chofer int NOT NULL
)

CREATE TABLE AUTOMOVIL(
	auto_id int PRIMARY KEY IDENTITY (1,1),
	auto_patente nvarchar(255) NOT NULL UNIQUE,
	auto_marca int NOT NULL,
	auto_modelo nvarchar(255) NOT NULL,
	--auto_chofer int not null? 
	auto_habilitado bit DEFAULT 1
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
	pago_chofer int NOT NULL
)

CREATE TABLE FACTURA(
	fact_id int  PRIMARY KEY IDENTITY (1,1),
	fact_fecha_inicio smalldatetime NOT NULL,
	fact_fecha_fin smalldatetime NOT NULL,
	fact_total decimal(12,2) NOT NULL,
	fact_cliente int NOT NULL,
	fact_nro_migracion int
)

-- FK
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

-- Migracion
-- ROL 
INSERT INTO ROL(rol_descripcion) values('Administrador')
INSERT INTO ROL(rol_descripcion) values('Cliente')
INSERT INTO ROL(rol_descripcion) values('Chofer')

--FUNCIONALIDADES
--falta agregar las funcionalidades a los roles
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
	SELECT m.Turno_Descripcion, m.Turno_Hora_Inicio,m.Turno_Hora_Fin, m.Turno_Precio_Base, m.Turno_Valor_Kilometro
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
----select distinct Cliente_Dni from gd_esquema.Maestra where Cliente_Dni is not null

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
insert into VIAJE(viaj_auto, viaj_cantidad_km, viaj_fyh_inicio, viaj_fyh_fin, viaj_turno, viaj_cliente, viaj_chofer)
		select isnull(au.auto_id,-1),
			   isnull(ma.Viaje_Cant_Kilometros,0),
			   isnull(ma.Viaje_Fecha, 0),
			   0, --ver esto
			   isnull(tu.turn_id,-1),
			   isnull(cli.clie_id,-1),
			   isnull(cho.chof_id,-1)
		from gd_esquema.Maestra ma
		left join Automovil au on au.auto_patente = ma.Auto_Patente
		left join CHOFER cho on chof_telefono = ma.Chofer_Telefono
		left join TURNO tu on tu.turn_descripcion = ma.Turno_Descripcion
		left join CLIENTE cli on clie_telefono = ma.Cliente_Telefono
		group by au.auto_id, cho.chof_id, ma.Viaje_Cant_Kilometros, ma.Viaje_Fecha, tu.turn_id, cli.clie_id
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
--insert into ITEM_FACTURA(itemf_fact, itemf_viaje, itemf_precioViaje)

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

--select Rendicion_Fecha, Rendicion_Nro from gd_esquema.Maestra where Factura_Fecha is null and Rendicion_Fecha is not null
--group by Rendicion_Nro, Rendicion_Fecha
---- para ver los viajes repetidos de la tabla maestra 
----select ma.Auto_Patente, ma.Cliente_Dni, ma.Chofer_Dni, ma.Turno_Descripcion, ma.Viaje_Fecha, 
----ma.Viaje_Cant_Kilometros,MAX(ma.Factura_Nro), MAX(ma.Rendicion_Nro), count(*) as repetidos
----from gd_esquema.Maestra ma 
----group by ma.Auto_Patente, ma.Cliente_Dni, ma.Chofer_Dni, ma.Turno_Descripcion, ma.Viaje_Fecha, ma.Viaje_Cant_Kilometros

---- viajes erroneos
----select * from VIAJE
----where viaj_auto < 0 
----or viaj_cantidad_km= 0 
----or viaj_cliente < 0 
----or viaj_turno < 0 
----or viaj_rendicion < 0 
----or viaj_factura < 0 
----or viaj_fyh_inicio < 0


-- --valida que no haya viajes repetidos cargados en nuestra tabla
----select viaj_turno, viaj_auto, viaj_cliente, viaj_fyh_inicio,  viaj_cantidad_km, COUNT(*)
----from VIAJE 
----group by viaj_turno, viaj_auto, viaj_cliente, viaj_fyh_inicio, viaj_cantidad_km
----having COUNT(*) > 1
----order by 1,2,3,4
--go
--create trigger Cifrar on Usuario after INSERT as
--begin
--update USUARIO set usua_password = HashBytes('SHA2_256',convert(nvarchar(255), usua_password)) 
--end
