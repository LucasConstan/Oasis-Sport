BD: 
CREATE TABLE usuarios (
    id_usuario INT IDENTITY(1,1) NOT NULL,
    nomUsuario NVARCHAR(50) NULL,
    contraseña NVARCHAR(50) NULL,
    PRIMARY KEY (id_usuario)
);
