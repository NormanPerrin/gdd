USE GD1C2017;
	GO

---- BORRO TABLAS Y REACTUALIZO

IF OBJECT_ID('CRAZYDRIVER.Viaje','U') IS NOT NULL
BEGIN
   DROP TABLE CRAZYDRIVER.Viaje;
END;

IF OBJECT_ID('CRAZYDRIVER.Facturacion','U') IS NOT NULL
BEGIN
   DROP TABLE CRAZYDRIVER.Facturacion;
END;

IF OBJECT_ID('CRAZYDRIVER.AutoPorChofer','U') IS NOT NULL
BEGIN
   DROP TABLE CRAZYDRIVER.AutoPorChofer;
END;

IF OBJECT_ID('CRAZYDRIVER.Auto','U') IS NOT NULL
BEGIN
   DROP TABLE CRAZYDRIVER.Auto;
END;

IF OBJECT_ID('CRAZYDRIVER.Rendicion','U') IS NOT NULL
BEGIN
   DROP TABLE CRAZYDRIVER.Rendicion;
END;

IF OBJECT_ID('CRAZYDRIVER.Turno','U') IS NOT NULL
BEGIN
   DROP TABLE CRAZYDRIVER.Turno;
END;

IF OBJECT_ID('CRAZYDRIVER.RolPorUsuario','U') IS NOT NULL
BEGIN
   DROP TABLE CRAZYDRIVER.RolPorUsuario;
END;

IF OBJECT_ID('CRAZYDRIVER.Usuario','U') IS NOT NULL
BEGIN
   DROP TABLE CRAZYDRIVER.Usuario;
END;

IF OBJECT_ID('CRAZYDRIVER.Persona','U') IS NOT NULL
BEGIN
   DROP TABLE CRAZYDRIVER.Persona;
END;

IF OBJECT_ID('CRAZYDRIVER.FuncionalidadPorRol','U') IS NOT NULL
BEGIN
   DROP TABLE CRAZYDRIVER.FuncionalidadPorRol;
END;

IF OBJECT_ID('CRAZYDRIVER.Rol','U') IS NOT NULL
BEGIN
   DROP TABLE CRAZYDRIVER.Rol;
END;

IF OBJECT_ID('CRAZYDRIVER.Funcionalidad','U') IS NOT NULL
BEGIN
   DROP TABLE CRAZYDRIVER.Funcionalidad;
END;

---- ESQUEMA POR SI NO EXISTE

IF EXISTS (SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = 'CRAZYDRIVER')
DROP SCHEMA CRAZYDRIVER
GO

CREATE SCHEMA CRAZYDRIVER AUTHORIZATION gd;
GO

---- TABLAS

CREATE TABLE CRAZYDRIVER.Funcionalidad(
	id_funcionalidad INT IDENTITY PRIMARY KEY,
	descripcion NVARCHAR(255) NOT NULL
);
GO

CREATE TABLE CRAZYDRIVER.Rol(
	id_rol INT IDENTITY PRIMARY KEY,
	nombre NVARCHAR(100) NOT NULL,
	habilitado TINYINT NOT NULL
);
GO

CREATE TABLE CRAZYDRIVER.FuncionalidadPorRol(
	id_funcionalidad INT NOT NULL FOREIGN KEY REFERENCES CRAZYDRIVER.Funcionalidad(id_funcionalidad),
	id_rol INT NOT NULL FOREIGN KEY REFERENCES CRAZYDRIVER.Rol(id_rol),
	habilitado TINYINT NOT NULL,
	PRIMARY KEY (id_funcionalidad, id_rol)
);
GO

CREATE TABLE CRAZYDRIVER.Persona(
	id_persona INT IDENTITY PRIMARY KEY,
	dni NUMERIC(18,0) UNIQUE NOT NULL,
	apellido NVARCHAR(255) NOT NULL,
	nombre NVARCHAR(255) NOT NULL,
	telefono NUMERIC(18,0) NOT NULL,
	mail NVARCHAR(255) NOT NULL,
	fecha_nac DATETIME NOT NULL,
	direccion NVARCHAR(255) NOT NULL,
	nro_piso INT,
	localidad NVARCHAR(255),
	cod_postal INT
);
GO

CREATE TABLE CRAZYDRIVER.Usuario(
	id_usuario INT IDENTITY PRIMARY KEY, -- no estoy seguro del not null porque el admin por ejemplo no va a tener una persona
	username NVARCHAR(225),
	pass VARBINARY(225),
	id_persona INT FOREIGN KEY REFERENCES CRAZYDRIVER.Persona(id_persona),
	habilitado TINYINT,
	intentos TINYINT
);
GO

CREATE TABLE CRAZYDRIVER.RolPorUsuario(
	id_rol INT NOT NULL FOREIGN KEY REFERENCES CRAZYDRIVER.Rol(id_rol),
	id_usuario INT NOT NULL FOREIGN KEY REFERENCES CRAZYDRIVER.Usuario(id_usuario) -- no estoy seguro si poner un habilitado aca
	PRIMARY KEY (id_rol, id_usuario)
);
GO

CREATE TABLE CRAZYDRIVER.Turno(
	id_turno INT IDENTITY PRIMARY KEY,
	hora_inicio NUMERIC(18,0) NOT NULL,
	hora_fin NUMERIC(18,0) NOT NULL,
	descripcion NVARCHAR(225) NOT NULL,
	valor_km NUMERIC(18,2),
	precio_base NUMERIC(18,2) NOT NULL,
	habilitado TINYINT
	-- (hora_inicio, hora_fin) podria ser una primary key porque no voy a tener tuplas repetidas de estos datos en a tabla
);
GO

CREATE TABLE CRAZYDRIVER.Rendicion(
	nro_rendicion NUMERIC(18,0) PRIMARY KEY, --cambie id_rendicion por nro_rendicion ya que nro es unica en la maestra para este grupo de datos
	fecha DATETIME NOT NULL,
  );
GO

CREATE TABLE CRAZYDRIVER.Auto(
	id_auto INT IDENTITY PRIMARY KEY,
	patente NVARCHAR(10) UNIQUE NOT NULL,
	marca NVARCHAR(225) NOT NULL,
	modelo NVARCHAR(225) NOT NULL,
	licencia NVARCHAR(26) NOT NULL,
	rodado NVARCHAR(10) NOT NULL,
	habilitado TINYINT
);
GO

CREATE TABLE CRAZYDRIVER.AutoPorChofer(
	id_auto INT NOT NULL FOREIGN KEY REFERENCES CRAZYDRIVER.Auto(id_auto),
	id_chofer INT NOT NULL FOREIGN KEY REFERENCES CRAZYDRIVER.Usuario(id_usuario),
	id_turno INT NOT NULL FOREIGN KEY REFERENCES CRAZYDRIVER.Turno(id_turno),
	PRIMARY KEY (id_auto, id_chofer, id_turno)
); --si no la vamos a usar para viaje y tenemos 3 keys en viaje es al pedo ya que cubrimos cualquier posibilidad en viaje de turno chofer y auto.
GO

CREATE TABLE CRAZYDRIVER.Facturacion(
	nro_facturacion NUMERIC(18,0) PRIMARY KEY, --cambie id_facturacion por nro_facturacion ya que nro es unico para este grupo de datos
	fecha_facturacion DATETIME NOT NULL,
	fecha_inicio DATETIME NOT NULL,
	fecha_fin DATETIME NOT NULL
);
GO

CREATE TABLE CRAZYDRIVER.Viaje(
	id_viaje INT IDENTITY PRIMARY KEY,
	id_cliente INT NOT NULL FOREIGN KEY REFERENCES CRAZYDRIVER.Usuario(id_usuario),
	id_chofer INT NOT NULL FOREIGN KEY REFERENCES CRAZYDRIVER.Usuario(id_usuario),
	id_turno INT NOT NULL FOREIGN KEY REFERENCES CRAZYDRIVER.Turno(id_turno),
	id_auto INT NOT NULL FOREIGN KEY REFERENCES CRAZYDRIVER.Auto(id_auto), -- en realidad no hace falta, pero para hacer el estadistico nos haria pegarle menos a la db al querer obtener el dato
	fecha DATETIME NOT NULL,
	cant_km NUMERIC(18,0) NOT NULL,
	nro_facturacion NUMERIC(18,0) FOREIGN KEY REFERENCES CRAZYDRIVER.Facturacion(nro_facturacion),
	nro_rendicion NUMERIC(18,0) FOREIGN KEY REFERENCES CRAZYDRIVER.Rendicion(nro_rendicion)
	-- PRIMARY KEY (id_cliente, id_chofer, id_turno, id_auto, fecha) podria ser pero los boludos del tp no pusieron fechas exactas en la db
);
GO

---- ROLES Y FUNCIONALIDES

INSERT INTO CRAZYDRIVER.Rol (nombre, habilitado)
	VALUES ('Administrador', 1);
GO

INSERT INTO CRAZYDRIVER.Rol (nombre, habilitado)
	VALUES ('Cliente', 1);
GO

INSERT INTO CRAZYDRIVER.Rol (nombre, habilitado)
	VALUES ('Chofer', 1);
GO

INSERT INTO CRAZYDRIVER.Rol (nombre, habilitado) -- tomarlo con pinzas, considerado como criterio para resolver el problema de inhabilitacion
	VALUES ('Default', 1);
GO

INSERT INTO CRAZYDRIVER.Funcionalidad(descripcion)
	VALUES ('ABM Rol'), ('ABM cliente'), ('ABM automovil'), ('ABM turno'), ('ABM chofer'),
	('Registrar viaje'), ('Rendir viaje'), ('Facturar cliente'), ('Listado Estadistico') -- no se si agregar una mas que sea dar de alta a usuarios
GO

---- DECLARACION DE ROLES Y FUNCIONALIDADES

-- Rol de un administrador (todo)
INSERT INTO CRAZYDRIVER.FuncionalidadPorRol(id_rol, id_funcionalidad, habilitado)
	VALUES (1, 1, 1), (1, 2, 1), (1, 3, 1), (1, 4, 1), (1, 5, 1), (1, 6, 1), (1, 7, 1), (1, 8, 1), (1, 9, 1)
GO
-- Rol de un cliente
INSERT INTO CRAZYDRIVER.FuncionalidadPorRol(id_rol, id_funcionalidad, habilitado)
	VALUES (2, 1, 0), (2, 2, 0), (2, 3, 0), (2, 4, 1), (2, 5, 1), (2, 6, 0), (2, 7, 0), (2, 8, 0), (2, 9, 1)
GO
-- Rol de un chofer
INSERT INTO CRAZYDRIVER.FuncionalidadPorRol(id_rol, id_funcionalidad, habilitado)
	VALUES (3, 1, 1), (3, 2, 1), (3, 3, 0), (3, 4, 0), (3, 5, 0), (3, 6, 1), (3, 7, 0), (3, 8, 1), (3, 9, 0)
GO
-- Rol default (nada)
INSERT INTO CRAZYDRIVER.FuncionalidadPorRol(id_rol, id_funcionalidad, habilitado)
	VALUES (4, 1, 0), (4, 2, 0), (4, 3, 0), (4, 4, 0), (4, 5, 0), (4, 6, 0), (4, 7, 0), (4, 8, 0), (4, 9, 0)
GO

---- DATOS AUTOGENERADOS

DECLARE @hash_password VARBINARY(225)
	SELECT @hash_password = HASHBYTES('SHA2_256', N'w23e');
INSERT INTO CRAZYDRIVER.Usuario(username, pass, id_persona, habilitado, intentos)
	values
		('admin', HASHBYTES('SHA2_256', N'w23e'), null, 1, 0)
GO

INSERT INTO CRAZYDRIVER.RolPorUsuario(id_usuario, id_rol)
	values
		((select id_usuario from CRAZYDRIVER.Usuario where username = 'admin'), 1)
GO

---- MIGRACION

INSERT INTO CRAZYDRIVER.Persona(dni, apellido, nombre, telefono, mail, fecha_nac, direccion, nro_piso, localidad, cod_postal)
	SELECT
		m.Chofer_Dni, m.Chofer_Apellido, m.Chofer_Nombre, m.Chofer_Telefono, m.Chofer_Mail, m.Chofer_Fecha_Nac, m.Chofer_Direccion, null, null, null
	FROM
		gd_esquema.Maestra m
	WHERE
		m.Chofer_Dni IS NOT NULL
    UNION
	SELECT
		m.Cliente_Dni, m.Cliente_Apellido, m.Cliente_Nombre, m.Cliente_Telefono, m.Cliente_Mail, m.Cliente_Fecha_Nac, m.Cliente_Direccion, null, null, null
	FROM
		gd_esquema.Maestra m
	WHERE
		m.Cliente_Dni IS NOT NULL
GO

DECLARE @hash_password VARBINARY(225)
	SELECT @hash_password = HASHBYTES('SHA2_256', N'w23e');
INSERT INTO CRAZYDRIVER.Usuario(username, pass, id_persona, habilitado, intentos)
	SELECT 
		(SELECT CAST(p.dni AS NVARCHAR(225))), @hash_password, p.id_persona, 1, 0
	FROM
		CRAZYDRIVER.Persona p
GO

INSERT INTO CRAZYDRIVER.RolPorUsuario(id_rol, id_usuario) -- cargo usuarios con rol de clientes
	SELECT DISTINCT
		2, u.id_persona
	FROM
		gd_esquema.Maestra m, CRAZYDRIVER.Usuario u, CRAZYDRIVER.Persona p
	WHERE
		m.Cliente_Dni IS NOT NULL AND m.Cliente_Dni = p.dni AND p.id_persona = u.id_persona
GO

INSERT INTO CRAZYDRIVER.RolPorUsuario(id_rol, id_usuario) -- cargo usuarios con rol de choferes
	SELECT DISTINCT
		3, u.id_persona
	FROM
		gd_esquema.Maestra m, CRAZYDRIVER.Usuario u, CRAZYDRIVER.Persona p
	WHERE
		m.Chofer_Dni IS NOT NULL AND m.Chofer_Dni = p.dni AND p.id_persona = u.id_persona
GO

INSERT INTO CRAZYDRIVER.Turno(hora_inicio, hora_fin, descripcion, valor_km, precio_base, habilitado)
	SELECT DISTINCT
		m.Turno_Hora_Inicio, m.Turno_Hora_Fin, m.Turno_Descripcion, m.Turno_Valor_Kilometro, m.Turno_Precio_Base, 1
	FROM
		gd_esquema.Maestra m
	WHERE
		m.Turno_Descripcion IS NOT NULL
GO

INSERT INTO CRAZYDRIVER.Auto(patente, marca, modelo, licencia, rodado, habilitado)
	SELECT DISTINCT
		m.Auto_Patente, m.Auto_Marca, m.Auto_Modelo, m.Auto_Licencia, m.Auto_Rodado, 1
	FROM
		gd_esquema.Maestra m
	WHERE
		m.Auto_Patente IS NOT NULL
	GO

INSERT INTO CRAZYDRIVER.AutoPorChofer(id_auto, id_chofer, id_turno)
	SELECT DISTINCT
		a.id_auto, u.id_usuario, t.id_turno
	FROM
		gd_esquema.Maestra m, CRAZYDRIVER.Turno t, CRAZYDRIVER.Usuario u, CRAZYDRIVER.Persona p, CRAZYDRIVER.Auto a
	WHERE
		m.Auto_Patente IS NOT NULL AND m.Auto_Patente = a.patente
			AND (m.Chofer_Dni = p.dni AND p.id_persona = u.id_persona)
			AND (m.Turno_Hora_Inicio = t.hora_inicio AND m.Turno_Hora_Fin = t.hora_fin)
GO

INSERT INTO CRAZYDRIVER.Facturacion(nro_facturacion, fecha_facturacion, fecha_inicio, fecha_fin)
	select DISTINCT Factura_Nro,Factura_Fecha,Factura_Fecha_Fin,Factura_Fecha_Inicio
    from gd_esquema.Maestra where Factura_Nro is not null
GO



INSERT INTO CRAZYDRIVER.Rendicion(nro_rendicion, fecha)
	select DISTINCT Rendicion_Nro,Rendicion_Fecha
	from gd_esquema.Maestra
	where Rendicion_Nro is not null
GO

INSERT INTO CRAZYDRIVER.Viaje(id_cliente, id_chofer, id_turno, id_auto, fecha, cant_km, nro_facturacion,nro_rendicion)

 select DISTINCT ucl.id_usuario,uch.id_usuario,t.id_turno,a.id_auto,m.Viaje_Fecha,m.Viaje_Cant_Kilometros,
(select DISTINCT Factura_Nro
from gd_esquema.Maestra
where chofer_dni = m.Chofer_Dni
and Cliente_Dni = m.Cliente_Dni
and Viaje_Cant_Kilometros = m.Viaje_Cant_Kilometros
and Viaje_Fecha = m.Viaje_Fecha
and Turno_Descripcion = m.Turno_Descripcion
and Turno_Hora_Fin = m.Turno_Hora_Fin
and Turno_Hora_Inicio = m.Turno_Hora_Inicio
and Turno_Precio_Base = m.Turno_Precio_Base
and Turno_Valor_Kilometro = m.Turno_Valor_Kilometro
and Auto_Patente = m.Auto_Patente
and Factura_nro is not null),

(select DISTINCT Rendicion_Nro
from gd_esquema.Maestra
where chofer_dni = m.Chofer_Dni
and Cliente_Dni = m.Cliente_Dni
and Viaje_Cant_Kilometros = m.Viaje_Cant_Kilometros
and Viaje_Fecha = m.Viaje_Fecha
and Turno_Descripcion = m.Turno_Descripcion
and Turno_Hora_Fin = m.Turno_Hora_Fin
and Turno_Hora_Inicio = m.Turno_Hora_Inicio
and Turno_Precio_Base = m.Turno_Precio_Base
and Turno_Valor_Kilometro = m.Turno_Valor_Kilometro
and Auto_Patente = m.Auto_Patente
and Rendicion_Nro is not null)

from gd_esquema.Maestra m 
	JOIN CRAZYDRIVER.Persona cl
	    on m.Cliente_Dni = cl.dni
	JOIN CRAZYDRIVER.Persona ch 
		on m.Chofer_Dni = ch.dni
	JOIN CRAZYDRIVER.Turno t  
		on m.Turno_Descripcion = t.descripcion 
		and m.Turno_Hora_Fin = t.hora_fin
		and m.Turno_Hora_Inicio = t.hora_inicio
		and m.Turno_Precio_Base = t.precio_base
		and m.Turno_Valor_Kilometro = t.valor_km
	JOIN CRAZYDRIVER.Auto a
		on m.Auto_Patente = a.patente
	JOIN CRAZYDRIVER.Usuario uch on uch.id_persona = ch.id_persona
	JOIN CRAZYDRIVER.Usuario ucl on ucl.id_persona = cl.id_persona

	
GO


