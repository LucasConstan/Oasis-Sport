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
