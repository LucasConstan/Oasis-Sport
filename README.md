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


CREATE TABLE Permiso (
    Id INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100) NOT NULL,
    Codigo NVARCHAR(100) NULL,
    EsGrupo BIT NOT NULL
);

CREATE TABLE PermisoRelacion (
    PadreId INT NOT NULL,
    HijoId INT NOT NULL,
    PRIMARY KEY (PadreId, HijoId),
    FOREIGN KEY (PadreId) REFERENCES Permiso(Id),
    FOREIGN KEY (HijoId) REFERENCES Permiso(Id)
);

CREATE TABLE UsuarioPermiso (
    UsuarioId INT NOT NULL,
    PermisoId INT NOT NULL,
    PRIMARY KEY (UsuarioId, PermisoId)
);

INSERT INTO Permiso (Nombre, Codigo, EsGrupo)
VALUES
('Bitacora', 'BTE', 0),
('Gestion de usuarios', 'GUS', 0),
('Gestion de perfiles', 'GPE', 0),
('Gestion de reservas', 'GRE', 0);

CREATE TABLE Idioma (
    IdIdioma INT IDENTITY PRIMARY KEY,
    Nombre VARCHAR(50)
);

CREATE TABLE Traduccion (
    IdTraduccion INT IDENTITY PRIMARY KEY,
    IdIdioma INT,
    Clave VARCHAR(100),
    Texto VARCHAR(200),
    FOREIGN KEY (IdIdioma) REFERENCES Idioma(IdIdioma)
);

INSERT INTO Idioma (Nombre) VALUES ('Español');
INSERT INTO Idioma (Nombre) VALUES ('Inglés');

INSERT INTO Permiso (Nombre, Codigo, EsGrupo) VALUES ('Gestion de idiomas', 'GID', 0);

SELECT Id FROM Permiso WHERE Codigo = 'GID';
-- Reemplazar el 5 por el id que devuelva el SELECT anterior
INSERT INTO UsuarioPermiso (UsuarioId, PermisoId) VALUES (1, 5);

ALTER TABLE Usuarios ADD DVH INT NOT NULL DEFAULT 0;

CREATE TABLE DVVertical (
    Tabla    VARCHAR(50) PRIMARY KEY,
    ValorDVV INT NOT NULL DEFAULT 0
);

INSERT INTO DVVertical (Tabla, ValorDVV) VALUES ('Usuarios', 0);

