USE [GD1C2017]
GO
-- DROP DE TABLAS

IF OBJECT_ID('ROL_POR_USUARIO') IS NOT NULL
DROP TABLE ROL_POR_USUARIO

IF OBJECT_ID('ROL_POR_FUNCIONALIDAD') IS NOT NULL
DROP TABLE ROL_POR_FUNCIONALIDAD

IF OBJECT_ID('FUNCIONALIDAD') IS NOT NULL
DROP TABLE FUNCIONALIDAD

IF OBJECT_ID('VIAJE') IS NOT NULL
DROP TABLE VIAJE

IF OBJECT_ID('FACTURA') IS NOT NULL
DROP TABLE FACTURA

IF OBJECT_ID('RENDICION_VIAJE') IS NOT NULL
DROP TABLE RENDICION_VIAJE

IF OBJECT_ID('TURNO_POR_AUTO') IS NOT NULL
DROP TABLE TURNO_POR_AUTO

IF OBJECT_ID('TURNO') IS NOT NULL
DROP TABLE TURNO

IF OBJECT_ID('AUTOMOVIL') IS NOT NULL
DROP TABLE AUTOMOVIL

IF OBJECT_ID('MARCA') IS NOT NULL
DROP TABLE MARCA

IF OBJECT_ID('USUARIO') IS NOT NULL
DROP TABLE USUARIO

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
	usua_habilitado bit default 1,
	usua_nombre nvarchar(255) NOT NULL ,
	usua_apellido nvarchar(255) NOT NULL ,
	usua_dni bigint NOT NULL UNIQUE,
	usua_mail nvarchar(255),
	usua_telefono nvarchar(255) NOT NULL ,
	usua_fechaNacimiento datetime NOT NULL,
	usua_direccion nvarchar(255) NOT NULL
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
	viaj_fyh_inicio datetime,
	viaj_fyh_fin datetime,
	viaj_cliente int,
	viaj_turno int,
	viaj_auto int,
	viaj_factura int,
	viaj_rendicion int
)

CREATE TABLE AUTOMOVIL(
	auto_id int PRIMARY KEY IDENTITY (1,1),
	auto_patente nvarchar(255) NOT NULL UNIQUE,
	auto_marca int,
	auto_modelo nvarchar(255) NOT NULL,
	auto_habilitado bit DEFAULT 1
)

CREATE TABLE TURNO_POR_AUTO(
	auto_id int,
	chof_id int,
	turn_id int
	PRIMARY KEY(auto_id, turn_id)
)

CREATE TABLE MARCA(
	marc_id int PRIMARY KEY IDENTITY (1,1),
	marc_detalle nvarchar(255) NOT NULL UNIQUE
	)

CREATE TABLE RENDICION_VIAJE(
	pago_id int PRIMARY KEY IDENTITY(1,1),
	pago_fecha datetime,
	pago_importe_total decimal(12,2),
	pago_turno int,
	pago_auto int
)

CREATE TABLE FACTURA(
	fact_id int  PRIMARY KEY IDENTITY (1,1),
	fact_fecha_inicio datetime,
	fact_fecha_fin datetime,
	fact_total decimal(12,2),
	fact_cliente int,
)

-- FK

ALTER TABLE ROL_POR_USUARIO ADD FOREIGN KEY (rol_id) REFERENCES ROL
ALTER TABLE ROL_POR_USUARIO ADD FOREIGN KEY (usua_id) REFERENCES USUARIO
ALTER TABLE ROL_POR_FUNCIONALIDAD ADD FOREIGN KEY (rol_id) REFERENCES ROL
ALTER TABLE ROL_POR_FUNCIONALIDAD ADD FOREIGN KEY (func_id) REFERENCES FUNCIONALIDAD
ALTER TABLE VIAJE ADD FOREIGN KEY (viaj_cliente) REFERENCES USUARIO
ALTER TABLE VIAJE ADD FOREIGN KEY (viaj_auto, viaj_turno) REFERENCES TURNO_POR_AUTO
ALTER TABLE VIAJE ADD FOREIGN KEY (viaj_rendicion) REFERENCES RENDICION_VIAJE
ALTER TABLE VIAJE ADD FOREIGN KEY (viaj_factura) REFERENCES FACTURA
ALTER TABLE AUTOMOVIL ADD FOREIGN KEY (auto_marca) REFERENCES MARCA
ALTER TABLE TURNO_POR_AUTO ADD FOREIGN KEY (auto_id) REFERENCES AUTOMOVIL
ALTER TABLE TURNO_POR_AUTO ADD FOREIGN KEY (turn_id) REFERENCES TURNO
ALTER TABLE RENDICION_VIAJE ADD FOREIGN KEY (pago_auto, pago_turno) REFERENCES TURNO_POR_AUTO
ALTER TABLE FACTURA ADD FOREIGN KEY (fact_cliente) REFERENCES USUARIO

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
INSERT INTO USUARIO(usua_usuario, usua_password, usua_nombre, usua_apellido, usua_dni, usua_telefono,usua_fechaNacimiento, usua_mail, usua_direccion)
	   VALUES('admin', 'w23e', '','','','','','', '')

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
insert into USUARIO(usua_usuario, usua_password, usua_dni, usua_nombre, usua_apellido, usua_telefono, usua_fechaNacimiento, usua_mail, usua_direccion)
	   select distinct m.Cliente_Dni,m.Cliente_Dni,m.Cliente_Dni, m.Cliente_Nombre, m.Cliente_Apellido, m.Cliente_Telefono, m.Cliente_Fecha_Nac, m.Cliente_Mail, m.Cliente_Direccion
	   from gd_esquema.Maestra m

-- 47 clientes 
--select distinct Cliente_Dni from gd_esquema.Maestra where Cliente_Dni is not null

-- Choferes
insert into USUARIO(usua_usuario, usua_password, usua_dni, usua_nombre, usua_apellido, usua_telefono, usua_fechaNacimiento, usua_mail, usua_direccion)
	   select distinct m.Chofer_Dni,m.Chofer_Dni,m.Chofer_Dni, m.Chofer_Nombre, m.Chofer_Apellido, m.Chofer_Telefono, m.Chofer_Fecha_Nac, m.Chofer_Mail, m.Chofer_Direccion
	   from gd_esquema.Maestra m

-- ROL POR USUARIO
insert into ROL_POR_USUARIO(usua_id, rol_id)
	   select usua_id, 1 
	   from USUARIO join gd_esquema.Maestra 
	   on usua_dni = Cliente_Dni
	   group by usua_id

insert into ROL_POR_USUARIO(usua_id, rol_id) 
		select usua_id, 2
		from USUARIO join gd_esquema.Maestra
		on usua_dni = Chofer_Dni 
		group by usua_id

-- AUTOS
insert into AUTOMOVIL(auto_patente,auto_marca, auto_modelo)
		select distinct m.Auto_patente, (select marc_id from Marca where m.Auto_Marca = marc_detalle), m.Auto_Modelo
		from gd_esquema.Maestra m
-- 41 autos

-- turnos por auto
insert into TURNO_POR_AUTO(chof_id, turn_id, auto_id) 
	   select distinct usua_id, turn_id, auto_id from gd_esquema.Maestra m join TURNO t on turn_descripcion = m.Turno_Descripcion
	   join AUTOMOVIL a on a.auto_patente = m.Auto_Patente
	   join USUARIO on usua_dni = Chofer_Dni
	   order by turn_id

-- Facturas
insert into FACTURA(fact_fecha_inicio, fact_fecha_fin, fact_cliente, fact_total)
		select ma.Factura_Fecha_Inicio, ma.Factura_Fecha_Fin, (select usua_id from USUARIO where usua_dni = ma.Cliente_Dni), SUM(ma.Turno_Precio_Base * ma.Turno_Valor_Kilometro)
		from gd_esquema.Maestra ma
		where ma.Factura_Fecha_Fin is not null
		group by ma.Factura_Nro, ma.Factura_Fecha_Inicio, ma.Factura_Fecha_Fin, ma.Cliente_Dni

-- Rendicoines
insert into RENDICION_VIAJE(pago_turno, pago_auto, pago_fecha, pago_importe_total)
	   select t.turn_id, a.auto_id, ma.Rendicion_Fecha, sum(ma.Rendicion_Importe)
	   from gd_esquema.Maestra ma, TURNO t , AUTOMOVIL a 
	   where ma.Rendicion_Importe is not null
	   and t.turn_id = t.turn_id 
	   and a.auto_id = a.auto_id
	   and a.auto_patente = ma.Auto_Patente
	   and t.turn_descripcion = ma.Turno_Descripcion
	   group by t.turn_id, a.auto_id, ma.Rendicion_Fecha

-- Viajes
-- inserto los viajes que no tienen factura ni rendicion
insert into VIAJE(viaj_cantidad_km, viaj_fyh_inicio, viaj_fyh_fin, viaj_cliente, viaj_auto, viaj_turno)
	  select ma.Viaje_Cant_Kilometros, 
			 ma.Viaje_Fecha, 
			 0, --ver esto 
			 us.usua_id,
			 au.auto_id,
			 tu.turn_id
	  from gd_esquema.Maestra ma join USUARIO us on us.usua_dni = ma.Cliente_Dni
	  join AUTOMOVIL au on au.auto_patente = ma.Auto_Patente
	  join TURNO tu on tu.turn_descripcion = ma.Turno_Descripcion
	  where ma.Rendicion_Nro is null and ma.Factura_Fecha is null

--inserto los viajes que solo tienen factura
insert into VIAJE(viaj_cantidad_km, viaj_fyh_inicio, viaj_fyh_fin, viaj_cliente, viaj_auto, viaj_turno, viaj_factura)
	  select ma.Viaje_Cant_Kilometros, 
			 ma.Viaje_Fecha, 
			 0, --ver esto 
			 us.usua_id,
			 au.auto_id,
			 tu.turn_id,
			 f.fact_id
	  from gd_esquema.Maestra ma join USUARIO us on us.usua_dni = ma.Cliente_Dni
	  join AUTOMOVIL au on au.auto_patente = ma.Auto_Patente
	  join TURNO tu on tu.turn_descripcion = ma.Turno_Descripcion
	  join FACTURA f on f.fact_cliente = us.usua_id 
	  where ma.Rendicion_Nro is null and ma.Factura_Fecha_Inicio = f.fact_fecha_inicio and ma.Factura_Fecha_Fin = f.fact_fecha_fin

-- inserto los viaes que solo tienen rendicion
insert into VIAJE(viaj_cantidad_km, viaj_fyh_inicio, viaj_fyh_fin, viaj_cliente, viaj_auto, viaj_turno, viaj_rendicion)
select ma.Viaje_Cant_Kilometros, 
			 ma.Viaje_Fecha, 
			 0, --ver esto 
			 us.usua_id,
			 au.auto_id,
			 tu.turn_id,
			 r.pago_id
	from gd_esquema.Maestra ma join USUARIO us on us.usua_dni = ma.Cliente_Dni
	  join AUTOMOVIL au on au.auto_patente = ma.Auto_Patente
	  join TURNO tu on tu.turn_descripcion = ma.Turno_Descripcion
	  join RENDICION_VIAJE r on r.pago_auto = au.auto_id
	  and tu.turn_id = r.pago_turno
	  where ma.Rendicion_Fecha = r.pago_fecha and ma.Factura_Fecha_Inicio IS NULL

-- valida que no haya viajes repetidos
select viaj_turno, viaj_auto, viaj_cliente, viaj_fyh_inicio,  viaj_cantidad_km, COUNT(*)
from VIAJE 
group by viaj_turno, viaj_auto, viaj_cliente, viaj_fyh_inicio, viaj_cantidad_km
having COUNT(*) > 1
order by 1,2,3,4


