create database concesionario

use concesionario

/*TABLA TIPO VEHICULO--------------------------------------------------------------------------*/
create table tipo_vehiculo
(
	id int primary key,
	nombre varchar(50),
)

/*INSERT*/
create proc registrarTipoVehiculos
(
	@id int, @nombre varchar(50)
)
as insert into tipo_vehiculo values(@id, @nombre)


/*UPDATE*/
create proc actualizarTipoVehiculos
(
	@id int, @nombre varchar(50)
)
as update tipo_vehiculo set nombre=@nombre where id=@id


/*DELETE*/
create proc eliminarTipoVehiculos
(
	@id int
)
as delete from tipo_vehiculo where id=@id



select * from tipo_vehiculo



/*TABLA VEHICULO--------------------------------------------------------------------------*/

create table vehiculo
(
	id int primary key,
	marca varchar(50),
	modelo varchar(50),
	matricula varchar(50),
	anio int,
	id_tipo_vehiculo int
)

/*INSERT*/
create proc registrarVehiculo
(
	@id int, @marca varchar(50), @modelo varchar(50), @matricula varchar (50), @anio int, @id_tipo_vehiculo int
)
as insert into vehiculo values(@id, @marca, @modelo, @matricula, @anio, @id_tipo_vehiculo)


/*UPDATE*/
create proc actualizarVehiculo
(
	@id int, @marca varchar(50), @modelo varchar(50), @matricula varchar (50), @anio int, @id_tipo_vehiculo int
)
as update vehiculo set marca=@marca, modelo=@modelo, matricula=@matricula, anio=@anio, id_tipo_vehiculo=@id_tipo_vehiculo where id=@id


/*DELETE*/
create proc eliminarVehiculo
(
	@id int
)
as delete from vehiculo where id=@id

/*Crear la foreign key*/
Alter table vehiculo
add constraint fk_tipo_vehiculo foreign key (id_tipo_vehiculo) references tipo_vehiculo (id)


select * from vehiculo


/*TABLA CONDUCTOR--------------------------------------------------------------------------*/

create table conductor
(
	id int NOT NULL,
	nombre varchar(50),
	tipo_licencia varchar(50),
	id_vehiculo int NOT NULL,
	id_tipo_conductor int NOT NULL,
	PRIMARY KEY (id),
	CONSTRAINT FK_idVehiculoC FOREIGN KEY (id_vehiculo) REFERENCES vehiculo(id),
	CONSTRAINT FK_idTipoConductorC FOREIGN KEY (id_tipo_conductor) REFERENCES tipo_conductor(id)
	ON DELETE CASCADE
    ON UPDATE CASCADE
   
)

/*Crear la foreign key*/
Alter table conductor
add constraint fk_id_vehiculo foreign key (id_vehiculo) references vehiculo (id)



/*INSERT*/
create proc registrarConductor
(
	@id int, @nombre varchar(50), @tipo_licencia varchar(50), @id_vehiculo int, @id_tipo_conductor int
)
as insert into conductor values(@id, @nombre, @tipo_licencia, @id_vehiculo, @id_tipo_conductor)


/*UPDATE*/
create proc actualizarConductor
(
	@id int, @nombre varchar(50), @tipo_licencia varchar(50), @id_vehiculo int, @id_tipo_conductor int
)
as update conductor set nombre=@nombre, tipo_licencia=@tipo_licencia, id_vehiculo=@id_vehiculo, id_tipo_conductor =@id_tipo_conductor where id=@id


/*DELETE*/
create proc eliminarConductor
(
	@id int
)
as delete from conductor where id=@id


/*TABLA TIPO CONDUCTOR--------------------------------------------------------------------------*/
create table tipo_conductor
(
	id int primary key,
	nombre varchar(50),
)

/*INSERT*/
create proc registrarTipoConductor
(
	@id int, @nombre varchar(50)
)
as insert into tipo_conductor values(@id, @nombre)


/*UPDATE*/
create proc actualizarTipoConductor
(
	@id int, @nombre varchar(50)
)
as update tipo_conductor set nombre=@nombre where id=@id


/*DELETE*/
create proc eliminarTipoConductor
(
	@id int
)
as delete from tipo_conductor where id=@id



/*TABLA TIPO CONTRATO--------------------------------------------------------------------------*/

create table contrato
(
	id int NOT NULL,
	id_vehiculo int NOT NULL,
	id_tipo_conductor int NOT NULL,
	PRIMARY KEY (id),
	CONSTRAINT FK_contrato_vehiculo FOREIGN KEY (id_vehiculo) REFERENCES vehiculo(id),
	CONSTRAINT FK_contrato_conductor FOREIGN KEY (id_tipo_conductor) REFERENCES tipo_conductor(id)
	ON DELETE CASCADE
    ON UPDATE CASCADE 
)

/*INSERT*/
create proc registrarContrato
(
	@id int, @id_vehiculo int, @id_tipo_conductor int
)
as insert into contrato values(@id, @id_vehiculo, @id_tipo_conductor)


/*UPDATE*/
create proc actualizarContrato
(
	@id int,  @id_vehiculo int, @id_tipo_conductor int
)
as update contrato set id_vehiculo=@id_vehiculo, id_tipo_conductor=@id_tipo_conductor  where id=@id


/*DELETE*/
create proc eliminarContrato
(
	@id int
)
as delete from contrato where id=@id


/*TABLA TIPO RUTA--------------------------------------------------------------------------*/

create table ruta
(
	id int NOT NULL,
	estacion varchar(50),
	id_vehiculo int NOT NULL,
	PRIMARY KEY (id),
	CONSTRAINT FK_ruta_vehiculo FOREIGN KEY (id_vehiculo) REFERENCES vehiculo(id)
	ON DELETE CASCADE
    ON UPDATE CASCADE 
)

/*INSERT*/
create proc registrarRuta
(
	@id int, @estacion varchar(50), @id_vehiculo int
)
as insert into ruta values(@id, @estacion, @id_vehiculo)


/*UPDATE*/
create proc actualizarRuta
(
	@id int,  @estacion varchar(50), @id_vehiculo int
)
as update ruta set estacion=@estacion, id_vehiculo=@id_vehiculo  where id=@id


/*DELETE*/
create proc eliminarRuta
(
	@id int
)
as delete from ruta where id=@id