CREATE DATABASE Gestion_Eventos;
USE Gestion_Eventos;


CREATE TABLE Categoria (
    nombre_categoria VARCHAR(30) NOT NULL,
    descripcion VARCHAR(100),
    PRIMARY KEY (nombre_categoria));

CREATE TABLE Ubicacion (
    id INT NOT NULL,
    tipo ENUM('online', 'presencial') NOT NULL,
    PRIMARY KEY (id));


CREATE TABLE Online (
    id INT NOT NULL,
    enlace VARCHAR(100) NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (id) REFERENCES Ubicacion(id)
);

CREATE TABLE Presencial (
    id INT NOT NULL,
    direccion VARCHAR(100) NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (id) REFERENCES Ubicacion(id)
);


CREATE TABLE Usuario (
    id_usuario INT NOT NULL,
    nombre VARCHAR(50) NOT NULL,
    email VARCHAR(50) NOT NULL,
    contraseña VARCHAR(100) NOT NULL,
    telefono VARCHAR(50),
    PRIMARY KEY (id_usuario)
);


CREATE TABLE Organizador (
    id_organizador INT NOT NULL,
    nombre VARCHAR(50) NOT NULL,
    telefono VARCHAR(30) NOT NULL,
    email VARCHAR(50) NOT NULL,
    contraseña VARCHAR(100) NOT NULL,
    PRIMARY KEY (id_organizador)
);


CREATE TABLE Evento (
    id_evento INT NOT NULL,
    nombre VARCHAR(50) NOT NULL,
    fecha DATE NOT NULL,
    duracion INT NOT NULL,
    aforoMax INT NOT NULL,
    estado ENUM('activo', 'cancelado') NOT NULL,
    id_organizador INT NOT NULL,
    id_ubicacion INT NOT NULL,
    nombre_categoria VARCHAR(30) NOT NULL,
    PRIMARY KEY (id_evento),
    FOREIGN KEY (id_organizador) REFERENCES Organizador(id_organizador),
    FOREIGN KEY (id_ubicacion) REFERENCES Ubicacion(id),
    FOREIGN KEY (nombre_categoria) REFERENCES Categoria(nombre_categoria)
);


CREATE TABLE Inscripcion (
    id_usuario INT NOT NULL,
    id_evento INT NOT NULL,
    fecha_inscripcion DATE NOT NULL,
    PRIMARY KEY (id_usuario, id_evento),
    FOREIGN KEY (id_usuario) REFERENCES Usuario(id_usuario),
    FOREIGN KEY (id_evento) REFERENCES Evento(id_evento)
);