-----------------------------PRESENTACION----------------------------------------

-- Base de Datos de un Banco

-- * Rolbik Urbaez 1105721

-- * Nelson Urena 1105268

-- * Cristofers Valdez 1104369

-- * Huan Hao Wu 1104326

-- * Jin Cheng Wu 1106398

-- * Natanael Zorrilla 1103111

---------------------------------------------------------------------------------

USE SistemaBancario;
GO 
------------------------- PROCEDIMIENTOS ALMACENADOS CRUD ----------------------------

--------------------------------------- CRUD Usuario ---------------------------------------
--INSERTAR
CREATE OR ALTER PROCEDURE sp_InsertarUsuario (
        @Cliente_ID int,
        @Usuario_Nombre nvarchar(50),
        @Usuario_clave nvarchar(50)
    ) AS BEGIN
INSERT INTO
    Usuario(
        Cliente_ID,
        Usuario_Nombre,
        Usuario_clave
    )
VALUES (
        @Cliente_ID,
        @Usuario_Nombre,
        @Usuario_clave
    )
END 
GO 

--ACTUALIZAR
CREATE OR ALTER PROCEDURE sp_ActualizarUsuario (
        @Usuario_ID int,
        @Cliente_ID int,
        @Usuario_Nombre nvarchar(50),
        @Usuario_clave nvarchar(50)
    ) AS BEGIN
UPDATE Usuario
SET
    Cliente_ID = @Cliente_ID,
    Usuario_Nombre = @Usuario_Nombre,
    Usuario_clave = @Usuario_clave
WHERE
    Usuario_ID = @Usuario_ID
END 
GO 

--ELIMINAR
CREATE OR ALTER PROCEDURE sp_EliminarUsuario (@Usuario_ID int) AS BEGIN
DELETE FROM Usuario
WHERE
    Usuario_ID = @Usuario_ID
END 
GO 

--READ FILTRADO
CREATE OR ALTER PROCEDURE sp_ObtenerUsuarioPorID (@Usuario_ID int) AS BEGIN
SELECT *
FROM Usuario
WHERE
    Usuario_ID = @Usuario_ID
END 
GO 

--READ DE TODO
CREATE OR ALTER PROCEDURE sp_ObtenerTodosLosUsuarios AS BEGIN
SELECT *
FROM
    Usuario
END 
GO 

--------------------------------------- CRUD Cuentas ---------------------------------------
--INSERTAR
CREATE OR ALTER PROCEDURE sp_InsertarCuenta (
        @Tipo_Cuenta_ID int,
        @Cliente_ID int,
		@Monto decimal(18,2),
        @Numero_Cuenta int, -- TODO: Hay que hacer un procedure que genere un número de cuenta
        @Moneda_ID int
    ) AS BEGIN
INSERT INTO
    Cuenta(
        Tipo_Cuenta_ID,
        Cliente_ID,
        Monto,
        Numero_Cuenta,
        Moneda_ID
    )
VALUES (
        @Tipo_Cuenta_ID,
        @Cliente_ID,
        0, --TODO: REVISAR ESTO 
        @Numero_Cuenta,
        @Moneda_ID
    )
END 
GO 

--Actualizar
CREATE OR ALTER PROCEDURE sp_ActualizarCuenta (
        @Cuenta_ID int,
        @Tipo_Cuenta_ID int,
        @Cliente_ID int,
        @Numero_Cuenta int,
        @Moneda_ID int
    ) AS BEGIN
UPDATE Cuenta
SET
    Tipo_Cuenta_ID = @Tipo_Cuenta_ID,
    Cliente_ID = @Cliente_ID,
    Numero_Cuenta = @Numero_Cuenta,
    Moneda_ID = @Moneda_ID
WHERE
    Cuenta_ID = @Cuenta_ID
END 
GO 

--ELIMINAR
CREATE OR ALTER PROCEDURE sp_EliminarCuenta (@Cuenta_ID int) AS BEGIN
DELETE FROM Cuenta
WHERE
    Cuenta_ID = @Cuenta_ID
END 
GO 

--READ por ID de cuenta
CREATE OR ALTER PROCEDURE sp_ObtenerCuentaPorID (@Cuenta_ID int) AS BEGIN
SELECT *
FROM Cuenta
WHERE
    Cuenta_ID = @Cuenta_ID
END 
GO 

--READ DE TODO
CREATE OR ALTER PROCEDURE sp_ObtenerTodasLasCuentas AS BEGIN
SELECT *
FROM
    Cuenta
END 
GO 

-- OBTENER MONTO DE UN CLIENTE
CREATE OR ALTER PROCEDURE sp_ObtenerTodasLasCuentas(
		@Cliente_ID int
	) AS BEGIN
SELECT Monto FROM Cuenta Cu
INNER JOIN Cliente Cli ON Cli.Cliente_ID = Cu.Cliente_ID
END 
GO 

--------------------------------------- CRUD Perfil ---------------------------------------
--INSERTAR PERFIL
CREATE OR ALTER PROCEDURE sp_InsertarPerfil (@Descripcion nvarchar(50)) AS BEGIN
INSERT INTO
    Perfil(Descripcion)
VALUES (@Descripcion)
END 
GO 

--ACTUALIZAR PERFIL
CREATE OR ALTER PROCEDURE sp_ActualizarPerfil (
        @Perfil_ID int,
        @Descripcion nvarchar(50)
    ) AS BEGIN
UPDATE Perfil
SET Descripcion = @Descripcion
WHERE
    Perfil_ID = @Perfil_ID
END 
GO 

--ELIMINAR PERFIL
CREATE OR ALTER PROCEDURE sp_EliminarPerfil (@Perfil_ID int) AS BEGIN
DELETE FROM Perfil
WHERE
    Perfil_ID = @Perfil_ID
END 
GO 

--READ FILTRADO POR ID
CREATE OR ALTER PROCEDURE sp_ObtenerPerfilPorID (@Perfil_ID int) AS BEGIN
SELECT *
FROM Perfil
WHERE
    Perfil_ID = @Perfil_ID
END 
GO 

--READ DE TODO
CREATE OR ALTER PROCEDURE sp_ObtenerTodosLosPerfiles AS BEGIN
SELECT *
FROM Perfil
END 
GO


--------------------------------------- CRUD Prestamo ---------------------------------------
--Insert
CREATE OR ALTER PROCEDURE sp_InsertPrestamo
(
    @ClienteID INT,
    @TasaInteres DECIMAL(18,2),
    @FechaFinal DATETIME,
    @MontoPrestamo DECIMAL(18,2),
    @MontoPagar DECIMAL(18,2),
    @BancoID INT,
    @EstadoID INT,
    @MonedaID INT
)
AS
BEGIN
    INSERT INTO Prestamo(Cliente_ID, Tasa_Interes, Fecha_Final, Monto_Prestamo, Monto_Pagar, Banco_ID, Estado_ID, Moneda_ID)
    VALUES (@ClienteID, @TasaInteres, @FechaFinal, @MontoPrestamo, @MontoPagar, @BancoID, @EstadoID, @MonedaID)
END
Go

--UPDATE
CREATE OR ALTER PROCEDURE sp_UpdatePrestamo
(
    @PrestamoID INT,
    @ClienteID INT,
    @TasaInteres DECIMAL(18,2),
    @FechaFinal DATETIME,
    @MontoPrestamo DECIMAL(18,2),
    @MontoPagar DECIMAL(18,2),
    @BancoID INT,
    @EstadoID INT,
    @MonedaID INT
)
AS
BEGIN
    UPDATE Prestamo
SET 
    Cliente_ID = @ClienteID,
    Tasa_Interes = @TasaInteres,
    Fecha_Final = @FechaFinal,
    Monto_Prestamo = @MontoPrestamo,
    Monto_Pagar = @MontoPagar,
    Banco_ID = @BancoID,
    Estado_ID = @EstadoID,
    Moneda_ID = @MonedaID
WHERE Prestamo_ID = @PrestamoID

END

Go
--DELETE
CREATE OR ALTER PROCEDURE sp_DeletePrestamo
(
    @PrestamoID INT
)
AS
BEGIN
    DELETE FROM Prestamo
    WHERE Prestamo_ID = @PrestamoID
END

Go
--GetAll
CREATE OR ALTER PROCEDURE sp_GetPrestamos
AS
BEGIN
    SELECT * FROM Prestamo
END

Go
--GetByID
CREATE OR ALTER PROCEDURE sp_GetPrestamoByID
(
    @PrestamoID INT
)
AS
BEGIN
    SELECT * FROM Prestamo
    WHERE Prestamo_ID = @PrestamoID
END
Go


--------------------------------------- CRUD Tipo Transaccion ---------------------------------------
--INSERT
CREATE OR ALTER PROCEDURE  sp_InsertTipoTransaccion
    @Descripcion NVARCHAR(50)
AS
BEGIN
    INSERT INTO Tipo_Transaccion (Descripcion)
    VALUES (@Descripcion)
END

Go
--UPDATE
CREATE OR ALTER PROCEDURE  sp_UpdateTipoTransaccion
    @TipoTransaccionID INT,
    @Descripcion NVARCHAR(50)
AS
BEGIN
    UPDATE Tipo_Transaccion
    SET Descripcion = COALESCE(@Descripcion, Descripcion)
    WHERE Tipo_Transaccion_ID = @TipoTransaccionID
END

Go
--DELETE
CREATE OR ALTER PROCEDURE  sp_EliminarTipoTransaccion
    @TipoTransaccionID INT
AS
BEGIN
    DELETE FROM Tipo_Transaccion
    WHERE Tipo_Transaccion_ID = @TipoTransaccionID
END


Go
--GetAll
CREATE OR ALTER PROCEDURE  sp_ObtenerTodosTipoTransaccion
AS
BEGIN
    SELECT * FROM Tipo_Transaccion
END

Go
--GetByID
CREATE OR ALTER PROCEDURE  sp_GetTipoTransaccionByID
    @TipoTransaccionID INT
AS
BEGIN
    SELECT * FROM Tipo_Transaccion
    WHERE Tipo_Transaccion_ID = @TipoTransaccionID
END
Go

--Consultar movimientos de cuentas
CREATE OR ALTER PROCEDURE sp_ConsultarMovimientosCuenta
    @CuentaID int
AS
BEGIN
    SELECT 
        t.Transaccion_FechaRegistro,
        tt.Descripcion AS Tipo_Transaccion,
        CASE 
            WHEN t.Cuenta_ID = @CuentaID THEN 'Retiro'
            ELSE 'Depósito'
        END AS Tipo_Movimiento,
        CASE 
            WHEN t.Cuenta_ID = @CuentaID THEN '-' + CONVERT(NVARCHAR(50), t.Transaccion_Monto)
            ELSE '+' + CONVERT(NVARCHAR(50), t.Transaccion_Monto)
        END AS Monto,
        m.Descripcion AS Moneda,
        ISNULL(cb.Beneficiario_alias, '') AS Beneficiario
    FROM Transaccion t
    INNER JOIN Tipo_Transaccion tt ON t.Tipo_Transaccion_ID = tt.Tipo_Transaccion_ID
    INNER JOIN Moneda m ON t.Moneda_ID = m.Moneda_ID
    LEFT JOIN Cuenta_beneficiario cb ON t.Beneficiario_ID = cb.Cuenta_ID AND t.Cuenta_ID = cb.Cuenta_ID
    WHERE t.Cuenta_ID = @CuentaID OR t.Beneficiario_ID = @CuentaID
END
