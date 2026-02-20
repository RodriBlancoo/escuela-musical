CREATE DATABASE GestionCamiones
GO
USE GestionCamiones;
GO

CREATE TABLE Camioneros (
    DNI VARCHAR(20) PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Direccion VARCHAR(255),
    Donde_vive VARCHAR(100),
    Telefono VARCHAR(20),
    Salario DECIMAL(10, 2)
);

CREATE TABLE Camion (
    Matricula VARCHAR(20) PRIMARY KEY,
    Modelo VARCHAR(100),
    Tipo VARCHAR(100),
    Potencia INT
);

CREATE TABLE Provincias (
    Codigo VARCHAR(10) PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL
);

CREATE TABLE Paquete (
    Codigo VARCHAR(20) PRIMARY KEY,
    Descripcion VARCHAR(255),
    Distancia DECIMAL(10, 2)
);

CREATE TABLE Conducir (
    DNI_Camionero VARCHAR(20),
    Matricula_Camion VARCHAR(20),
    PRIMARY KEY (DNI_Camionero, Matricula_Camion),
    FOREIGN KEY (DNI_Camionero) REFERENCES Camioneros(DNI),
    FOREIGN KEY (Matricula_Camion) REFERENCES Camion(Matricula)
);

CREATE TABLE Distribuir (
    Matricula_Camion VARCHAR(20),
    Codigo_Paquete VARCHAR(20),
    PRIMARY KEY (Matricula_Camion, Codigo_Paquete),
    FOREIGN KEY (Matricula_Camion) REFERENCES Camion(Matricula),
    FOREIGN KEY (Codigo_Paquete) REFERENCES Paquete(Codigo)
);

CREATE TABLE Llegar (
    Codigo_Paquete VARCHAR(20),
    Codigo_Provincia VARCHAR(10),
    PRIMARY KEY (Codigo_Paquete, Codigo_Provincia),
    FOREIGN KEY (Codigo_Paquete) REFERENCES Paquete(Codigo),
    FOREIGN KEY (Codigo_Provincia) REFERENCES Provincias(Codigo)
);

INSERT INTO Camioneros (DNI, Nombre, Direccion, Donde_vive, Telefono, Salario) VALUES
('12345678-9', 'Juan Perez', 'Calle Falsa 123', 'San Salvador', '7890-1234', 850.50),
('98765432-1', 'Maria Rodriguez', 'Avenida Siempre Viva 456', 'Santa Ana', '6789-5432', 900.00),
('11223344-5', 'Carlos Lopez', 'Blvd. Los Heroes 789', 'San Miguel', '7123-4567', 875.25),
('55667788-9', 'Ana Garcia', 'Res. Las Brisas 101', 'Sonsonate', '6012-3456', 920.75),
('99001122-3', 'Pedro Martinez', 'Colonia Escalón 202', 'San Salvador', '7788-9900', 950.00),
('33445566-7', 'Luisa Fernandez', 'Urb. La Paz 303', 'La Union', '6543-2109', 880.00),
('77889900-1', 'Javier Diaz', 'Pasaje San Antonio 404', 'Usulutan', '7000-1111', 895.50),
('22114433-8', 'Sofía Romero', 'Condominio El Roble 505', 'Cojutepeque', '6123-7890', 910.00),
('66554433-2', 'Daniel Vazquez', 'Calle Principal 606', 'Chalatenango', '7345-6789', 860.00),
('44556677-0', 'Elena Soto', 'Sendero #7 707', 'Zacatecoluca', '6987-6543', 930.00);

INSERT INTO Camion (Matricula, Modelo, Tipo, Potencia) VALUES
('P12345', 'Volvo FH', 'Tractocamión', 500),
('P67890', 'Freightliner Cascadia', 'Remolque', 450),
('P11223', 'Mercedes-Benz Actros', 'Furgón', 480),
('P44556', 'Scania R-Series', 'Cisterna', 520),
('P77889', 'DAF XF', 'Plataforma', 470),
('P00112', 'Kenworth T680', 'Refrigerado', 490),
('P33445', 'MAN TGX', 'Grúa', 510),
('P66778', 'Iveco Stralis', 'Volquete', 460),
('P99001', 'Renault Trucks T', 'Contenedor', 475),
('P22334', 'Hino 500 Series', 'Carga General', 400);

INSERT INTO Provincias (Codigo, Nombre) VALUES
('SS', 'San Salvador'),
('SA', 'Santa Ana'),
('SM', 'San Miguel'),
('SO', 'Sonsonate'),
('LU', 'La Union'),
('US', 'Usulutan'),
('CH', 'Chalatenango'),
('ZA', 'Zacatecoluca'),
('LP', 'La Paz'),
('CU', 'Cuscatlan');

INSERT INTO Paquete (Codigo, Descripcion, Distancia) VALUES
('PKG001', 'Electronica Sensible', 150.75),
('PKG002', 'Alimentos Perecederos', 230.00),
('PKG003', 'Muebles Grandes', 50.20),
('PKG004', 'Documentos Urgentes', 10.50),
('PKG005', 'Material de Construccion', 300.10),
('PKG006', 'Repuestos Automotrices', 90.00),
('PKG007', 'Productos Farmaceuticos', 180.00),
('PKG008', 'Textiles y Ropa', 120.30),
('PKG009', 'Herramientas Industriales', 250.60),
('PKG010', 'Articulos Deportivos', 75.80);

INSERT INTO Conducir (DNI_Camionero, Matricula_Camion) VALUES
('12345678-9', 'P12345'),
('98765432-1', 'P67890'),
('11223344-5', 'P11223'),
('55667788-9', 'P44556'),
('99001122-3', 'P77889'),
('33445566-7', 'P00112'),
('77889900-1', 'P33445'),
('22114433-8', 'P66778'),
('66554433-2', 'P99001'),
('44556677-0', 'P22334');

INSERT INTO Distribuir (Matricula_Camion, Codigo_Paquete) VALUES
('P12345', 'PKG001'),
('P67890', 'PKG002'),
('P11223', 'PKG003'),
('P44556', 'PKG004'),
('P77889', 'PKG005'),
('P00112', 'PKG006'),
('P33445', 'PKG007'),
('P66778', 'PKG008'),
('P99001', 'PKG009'),
('P22334', 'PKG010');

INSERT INTO Llegar (Codigo_Paquete, Codigo_Provincia) VALUES
('PKG001', 'SS'),
('PKG002', 'SA'),
('PKG003', 'SM'),
('PKG004', 'SO'),
('PKG005', 'LU'),
('PKG006', 'US'),
('PKG007', 'CH'),
('PKG008', 'ZA'),
('PKG009', 'LP'),
('PKG010', 'CU');


SELECT*FROM Camioneros 
SELECT*FROM Camion 
SELECT*FROM Provincias 
SELECT*FROM Paquete 
SELECT*FROM Conducir 
SELECT*FROM Distribuir 
SELECT*FROM Llegar 