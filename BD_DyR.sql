create Database BD_DyR
use BD_DyR
GO

/*========================================================== 
TABLA: Tipo_Empleado Descripción: Define los tipos o cargos del personal. 
==========================================================*/ 
CREATE TABLE Tipo_Empleado ( 
Id_Tipo INT IDENTITY PRIMARY KEY, 
Tipo_Emp VARCHAR(50) NOT NULL UNIQUE 
); 
GO

/*==========================================================
TABLA: Usuario
Descripción: Contiene los usuarios del sistema (empleados).
==========================================================*/
CREATE TABLE Usuario (
    Id_Us INT IDENTITY PRIMARY KEY,    
    Id_Tipo INT NULL,
    Nom_Us VARCHAR(100) NOT NULL,    
    Email_Us VARCHAR(100) NOT NULL UNIQUE,
    Contra_Us VARCHAR(15) NOT NULL,
    Rol VARCHAR(20) NOT NULL,
    -- Relacionar de la tabla Usuario con la tabla
    CONSTRAINT fk_usuario_tipo_empleado 
        FOREIGN KEY (Id_Tipo) REFERENCES Tipo_Empleado(Id_Tipo)
);
GO

/*==========================================================
TABLA: Proveedor
Descripción: Registra los datos de los proveedores.
==========================================================*/
CREATE TABLE Proveedor (
    Id_Prov INT IDENTITY PRIMARY KEY,
    Nom_Prov VARCHAR(100) NOT NULL,
    RUC_Prov CHAR(11) NOT NULL UNIQUE
);
GO

/*==========================================================
TABLA: Material
Descripción: Almacena los materiales y su stock actual.
==========================================================*/
CREATE TABLE Material (
    Id_Mat INT IDENTITY PRIMARY KEY,
    Nom_Mat VARCHAR(100) NOT NULL,
    Uds_Mat VARCHAR(5) NOT NULL, /*Unidad de medida*/
    Stock_Mat INT NOT NULL DEFAULT 0
);
GO

/*==========================================================
TABLA: Compra
Descripción: Cabecera de las compras registradas.
==========================================================*/
CREATE TABLE Compra (
    Id_Comp INT IDENTITY PRIMARY KEY,
	Id_Us INT NOT NULL,
    Fec_Comp DATE NOT NULL,
    Tot_Comp DECIMAL(13,2) NOT NULL,

    --Relacionar Compra con Usuario y Proveedor
    CONSTRAINT fk_compra_usuario
        FOREIGN KEY (Id_Us) REFERENCES Usuario(Id_Us)
);
GO

/*==========================================================
TABLA: Detalle_Compra
Descripción: Detalle de cada compra, con materiales y precios.
==========================================================*/
CREATE TABLE Detalle_Compra (
    Id_DetComp INT IDENTITY PRIMARY KEY,
	Id_Prov INT NOT NULL,
    Id_Comp INT NOT NULL,
    Id_Mat INT NOT NULL,
    Cant_DetComp INT NOT NULL,
    PU_DetComp DECIMAL(10,4) NOT NULL, /* Precio unitario */

    --Relacionar Detalle_Compra con Compra y Material
    CONSTRAINT fk_detalle_prov
        FOREIGN KEY (Id_Prov) REFERENCES Proveedor(Id_Prov),
    CONSTRAINT fk_detalle_compra_compra
        FOREIGN KEY (Id_Comp) REFERENCES Compra(Id_Comp),
    CONSTRAINT fk_detalle_compra_material
        FOREIGN KEY (Id_Mat) REFERENCES Material(Id_Mat)
);
GO
--------------------------------------------------------------
/*===========================================================
1️. TRIGGER PARA ACTUALIZAR TOTAL COMPRA
===========================================================*/
CREATE TRIGGER trg_ActualizarTotalCompra
ON Detalle_Compra
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    -- Actualiza todos los Id_Comp afectados, tanto en inserciones como en eliminaciones o actualizaciones
    UPDATE C
    SET Tot_Comp = ISNULL(SUMAS.Total, 0)
    FROM Compra C
    INNER JOIN (
        SELECT Id_Comp, SUM(Cant_DetComp * PU_DetComp) AS Total
        FROM Detalle_Compra
        WHERE Id_Comp IN (
            SELECT DISTINCT Id_Comp FROM inserted
            UNION
            SELECT DISTINCT Id_Comp FROM deleted
        )
        GROUP BY Id_Comp
    ) AS SUMAS ON C.Id_Comp = SUMAS.Id_Comp;

    -- En caso se eliminen todos los detalles de una compra, el total debe quedar en 0
    UPDATE Compra
    SET Tot_Comp = 0
    WHERE Id_Comp IN (
        SELECT DISTINCT Id_Comp FROM deleted
    )
    AND Id_Comp NOT IN (
        SELECT DISTINCT Id_Comp FROM Detalle_Compra
    );
END;
GO

---------------------------------------------------------------
/*===========================================================
1️. Tipo de empleado
===========================================================*/
INSERT INTO Tipo_Empleado (Tipo_Emp)
VALUES ('Administrador de compras');
GO

/*===========================================================
2️. Usuario interno (empleado de D&R que registra la compra)
===========================================================*/
INSERT INTO Usuario (Id_Tipo, Nom_Us, Email_Us, Contra_Us, Rol)
VALUES (1, 'Dayana Escobedo', 'DY@dyreconstructores.com', '10203040', 'Comprador');
GO

/*===========================================================
3️⃣ Proveedor (Industrial Milciades Vargas SRL)
===========================================================*/
INSERT INTO Proveedor (Nom_Prov, RUC_Prov)
VALUES 
('Industrial Milciades Vargas SRL', '20481842515'),
('Roal Electric S.A.C.', '20605191755'),
('POSTES DEL NORTE S.A.', '20440424792'),
('Representaciones Otoya S.A.C.', '20608149491'),
('Inversiones Delta', '10178596140'),
('INDECO S.A.', '20251293181'),
('Conductores Eléctricos Lima S.A.', '20100063680'),
('CIA LLONPAHG S.R.L.', '20531822910'),
('EQUIPOS Y MEDICIONES ESPECIALIZADOS S.A.C.', '20601794412');
GO

/*===========================================================
4️. Material adquirido
===========================================================*/
INSERT INTO Material (Nom_Mat, Uds_Mat, Stock_Mat)
VALUES 
('Caja Met. Portamedidor Monofásico 32x18x12.5cm', 'und', 47),
('Seccionador Unipolar tipo cut out 27kv 100 a 150kv bil 10ka silicon', 'und', 3),
('Mensula De Cav De 1.50 M.', 'und', 6),
('Media Palomilla De Cav De 1.50 M.', 'und', 2),
('Media Loza De Cav De 1.50 M.', 'und', 2),
('Cajas Monofásicas', 'und', 40),
('Rollos Cable Vulcanizado 2x14 AWG Indeco', 'und', 2),
('Wincha 5 MTS', 'und', 1),
('Cable/N2XOH 0.6/1 kV 10 mm2 (01) Negro', 'mt', 270),
('Poste de CAC de 09/300/2/150/285', 'und', 14),
('Poste de CAC de 09/400/2/150/285', 'und', 13),
('Poste de CAC de 15/500/2/225/450', 'und', 2),
('Cable/N2XSY 18/30 kV 50 mm2 Rojo', 'mt', 200),
('CAAI-S 3x35+2x25 mm2 0,6/1 kV Negro', 'mt', 795),
('Cable de cobre duro 35 mm2 RM', 'mt', 20),
('Cable de cobre blando 35 mm2 RM', 'mt', 40),
('Perno', 'und', 2),
('Aislador', 'und', 2),
('Preformes', 'und', 12),
('Varilla de anclaje', 'und', 2),
('Medidor electrónico trifásico ELSTER A1800 con módem 4G/GPRS', 'und', 1),
('Medidor electrónico polifásico ELSTER AS3000', 'und', 1),
('Tab. de polietileno reforzado c/fibra de vidrio 1000x900x250', 'und', 1),
('Abrazadera de acero zinc de 2"x1/4xØ260mm c/ Pernos 1/2x4"', 'set', 1),
('Int. Term. EASYPACT CVS 3x35-50A 40/25KA', 'und', 4),
('Int. Termomagnetico CVS100B TM32D de 22.4-32A 40/25KA', 'und', 1),
('Contactor tripolar 32A 220VAC LC1E3210M5', 'und', 1),
('Fotocelda 1000W 1800VA 220VAC FHS-06A', 'und', 1),
('Int. Termom. EASY9 2x10A 230/400VAC', 'und', 1),
('Wall Socket oval P21A 4BTNC10', 'und', 1),
('Esencial LEDBULB 9W E27 6500K CDL', 'und', 1),
('Montaje de componentes tablero eléctrico', 'und', 1),
('Int. Tomacorriente Universal 10A/250V', 'und', 1),
('Caja Superficial Universal de 124x85x49mm', 'und', 1),
('Item. Riel 2 Amp. 1P, 6kA/400V LS', 'und', 4),
('Iterr. Termomag. Unipolar 1x10AMP', 'und', 1),
('Transformador corriente núcleo cerrado CL.0.5 4VA', 'und', 3),
('Borne de conexión simple 4mm2 c/Tornillo', 'und', 12),
('Borne de conexión simple 6mm2 c/Tornillo', 'und', 8),
('Tapa final para Borneras de 2.5A 10mm2', 'und', 4),
('Tope de Fijación Grampa p/Sujetar Borneras P/JxB', 'und', 4);
GO

/* ===========================
   PROCEDIMIENTOS PROVEEDOR
   =========================== */
-- Listar Proveedores
CREATE PROCEDURE spListarProveedor
AS
BEGIN
    SELECT Id_Prov, Nom_Prov, RUC_Prov FROM Proveedor;
END;
GO

-- Insertar Proveedor
CREATE PROCEDURE spInsertarProveedor
    @Nom_Prov VARCHAR(100),
    @RUC_Prov CHAR(11)
AS
BEGIN
    INSERT INTO Proveedor (Nom_Prov, RUC_Prov)
    VALUES (@Nom_Prov, @RUC_Prov);
END;
GO

-- Editar Proveedor
CREATE PROCEDURE spEditarProveedor
    @Id_Prov INT,
    @Nom_Prov VARCHAR(100),
    @RUC_Prov CHAR(11)
AS
BEGIN
    UPDATE Proveedor
    SET Nom_Prov = @Nom_Prov, RUC_Prov = @RUC_Prov
    WHERE Id_Prov = @Id_Prov;
END;
GO

-- Eliminar Proveedor
CREATE PROCEDURE spEliminarProveedor
    @Id_Prov INT
AS
BEGIN
    DELETE FROM Proveedor WHERE Id_Prov = @Id_Prov;
END;
GO

/*================================================================*/

/* ======================
   PROCEDIMIENTOS COMPRA
   ====================== */
-- Listar compras con proveedores y materiales
CREATE or alter PROCEDURE spListarCompra
AS
BEGIN
    SELECT 
        C.Id_Comp,
        C.Id_Us,
        D.Id_Prov,
        D.Id_Mat,
        D.Cant_DetComp,
        D.PU_DetComp,
        C.Tot_Comp,
        C.Fec_Comp,
        P.Nom_Prov,
        M.Nom_Mat
    FROM Compra C
    INNER JOIN Detalle_Compra D ON C.Id_Comp = D.Id_Comp
    INNER JOIN Proveedor P ON D.Id_Prov = P.Id_Prov
    INNER JOIN Material M ON D.Id_Mat = M.Id_Mat;
END;
GO

-- Insertar compra (cabecera + detalle)
CREATE or alter PROCEDURE spInsertarCompra
    @Id_Us INT,
    @Id_Prov INT,
    @Id_Mat INT,
    @Cant_DetComp INT,
    @PU_DetComp DECIMAL(10,4),
    @Fec_Comp DATE
AS
BEGIN
    DECLARE @Id_Comp INT;

    INSERT INTO Compra (Id_Us, Fec_Comp, Tot_Comp)
    VALUES (@Id_Us, @Fec_Comp, 0);

    SET @Id_Comp = SCOPE_IDENTITY();

    INSERT INTO Detalle_Compra (Id_Prov, Id_Comp, Id_Mat, Cant_DetComp, PU_DetComp)
    VALUES (@Id_Prov, @Id_Comp, @Id_Mat, @Cant_DetComp, @PU_DetComp);
END;
GO

-- Editar compra (solo detalle)
CREATE or alter PROCEDURE spEditarCompra
    @Id_Comp INT,
    @Cant_DetComp INT,
    @PU_DetComp DECIMAL(10,4)
AS
BEGIN
    UPDATE D
    SET D.Cant_DetComp = @Cant_DetComp,
        D.PU_DetComp = @PU_DetComp
    FROM Detalle_Compra D
    WHERE D.Id_Comp = @Id_Comp;
END;
GO

-- Eliminar compra
CREATE or alter PROCEDURE spEliminarCompra
    @Id_Comp INT
AS
BEGIN
    DELETE FROM Detalle_Compra WHERE Id_Comp = @Id_Comp;
    DELETE FROM Compra WHERE Id_Comp = @Id_Comp;
END;
GO


SELECT*FROM Detalle_Compra