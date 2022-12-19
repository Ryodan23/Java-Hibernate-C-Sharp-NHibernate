create database ExamenFinalProgra
go

use ExamenFinalProgra
go

create table cliente(
idCliente int primary key,
nombre varchar(30),
apellido varchar(30)
)

create table libros(
idLibro int primary key,
nombre varchar(30),
autor varchar(30),
anno varchar(30),
estado int
)

create table prestamos(
idPrestamo int primary key,
fecha varchar(50),
idCliente int foreign key references cliente (idCliente),
idlibro int foreign key references libros (idlibro)
)

create table devoluciones(
idDevolucion int primary key,
fecha varchar(50),
idCliente int foreign key references cliente (idCliente),
idlibro int foreign key references libros (idlibro)
)

create procedure ListaCliente
AS
	BEGIN
		SELECT * FROM cliente
	END
GO

create procedure ListaLibro
AS
	BEGIN
		SELECT * FROM libros
	END
GO

create procedure ListaPrestamos
AS
	BEGIN
		SELECT * FROM prestamos
	END
GO

create procedure ListaDevoluciones
AS
	BEGIN
		SELECT * FROM devoluciones
	END
GO


SELECT * FROM cliente
SELECT * FROM libros
SELECT * FROM prestamos
SELECT * FROM devoluciones

-- DELETE FROM cliente