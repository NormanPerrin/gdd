USE GD1C2017;
	GO

---- BORRO PROCEDIMIENTOS

IF OBJECT_ID('CRAZYDRIVER.spLogin') IS NOT NULL
BEGIN
	DROP PROCEDURE CRAZYDRIVER.spLogin;
END;

IF OBJECT_ID('CRAZYDRIVER.spEditarIntentosUsuario') IS NOT NULL
BEGIN
	DROP PROCEDURE CRAZYDRIVER.spEditarIntentosUsuario;
END;

IF OBJECT_ID('CRAZYDRIVER.spObtenerFuncionalidadesPorRol') IS NOT NULL
BEGIN
	DROP PROCEDURE CRAZYDRIVER.spObtenerFuncionalidadesPorRol;
END;

IF OBJECT_ID('CRAZYDRIVER.spObtenerFuncionalidades') IS NOT NULL
BEGIN
	DROP PROCEDURE CRAZYDRIVER.spObtenerFuncionalidades;
END;

IF OBJECT_ID('CRAZYDRIVER.spObtenerHorarioTurno') IS NOT NULL
BEGIN
	DROP PROCEDURE CRAZYDRIVER.spObtenerHorarioTurno;
END;

IF OBJECT_ID('CRAZYDRIVER.spObtenerRolesPorUsuario') IS NOT NULL
BEGIN
	DROP PROCEDURE CRAZYDRIVER.spObtenerRolesPorUsuario;
END;

IF OBJECT_ID('CRAZYDRIVER.spObtenerRoles') IS NOT NULL
BEGIN
	DROP PROCEDURE CRAZYDRIVER.spObtenerRoles;
END;

IF OBJECT_ID('CRAZYDRIVER.spObtenerRol') IS NOT NULL
BEGIN
	DROP PROCEDURE CRAZYDRIVER.spObtenerRol;
END;

IF OBJECT_ID('CRAZYDRIVER.spAgregarRol') IS NOT NULL
BEGIN
	DROP PROCEDURE CRAZYDRIVER.spAgregarRol;
END;

IF OBJECT_ID('CRAZYDRIVER.spAgregarRolFuncionalidad') IS NOT NULL
BEGIN
	DROP PROCEDURE CRAZYDRIVER.spAgregarRolFuncionalidad;
END;

IF OBJECT_ID('CRAZYDRIVER.spObtenerTurnos') IS NOT NULL
BEGIN
	DROP PROCEDURE CRAZYDRIVER.spObtenerTurnos;
END;

IF OBJECT_ID('CRAZYDRIVER.spObtenerChoferes') IS NOT NULL
BEGIN
	DROP PROCEDURE CRAZYDRIVER.spObtenerChoferes;
END;

IF OBJECT_ID('CRAZYDRIVER.spBuscarRoles') IS NOT NULL
BEGIN
	DROP PROCEDURE CRAZYDRIVER.spBuscarRoles;
END;

IF OBJECT_ID('CRAZYDRIVER.spActualizarRol') IS NOT NULL
BEGIN
	DROP PROCEDURE CRAZYDRIVER.spActualizarRol;
END;

IF OBJECT_ID('CRAZYDRIVER.spActualizarFuncionalidadPorRol') IS NOT NULL
BEGIN
	DROP PROCEDURE CRAZYDRIVER.spActualizarFuncionalidadPorRol;
END;

IF OBJECT_ID('CRAZYDRIVER.spObtenerTodoChoferes') IS NOT NULL
BEGIN
	DROP PROCEDURE CRAZYDRIVER.spObtenerTodoChoferes;
END;

IF OBJECT_ID('CRAZYDRIVER.spAgregarCliente') IS NOT NULL
BEGIN
	DROP PROCEDURE CRAZYDRIVER.spAgregarCliente;
END;

IF OBJECT_ID('CRAZYDRIVER.spAgregarViaje') IS NOT NULL
BEGIN
	DROP PROCEDURE CRAZYDRIVER.spAgregarViaje;
END;

IF OBJECT_ID('CRAZYDRIVER.spObtenerChoferesPorTurno') IS NOT NULL
BEGIN
	DROP PROCEDURE CRAZYDRIVER.spObtenerChoferesPorTurno;
END;

IF OBJECT_ID('CRAZYDRIVER.spObtenerValorTurno') IS NOT NULL
BEGIN
	DROP PROCEDURE CRAZYDRIVER.spObtenerValorTurno;
END;

IF OBJECT_ID('CRAZYDRIVER.spObtenerAutoPorIDChoferTurno') IS NOT NULL
BEGIN
	DROP PROCEDURE CRAZYDRIVER.spObtenerAutoPorIDChoferTurno;
END;

IF OBJECT_ID('CRAZYDRIVER.spObtenerClientes') IS NOT NULL
BEGIN
	DROP PROCEDURE CRAZYDRIVER.spObtenerClientes;
END;

IF OBJECT_ID('CRAZYDRIVER.spObtenerChoferEspecifico') IS NOT NULL
BEGIN
	DROP PROCEDURE CRAZYDRIVER.spObtenerChoferEspecifico;
END;

IF OBJECT_ID('CRAZYDRIVER.spObtenerChoferEspecificoConDni') IS NOT NULL
BEGIN
	DROP PROCEDURE CRAZYDRIVER.spObtenerChoferEspecificoConDni;
END;

IF OBJECT_ID('CRAZYDRIVER.spAgregarRol') IS NOT NULL
BEGIN
	DROP PROCEDURE CRAZYDRIVER.spAgregarRol;
END;

IF OBJECT_ID('CRAZYDRIVER.spAgregarAutoPorChofer') IS NOT NULL
BEGIN
	DROP PROCEDURE CRAZYDRIVER.spAgregarAutoPorChofer;
END;

IF OBJECT_ID('CRAZYDRIVER.spAgregarAuto') IS NOT NULL
BEGIN
	DROP PROCEDURE CRAZYDRIVER.spAgregarAuto;
END;

IF OBJECT_ID('CRAZYDRIVER.spAltaAutomovil') IS NOT NULL
BEGIN
	DROP PROCEDURE CRAZYDRIVER.spAltaAutomovil;
END;

IF OBJECT_ID('CRAZYDRIVER.spObtenerMarcasYModelos') IS NOT NULL
BEGIN
   DROP PROCEDURE CRAZYDRIVER.spObtenerMarcasYModelos;
END;

IF OBJECT_ID('CRAZYDRIVER.spBuscarCliente') IS NOT NULL
BEGIN
   DROP PROCEDURE CRAZYDRIVER.spBuscarCliente;
END;

IF OBJECT_ID('CRAZYDRIVER.spModificarCliente') IS NOT NULL
BEGIN
   DROP PROCEDURE CRAZYDRIVER.spModificarCliente;
END;

IF OBJECT_ID('CRAZYDRIVER.spEliminarCliente') IS NOT NULL
BEGIN
   DROP PROCEDURE CRAZYDRIVER.spEliminarCliente;
END;

IF OBJECT_ID('CRAZYDRIVER.spActualizarChofer') IS NOT NULL
BEGIN
   DROP PROCEDURE CRAZYDRIVER.spActualizarChofer;
END;

IF OBJECT_ID('CRAZYDRIVER.spCrearChofer') IS NOT NULL
BEGIN
   DROP PROCEDURE CRAZYDRIVER.spCrearChofer;
END;

IF OBJECT_ID('CRAZYDRIVER.spBuscarAnios') IS NOT NULL
BEGIN
   DROP PROCEDURE CRAZYDRIVER.spBuscarAnios;
END;

IF OBJECT_ID('CRAZYDRIVER.spTop5Recaudacion') IS NOT NULL
BEGIN
   DROP PROCEDURE CRAZYDRIVER.spTop5Recaudacion;
END;

IF OBJECT_ID('CRAZYDRIVER.spTop5CantVecesClienteMismoAuto') IS NOT NULL
BEGIN
   DROP PROCEDURE CRAZYDRIVER.spTop5CantVecesClienteMismoAuto;
END;

IF OBJECT_ID('CRAZYDRIVER.spTop5ClientesMayorConsumo') IS NOT NULL
BEGIN
   DROP PROCEDURE CRAZYDRIVER.spTop5ClientesMayorConsumo;
END;

IF OBJECT_ID('CRAZYDRIVER.spTop5ViajesMasLargos') IS NOT NULL
BEGIN
   DROP PROCEDURE CRAZYDRIVER.spTop5ViajesMasLargos;
END;

IF OBJECT_ID('CRAZYDRIVER.spObtenerViajesEntreFechasYCliente') IS NOT NULL
BEGIN
   DROP PROCEDURE CRAZYDRIVER.spObtenerViajesEntreFechasYCliente;
END;

IF OBJECT_ID('CRAZYDRIVER.spBuscarClientesSinFacturacion') IS NOT NULL
BEGIN
   DROP PROCEDURE CRAZYDRIVER.spBuscarClientesSinFacturacion;
END;

IF OBJECT_ID('CRAZYDRIVER.spAltaFactura') IS NOT NULL
BEGIN
   DROP PROCEDURE CRAZYDRIVER.spAltaFactura;
END;

IF OBJECT_ID('CRAZYDRIVER.spAltaTurno') IS NOT NULL
BEGIN
	DROP PROCEDURE CRAZYDRIVER.spAltaTurno;
END;

IF OBJECT_ID('CRAZYDRIVER.spBuscarTurno') IS NOT NULL
BEGIN
	DROP PROCEDURE CRAZYDRIVER.spBuscarTurno;
END;

IF OBJECT_ID('CRAZYDRIVER.spEliminarTurno') IS NOT NULL
BEGIN
	DROP PROCEDURE CRAZYDRIVER.spEliminarTurno;
END;

IF OBJECT_ID('CRAZYDRIVER.spModificarTurno') IS NOT NULL
BEGIN
	DROP PROCEDURE CRAZYDRIVER.spModificarTurno;
END;

IF OBJECT_ID('CRAZYDRIVER.spObtenerAutosMarcaModelo') IS NOT NULL
BEGIN
	DROP PROCEDURE CRAZYDRIVER.spObtenerAutosMarcaModelo;
END;

IF OBJECT_ID('CRAZYDRIVER.spObtenerAutosChofer') IS NOT NULL
BEGIN
	DROP PROCEDURE CRAZYDRIVER.spObtenerAutosChofer;
END;

IF OBJECT_ID('CRAZYDRIVER.spObtenerAutosPatente') IS NOT NULL
BEGIN
	DROP PROCEDURE CRAZYDRIVER.spObtenerAutosPatente;
END;

IF OBJECT_ID('CRAZYDRIVER.spObtenerAutosMarcaModeloChofer') IS NOT NULL
BEGIN
	DROP PROCEDURE CRAZYDRIVER.spObtenerAutosMarcaModeloChofer;
END;

IF OBJECT_ID('CRAZYDRIVER.spObtenerAutosMarcaModeloPatente') IS NOT NULL
BEGIN
	DROP PROCEDURE CRAZYDRIVER.spObtenerAutosMarcaModeloPatente;
END;

IF OBJECT_ID('CRAZYDRIVER.spObtenerAutosPatenteChofer') IS NOT NULL
BEGIN
	DROP PROCEDURE CRAZYDRIVER.spObtenerAutosPatenteChofer;
END;

IF OBJECT_ID('CRAZYDRIVER.spObtenerAutos') IS NOT NULL
BEGIN
	DROP PROCEDURE CRAZYDRIVER.spObtenerAutos;
END;

IF OBJECT_ID('CRAZYDRIVER.spModificacionAutomovil') IS NOT NULL
BEGIN
	DROP PROCEDURE CRAZYDRIVER.spModificacionAutomovil;
END;

IF OBJECT_ID('CRAZYDRIVER.spEliminarAuto') IS NOT NULL
BEGIN
	DROP PROCEDURE CRAZYDRIVER.spEliminarAuto;
END;

IF OBJECT_ID('CRAZYDRIVER.spObtenerViajes') IS NOT NULL
BEGIN
	DROP PROCEDURE CRAZYDRIVER.spObtenerViajes;
END;

IF OBJECT_ID('CRAZYDRIVER.spRendir') IS NOT NULL
BEGIN
	DROP PROCEDURE CRAZYDRIVER.spRendir;
END;

IF OBJECT_ID('CRAZYDRIVER.spImportePorViaje') IS NOT NULL
BEGIN
	DROP PROCEDURE CRAZYDRIVER.spImportePorViaje;
END;

IF OBJECT_ID('CRAZYDRIVER.spObtenerTotalViajes') IS NOT NULL
BEGIN
	DROP PROCEDURE CRAZYDRIVER.spObtenerTotalViajes;
END;

IF OBJECT_ID('CRAZYDRIVER.spHabilitarAuto') IS NOT NULL
BEGIN
	DROP PROCEDURE CRAZYDRIVER.spHabilitarAuto;
END;
---- BORRO TABLAS

IF OBJECT_ID('CRAZYDRIVER.FacturacionPorViaje','U') IS NOT NULL
BEGIN
   DROP TABLE CRAZYDRIVER.FacturacionPorViaje;
END;

IF OBJECT_ID('CRAZYDRIVER.Facturacion','U') IS NOT NULL
BEGIN
   DROP TABLE CRAZYDRIVER.Facturacion;
END;

IF OBJECT_ID('CRAZYDRIVER.RendicionPorViaje','U') IS NOT NULL
BEGIN
   DROP TABLE CRAZYDRIVER.RendicionPorViaje;
END;

IF OBJECT_ID('CRAZYDRIVER.Rendicion','U') IS NOT NULL
BEGIN
   DROP TABLE CRAZYDRIVER.Rendicion;
END;

IF OBJECT_ID('CRAZYDRIVER.Viaje','U') IS NOT NULL
BEGIN
   DROP TABLE CRAZYDRIVER.Viaje;
END;

IF OBJECT_ID('CRAZYDRIVER.AutoPorChofer','U') IS NOT NULL
BEGIN
   DROP TABLE CRAZYDRIVER.AutoPorChofer;
END;

IF OBJECT_ID('CRAZYDRIVER.Auto','U') IS NOT NULL
BEGIN
   DROP TABLE CRAZYDRIVER.Auto;
END;

IF OBJECT_ID('CRAZYDRIVER.Modelo','U') IS NOT NULL
BEGIN
   DROP TABLE CRAZYDRIVER.Modelo;
END;

IF OBJECT_ID('CRAZYDRIVER.Marca','U') IS NOT NULL
BEGIN
   DROP TABLE CRAZYDRIVER.Marca;
END;

IF OBJECT_ID('CRAZYDRIVER.Turno','U') IS NOT NULL
BEGIN
   DROP TABLE CRAZYDRIVER.Turno;
END;

IF OBJECT_ID('CRAZYDRIVER.RolPorUsuario','U') IS NOT NULL
BEGIN
   DROP TABLE CRAZYDRIVER.RolPorUsuario;
END;

IF OBJECT_ID('CRAZYDRIVER.Chofer','U') IS NOT NULL
BEGIN
   DROP TABLE CRAZYDRIVER.Chofer;
END;

IF OBJECT_ID('CRAZYDRIVER.Cliente','U') IS NOT NULL
BEGIN
   DROP TABLE CRAZYDRIVER.Cliente;
END;

IF OBJECT_ID('CRAZYDRIVER.Usuario','U') IS NOT NULL
BEGIN
   DROP TABLE CRAZYDRIVER.Usuario;
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
	habilitado TINYINT NOT NULL default 1
);
GO

CREATE TABLE CRAZYDRIVER.FuncionalidadPorRol(
	id_funcionalidad INT NOT NULL FOREIGN KEY REFERENCES CRAZYDRIVER.Funcionalidad(id_funcionalidad),
	id_rol INT NOT NULL FOREIGN KEY REFERENCES CRAZYDRIVER.Rol(id_rol),
	habilitado TINYINT NOT NULL default 1,
	PRIMARY KEY (id_funcionalidad, id_rol)
);
GO

CREATE TABLE CRAZYDRIVER.Usuario(
	id_usuario INT IDENTITY PRIMARY KEY,
	username NVARCHAR(225) NOT NULL ,
	pass VARBINARY(225) NOT NULL,
	habilitado TINYINT NOT NULL default 1,
	intentos TINYINT NOT NULL default 0
);
GO

CREATE TABLE CRAZYDRIVER.Cliente(
	id_cliente INT IDENTITY PRIMARY KEY,
	dni NUMERIC(18,0) UNIQUE NOT NULL,
	nombre NVARCHAR(255) NOT NULL,
	apellido NVARCHAR(255) NOT NULL,
	mail NVARCHAR(255) NOT NULL,
	telefono NUMERIC(18,0) NOT NULL,
	fecha_nac DATETIME NOT NULL,
	direccion NVARCHAR(255) NOT NULL,
	nro_piso INT, -- requisito nuevo
	depto CHAR(1), -- requisito nuevo
	localidad NVARCHAR(255), -- requisito nuevo
	cod_postal INT, -- requisito nuevo
	habilitado TINYINT NOT NULL default 1,
	id_usuario INT NOT NULL FOREIGN KEY REFERENCES CRAZYDRIVER.Usuario(id_usuario)
);
GO

CREATE TABLE CRAZYDRIVER.Chofer(
	id_chofer INT IDENTITY PRIMARY KEY,
	id_usuario INT NOT NULL FOREIGN KEY REFERENCES CRAZYDRIVER.Usuario(id_usuario),
	habilitado TINYINT NOT NULL default 1,
	nombre NVARCHAR(255) NOT NULL,
	apellido NVARCHAR(255) NOT NULL,
	dni NUMERIC(18,0) UNIQUE NOT NULL,
	fecha_nac DATETIME NOT NULL,
	telefono NUMERIC(18,0) NOT NULL,
	mail NVARCHAR(255) NOT NULL,
	direccion NVARCHAR(255) NOT NULL,
	localidad NVARCHAR(255), -- requisito nuevo
	nro_piso INT, -- requisito nuevo
	depto CHAR(1) -- requisito nuevo
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
	habilitado TINYINT default 1
);
GO

CREATE TABLE CRAZYDRIVER.Marca(
	id_marca INT IDENTITY PRIMARY KEY,
	nombre NVARCHAR(255) Not NULL
);
GO

CREATE TABLE CRAZYDRIVER.Modelo(
	id_modelo INT IDENTITY PRIMARY KEY,
	nombre NVARCHAR(255) NULL default '',
	id_marca INT NOT NULL FOREIGN KEY REFERENCES CRAZYDRIVER.Marca(id_marca),
);
GO

CREATE TABLE CRAZYDRIVER.Auto(
	id_auto INT IDENTITY PRIMARY KEY,
	patente NVARCHAR(10) UNIQUE NOT NULL,
	id_modelo INT NOT NULL FOREIGN KEY REFERENCES CRAZYDRIVER.Modelo(id_modelo),
	licencia NVARCHAR(26) NULL default '',
    rodado NVARCHAR(10) NULL default '',
	habilitado TINYINT default 1
);
GO

CREATE TABLE CRAZYDRIVER.AutoPorChofer(
	id_auto INT NOT NULL FOREIGN KEY REFERENCES CRAZYDRIVER.Auto(id_auto),
	id_chofer INT NOT NULL FOREIGN KEY REFERENCES CRAZYDRIVER.Chofer(id_chofer),
	id_turno INT NOT NULL FOREIGN KEY REFERENCES CRAZYDRIVER.Turno(id_turno),
	PRIMARY KEY (id_auto, id_chofer, id_turno)
);
GO

CREATE TABLE CRAZYDRIVER.Viaje(
	id_viaje INT IDENTITY PRIMARY KEY,
	id_cliente INT NOT NULL FOREIGN KEY REFERENCES CRAZYDRIVER.Cliente(id_cliente),
	id_chofer INT NOT NULL FOREIGN KEY REFERENCES CRAZYDRIVER.Chofer(id_chofer),
	id_turno INT NOT NULL FOREIGN KEY REFERENCES CRAZYDRIVER.Turno(id_turno),
	id_auto INT NOT NULL FOREIGN KEY REFERENCES CRAZYDRIVER.Auto(id_auto),
	fecha_inicio DATETIME NOT NULL,
	fecha_fin DATETIME NOT NULL,
	cant_km NUMERIC(18,0) NOT NULL
);
GO

CREATE TABLE CRAZYDRIVER.Rendicion(
	nro_rendicion NUMERIC(18,0) PRIMARY KEY,
	fecha DATETIME NOT NULL
  );
GO

CREATE TABLE CRAZYDRIVER.RendicionPorViaje(
	nro_rendicion NUMERIC(18,0) NOT NULL FOREIGN KEY REFERENCES CRAZYDRIVER.Rendicion(nro_rendicion),
	id_viaje INT NOT NULL FOREIGN KEY REFERENCES CRAZYDRIVER.Viaje(id_viaje),
	importe NUMERIC(18,2),
	PRIMARY KEY (nro_rendicion, id_viaje)
  );
GO

CREATE TABLE CRAZYDRIVER.Facturacion(
	nro_facturacion NUMERIC(18,0) PRIMARY KEY, --cambie id_facturacion por nro_facturacion ya que nro es unico para este grupo de datos
	fecha DATETIME NOT NULL,
	fecha_inicio DATETIME NOT NULL,
	fecha_fin DATETIME NOT NULL
);
GO

CREATE TABLE CRAZYDRIVER.FacturacionPorViaje(
	nro_facturacion NUMERIC(18,0) NOT NULL FOREIGN KEY REFERENCES CRAZYDRIVER.Facturacion(nro_facturacion),
	id_viaje INT NOT NULL FOREIGN KEY REFERENCES CRAZYDRIVER.Viaje(id_viaje),
	importe NUMERIC(18,2),
	PRIMARY KEY (nro_facturacion, id_viaje)
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
	VALUES ('ABM rol'), ('ABM cliente'), ('ABM automovil'), ('ABM turno'), ('ABM chofer'),
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
INSERT INTO CRAZYDRIVER.Usuario(username, pass, habilitado, intentos)
	values
		('admin', HASHBYTES('SHA2_256', N'w23e'), 1, 0)
GO

INSERT INTO CRAZYDRIVER.RolPorUsuario(id_usuario, id_rol)
	values
		((select id_usuario from CRAZYDRIVER.Usuario where username = 'admin'), 1)
GO

---- MIGRACION

DECLARE @hash_password VARBINARY(225)
	SELECT @hash_password = HASHBYTES('SHA2_256', N'w23e');
INSERT INTO CRAZYDRIVER.Usuario(username, pass, habilitado, intentos)
	SELECT
		(SELECT CAST(Chofer_Dni AS NVARCHAR(225))), HASHBYTES('SHA2_256', N'w23e'), 1, 0
	FROM
		gd_esquema.Maestra
	UNION SELECT
		(SELECT CAST(Cliente_Dni AS NVARCHAR(225))), HASHBYTES('SHA2_256', N'w23e'), 1, 0
	FROM
		gd_esquema.Maestra
GO

INSERT INTO CRAZYDRIVER.Chofer(dni, apellido, nombre, telefono, mail, fecha_nac, direccion, nro_piso, depto, localidad, id_usuario, habilitado)
	SELECT DISTINCT
		m.Chofer_Dni, m.Chofer_Apellido, m.Chofer_Nombre, m.Chofer_Telefono, m.Chofer_Mail, m.Chofer_Fecha_Nac, m.Chofer_Direccion, null, null, null, u.id_usuario, 1
	FROM
		gd_esquema.Maestra m, CRAZYDRIVER.Usuario u
	WHERE
		cast(m.Chofer_Dni as varchar(255)) = u.username
GO

INSERT INTO CRAZYDRIVER.Cliente(dni, apellido, nombre, telefono, mail, fecha_nac, direccion, nro_piso, depto, localidad, cod_postal, id_usuario, habilitado)
	SELECT DISTINCT
		m.Cliente_Dni, m.Cliente_Apellido, m.Cliente_Nombre, m.Cliente_Telefono, m.Cliente_Mail, m.Cliente_Fecha_Nac, m.Cliente_Direccion, null, null, null, null, u.id_usuario, 1
	FROM
		gd_esquema.Maestra m, CRAZYDRIVER.Usuario u
	WHERE
		cast(m.Cliente_Dni as varchar(255)) = u.username
GO

INSERT INTO CRAZYDRIVER.RolPorUsuario(id_rol, id_usuario) -- cargo usuarios con rol de clientes
	SELECT
		2, cl.id_usuario
	FROM
		gd_esquema.Maestra m,  CRAZYDRIVER.Cliente cl
	WHERE
		m.Cliente_Dni = cl.dni
	UNION SELECT
		3, ch.id_usuario
	FROM
		gd_esquema.Maestra m,  CRAZYDRIVER.Chofer ch
	WHERE
		m.Chofer_Dni = ch.dni
GO

INSERT INTO CRAZYDRIVER.Turno(hora_inicio, hora_fin, descripcion, valor_km, precio_base, habilitado)
	SELECT DISTINCT
		Turno_Hora_Inicio, Turno_Hora_Fin, Turno_Descripcion, Turno_Valor_Kilometro, Turno_Precio_Base, 1
	FROM
		gd_esquema.Maestra
GO

INSERT INTO CRAZYDRIVER.Marca(nombre)
	SELECT DISTINCT
		Auto_Marca
	FROM
		gd_esquema.Maestra
GO

INSERT INTO CRAZYDRIVER.Modelo(nombre, id_marca)
	SELECT DISTINCT
		Auto_Modelo, ma.id_marca
	FROM
		gd_esquema.Maestra
		JOIN CRAZYDRIVER.Marca ma
			ON ma.nombre = Auto_Marca
GO

INSERT INTO CRAZYDRIVER.Auto(patente, id_modelo, licencia, rodado, habilitado)
	SELECT DISTINCT
		m.Auto_Patente, mo.id_modelo, m.Auto_Licencia, m.Auto_Rodado, 1
	FROM
		gd_esquema.Maestra m
		JOIN CRAZYDRIVER.Modelo mo
			ON mo.nombre = m.Auto_Modelo
		JOIN CRAZYDRIVER.Marca ma
			ON ma.nombre = m.Auto_Marca
GO

INSERT INTO CRAZYDRIVER.AutoPorChofer(id_auto, id_chofer, id_turno)
	SELECT DISTINCT
		a.id_auto, ch.id_chofer, t.id_turno
	FROM
		gd_esquema.Maestra m, CRAZYDRIVER.Turno t, CRAZYDRIVER.Chofer ch, CRAZYDRIVER.Auto a
	WHERE
		m.Auto_Patente = a.patente
		AND (m.Chofer_Dni = ch.dni)
		AND (m.Turno_Hora_Inicio = t.hora_inicio AND m.Turno_Hora_Fin = t.hora_fin)
GO

INSERT INTO CRAZYDRIVER.Viaje(id_cliente, id_chofer, id_turno, id_auto, fecha_inicio, fecha_fin, cant_km)
	SELECT
		cl.id_cliente, ch.id_chofer, t.id_turno, a.id_auto, m.Viaje_Fecha, m.Viaje_Fecha, m.Viaje_Cant_Kilometros
	FROM
		gd_esquema.Maestra m
			JOIN CRAZYDRIVER.Cliente cl
				ON m.Cliente_Dni = cl.dni
			JOIN CRAZYDRIVER.Chofer ch
				ON m.Chofer_Dni = ch.dni
			JOIN CRAZYDRIVER.Turno t
				ON m.Turno_Hora_Fin = t.hora_fin
				AND m.Turno_Hora_Inicio = t.hora_inicio
			JOIN CRAZYDRIVER.Auto a
				ON m.Auto_Patente = a.patente
	WHERE
		m.Rendicion_Nro IS NULL AND m.Factura_Nro IS NULL
GO

INSERT INTO CRAZYDRIVER.Rendicion(nro_rendicion, fecha)
	SELECT DISTINCT
		Rendicion_Nro, Rendicion_Fecha
	FROM
		gd_esquema.Maestra
	WHERE
		Rendicion_Nro IS NOT NULL
GO

INSERT INTO CRAZYDRIVER.RendicionPorViaje(nro_rendicion, id_viaje, importe)
	SELECT DISTINCT
		m.Rendicion_Nro, v.id_viaje, m.Rendicion_Importe
	FROM
		gd_esquema.Maestra m
			JOIN CRAZYDRIVER.Viaje v
				ON v.cant_km = m.Viaje_Cant_Kilometros
				AND v.fecha_inicio = m.Viaje_Fecha
			JOIN CRAZYDRIVER.Turno t
				ON m.Turno_Hora_Fin = t.hora_fin
				AND m.Turno_Hora_Inicio = t.hora_inicio
				AND v.id_turno = t.id_turno
			JOIN CRAZYDRIVER.Cliente cl
				ON m.Cliente_Dni = cl.dni
				AND v.id_cliente = cl.id_cliente
			JOIN CRAZYDRIVER.Chofer ch
				ON m.Chofer_Dni = ch.dni
				AND v.id_chofer = ch.id_chofer
			JOIN CRAZYDRIVER.Auto a
				ON m.Auto_Patente = a.patente
				AND v.id_auto = a.id_auto
	WHERE
		m.Rendicion_Nro IS NOT NULL
GO

INSERT INTO CRAZYDRIVER.Facturacion(nro_facturacion, fecha, fecha_inicio, fecha_fin)
	SELECT DISTINCT
		Factura_Nro, Factura_Fecha, Factura_Fecha_Inicio, Factura_Fecha_Fin
	FROM
		gd_esquema.Maestra
	WHERE
		Factura_Nro IS NOT NULL
GO

INSERT INTO CRAZYDRIVER.FacturacionPorViaje(nro_facturacion, id_viaje, importe)
    SELECT DISTINCT
		m.Factura_Nro, v.id_viaje, (m.Viaje_Cant_Kilometros * m.Turno_Valor_Kilometro + m.Turno_Precio_Base)
	FROM
		gd_esquema.Maestra m
			JOIN CRAZYDRIVER.Viaje v
				ON v.cant_km = m.Viaje_Cant_Kilometros
				AND v.fecha_inicio = m.Viaje_Fecha
			JOIN CRAZYDRIVER.Turno t
				ON m.Turno_Hora_Fin = t.hora_fin
				AND m.Turno_Hora_Inicio = t.hora_inicio
				AND v.id_turno = t.id_turno
			JOIN CRAZYDRIVER.Cliente cl
				ON m.Cliente_Dni = cl.dni
				AND v.id_cliente = cl.id_cliente
			JOIN CRAZYDRIVER.Chofer ch
				ON m.Chofer_Dni = ch.dni
				AND v.id_chofer = ch.id_chofer
			JOIN CRAZYDRIVER.Auto a
				ON m.Auto_Patente = a.patente
				AND v.id_auto = a.id_auto
	WHERE
		m.Factura_Nro IS NOT NULL
GO

---- PROCEDIMIENTOS ALMACENADOS

CREATE PROC CRAZYDRIVER.spLogin
	@username NVARCHAR(255)
	AS
	SELECT id_usuario, pass, intentos, habilitado
		FROM CRAZYDRIVER.Usuario
		WHERE username=@username
GO

CREATE PROC CRAZYDRIVER.spEditarIntentosUsuario
	@idUsuario INT,
	@intentos INT
	AS
		UPDATE CRAZYDRIVER.Usuario SET intentos=@intentos
		WHERE id_usuario=@idUsuario
GO

CREATE PROC CRAZYDRIVER.spObtenerRolesPorUsuario
	@idUsuario INT
	AS
		SELECT DISTINCT r.nombre
		FROM CRAZYDRIVER.RolPorUsuario rpu, CRAZYDRIVER.Rol r
		WHERE rpu.id_usuario = @idUsuario and rpu.id_rol = r.id_rol and r.habilitado = 1
GO

CREATE PROC CRAZYDRIVER.spObtenerRoles
	AS
		SELECT DISTINCT id_rol, nombre, CAST(
				 CASE
					  WHEN habilitado = 1
						 THEN 'habilitado'
					  ELSE 'deshabilitado'
				 END AS NVARCHAR(20)
			) as estado
			FROM CRAZYDRIVER.Rol
GO

CREATE PROC CRAZYDRIVER.spObtenerFuncionalidades
	AS
		SELECT DISTINCT *
		FROM CRAZYDRIVER.Funcionalidad
GO

CREATE PROC CRAZYDRIVER.spObtenerFuncionalidadesPorRol
	@rolId INT
	AS
		SELECT DISTINCT
			f.id_funcionalidad id_funcionalidad,
			f.descripcion descripcion,
			fpr.habilitado habilitado
		FROM
			CRAZYDRIVER.FuncionalidadPorRol fpr,
			CRAZYDRIVER.Rol r,
			CRAZYDRIVER.Funcionalidad f
		WHERE
			r.id_rol = @rolId AND
			fpr.id_rol = r.id_rol AND
			fpr.id_funcionalidad = f.id_funcionalidad
GO

CREATE PROC CRAZYDRIVER.spObtenerRol
	@rolNombre NVARCHAR(100)
	AS
		SELECT DISTINCT *
			FROM CRAZYDRIVER.Rol
			WHERE nombre = @rolNombre
GO

CREATE PROC CRAZYDRIVER.spAgregarRol
	@idRol INT OUTPUT,
	@rolNombre NVARCHAR(100)
	AS
		INSERT INTO CRAZYDRIVER.Rol
			(nombre, habilitado)
			VALUES (@rolNombre, 1)
GO

CREATE PROC CRAZYDRIVER.spAgregarRolFuncionalidad
	@idRol INT,
	@idFuncionalidad INT,
	@habilitado INT
	AS
		INSERT INTO CRAZYDRIVER.FuncionalidadPorRol
			(id_rol, id_funcionalidad, habilitado)
			VALUES (@idRol, @idFuncionalidad, @habilitado)
GO

CREATE PROC CRAZYDRIVER.spObtenerTurnos
	AS
		SELECT DISTINCT id_turno, descripcion
		FROM CRAZYDRIVER.Turno
GO

CREATE PROC CRAZYDRIVER.spObtenerChoferes
	AS
		SELECT DISTINCT id_chofer, dni, nombre, apellido
		FROM CRAZYDRIVER.Chofer
		WHERE habilitado = 1
GO

CREATE PROC CRAZYDRIVER.spObtenerMarcasYModelos
	AS
		SELECT DISTINCT m.id_modelo, m.nombre, m.id_marca, m2.nombre
		FROM CRAZYDRIVER.Modelo m
		JOIN CRAZYDRIVER.Marca m2 on m.id_marca = m2.id_marca
GO

CREATE PROC CRAZYDRIVER.spBuscarRoles
	@rolNombre NVARCHAR(100)
	AS
		SELECT DISTINCT id_rol, nombre, CAST(
				 CASE
					  WHEN habilitado = 1
						 THEN 'habilitado'
					  ELSE 'deshabilitado'
				 END AS NVARCHAR(20)
			) as Estado
			FROM CRAZYDRIVER.Rol
			WHERE nombre like @rolNombre + '%'
GO

CREATE PROC CRAZYDRIVER.spActualizarRol
	@idRol INT,
	@rolNombre NVARCHAR(100),
	@habilitado INT
	AS
		UPDATE CRAZYDRIVER.ROL
			SET nombre = @rolNombre, habilitado = @habilitado
			WHERE id_rol = @idRol
GO

CREATE PROC CRAZYDRIVER.spActualizarFuncionalidadPorRol
	@idRol INT,
	@idFuncionalidad INT,
	@habilitado INT
	AS
		UPDATE CRAZYDRIVER.FuncionalidadPorRol
			SET habilitado = @habilitado
			WHERE id_rol = @idRol AND id_funcionalidad = @idFuncionalidad
GO

CREATE PROC CRAZYDRIVER.spObtenerChoferesPorTurno
	@turno INT,
	@dateFrom DATETIME,
	@dateTo DATETIME
	AS
		SELECT DISTINCT c.id_chofer, c.nombre + ' ' + c.apellido as nombre FROM CRAZYDRIVER.Chofer c
			JOIN CRAZYDRIVER.AutoPorChofer apc ON apc.id_chofer = c.id_chofer AND apc.id_turno = @turno
			WHERE c.habilitado = 1
				AND (SELECT DISTINCT 1 FROM CRAZYDRIVER.Viaje v 
					WHERE v.id_chofer = c.id_chofer
						AND v.fecha_inicio BETWEEN @dateFrom AND @dateTo) IS NULL
			ORDER BY nombre
GO

CREATE PROC CRAZYDRIVER.spObtenerAutoPorIDChoferTurno
	@idchofer INT,
	@turno INT
	AS
		SELECT a.id_auto, mc.nombre, md.nombre FROM CRAZYDRIVER.modelo md
			JOIN CRAZYDRIVER.marca mc ON mc.id_marca = md.id_marca
			JOIN CRAZYDRIVER.Auto a ON a.id_modelo = md.id_modelo
			JOIN CRAZYDRIVER.AutoPorChofer apc ON apc.id_auto = a.id_auto AND apc.id_turno = @turno
			JOIN CRAZYDRIVER.Chofer c ON c.id_chofer = apc.id_chofer
			WHERE c.id_chofer = @idchofer
GO

CREATE PROC CRAZYDRIVER.spObtenerClientes
	@dateFrom DATETIME,
	@dateTo DATETIME
	AS
	SELECT c.id_cliente, c.nombre, c.apellido FROM CRAZYDRIVER.Cliente c
		WHERE c.habilitado = 1
			AND (SELECT DISTINCT 1 FROM CRAZYDRIVER.Viaje v 
					WHERE v.id_cliente = c.id_cliente
						AND v.fecha_inicio BETWEEN @dateFrom AND @dateTo) IS NULL
		ORDER BY c.id_cliente
GO

CREATE PROC CRAZYDRIVER.spObtenerValorTurno
	@turno INT
	AS
		SELECT t.precio_base, t.valor_km FROM CRAZYDRIVER.Turno t
			WHERE t.id_turno = @turno
GO

CREATE PROC CRAZYDRIVER.spAgregarViaje
	@idcliente INT,
	@idchofer INT,
	@turno INT,
	@idauto INT,
    @fechaDesde DATETIME,
	@fechaHasta DATETIME,
 	@kms NUMERIC(18, 0)
	AS
		INSERT INTO CRAZYDRIVER.Viaje(id_cliente, id_chofer, id_turno, id_auto, fecha_inicio, fecha_fin, cant_km)
			VALUES (@idcliente, @idchofer, @turno, @idauto, @fechaDesde, @fechaHasta, @kms)
GO

CREATE PROC CRAZYDRIVER.spObtenerTodoChoferes
	AS
		SELECT *, CAST(
				 CASE
					  WHEN habilitado = 1
						 THEN 'habilitado'
					  ELSE 'deshabilitado'
				 END AS NVARCHAR(20)
			) as estado
			FROM CRAZYDRIVER.Chofer
GO

CREATE PROC CRAZYDRIVER.spObtenerChoferEspecifico
	@choferNombre NVARCHAR(255),
	@choferApellido NVARCHAR(255),
	@choferDni NVARCHAR(18)
	AS
		SELECT DISTINCT *, CAST(
				 CASE
					  WHEN habilitado = 1
						 THEN 'habilitado'
					  ELSE 'deshabilitado'
				 END AS NVARCHAR(20)
			) as estado
			FROM
				CRAZYDRIVER.Chofer
			WHERE
				nombre like @choferNombre + '%' AND
				apellido like @choferApellido  + '%' AND
				CAST(dni AS VARCHAR(255)) like @choferDni + '%'

GO

CREATE PROC CRAZYDRIVER.spAgregarCliente
	  @dni int,
	  @nombre NVARCHAR(255),
	  @apellido NVARCHAR(255),
	  @direccion NVARCHAR(255),
	  @mail NVARCHAR(255),
	  @telefono int,
	  @fecha_nac DATETIME,
	  @nro_piso int,
	  @depto CHAR(1),
	  @localidad NVARCHAR(255),
	  @cod_postal int
	  AS

	  DECLARE @usuario int;
	  DECLARE @dnib int;
	  DECLARE @telefonob int;


	  SELECT  @usuario = c.id_usuario, @dnib = c.dni, @telefonob = c.telefono
	  from CRAZYDRIVER.Cliente c
	  where @dni = c.dni or @telefono = c.telefono;

	  SELECT  @usuario = c.id_usuario, @dnib = c.dni, @telefonob = CASE WHEN @telefonob is null then c.telefono else @telefonob END
	  from CRAZYDRIVER.Chofer c
	  where @dni = c.dni or @telefono = c.telefono;



	  IF (@telefonob is not null and @telefono = @telefonob)
		 BEGIN
		 RAISERROR('Telefono existente',17,1);
		 END

	  ELSE IF (@dnib is not null and @dni = @dnib)
		 BEGIN
		 RAISERROR('DNI existente',17,1);
		 END

	  ELSE
		BEGIN
		INSERT INTO CRAZYDRIVER.Usuario(username, pass, habilitado, intentos)
		values (CAST(@dni AS VARCHAR(255)), HASHBYTES('SHA2_256', N'w23e'), 1, 0);

		if (@usuario is null) SELECT @usuario = SCOPE_IDENTITY();

		INSERT INTO CRAZYDRIVER.RolPorUsuario (id_rol,id_usuario) values (2,@usuario);

		INSERT INTO CRAZYDRIVER.Cliente (dni,nombre,apellido,direccion,mail,telefono,fecha_nac,nro_piso,depto,localidad,cod_postal,id_usuario,habilitado)
		values (@dni,@nombre,@apellido,@direccion,@mail,@telefono,@fecha_nac,@nro_piso,@depto,@localidad,@cod_postal,@usuario,1);
		END
 GO


CREATE PROC CRAZYDRIVER.spAgregarAutoPorChofer
	@idAuto INT,
	@idTurno INT,
	@idChofer INT
	AS
		INSERT INTO CRAZYDRIVER.AutoPorChofer
			(id_auto, id_chofer, id_turno)
			VALUES (@idAuto, @idChofer, @idTurno)
GO

CREATE PROC CRAZYDRIVER.spAgregarAuto
	@patente NVARCHAR(10),
	@modelo INT
	AS
			INSERT INTO CRAZYDRIVER.Auto
				(patente, id_modelo)
				VALUES (@patente, @modelo)
GO

CREATE PROC CRAZYDRIVER.spAltaAutomovil
	@patente NVARCHAR(10),
	@marca INT,
	@modelo INT,
	@idTurno INT,
	@idChofer INT
	AS
		DECLARE @idAuto int;

		IF EXISTS (SELECT 1 FROM CRAZYDRIVER.Auto
			WHERE patente = @patente AND habilitado = 1)
			BEGIN
			RAISERROR('Patente existente',17,1);
			RETURN
			END
		ELSE
			EXEC CRAZYDRIVER.spAgregarAuto @patente, @modelo;

		SELECT @idAuto = a.id_auto from CRAZYDRIVER.Auto a
		WHERE a.patente = @patente;
		EXEC CRAZYDRIVER.spAgregarAutoPorChofer @idAuto, @idTurno, @idChofer;
GO

CREATE PROC CRAZYDRIVER.spBuscarCliente
    @nombre NVARCHAR(255),
	@apellido NVARCHAR(255),
	@dni int
	AS

	select c.id_cliente,c.dni,c.nombre,c.apellido,c.mail,c.telefono,c.fecha_nac,c.direccion,c.nro_piso,c.depto,c.localidad,c.cod_postal,
	CASE when c.habilitado = 1 then 'Habilitado' else 'Deshabilitado' END habilitado
	from CRAZYDRIVER.Cliente c
	where CAST(c.dni as NVARCHAR(10)) like '%' + CAST(@dni as NVARCHAR(10)) + '%'
	and lower(c.apellido) like '%' + lower(@apellido) + '%'
	and lower(c.nombre) like '%' + lower(@nombre) + '%';

GO

CREATE PROC CRAZYDRIVER.spModificarCliente
  	  @dni int,
	  @nombre NVARCHAR(255),
	  @apellido NVARCHAR(255),
	  @direccion NVARCHAR(255),
	  @mail NVARCHAR(255),
	  @telefono int,
	  @fecha_nac DATETIME,
	  @nro_piso int,
	  @depto CHAR(1),
	  @localidad NVARCHAR(255),
	  @cod_postal int,
	  @id_cliente int,
	  @habilitado bit
	  AS

	  DECLARE @usuario int;
	  DECLARE @dnib int;
	  DECLARE @telefonob int;


	  SELECT  @usuario = c.id_usuario, @dnib = c.dni, @telefonob = c.telefono
	  from CRAZYDRIVER.Cliente c
	  where (@dni = c.dni or @telefono = c.telefono) and c.id_cliente != @id_cliente;

	  SELECT  @usuario = c.id_usuario, @dnib = c.dni, @telefonob = CASE WHEN @telefonob is null then c.telefono else @telefonob END
	  from CRAZYDRIVER.Chofer c
	  where (@dni = c.dni or @telefono = c.telefono) and @usuario != c.id_usuario;

	  IF (@telefonob is not null and @telefono = @telefonob)
		 BEGIN
		 RAISERROR('Telefono existente',17,1);
		 END

	  ELSE IF (@dnib is not null and @dni = @dnib)
		 BEGIN
		 RAISERROR('DNI existente',17,1);
		 END

	  ELSE
		BEGIN
		UPDATE CRAZYDRIVER.Cliente set
		dni = @dni,
		nombre = @nombre ,
		apellido = @apellido,
		direccion = @direccion,
		mail = @mail,
		telefono = @telefono,
		fecha_nac = @fecha_nac,
		nro_piso = @nro_piso,
		depto = @depto,
		localidad = @localidad,
		cod_postal = @cod_postal,
		habilitado = @habilitado
		where id_cliente = @id_cliente
		END
GO

CREATE PROC CRAZYDRIVER.spEliminarCliente
	@id_cliente int AS
	UPDATE CRAZYDRIVER.Cliente set habilitado = 0 where id_cliente = @id_cliente
GO

CREATE PROC CRAZYDRIVER.spObtenerViajesEntreFechasYCliente
	@fechaDesde DATETIME,
	@fechaHasta DATETIME,
	@clienteid INT
	AS
	SELECT v.id_turno AS Turno,
			v.fecha_inicio AS 'Fecha Inicio',
			v.fecha_fin AS 'Fecha Fin',
			v.cant_km AS 'Kms viajados',
			t.precio_base AS 'Precio Base',
			t.valor_km AS 'Valor Kms',
			t.precio_base + (v.cant_km * t.valor_km) AS 'Total'
		FROM CRAZYDRIVER.Viaje v, CRAZYDRIVER.Turno t
		WHERE v.id_cliente = @clienteid AND t.id_turno = v.id_turno AND v.fecha_inicio BETWEEN @fechaDesde AND @fechaHasta
GO

CREATE PROC CRAZYDRIVER.spBuscarClientesSinFacturacion
	@fechaDesde DATETIME,
	@fechaHasta DATETIME
	AS
	SELECT DISTINCT c.id_cliente, c.apellido + ' ' + c.nombre FROM CRAZYDRIVER.Cliente c
		JOIN CRAZYDRIVER.Viaje v ON v.id_cliente = c.id_cliente
			AND v.fecha_inicio BETWEEN @fechaDesde AND @fechaHasta
		WHERE (SELECT DISTINCT 1 FROM CRAZYDRIVER.Viaje v
				JOIN CRAZYDRIVER.FacturacionPorViaje fv ON v.id_viaje = fv.id_viaje
				JOIN CRAZYDRIVER.Facturacion f ON f.nro_facturacion = fv.nro_facturacion
				WHERE v.id_cliente = c.id_cliente
					AND f.fecha BETWEEN @fechaDesde AND @fechaHasta) IS NULL
		ORDER BY c.id_cliente
GO

CREATE PROC CRAZYDRIVER.spAltaFactura
	@fechaDesde DATETIME,
	@fechaHasta DATETIME,
	@fechaCreado DATETIME,
	@clienteid INT
	AS

	-- 1) obtengo el mayor numero de factura actual
	DECLARE @nroMax INT;

	SELECT TOP 1 @nroMax = nro_facturacion FROM CRAZYDRIVER.Facturacion
							ORDER BY nro_facturacion DESC

	-- 2) hago un insert de la facturacion
	 INSERT INTO CRAZYDRIVER.Facturacion (nro_facturacion, fecha, fecha_inicio, fecha_fin)
			VALUES (@nroMax + 1, @fechaCreado, @fechaDesde, @fechaHasta)

	-- 3) hago un insert de los viajes de @clienteid entre fechas @fechaDesde y @fechaHasta en tabla FacturacionPorViaje
	 INSERT INTO CRAZYDRIVER.FacturacionPorViaje (nro_facturacion, id_viaje, importe)
			SELECT @nroMax + 1, v.id_viaje, t.precio_base + (v.cant_km * t.valor_km)
				FROM CRAZYDRIVER.Viaje v, CRAZYDRIVER.Turno t
				WHERE v.id_cliente = @clienteid
					AND t.id_turno = v.id_turno
					AND v.fecha_inicio BETWEEN @fechaDesde AND @fechaHasta;
GO

CREATE PROC CRAZYDRIVER.spActualizarChofer
	@choferId INT,
	@choferNombre NVARCHAR(255),
	@choferApellido NVARCHAR(255),
	@choferDni INT,
	@choferFechaNac DATETIME,
	@choferTelefono INT,
	@choferMail NVARCHAR(255),
	@choferDireccion NVARCHAR(255),
	@choferLocalidad NVARCHAR(255),
	@choferNroPiso INT,
	@choferDepto CHAR(1),
	@habilitado TINYINT
	AS
		IF EXISTS (
				SELECT 1
					FROM CRAZYDRIVER.Chofer
					WHERE dni = CAST(@choferDni AS NUMERIC(18,0)) AND id_chofer != @choferId
			)
			OR EXISTS (
				SELECT 1
					FROM CRAZYDRIVER.Chofer
					WHERE telefono = CAST(@choferTelefono AS NUMERIC(18,0)) AND id_chofer != @choferId
			)
			BEGIN
				--DECLARE @ErrorMessage NVARCHAR(255);
				--SET @ErrorMessage = CAST(@choferId AS NVARCHAR(255));
				RAISERROR('Ya existe otro chofer con este DNI o con el mismo telefono' ,17,1);
				RETURN
			END
		ELSE
			BEGIN
				UPDATE CRAZYDRIVER.Chofer
					SET
						nombre = @choferNombre,
						apellido = @choferApellido,
						dni = CAST(@choferDni AS NUMERIC(18,0)),
						fecha_nac = @choferFechaNac,
						telefono = CAST(@choferTelefono AS NUMERIC(18,0)),
						mail = @choferMail,
						direccion = @choferDireccion,
						localidad = @choferLocalidad,
						nro_piso = @choferNroPiso,
						depto = @choferDepto,
						habilitado = @habilitado
					WHERE id_chofer = @choferId
				RAISERROR('Se ha logrado actualizar un chofer' ,17,1);
			END
GO

CREATE PROC CRAZYDRIVER.spCrearChofer
	@choferNombre NVARCHAR(255),
	@choferApellido NVARCHAR(255),
	@choferDni INT,
	@choferFechaNac DATETIME,
	@choferTelefono INT,
	@choferMail NVARCHAR(255),
	@choferDireccion NVARCHAR(255),
	@choferLocalidad NVARCHAR(255),
	@choferNroPiso INT,
	@choferDepto NCHAR(1)
	AS
		DECLARE @usuario INT;
		DECLARE @dnib INT;
		DECLARE @telefonob INT;
		SELECT  @usuario = c.id_usuario, @dnib = c.dni, @telefonob = c.telefono
			FROM CRAZYDRIVER.Chofer c
			WHERE @choferDni = c.dni or @choferTelefono = c.telefono;
		SELECT  @usuario = c.id_usuario, @dnib = c.dni, @telefonob = CASE WHEN @telefonob is null THEN c.telefono ELSE @telefonob END
			FROM CRAZYDRIVER.Cliente c
			WHERE @choferDni = c.dni or @choferTelefono = c.telefono;
		IF (@telefonob is not null and @choferTelefono = @telefonob)
			BEGIN
				RAISERROR('Telefono existente',17,1);
			END
		ELSE IF (@dnib is not null and @choferDni = @dnib)
			BEGIN
				RAISERROR('DNI existente',17,1);
			END
		ELSE
			BEGIN
				INSERT INTO CRAZYDRIVER.Usuario(username, pass, habilitado, intentos)
					VALUES (CAST(@choferDni AS VARCHAR(255)), HASHBYTES('SHA2_256', N'w23e'), 1, 0);
				IF (@usuario is null)
					SELECT @usuario = SCOPE_IDENTITY();
				INSERT INTO CRAZYDRIVER.RolPorUsuario (id_rol,id_usuario)
					VALUES (3, @usuario);
				INSERT INTO CRAZYDRIVER.Chofer (dni,nombre,apellido,direccion,mail,telefono,fecha_nac,nro_piso,depto,localidad,id_usuario,habilitado)
					VALUES (@choferDni,@choferNombre,@choferApellido,@choferDireccion,@choferMail,@choferTelefono,@choferFechaNac,@choferNroPiso,@choferDepto,@choferLocalidad,@usuario,1);
				RAISERROR('Se logro crear con exito el chofer. Por default se le agrego un usuario con username igual al dni password w23e',17,1);
			END
GO

CREATE PROC CRAZYDRIVER.spBuscarAnios
	AS
		SELECT DISTINCT year(fecha_inicio)
			FROM CRAZYDRIVER.Viaje
GO

CREATE PROC CRAZYDRIVER.spTop5Recaudacion
	@trimestre INT,
	@anio INT
	AS
		SELECT TOP 5
			SUM(r.importe) RECAUDACION,
			c.dni CHOFER_DNI,
			c.nombre CHOFER_NOMBRE,
			c.apellido CHOFER_APELLIDO
			FROM
				CRAZYDRIVER.RendicionPorViaje r
					JOIN CRAZYDRIVER.Viaje v
						ON r.id_viaje = v.id_viaje
					JOIN CRAZYDRIVER.chofer c
					ON c.id_chofer = v.id_chofer
			WHERE
				@anio = year(v.fecha_inicio) AND
				(month(v.fecha_inicio) - 1) / 3 + 1 = @trimestre
			GROUP BY c.dni, c.nombre, c.apellido
			ORDER BY 1 DESC;
GO

CREATE PROC CRAZYDRIVER.spTop5ViajesMasLargos
	@trimestre INT,
	@anio INT
	AS
		SELECT TOP 5
			c.dni CHOFER_DNI, c.nombre CHOFER_NOMBRE, c.apellido CHOFER_APELLIDO,
			cl.dni CLIENTE_DNI, cl.nombre CLIENTE_NOMBRE, cl.apellido CLIENTE_APELLIDO,
			v.cant_km CANTIDAD_KILOMETROS, t.valor_km VALOR_KM, t.descripcion TURNO_DESCRIPCION,
			t.hora_inicio TURNO_HORA_INICIO, t.hora_fin TURNO_HORA_FIN, f.importe IMPORTE_VIAJE
			FROM
				CRAZYDRIVER.viaje v
				JOIN CRAZYDRIVER.chofer c
					ON c.id_chofer = v.id_chofer
				JOIN CRAZYDRIVER.Turno t
					ON t.id_turno = v.id_turno
				JOIN CRAZYDRIVER.Cliente cl
					ON cl.id_cliente = v.id_cliente
				JOIN CRAZYDRIVER.FacturacionPorViaje f
					ON v.id_viaje = f.id_viaje
			WHERE
				@anio = year(v.fecha_inicio) AND
				(month(v.fecha_inicio) - 1) / 3 + 1 = @trimestre
			ORDER BY v.cant_km DESC;
GO

CREATE PROC CRAZYDRIVER.spTop5ClientesMayorConsumo
	@trimestre INT,
	@anio INT
	AS
		SELECT TOP 5
			SUM(f.importe) CONSUMO, c.dni CLIENTE_DNI,
			c.nombre CLIENTE_NOMBRE, c.apellido CLIENTE_APELLIDO
			FROM
				CRAZYDRIVER.FacturacionPorViaje f
				JOIN CRAZYDRIVER.Viaje v
					ON f.id_viaje = v.id_viaje
				JOIN CRAZYDRIVER.Cliente c
					ON c.id_cliente = v.id_cliente
			WHERE
				@anio = year(v.fecha_inicio) AND
				(month(v.fecha_inicio) - 1) / 3 + 1 = @trimestre
			GROUP BY c.dni,c.nombre,c.apellido
			ORDER BY 1 DESC;
GO

CREATE PROC CRAZYDRIVER.spTop5CantVecesClienteMismoAuto
	@trimestre INT,
	@anio INT
	AS
		SELECT TOP 5
			count(*) CANTIDAD_VECES, a.patente PATENTE, a.rodado RODADO,
			ma.nombre MARCA, m.nombre MODELO, c.dni CLIENTE_DNI,
			c.nombre CLIENTE_NOMBRE, c.apellido CLIENTE_APELLIDO
			FROM
				CRAZYDRIVER.Viaje v
				JOIN CRAZYDRIVER.Cliente c
					ON c.id_cliente = v.id_cliente
				JOIN CRAZYDRIVER.Auto a
					ON a.id_auto = v.id_auto
				JOIN CRAZYDRIVER.Modelo m
					ON m.id_modelo = a.id_modelo
				JOIN CRAZYDRIVER.Marca ma
					ON ma.id_marca = m.id_marca
			WHERE
				@anio = year(v.fecha_inicio) AND
				(month(v.fecha_inicio) - 1) / 3 + 1= @trimestre
			GROUP BY a.patente, a.rodado, ma.nombre, m.nombre, c.dni, c.nombre, c.apellido
GO

CREATE PROC CRAZYDRIVER.spAltaTurno
	@desc varchar(225),
	@hinicio int,
	@hfin int,
	@valorkm numeric(18,2),
	@pbase numeric(18,2),
	@habilitado tinyint
	AS
		declare @existe bit;

		select @existe = count(*) from CRAZYDRIVER.Turno
		where ((@hinicio >= hora_inicio and @hinicio < hora_fin)
		or (@hfin > hora_inicio and @hfin <= hora_fin)
		or (@hinicio < hora_inicio and @hfin >= hora_fin)) and habilitado = 1;

		if (@existe > 0 and @habilitado = 1)
			RAISERROR('Los horarios del turno se superponen con un turno existente habilitado.',17,1)
		else
			INSERT INTO CRAZYDRIVER.Turno (descripcion,hora_inicio,hora_fin,valor_km,precio_base,habilitado)
			values (@desc, @hinicio, @hfin, @valorkm, @pbase, @habilitado)

GO

CREATE PROC CRAZYDRIVER.spBuscarTurno
	@desc varchar(225)
	AS
	select t.id_turno ID_TURNO,t.descripcion DESCRIPCION,t.hora_inicio HORA_INICIO,t.hora_fin HORA_FIN,t.precio_base PRECIO_BASE,t.valor_km VALOR_KM,CASE when t.habilitado = 1 then 'Habilitado' else 'Deshabilitado' END habilitado
	 from CRAZYDRIVER.Turno t where descripcion like '%' + @desc + '%'

GO

CREATE PROC CRAZYDRIVER.spEliminarTurno
	@id_turno int
	AS
	UPDATE CRAZYDRIVER.Turno set habilitado = 0 where id_turno = @id_turno;
GO

CREATE PROC CRAZYDRIVER.spModificarTurno
	@desc varchar(225),
	@hinicio int,
	@hfin int,
	@valorkm numeric(18,2),
	@pbase numeric(18,2),
	@habilitado tinyint,
	@id_turno int
	AS
		declare @existe bit;

		select @existe = count(*) from CRAZYDRIVER.Turno
		where ((@hinicio >= hora_inicio and @hinicio < hora_fin)
		or (@hfin > hora_inicio and @hfin <= hora_fin)
		or (@hinicio < hora_inicio and @hfin >= hora_fin)) and habilitado = 1 and @id_turno != id_turno;

		if (@existe > 0 and @habilitado = 1)
			RAISERROR('Los horarios del turno se superponen con un turno existente habilitado.',17,1)
		else
			UPDATE CRAZYDRIVER.Turno set
			descripcion = @desc,
			hora_inicio = @hinicio,
			hora_fin = @hfin,
			valor_km = @valorkm,
			precio_base = @pbase,
			habilitado = @habilitado
			where id_turno = @id_turno
GO

CREATE PROC CRAZYDRIVER.spObtenerHorarioTurno
	@idTurno INT
	AS
		SELECT hora_inicio, hora_fin FROM CRAZYDRIVER.Turno
			WHERE id_turno = @idTurno
GO

CREATE PROC CRAZYDRIVER.spObtenerAutosMarcaModelo
	@marca int,
	@modelo int
	AS
		SELECT a.id_auto, a.patente, ma.id_marca, ma.nombre as marca, mo.id_modelo, mo.nombre as modelo, 
		ac.id_chofer, c.nombre,c.apellido, ac.id_turno, t.descripcion,a.licencia, a.rodado, a.habilitado
		FROM CRAZYDRIVER.Chofer c, CRAZYDRIVER.Turno t ,CRAZYDRIVER.Marca ma
		JOIN CRAZYDRIVER.Modelo mo on mo.id_marca = @marca AND mo.id_modelo = @modelo
		JOIN CRAZYDRIVER.Auto a on mo.id_modelo = a.id_modelo
		JOIN CRAZYDRIVER.AutoPorChofer ac on a.id_auto = ac.id_auto
		WHERE ma.id_marca = @marca AND ac.id_chofer = c.id_chofer AND ac.id_turno = t.id_turno
		GROUP BY a.id_auto, a.patente, ma.id_marca, ma.nombre, mo.id_modelo, mo.nombre, 
		ac.id_chofer, c.nombre,c.apellido, ac.id_turno, t.descripcion, a.licencia, a.rodado, a.habilitado
GO

CREATE PROC CRAZYDRIVER.spObtenerAutosChofer
	@chofer int
	AS
		SELECT a.id_auto, a.patente, ma.id_marca, ma.nombre as marca, mo.id_modelo, mo.nombre as modelo, 
		ac.id_chofer, c.nombre,c.apellido, ac.id_turno, t.descripcion, a.licencia, a.rodado, a.habilitado
		FROM CRAZYDRIVER.Chofer c, CRAZYDRIVER.Turno t, CRAZYDRIVER.AutoPorChofer ac
		JOIN CRAZYDRIVER.Auto a on ac.id_auto = a.id_auto
		JOIN CRAZYDRIVER.Modelo mo on a.id_modelo = mo.id_modelo
		JOIN CRAZYDRIVER.Marca ma on mo.id_marca = ma.id_marca
		WHERE ac.id_chofer = @chofer AND ac.id_chofer = c.id_chofer AND ac.id_turno = t.id_turno
		GROUP BY a.id_auto, a.patente, ma.id_marca, ma.nombre, mo.id_modelo, mo.nombre, 
		ac.id_chofer, c.nombre,c.apellido, ac.id_turno, t.descripcion, a.licencia, a.rodado, a.habilitado
GO

CREATE PROC CRAZYDRIVER.spObtenerAutosPatente
	@patente nvarchar(10)
	AS
		SELECT a.id_auto, a.patente, ma.id_marca, ma.nombre as marca, mo.id_modelo, mo.nombre as modelo, 
		ac.id_chofer, c.nombre,c.apellido, ac.id_turno, t.descripcion, a.licencia, a.rodado, a.habilitado
		FROM  CRAZYDRIVER.AutoPorChofer ac, CRAZYDRIVER.Chofer c, CRAZYDRIVER.Turno t, CRAZYDRIVER.Auto a
		JOIN CRAZYDRIVER.Modelo mo on a.id_modelo = mo.id_modelo
		JOIN CRAZYDRIVER.Marca ma on mo.id_marca = ma.id_marca
		WHERE a.patente = @patente AND a.id_auto = ac.id_auto AND ac.id_chofer = c.id_chofer AND ac.id_turno = t.id_turno
		GROUP BY a.id_auto, a.patente, ma.id_marca, ma.nombre, mo.id_modelo, mo.nombre, 
		ac.id_chofer, c.nombre,c.apellido, ac.id_turno, t.descripcion, a.licencia, a.rodado, a.habilitado
GO

CREATE PROC CRAZYDRIVER.spObtenerAutosMarcaModeloChofer
	@marca int,
	@modelo int,
	@chofer int
	AS 
		declare @procedure1 table ( id_auto int, patente nvarchar(10), id_marca int, nombreMarca nvarchar(255), id_modelo int, nombreModelo nvarchar(255), 
		id_chofer int, nomChofer nvarchar(255), apeChofer nvarchar(255), id_turno int, descTurno nvarchar(255), licencia nvarchar(26),rodado nvarchar(10), habilitado int)
		declare @procedure2 table ( id_auto int, patente nvarchar(10), id_marca int, nombreMarca nvarchar(255), id_modelo int, nombreModelo nvarchar(255), 
		id_chofer int, nomChofer nvarchar(255), apeChofer nvarchar(255), id_turno int, descTurno nvarchar(255), licencia nvarchar(26),rodado nvarchar(10), habilitado int)

		insert into  @procedure1
		exec CRAZYDRIVER.spObtenerAutosMarcaModelo @marca, @modelo ;

		insert into  @procedure2
		exec CRAZYDRIVER.spObtenerAutosChofer @chofer;

		select * from @procedure1
		intersect
		select * from @procedure2;
GO

CREATE PROC CRAZYDRIVER.spObtenerAutosMarcaModeloPatente
	@marca int,
	@modelo int,
	@patente nvarchar(10)
	AS
		declare @procedure1 table ( id_auto int, patente nvarchar(10), id_marca int, nombreMarca nvarchar(255), id_modelo int, nombreModelo nvarchar(255), 
		id_chofer int, nomChofer nvarchar(255), apeChofer nvarchar(255), id_turno int, descTurno nvarchar(255), licencia nvarchar(26),rodado nvarchar(10), habilitado int)
		declare @procedure2 table ( id_auto int, patente nvarchar(10), id_marca int, nombreMarca nvarchar(255), id_modelo int, nombreModelo nvarchar(255), 
		id_chofer int, nomChofer nvarchar(255), apeChofer nvarchar(255), id_turno int, descTurno nvarchar(255), licencia nvarchar(26),rodado nvarchar(10), habilitado int)

		insert into  @procedure1
		exec CRAZYDRIVER.spObtenerAutosMarcaModelo @marca, @modelo ;

		insert into  @procedure2
		exec CRAZYDRIVER.spObtenerAutosPatente @patente;

		select * from @procedure1
		intersect
		select * from @procedure2;
GO

CREATE PROC CRAZYDRIVER.spObtenerAutosPatenteChofer
	@patente nvarchar(10),
	@chofer int
	AS
		declare @procedure1 table ( id_auto int, patente nvarchar(10), id_marca int, nombreMarca nvarchar(255), id_modelo int, nombreModelo nvarchar(255), 
		id_chofer int, nomChofer nvarchar(255), apeChofer nvarchar(255), id_turno int, descTurno nvarchar(255), licencia nvarchar(26),rodado nvarchar(10), habilitado int)
		declare @procedure2 table ( id_auto int, patente nvarchar(10), id_marca int, nombreMarca nvarchar(255), id_modelo int, nombreModelo nvarchar(255), 
		id_chofer int, nomChofer nvarchar(255), apeChofer nvarchar(255), id_turno int, descTurno nvarchar(255), licencia nvarchar(26),rodado nvarchar(10), habilitado int)

		insert into  @procedure1
		exec CRAZYDRIVER.spObtenerAutosChofer @chofer ;

		insert into  @procedure2
		exec CRAZYDRIVER.spObtenerAutosPatente @patente;

		select * from @procedure1
		intersect
		select * from @procedure2;
GO

CREATE PROC CRAZYDRIVER.spObtenerAutos
	@marca int,
	@modelo int,
	@patente nvarchar(10),
	@chofer int
	AS
		declare @procedure1 table ( id_auto int, patente nvarchar(10), id_marca int, nombreMarca nvarchar(255), id_modelo int, nombreModelo nvarchar(255), 
		id_chofer int, nomChofer nvarchar(255), apeChofer nvarchar(255), id_turno int, descTurno nvarchar(255), licencia nvarchar(26),rodado nvarchar(10), habilitado int)
		declare @procedure2 table ( id_auto int, patente nvarchar(10), id_marca int, nombreMarca nvarchar(255), id_modelo int, nombreModelo nvarchar(255), 
		id_chofer int, nomChofer nvarchar(255), apeChofer nvarchar(255), id_turno int, descTurno nvarchar(255), licencia nvarchar(26),rodado nvarchar(10), habilitado int)

		insert into  @procedure1
		exec CRAZYDRIVER.spObtenerAutosPatenteChofer @patente, @chofer ;

		insert into  @procedure2
		exec CRAZYDRIVER.spObtenerAutosMarcaModelo @marca, @modelo ;

		select * from @procedure1
		intersect
		select * from @procedure2;
GO

CREATE PROC CRAZYDRIVER.spModificacionAutomovil
	@idAuto int,
	@licencia nvarchar(26),
	@rodado nvarchar(10)
	AS
		UPDATE CRAZYDRIVER.Auto set
		licencia = @licencia,
		rodado = @rodado
		WHERE id_auto = @idAuto
GO

CREATE PROC CRAZYDRIVER.spEliminarAuto
	@idAuto int
	AS
	UPDATE CRAZYDRIVER.Auto set habilitado = 0 where id_auto = @idAuto;
GO

CREATE PROC CRAZYDRIVER.spHabilitarAuto
	@idAuto int
	AS
	UPDATE CRAZYDRIVER.Auto set habilitado = 1 where id_auto = @idAuto;
GO

CREATE PROC CRAZYDRIVER.spObtenerViajes
	@fecha datetime,
	@turno int,
	@chofer int
	AS
		declare @fechaSinHora datetime = CONVERT (char(10), @fecha, 103);

		SELECT c.id_chofer,c.nombre , c.apellido, v.id_turno, t.descripcion, v.fecha_inicio, v.id_viaje, (SELECT (t.precio_base+v.cant_km * t.valor_km)
			FROM CRAZYDRIVER.Turno t
			WHERE t.id_turno = v.id_turno) as importe
		FROM CRAZYDRIVER.Chofer c
		JOIN CRAZYDRIVER.Viaje v on c.id_chofer = v.id_chofer
		JOIN CRAZYDRIVER.Turno t on v.id_turno = t.id_turno
		WHERE v.id_viaje NOT IN (SELECT id_viaje FROM CRAZYDRIVER.RendicionPorViaje) AND
		c.id_chofer = @chofer AND (CONVERT (char(10),v.fecha_inicio, 103)) = @fechaSinHora AND v.id_turno = @turno
GO

CREATE PROC CRAZYDRIVER.spObtenerTotalViajes
	AS
		SELECT c.id_chofer,c.nombre , c.apellido, v.id_turno, t.descripcion, v.fecha_inicio as fecha, v.id_viaje
		FROM CRAZYDRIVER.Chofer c
		JOIN CRAZYDRIVER.Viaje v on c.id_chofer = v.id_chofer
		JOIN CRAZYDRIVER.Turno t on v.id_turno = t.id_turno
		WHERE v.id_viaje NOT IN (SELECT id_viaje FROM CRAZYDRIVER.RendicionPorViaje)
GO

CREATE PROC CRAZYDRIVER.spRendir
	@fecha datetime
	AS
		declare @idRendicion int;
		SELECT @idRendicion = (max(nro_rendicion)+1) from CRAZYDRIVER.Rendicion;
		INSERT INTO CRAZYDRIVER.Rendicion (nro_rendicion ,fecha) VALUES (@idRendicion, @fecha)

GO

CREATE PROC CRAZYDRIVER.spImportePorViaje
	@viaje int,
	@importe int
	AS
		declare @idRendicion int;
		SELECT @idRendicion = (max(nro_rendicion)) from CRAZYDRIVER.Rendicion;

		INSERT INTO CRAZYDRIVER.RendicionPorViaje (nro_rendicion, id_viaje, importe)
			VALUES (@idRendicion, @viaje, @importe)
GO 
