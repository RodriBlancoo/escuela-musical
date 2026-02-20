CREATE DATABASE EmpresaVentasProductos;
GO
USE EmpresaVentasProductos;
GO

CREATE TABLE Proveedor (
    NIF VARCHAR(15) PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Direccion VARCHAR(255)
);
GO

CREATE TABLE Productos (
    Codigo VARCHAR(20) PRIMARY KEY,
    Nombre VARCHAR(255) NOT NULL,
    Precio_unitario DECIMAL(10, 2) NOT NULL,
    NIF_Proveedor VARCHAR(15) NOT NULL, 
    FOREIGN KEY (NIF_Proveedor) REFERENCES Proveedor(NIF)
);
GO

CREATE TABLE Clientes (
    DUI VARCHAR(20) PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Apellido VARCHAR(100) NOT NULL,
    Direccion VARCHAR(255),
    Fecha_de_nacimiento DATE
);
GO

CREATE TABLE Compras (
    Id_Compra INT IDENTITY(1,1) PRIMARY KEY, 
    DNI_Cliente VARCHAR(20) NOT NULL,
    Codigo_Producto VARCHAR(20) NOT NULL,
    Fecha_compra DATETIME DEFAULT GETDATE(), 
    Cantidad INT NOT NULL CHECK (Cantidad > 0), 

    FOREIGN KEY (DNI_Cliente) REFERENCES Clientes(DUI),
    FOREIGN KEY (Codigo_Producto) REFERENCES Productos(Codigo)
);
GO

INSERT INTO Proveedor (NIF, Nombre, Direccion) VALUES
('P001A', 'Tecno Suministros SA', 'Calle Mayor 1, Madrid');
INSERT INTO Proveedor (NIF, Nombre, Direccion) VALUES
('P002B', 'Electro Componentes Ltda.', 'Av. Central 20, Barcelona');
INSERT INTO Proveedor (NIF, Nombre, Direccion) VALUES
('P003C', 'Digital Solutions Corp', 'Paseo del Sol 5, Valencia');
INSERT INTO Proveedor (NIF, Nombre, Direccion) VALUES
('P004D', 'Materiales Informaticos', 'Plaza España 8, Sevilla');
INSERT INTO Proveedor (NIF, Nombre, Direccion) VALUES
('P005E', 'Global Tech Imports', 'Via Augusta 15, Zaragoza');
INSERT INTO Proveedor (NIF, Nombre, Direccion) VALUES
('P006F', 'Componentes del Futuro', 'Ronda de Dalt 30, Bilbao');
INSERT INTO Proveedor (NIF, Nombre, Direccion) VALUES
('P007G', 'Innovacion Electrónica', 'Alameda Principal 10, Málaga');
INSERT INTO Proveedor (NIF, Nombre, Direccion) VALUES
('P008H', 'Suministros de Oficina', 'Gran Via 45, Palma');
INSERT INTO Proveedor (NIF, Nombre, Direccion) VALUES
('P009I', 'Pro-Tecnologia', 'Calle del Oro 7, Murcia');
INSERT INTO Proveedor (NIF, Nombre, Direccion) VALUES
('P010J', 'Distribuidora del Norte', 'Av. America 25, Oviedo');
GO


INSERT INTO Productos (Codigo, Nombre, Precio_unitario, NIF_Proveedor) VALUES
('PRD001', 'Smartphone X', 899.99, 'P001A');
INSERT INTO Productos (Codigo, Nombre, Precio_unitario, NIF_Proveedor) VALUES
('PRD002', 'Laptop Ultra Pro', 1499.00, 'P001A');
INSERT INTO Productos (Codigo, Nombre, Precio_unitario, NIF_Proveedor) VALUES
('PRD003', 'Auriculares Inalambricos', 120.50, 'P002B');
INSERT INTO Productos (Codigo, Nombre, Precio_unitario, NIF_Proveedor) VALUES
('PRD004', 'Disco Duro SSD 1TB', 95.00, 'P002B');
INSERT INTO Productos (Codigo, Nombre, Precio_unitario, NIF_Proveedor) VALUES
('PRD005', 'Impresora Multifuncion', 210.75, 'P003C');
INSERT INTO Productos (Codigo, Nombre, Precio_unitario, NIF_Proveedor) VALUES
('PRD006', 'Monitor Gamer 24"', 280.00, 'P003C');
INSERT INTO Productos (Codigo, Nombre, Precio_unitario, NIF_Proveedor) VALUES
('PRD007', 'Router Wi-Fi 6', 80.20, 'P004D');
INSERT INTO Productos (Codigo, Nombre, Precio_unitario, NIF_Proveedor) VALUES
('PRD008', 'Camara Web HD', 35.00, 'P004D');
INSERT INTO Productos (Codigo, Nombre, Precio_unitario, NIF_Proveedor) VALUES
('PRD009', 'Tablet Pro 10"', 399.00, 'P005E');
INSERT INTO Productos (Codigo, Nombre, Precio_unitario, NIF_Proveedor) VALUES
('PRD010', 'Smartwatch Deportivo', 150.00, 'P005E');
GO

INSERT INTO Clientes (DUI, Nombre, Apellido, Direccion, Fecha_de_nacimiento) VALUES
('11111111A', 'Juan', 'Perez Garcia', 'Calle Larga 1, Madrid', '1990-01-15');
INSERT INTO Clientes (DUI, Nombre, Apellido, Direccion, Fecha_de_nacimiento) VALUES
('22222222B', 'Maria', 'Fernandez Lopez', 'Av. del Mar 20, Barcelona', '1988-05-22');
INSERT INTO Clientes (DUI, Nombre, Apellido, Direccion, Fecha_de_nacimiento) VALUES
('33333333C', 'Carlos', 'Ruiz Sanchez', 'Paseo de Gracia 5, Valencia', '1995-09-03');
INSERT INTO Clientes (DUI, Nombre, Apellido, Direccion, Fecha_de_nacimiento) VALUES
('44444444D', 'Laura', 'Diaz Blanco', 'Gran Via 10, Sevilla', '1982-12-01');
INSERT INTO Clientes (DUI, Nombre, Apellido, Direccion, Fecha_de_nacimiento) VALUES
('55555555E', 'Pedro', 'Gomez Martin', 'Plaza Mayor 3, Zaragoza', '1975-07-18');
INSERT INTO Clientes (DUI, Nombre, Apellido, Direccion, Fecha_de_nacimiento) VALUES
('66666666F', 'Sofia', 'Hernandez Ruiz', 'Ronda Sant Pere 8, Bilbao', '1998-02-28');
INSERT INTO Clientes (DUI, Nombre, Apellido, Direccion, Fecha_de_nacimiento) VALUES
('77777777G', 'Miguel', 'Jimenez Torres', 'Calle de la Paz 12, Málaga', '1980-04-05');
INSERT INTO Clientes (DUI, Nombre, Apellido, Direccion, Fecha_de_nacimiento) VALUES
('88888888H', 'Ana', 'Moreno Castro', 'Av. de la Constitucion 7, Palma', '1993-06-11');
INSERT INTO Clientes (DUI, Nombre, Apellido, Direccion, Fecha_de_nacimiento) VALUES
('99999999I', 'Elena', 'Romero Gil', 'Paseo del Prado 4, Murcia', '1970-10-25');
INSERT INTO Clientes (DUI, Nombre, Apellido, Direccion, Fecha_de_nacimiento) VALUES
('10101010J', 'Pablo', 'Vazquez Conde', 'Calle Toledo 9, Oviedo', '1987-11-09');
GO

INSERT INTO Compras (DNI_Cliente, Codigo_Producto, Cantidad, Fecha_compra) VALUES
('11111111A', 'PRD001', 1, GETDATE()); 
INSERT INTO Compras (DNI_Cliente, Codigo_Producto, Cantidad, Fecha_compra) VALUES
('22222222B', 'PRD003', 2, '2025-06-28 10:00:00'); 
INSERT INTO Compras (DNI_Cliente, Codigo_Producto, Cantidad, Fecha_compra) VALUES
('33333333C', 'PRD005', 1, GETDATE()); 
INSERT INTO Compras (DNI_Cliente, Codigo_Producto, Cantidad, Fecha_compra) VALUES
('44444444D', 'PRD007', 1, '2025-07-01 15:30:00'); 
INSERT INTO Compras (DNI_Cliente, Codigo_Producto, Cantidad, Fecha_compra) VALUES
('55555555E', 'PRD002', 1, GETDATE()); 
INSERT INTO Compras (DNI_Cliente, Codigo_Producto, Cantidad, Fecha_compra) VALUES
('66666666F', 'PRD004', 2, '2025-06-29 09:00:00'); 
INSERT INTO Compras (DNI_Cliente, Codigo_Producto, Cantidad, Fecha_compra) VALUES
('77777777G', 'PRD006', 1, GETDATE()); 
INSERT INTO Compras (DNI_Cliente, Codigo_Producto, Cantidad, Fecha_compra) VALUES
('88888888H', 'PRD008', 3, '2025-07-02 11:00:00'); 
INSERT INTO Compras (DNI_Cliente, Codigo_Producto, Cantidad, Fecha_compra) VALUES
('99999999I', 'PRD009', 1, GETDATE()); 
INSERT INTO Compras (DNI_Cliente, Codigo_Producto, Cantidad, Fecha_compra) VALUES
('10101010J', 'PRD010', 1, '2025-07-01 17:45:00'); 
GO

SELECT 'Proveedores:' AS Tabla, COUNT(*) AS TotalRegistros FROM Proveedor;
SELECT * FROM Proveedor;
GO

SELECT 'Productos:' AS Tabla, COUNT(*) AS TotalRegistros FROM Productos;
SELECT * FROM Productos;
GO

SELECT 'Clientes:' AS Tabla, COUNT(*) AS TotalRegistros FROM Clientes;
SELECT * FROM Clientes;
GO

SELECT 'Compras:' AS Tabla, COUNT(*) AS TotalRegistros FROM Compras;
SELECT * FROM Compras;
GO
