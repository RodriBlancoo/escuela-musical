CREATE DATABASE TiendaInformatica
GO
USE TiendaInformatica;
GO


CREATE TABLE Productos (
    codigo_producto VARCHAR(20) PRIMARY KEY,
    descripcion VARCHAR(255) NOT NULL,
    precio DECIMAL(10, 2) NOT NULL,
    numero_existencias INT NOT NULL CHECK (numero_existencias >= 0)
);
GO

CREATE TABLE Clientes (
    codigo_cliente VARCHAR(20) PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    apellidos VARCHAR(100),
    direccion VARCHAR(255),
    numero_telefono VARCHAR(20)
);
GO

CREATE TABLE Proveedores (
    codigo_proveedor VARCHAR(20) PRIMARY KEY, 
    nombre VARCHAR(100) NOT NULL,
    apellidos VARCHAR(100), 
    direccion VARCHAR(255),
    provincia VARCHAR(100),
    numero_telefono VARCHAR(20)
);
GO

CREATE TABLE Compras (
    id_compra INT IDENTITY(1,1) PRIMARY KEY,
    codigo_cliente VARCHAR(20) NOT NULL,
    codigo_producto VARCHAR(20) NOT NULL,
    fecha_compra DATETIME NOT NULL DEFAULT GETDATE(),
    cantidad INT NOT NULL CHECK (cantidad > 0),

    FOREIGN KEY (codigo_cliente) REFERENCES Clientes(codigo_cliente),
    FOREIGN KEY (codigo_producto) REFERENCES Productos(codigo_producto)
);
GO


CREATE TABLE Suministros (
    id_suministro INT IDENTITY(1,1) PRIMARY KEY,
    codigo_producto VARCHAR(20) NOT NULL,
    codigo_proveedor VARCHAR(20) NOT NULL,
    fecha_suministro DATE NOT NULL DEFAULT GETDATE(),
    FOREIGN KEY (codigo_producto) REFERENCES Productos(codigo_producto),
    FOREIGN KEY (codigo_proveedor) REFERENCES Proveedores(codigo_proveedor)
);
GO



INSERT INTO Productos (codigo_producto, descripcion, precio, numero_existencias)
VALUES
('PROD001', 'Portatil HP Pavilion 15', 850.00, 15),
('PROD002', 'Monitor Dell UltraSharp 24', 250.00, 30),
('PROD003', 'Teclado Mecanico Logitech G Pro', 120.00, 20),
('PROD004', 'Disco SSD Samsung 1TB', 99.99, 40);
GO

INSERT INTO Clientes (codigo_cliente, nombre, apellidos, direccion, numero_telefono)
VALUES
('CLI001', 'Roberto', 'Martínez', 'Av. Las Acacias 15', '6000-1111'),
('CLI002', 'Laura', 'González', 'C. Los Olivos 22', '7000-2222'),
('CLI003', 'Miguel', 'Hernández', 'Blvd. Constitución 7', '6123-4567');
GO

INSERT INTO Proveedores (codigo_proveedor, nombre, apellidos, direccion, provincia, numero_telefono)
VALUES
('PROV001', 'Tech Distributors', 'S.A.', 'Parque Industrial 1', 'San Salvador', '2222-3333'),
('PROV002', 'Componentes Globales', 'Ltda.', 'Zona Franca 5', 'La Libertad', '2345-6789');
GO


INSERT INTO Compras (codigo_cliente, codigo_producto, cantidad)
VALUES ('CLI001', 'PROD001', 1);

INSERT INTO Compras (codigo_cliente, codigo_producto, cantidad)
VALUES ('CLI002', 'PROD002', 2), ('CLI002', 'PROD003', 1);

INSERT INTO Compras (codigo_cliente, codigo_producto, cantidad, fecha_compra)
VALUES ('CLI003', 'PROD004', 1, '2025-06-28 10:30:00'); 
GO

INSERT INTO Suministros (codigo_producto, codigo_proveedor)
VALUES ('PROD001', 'PROV001');

INSERT INTO Suministros (codigo_producto, codigo_proveedor, fecha_suministro)
VALUES ('PROD002', 'PROV002', '2025-06-15'), ('PROD004', 'PROV002', '2025-06-15');
GO

SELECT*FROM Productos  
SELECT*FROM Clientes 
SELECT*FROM Proveedores 
SELECT*FROM Compras  
SELECT*FROM Suministros 