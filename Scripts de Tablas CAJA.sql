-----------------------------PRESENTACION----------------------------------------
-- Base de Datos de un Banco

-- * Rolbik Urbaez 1105721

-- * Nelson Urena 1105268

-- * Cristofers Valdez 1104369

-- * Huan Hao Wu 1104326 

-- * Jin Cheng Wu 1106398

-- * Natanael Zorrilla 1103111

---------------------------CREACION DE LA BASE DE DATOS--------------------------

USE master
GO

DROP DATABASE IF EXISTS SistemaBancario;
GO

CREATE DATABASE SistemaBancario
GO

USE SistemaBancario;
GO

----------------------------CREACION DE LAS TABLAS--------------------------------
CREATE TABLE Usuario(
	Usuario_ID int identity(1,1),
	Cliente_ID int NOT NULL,
	Usuario_Nombre NVARCHAR(50) NOT NULL,
	Usuario_Clave NVARCHAR(50) NOT NULL,
	Fecha_creacion DATETIME DEFAULT GETDATE(),
);

CREATE TABLE Cliente(
	Cliente_ID int identity(1,1),
	Cliente_Nombre NVARCHAR(50) NOT NULL,
	Cliente_Apellido NVARCHAR(50) NOT NULL,
	Cliente_TipoDocumento NVARCHAR(50) NOT NULL,
	Cliente_Documento NVARCHAR(50) NOT NULL,
	Cliente_Correo NVARCHAR(50) NOT NULL,
	Cliente_Telefono NVARCHAR(50) NOT NULL,
	Cliente_Direccion NVARCHAR(50) NOT NULL,
	Cliente_FNacimiento DATETIME NOT NULL,
	Cliente_FRegistro DATETIME default getdate() NOT NULL
);

CREATE TABLE Cuenta (
	Cuenta_ID int identity(1,1), 
	Numero_Cuenta int NOT NULL,
	Tipo_Cuenta_ID int NOT NULL,
	Cliente_ID int NOT NULL,
	Monto decimal(18,2) NOT NULL,
	Fecha_Registro DATETIME default getdate() NOT NULL,
	Moneda_ID int NOT NULL
);

CREATE TABLE Transaccion(
	Transaccion_ID int identity(1,1),
	Tipo_Transaccion_ID int NOT NULL,
	Cuenta_ID int NOT NULL, --Origen
	Beneficiario_ID int NOT NULL, --Destino
	Transaccion_Monto int NOT NULL,
	Transaccion_FechaRegistro datetime default getdate() NOT NULL,
	Estado_ID int NOT NULL,
	Moneda_ID int NOT NULL
);

CREATE TABLE Tipo_Transaccion(
	Tipo_Transaccion_ID int identity(1,1),
	Descripcion NVARCHAR(50) NOT NULL
);

CREATE TABLE Estado(
	Estado_ID int identity(1,1),
	Descripcion NVARCHAR(50) NOT NULL
);

CREATE TABLE Tipo_Cuenta(
	Tipo_Cuenta_ID int identity(1,1),
	Descripcion NVARCHAR(50) NOT NULL
);

CREATE TABLE Banco(
	Banco_ID int identity(1,1),
	Descripcion NVARCHAR(50) NOT NULL,
);

CREATE TABLE Prestamo(
	Prestamo_ID int identity(1,1),
	Cliente_ID int NOT NULL,
	Tasa_Interes decimal(18,2) NOT NULL,
	Fecha_Ingreso datetime default getdate() NOT NULL,
	Fecha_Final datetime NOT NULL,
	Monto_Prestamo decimal(18,2) NOT NULL,
	Monto_Pagar decimal(18,2) NOT NULL,
	Banco_ID int NOT NULL,
	Estado_ID int NOT NULL, 
	Moneda_ID int NOT NULL
);