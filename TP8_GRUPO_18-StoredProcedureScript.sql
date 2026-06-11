    CREATE PROCEDURE dbo.spEliminarSucursal
    (
        @ID_SUCURSAL INT
    )
    AS
    BEGIN
        DELETE FROM Sucursal
        WHERE ID_SUCURSAL = @ID_SUCURSAL
    END
    GO
     

    
   CREATE PROCEDURE dbo.spAgregarSucursal
    (
        @ID_SUCURSAL INT,
        @NombreSucursal NVARCHAR(100)
    )
    AS
    BEGIN
        INSERT INTO Sucursal (ID_SUCURSAL, NombreSucursal)
        VALUES (@ID_SUCURSAL, @NombreSucursal)
    END
    GO

    ALTER PROCEDURE spAgregarSucursal
    (
        @NombreSucursal VARCHAR(100),
        @DescripcionSucursal VARCHAR(100),
        @DireccionSucursal VARCHAR(100),
        @Id_ProvinciaSucursal INT
    )
    AS
    BEGIN
        INSERT INTO Sucursal
        (
            NombreSucursal,
            DescripcionSucursal,
            DireccionSucursal,
            Id_ProvinciaSucursal
        )
        VALUES
        (
            @NombreSucursal,
            @DescripcionSucursal,
            @DireccionSucursal,
            @Id_ProvinciaSucursal
        )
    END