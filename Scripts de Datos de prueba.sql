-----------------------------PRESENTACION----------------------------------------
-- Base de Datos de un Banco

-- * Rolbik Urbaez 1105721

-- * Nelson Ureña 1105268

-- * Cristofers Valdez 1104369

-- * Huan Hao Wu 1104326 

-- * Jin Cheng Wu 1106398

-- * Natanael Zorrilla 1103111

------------------------INSERTAR DATOS DE PRUEBA--------------------------------

-- TRUNCATE TABLE Roles;
INSERT INTO Roles (Descripcion) VALUES ('Administrador');
INSERT INTO Roles (Descripcion) VALUES ('Supervisor');
INSERT INTO Roles (Descripcion) VALUES ('Empleado');
INSERT INTO Roles (Descripcion) VALUES ('Consultor');
INSERT INTO Roles (Descripcion) VALUES ('Cliente');


-- TRUNCATE TABLE Perfil;
INSERT INTO Perfil (Descripcion) VALUES ('Administrador de Sistemas');
INSERT INTO Perfil (Descripcion) VALUES ('Desarrollador Web');
INSERT INTO Perfil (Descripcion) VALUES ('Cajero');
INSERT INTO Perfil (Descripcion) VALUES ('Gerente de Proyectos');
INSERT INTO Perfil (Descripcion) VALUES ('Diseñador Gráfico');


-- TRUNCATE TABLE Usuario;
INSERT INTO Usuario (Cliente_ID, Usuario_Nombre, Usuario_Clave) VALUES (1, 'Juan', 'abc123');
INSERT INTO Usuario (Cliente_ID, Usuario_Nombre, Usuario_Clave) VALUES (2, 'María', 'qwerty');
INSERT INTO Usuario (Cliente_ID, Usuario_Nombre, Usuario_Clave) VALUES (1, 'Pedro', 'contraseña');
INSERT INTO Usuario (Cliente_ID, Usuario_Nombre, Usuario_Clave) VALUES (3, 'Ana', 'clave123');
INSERT INTO Usuario (Cliente_ID, Usuario_Nombre, Usuario_Clave) VALUES (2, 'Luis', 'qwerty123');


-- TRUNCATE TABLE Cliente;
INSERT INTO Cliente (Cliente_Nombre, Cliente_Apellido, Cliente_TipoDocumento, Cliente_Documento, Cliente_Correo, Cliente_Telefono, Cliente_Direccion, Cliente_FNacimiento, Cliente_FRegistro)
VALUES ('Juan', 'Pérez', 'DNI', '12345678', 'juanperez@mail.com', '555-1234', 'Calle Falsa 123', '1990-05-15', '2022-01-01');

INSERT INTO Cliente (Cliente_Nombre, Cliente_Apellido, Cliente_TipoDocumento, Cliente_Documento, Cliente_Correo, Cliente_Telefono, Cliente_Direccion, Cliente_FNacimiento, Cliente_FRegistro)
VALUES ('María', 'González', 'DNI', '23456789', 'mariagonzalez@mail.com', '555-5678', 'Avenida Siempreviva 456', '1985-10-20', '2022-01-02');

INSERT INTO Cliente (Cliente_Nombre, Cliente_Apellido, Cliente_TipoDocumento, Cliente_Documento, Cliente_Correo, Cliente_Telefono, Cliente_Direccion, Cliente_FNacimiento, Cliente_FRegistro)
VALUES ('Pedro', 'Gómez', 'Cédula', 'A1234567', 'pedrogomez@mail.com', '555-9012', 'Carrera 7 # 10-10', '1995-03-30', '2022-01-03');

INSERT INTO Cliente (Cliente_Nombre, Cliente_Apellido, Cliente_TipoDocumento, Cliente_Documento, Cliente_Correo, Cliente_Telefono, Cliente_Direccion, Cliente_FNacimiento, Cliente_FRegistro)
VALUES ('Ana', 'Martínez', 'DNI', '34567890', 'anamartinez@mail.com', '555-3456', 'Calle 13 # 15-20', '1980-11-05', '2022-01-04');

INSERT INTO Cliente (Cliente_Nombre, Cliente_Apellido, Cliente_TipoDocumento, Cliente_Documento, Cliente_Correo, Cliente_Telefono, Cliente_Direccion, Cliente_FNacimiento, Cliente_FRegistro)
VALUES ('Luis', 'Fernández', 'Pasaporte', 'A1B2C3D4', 'luisfernandez@mail.com', '555-7890', 'Avenida Circunvalar 789', '1998-06-10', '2022-01-05');


-- TRUNCATE TABLE Cuenta;
INSERT INTO Cuenta (Numero_Cuenta, Tipo_Cuenta_ID, Cliente_ID, Monto, Fecha_Registro)
VALUES (12345, 1, 1, 5000.00, '2022-01-01');

INSERT INTO Cuenta (Numero_Cuenta, Tipo_Cuenta_ID, Cliente_ID, Monto, Fecha_Registro)
VALUES (23456, 2, 2, 10000.00, '2022-01-02');

INSERT INTO Cuenta (Numero_Cuenta, Tipo_Cuenta_ID, Cliente_ID, Monto, Fecha_Registro)
VALUES (34567, 1, 3, 8000.00, '2022-01-03');

INSERT INTO Cuenta (Numero_Cuenta, Tipo_Cuenta_ID, Cliente_ID, Monto, Fecha_Registro)
VALUES (45678, 3, 4, 15000.00, '2022-01-04');

INSERT INTO Cuenta (Numero_Cuenta, Tipo_Cuenta_ID, Cliente_ID, Monto, Fecha_Registro)
VALUES (56789, 2, 5, 12000.00, '2022-01-05');


-- TRUNCATE TABLE Moneda
INSERT INTO Moneda (Descripcion, Moneda_abrev)
VALUES ('Dólar Estadounidense', 'USD');

INSERT INTO Moneda (Descripcion, Moneda_abrev)
VALUES ('Euro', 'EUR');

INSERT INTO Moneda (Descripcion, Moneda_abrev)
VALUES ('Libra Esterlina', 'GBP');

INSERT INTO Moneda (Descripcion, Moneda_abrev)
VALUES ('Yen Japonés', 'JPY');

INSERT INTO Moneda (Descripcion, Moneda_abrev)
VALUES ('Dólar Canadiense', 'CAD');


-- TRUNCATE TABLE Transaccion
INSERT INTO Transaccion (Tipo_Transaccion_ID, Cuenta_ID, Beneficiario_ID, Transaccion_Monto, Estado_ID, Moneda_ID)
VALUES (1, 1, 2, 1000.00, 1, 1);

INSERT INTO Transaccion (Tipo_Transaccion_ID, Cuenta_ID, Beneficiario_ID, Transaccion_Monto, Estado_ID, Moneda_ID)
VALUES (2, 3, 4, 500.00, 2, 2);

INSERT INTO Transaccion (Tipo_Transaccion_ID, Cuenta_ID, Beneficiario_ID, Transaccion_Monto, Estado_ID, Moneda_ID)
VALUES (1, 5, 6, 2000.00, 1, 3);

INSERT INTO Transaccion (Tipo_Transaccion_ID, Cuenta_ID, Beneficiario_ID, Transaccion_Monto, Estado_ID, Moneda_ID)
VALUES (3, 7, 8, 1500.00, 2, 4);

INSERT INTO Transaccion (Tipo_Transaccion_ID, Cuenta_ID, Beneficiario_ID, Transaccion_Monto, Estado_ID, Moneda_ID)
VALUES (2, 9, 10, 3000.00, 1, 5);


-- TRUNCATE TABLE Tipo_Transaccion
INSERT INTO Tipo_Transaccion (Descripcion)
VALUES ('Transferencia');

INSERT INTO Tipo_Transaccion (Descripcion)
VALUES ('Depósito');

INSERT INTO Tipo_Transaccion (Descripcion)
VALUES ('Retiro');

INSERT INTO Tipo_Transaccion (Descripcion)
VALUES ('Pago');


-- TRUNCATE TABLA Estado
INSERT INTO Estado (Descripcion)
VALUES ('Completado');

INSERT INTO Estado (Descripcion)
VALUES ('Pendiente');

INSERT INTO Estado (Descripcion)
VALUES ('Rechazado');

INSERT INTO Estado (Descripcion)
VALUES ('Cancelado');


-- TRUNCATE TABLE Tipo_Cuenta
INSERT INTO Tipo_Cuenta (Descripcion)
VALUES ('Cuenta Corriente');

INSERT INTO Tipo_Cuenta (Descripcion)
VALUES ('Cuenta de Ahorros');

INSERT INTO Tipo_Cuenta (Descripcion)
VALUES ('Cuenta Nómina');

INSERT INTO Tipo_Cuenta (Descripcion)
VALUES ('Cuenta de Inversión');

INSERT INTO Tipo_Cuenta (Descripcion)
VALUES ('Cuenta Estudiantil');


---- TRUNCATE TABLE Cuenta_beneficiario;
--INSERT INTO Cuenta_beneficiario (Cuenta_ID, Beneficiario, Beneficiario_alias)
--VALUES (1, 2, 'Cuenta de Ahorros de Juan');

--INSERT INTO Cuenta_beneficiario (Cuenta_ID, Beneficiario, Beneficiario_alias)
--VALUES (2, 1, 'Cuenta Corriente de María');

--INSERT INTO Cuenta_beneficiario (Cuenta_ID, Beneficiario, Beneficiario_alias)
--VALUES (3, 4, 'Cuenta Estudiantil de Pedro');

--INSERT INTO Cuenta_beneficiario (Cuenta_ID, Beneficiario, Beneficiario_alias)
--VALUES (4, 3, 'Cuenta Nómina de Ana');

--INSERT INTO Cuenta_beneficiario (Cuenta_ID, Beneficiario, Beneficiario_alias)
--VALUES (5, 2, 'Cuenta de Inversión de Juan');


---- TRUNCATE TABLE Beneficiario
--INSERT INTO Beneficiario(Beneficiario_Documento, Beneficiario_Correo, Banco_ID, Moneda_ID) 
--VALUES(123456, 'beneficiario1@banco.com', 1, 1);

--INSERT INTO Beneficiario(Beneficiario_Documento, Beneficiario_Correo, Banco_ID, Moneda_ID) 
--VALUES(234567, 'beneficiario2@banco.com', 2, 2);

--INSERT INTO Beneficiario(Beneficiario_Documento, Beneficiario_Correo, Banco_ID, Moneda_ID) 
--VALUES(345678, 'beneficiario3@banco.com', 3, 1);

--INSERT INTO Beneficiario(Beneficiario_Documento, Beneficiario_Correo, Banco_ID, Moneda_ID) 
--VALUES(456789, 'beneficiario4@banco.com', 2, 3);

--INSERT INTO Beneficiario(Beneficiario_Documento, Beneficiario_Correo, Banco_ID, Moneda_ID) 
--VALUES(567890, 'beneficiario5@banco.com', 1, 2);


-- TRUNCATE TABLE Banco;
INSERT INTO Banco (Descripcion) 
VALUES ('Banco Santander');

INSERT INTO Banco (Descripcion) 
VALUES ('Banco de Chile');

INSERT INTO Banco (Descripcion) 
VALUES ('BBVA');

INSERT INTO Banco (Descripcion) 
VALUES ('Banco Estado');

INSERT INTO Banco (Descripcion) 
VALUES ('Banco Itaú');

INSERT INTO Banco (Descripcion) 
VALUES ('Scotiabank');


-- TRUNCATE TABLE Prestamo;
INSERT INTO Prestamo (Cliente_ID, Tasa_Interes, Fecha_Ingreso, Fecha_Final, Monto_Prestamo, Monto_Pagar, Banco_ID, Estado_ID, Moneda_ID) 
VALUES (1, 2.5, '2022-01-01', '2022-06-01', 5000.00, 5500.00, 1, 1, 1);

INSERT INTO Prestamo (Cliente_ID, Tasa_Interes, Fecha_Ingreso, Fecha_Final, Monto_Prestamo, Monto_Pagar, Banco_ID, Estado_ID, Moneda_ID) 
VALUES (2, 3.0, '2022-02-01', '2022-08-01', 7000.00, 7700.00, 2, 1, 2);

INSERT INTO Prestamo (Cliente_ID, Tasa_Interes, Fecha_Ingreso, Fecha_Final, Monto_Prestamo, Monto_Pagar, Banco_ID, Estado_ID, Moneda_ID) 
VALUES (3, 4.0, '2022-03-01', '2022-09-01', 10000.00, 11200.00, 3, 1, 1);

INSERT INTO Prestamo (Cliente_ID, Tasa_Interes, Fecha_Ingreso, Fecha_Final, Monto_Prestamo, Monto_Pagar, Banco_ID, Estado_ID, Moneda_ID) 
VALUES (4, 1.5, '2022-04-01', '2022-10-01', 2000.00, 2100.00, 4, 1, 2);

INSERT INTO Prestamo (Cliente_ID, Tasa_Interes, Fecha_Ingreso, Fecha_Final, Monto_Prestamo, Monto_Pagar, Banco_ID, Estado_ID, Moneda_ID) 
VALUES (5, 5.0, '2022-05-01', '2022-11-01', 15000.00, 17250.00, 5, 1, 1);
