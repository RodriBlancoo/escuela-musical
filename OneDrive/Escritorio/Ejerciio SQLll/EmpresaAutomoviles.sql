CREATE DATABASE EmpresaAutomoviles;
GO
USE EmpresaAutomoviles;
GO


CREATE TABLE Clientes (
    codigo_cliente INT IDENTITY(1,1) PRIMARY KEY,
    DUI VARCHAR(20) UNIQUE NOT NULL,
    nombre VARCHAR(100) NOT NULL,
    direccion VARCHAR(255),
    ciudad VARCHAR(100),
    numero_telefono VARCHAR(20)
);
GO


CREATE TABLE Automoviles (
    matricula VARCHAR(20) PRIMARY KEY, 
    marca VARCHAR(100) NOT NULL,
    modelo VARCHAR(100) NOT NULL,
    color VARCHAR(50),
    precio_venta DECIMAL(18, 2) NOT NULL,
    cliente_codigo_cliente INT NULL,
    FOREIGN KEY (cliente_codigo_cliente) REFERENCES Clientes(codigo_cliente)
);
GO


CREATE TABLE Revisiones (
    codigo_revision INT IDENTITY(1,1) PRIMARY KEY,
    matricula_automovil VARCHAR(20) NOT NULL, 
    fecha_revision DATE DEFAULT GETDATE(),     
    cambio_filtro BIT DEFAULT 0,               
    cambio_aceite BIT DEFAULT 0,
    cambio_frenos BIT DEFAULT 0,
    otros_cambios VARCHAR(MAX),                
    FOREIGN KEY (matricula_automovil) REFERENCES Automoviles(matricula)
);
GO


INSERT INTO Clientes (DUI, nombre, direccion, ciudad, numero_telefono)
VALUES
('01234567-8', 'Ana Maria', 'Col. Centro, Av. Libertad 10', 'San Salvador', '7890-1234'),
('09876543-2', 'Carlos David', 'Res. Las Flores, C. Principal 5', 'Santa Tecla', '6789-0123'),
('11223344-5', 'Sofia Elena', 'Urb. La Paz, Blv. Los Pinos 20', 'Antiguo Cuscatlan', '7123-4567');
GO


INSERT INTO Automoviles (matricula, marca, modelo, color, precio_venta, cliente_codigo_cliente)
VALUES
('P123-456', 'Toyota', 'Corolla', 'Blanco', 22500.00, NULL), 
('P789-012', 'Honda', 'Civic', 'Gris', 28000.00, NULL),     
('P345-678', 'Mazda', 'CX-5', 'Rojo', 35000.00, (SELECT codigo_cliente FROM Clientes WHERE DUI = '01234567-8')); -- Sold to Ana Maria
GO


INSERT INTO Revisiones (matricula_automovil, cambio_filtro, otros_cambios)
VALUES ('P123-456', 1, 'Revisión de 10,000 km, se cambió el filtro de aire.');
GO

INSERT INTO Revisiones (matricula_automovil, fecha_revision, cambio_aceite, cambio_frenos, otros_cambios)
VALUES ('P789-012', '2025-05-20', 1, 1, 'Cambio de aceite, filtro de aceite y pastillas de freno delanteras.');
GO

INSERT INTO Revisiones (matricula_automovil, fecha_revision, cambio_filtro, cambio_aceite, cambio_frenos, otros_cambios)
VALUES ('P123-456', '2025-06-25', 1, 1, 1, 'Mantenimiento completo de los 20,000 km.');
GO


SELECT*FROM Clientes 
SELECT*FROM Automoviles  
SELECT*FROM Revisiones 