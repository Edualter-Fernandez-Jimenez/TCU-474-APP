CREATE PROCEDURE InsertarDireccion
    @Otras_Señas NVARCHAR(MAX),
    @Id_Provincia INT,
    @Id_Canton INT,
    @Id_Distrito INT,
    @Id_Direccion INT OUTPUT -- Parámetro de salida para el ID generado automáticamente
AS
BEGIN
    INSERT INTO Direccion (Otras_Señas, Id_Provincia, Id_Canton, Id_Distrito)
    VALUES (@Otras_Señas, @Id_Provincia, @Id_Canton, @Id_Distrito);

    SET @Id_Direccion = SCOPE_IDENTITY(); -- Asignar el valor de la identidad al parámetro de salida
END

CREATE PROCEDURE InsertarMicroempresarioEmprendimiento
    @NombreMicroempresario NVARCHAR(50),
    @ApellidoMicroempresario NVARCHAR(50),
    @Cedula NVARCHAR(50),
    @Telefono NVARCHAR(15),
    @CorreoElectronico NVARCHAR(50),
    @UltimaFechaAtencion DATETIME,
    
	/*Emprendimiento*/
	@NombreEmprendimiento NVARCHAR(50),
    @DescripcionEmprendimiento NVARCHAR(MAX),
	@CantidadColaboradores INT,
	@Id_Direccion INT
    
AS
BEGIN
    
	 -- Insertar en la tabla Emprendimientos
    INSERT INTO Emprendimientos (Nombre, Descripcion,Cantidad_Colaboradores,Id_Direccion)
    VALUES (@NombreEmprendimiento, @DescripcionEmprendimiento, @CantidadColaboradores, @Id_Direccion);

    -- Obtener el ID de Emprendimiento insertado
    DECLARE @Id_Emprendimiento INT;
    SET @Id_Emprendimiento = SCOPE_IDENTITY();

	-- Insertar en la tabla Microempresarios
    INSERT INTO Microempresarios (Nombre, Apellidos, Cedula, Telefono, Correo_Electronico, Ult_Fecha_Atencion, Id_Emprendimiento)
    VALUES (@NombreMicroempresario, @ApellidoMicroempresario, @Cedula, @Telefono, @CorreoElectronico, @UltimaFechaAtencion,@Id_Emprendimiento);

END

CREATE PROCEDURE EliminarDireccion
    @Id_Direccion INT
AS
BEGIN
    -- Verificar si la dirección existe antes de intentar eliminarla
    IF EXISTS (SELECT 1 FROM Direccion WHERE Id_Direccion = @Id_Direccion)
    BEGIN
        -- Eliminar la dirección
        DELETE FROM Direccion WHERE Id_Direccion = @Id_Direccion;
    END
END

CREATE PROCEDURE ModificarDireccion
    @Otras_Señas NVARCHAR(MAX),
    @Id_Provincia INT,
    @Id_Canton INT,
    @Id_Distrito INT,
    @Id_Direccion INT
AS
BEGIN
    UPDATE Direccion 
    SET Otras_Señas = @Otras_Señas,
        Id_Provincia = @Id_Provincia,
        Id_Canton = @Id_Canton,
        Id_Distrito = @Id_Distrito
    WHERE Id_Direccion = @Id_Direccion;
END


CREATE PROCEDURE ModificarMicroempresarioEmprendimiento
    @idMicroempresario INT,
	@NombreMicroempresario NVARCHAR(50),
    @ApellidoMicroempresario NVARCHAR(50),
    @Cedula NVARCHAR(50),
    @Telefono NVARCHAR(15),
    @CorreoElectronico NVARCHAR(50),
    @UltimaFechaAtencion DATETIME,
    
	/*Emprendimiento*/
	@IdEmprendimiento INT,
	@NombreEmprendimiento NVARCHAR(50),
    @DescripcionEmprendimiento NVARCHAR(MAX),
	@CantidadColaboradores INT,
	@Id_Direccion INT    
AS
BEGIN
    -- Actualizar la tabla Emprendimientos
    UPDATE Emprendimientos 
    SET Nombre = @NombreEmprendimiento,
        Descripcion = @DescripcionEmprendimiento,
        Cantidad_Colaboradores = @CantidadColaboradores,
        Id_Direccion = @Id_Direccion
    WHERE Id_Emprendimiento = @IdEmprendimiento;

    -- Actualizar la tabla Microempresarios
    UPDATE Microempresarios 
    SET Nombre = @NombreMicroempresario,
        Apellidos = @ApellidoMicroempresario,
        Cedula = @Cedula,
        Telefono = @Telefono,
        Correo_Electronico = @CorreoElectronico,
        Ult_Fecha_Atencion = @UltimaFechaAtencion
    WHERE Id_Microempresario = @idMicroempresario;
END
