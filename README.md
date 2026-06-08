BD:

CREATE DATABASE OasisSports;

CREATE TABLE usuarios (
    id_usuario INT IDENTITY(1,1) NOT NULL,
    nomUsuario NVARCHAR(50) NULL,
    contraseña NVARCHAR(100) NULL,
    bloqueado BIT NOT NULL DEFAULT 0,
    eliminado BIT NOT NULL DEFAULT 0,
    PRIMARY KEY (id_usuario)
);


CREATE TABLE BitacoraEventos
(
    IdEvento INT IDENTITY(1,1) PRIMARY KEY,
    Usuario VARCHAR(50),
    Modulo VARCHAR(50),
    Descripcion VARCHAR(200),
    Fecha DATETIME,
    Criticidad INT
)
