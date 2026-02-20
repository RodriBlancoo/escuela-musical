CREATE DATABASE GestionBiblioteca;
GO
USE GestionBiblioteca;
GO


CREATE TABLE Libros (
    ISBN VARCHAR(20) PRIMARY KEY,
    Titulo VARCHAR(100),
    Autor VARCHAR(100),
    Editorial VARCHAR(100),
    Fecha_Publicacion DATE,
    Genero VARCHAR(50)
);


CREATE TABLE Usuarios (
    ID_Usuario INT PRIMARY KEY,
    Nombre VARCHAR(50),
    Apellido VARCHAR(50),
    Numero_Salida INT,
    Correo VARCHAR(100),
    Direccion VARCHAR(150),
    Numero_Telefonico VARCHAR(15)
);


CREATE TABLE Eventos (
    ID_Evento INT PRIMARY KEY,
    Nombre VARCHAR(100),
    Provincia VARCHAR(50),
    Codigo VARCHAR(20),
    Hora TIME,
    Fecha DATE,
    Nombre_Ponente VARCHAR(100)
);


CREATE TABLE Prestamos (
    ID_Prestamo INT PRIMARY KEY,
    ISBN VARCHAR(20),
    ID_Usuario INT
);


CREATE TABLE Asistentes (
    ID_Asistente INT PRIMARY KEY,
    Nombre VARCHAR(100)
);

CREATE TABLE Ir (
    ID_Usuario INT,
    ID_Evento INT
);

CREATE TABLE Pueden_Asistir (
    ID_Asistente INT,
    ID_Evento INT
);

INSERT INTO Libros VALUES ('ISBN001', 'Cien años de soledad', 'Gabriel García Márquez', 'Sudamericana', '1967-05-30', 'Novela');
INSERT INTO Libros VALUES ('ISBN002', '1984', 'George Orwell', 'Secker & Warburg', '1949-06-08', 'Distopía');
INSERT INTO Libros VALUES ('ISBN003', 'El principito', 'Antoine de Saint-Exupéry', 'Reynal & Hitchcock', '1943-04-06', 'Fábula');
INSERT INTO Libros VALUES ('ISBN004', 'Don Quijote', 'Miguel de Cervantes', 'Francisco de Robles', '1605-01-16', 'Clásico');
INSERT INTO Libros VALUES ('ISBN005', 'La sombra del viento', 'Carlos Ruiz Zafón', 'Planeta', '2001-06-06', 'Misterio');
INSERT INTO Libros VALUES ('ISBN006', 'Crónica de una muerte anunciada', 'Gabriel García Márquez', 'Sudamericana', '1981-03-01', 'Novela');
INSERT INTO Libros VALUES ('ISBN007', 'Fahrenheit 451', 'Ray Bradbury', 'Ballantine Books', '1953-10-19', 'Ciencia ficción');
INSERT INTO Libros VALUES ('ISBN008', 'Rayuela', 'Julio Cortázar', 'Sudamericana', '1963-06-28', 'Novela');
INSERT INTO Libros VALUES ('ISBN009', 'Orgullo y prejuicio', 'Jane Austen', 'T. Egerton', '1813-01-28', 'Romántico');
INSERT INTO Libros VALUES ('ISBN010', 'El alquimista', 'Paulo Coelho', 'HarperCollins', '1988-05-01', 'Aventura');

INSERT INTO Usuarios VALUES (1, 'Ana', 'López', 1001, 'ana@gmail.com', 'San Salvador', '71234567');
INSERT INTO Usuarios VALUES (2, 'Luis', 'Martínez', 1002, 'luis@yahoo.com', 'Santa Ana', '72345678');
INSERT INTO Usuarios VALUES (3, 'María', 'Gómez', 1003, 'maria@hotmail.com', 'San Miguel', '73456789');
INSERT INTO Usuarios VALUES (4, 'Carlos', 'Hernández', 1004, 'carlos@gmail.com', 'La Libertad', '74567890');
INSERT INTO Usuarios VALUES (5, 'Laura', 'Ramírez', 1005, 'laura@gmail.com', 'Chalatenango', '75678901');
INSERT INTO Usuarios VALUES (6, 'Pedro', 'Castro', 1006, 'pedro@outlook.com', 'Cabañas', '76789012');
INSERT INTO Usuarios VALUES (7, 'Elena', 'Ruiz', 1007, 'elena@gmail.com', 'Ahuachapán', '77890123');
INSERT INTO Usuarios VALUES (8, 'José', 'Pérez', 1008, 'jose@yahoo.com', 'Cuscatlán', '78901234');
INSERT INTO Usuarios VALUES (9, 'Sofía', 'Vargas', 1009, 'sofia@gmail.com', 'Morazán', '79012345');
INSERT INTO Usuarios VALUES (10, 'Diego', 'Mendoza', 1010, 'diego@hotmail.com', 'Usulután', '70123456');

INSERT INTO Eventos VALUES (1, 'Feria del Libro', 'San Salvador', 'EV001', '09:00', '2025-08-10', 'Juan Pérez');
INSERT INTO Eventos VALUES (2, 'Charla de Ciencia', 'Santa Ana', 'EV002', '14:00', '2025-08-12', 'Dra. Gómez');
INSERT INTO Eventos VALUES (3, 'Taller de Escritura', 'San Miguel', 'EV003', '10:30', '2025-08-14', 'Luis Ramírez');
INSERT INTO Eventos VALUES (4, 'Seminario de Historia', 'La Libertad', 'EV004', '08:00', '2025-08-15', 'Carlos Romero');
INSERT INTO Eventos VALUES (5, 'Expo Tecnología', 'Cuscatlán', 'EV005', '13:00', '2025-08-17', 'Sofía Morales');
INSERT INTO Eventos VALUES (6, 'Foro Ambiental', 'Morazán', 'EV006', '15:00', '2025-08-19', 'Ana Castillo');
INSERT INTO Eventos VALUES (7, 'Debate Juvenil', 'Ahuachapán', 'EV007', '11:00', '2025-08-21', 'José Méndez');
INSERT INTO Eventos VALUES (8, 'Concierto Cultural', 'Usulután', 'EV008', '18:00', '2025-08-23', 'Laura Menjívar');
INSERT INTO Eventos VALUES (9, 'Maratón de Lectura', 'Chalatenango', 'EV009', '16:00', '2025-08-25', 'Pedro Cruz');
INSERT INTO Eventos VALUES (10, 'Encuentro de Programadores', 'Cabañas', 'EV010', '10:00', '2025-08-27', 'Fernando Paredes');

INSERT INTO Prestamos VALUES (1, 'ISBN001', 1);
INSERT INTO Prestamos VALUES (2, 'ISBN002', 2);
INSERT INTO Prestamos VALUES (3, 'ISBN003', 3);
INSERT INTO Prestamos VALUES (4, 'ISBN004', 4);
INSERT INTO Prestamos VALUES (5, 'ISBN005', 5);
INSERT INTO Prestamos VALUES (6, 'ISBN006', 6);
INSERT INTO Prestamos VALUES (7, 'ISBN007', 7);
INSERT INTO Prestamos VALUES (8, 'ISBN008', 8);
INSERT INTO Prestamos VALUES (9, 'ISBN009', 9);
INSERT INTO Prestamos VALUES (10, 'ISBN010', 10);

INSERT INTO Asistentes VALUES (1, 'Ana López');
INSERT INTO Asistentes VALUES (2, 'Luis Martínez');
INSERT INTO Asistentes VALUES (3, 'María Gómez');
INSERT INTO Asistentes VALUES (4, 'Carlos Hernández');
INSERT INTO Asistentes VALUES (5, 'Laura Ramírez');
INSERT INTO Asistentes VALUES (6, 'Pedro Castro');
INSERT INTO Asistentes VALUES (7, 'Elena Ruiz');
INSERT INTO Asistentes VALUES (8, 'José Pérez');
INSERT INTO Asistentes VALUES (9, 'Sofía Vargas');
INSERT INTO Asistentes VALUES (10, 'Diego Mendoza');

INSERT INTO Ir VALUES (1, 1);
INSERT INTO Ir VALUES (2, 2);
INSERT INTO Ir VALUES (3, 3);
INSERT INTO Ir VALUES (4, 4);
INSERT INTO Ir VALUES (5, 5);
INSERT INTO Ir VALUES (6, 6);
INSERT INTO Ir VALUES (7, 7);
INSERT INTO Ir VALUES (8, 8);
INSERT INTO Ir VALUES (9, 9);
INSERT INTO Ir VALUES (10, 10);

INSERT INTO Pueden_Asistir VALUES (1, 1);
INSERT INTO Pueden_Asistir VALUES (2, 2);
INSERT INTO Pueden_Asistir VALUES (3, 3);
INSERT INTO Pueden_Asistir VALUES (4, 4);
INSERT INTO Pueden_Asistir VALUES (5, 5);
INSERT INTO Pueden_Asistir VALUES (6, 6);
INSERT INTO Pueden_Asistir VALUES (7, 7);
INSERT INTO Pueden_Asistir VALUES (8, 8);
INSERT INTO Pueden_Asistir VALUES (9, 9);
INSERT INTO Pueden_Asistir VALUES (10, 10);

SELECT*FROM Libros  
SELECT*FROM Usuarios   
SELECT*FROM Prestamos   
SELECT*FROM Eventos 
SELECT*FROM Asistentes 

drop table Libros 
drop table Usuarios 
drop table Prestamos 
drop table Eventos 
drop table Asistentes 