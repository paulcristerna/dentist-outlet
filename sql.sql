create database ConsultorioDental;

use ConsultorioDental;

create table Pacientes
(
	IdPaciente int auto_increment primary key,
	Nombre varchar(50) not null,
	Apellido varchar(50) not null,
	FechaNacimiento date not null,
	Sexo varchar(20) not null,
	Domicilio varchar(50) not null,
	Telefono varchar(20)
);

create table Citas
(
	IdCita int auto_increment primary key,
	NombrePaciente varchar(50) not null,
	Fecha date not null
);

create table Servicios
(
	IdServicio int auto_increment primary key,
	NombreServicio varchar(50) not null,
	Descripcion varchar(50) not null,
	Precio float not null
);

create table Cobros
(
	IdCobro int auto_increment primary key,
	NombrePaciente varchar(50) not null,
	NombreServicio varchar(50) not null,
	Fecha date not null,
	Total float not null
);