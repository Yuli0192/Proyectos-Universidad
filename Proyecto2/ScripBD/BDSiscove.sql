-- Creado por: Argus
-- Fecha Creación: 04/07/11  13:32
-- Modificado por: Emilio Ponce 
-- Fecha Modificación: 28/07/11  11:13 a.m.

USE master 

CREATE DATABASE BDSiscove 
go
USE BDSiscove 
go

CREATE TABLE tdepartamento (
	cod				varchar(50) NOT NULL,
    nombre			varchar(50) NOT NULL,
    estado			Bit NOT NULL,
	CONSTRAINT pk_departamento PRIMARY KEY(cod)
)
GO

CREATE TABLE trol (
	nombre			varchar(50) NOT NULL,
    descripcion     varchar(256) NOT NULL,
    estado			Bit NOT NULL,
	CONSTRAINT pk_rol PRIMARY KEY(nombre)
)
GO

CREATE TABLE tusuario (
	cedula         	varchar(50) NOT NULL,
    nombre        	varchar(50) NOT NULL,
	apellido1	    varchar(50) NOT NULL,
	apellido2		varchar(50) NOT NULL,
	correo			varchar(50) NOT NULL,
	contrasenna		varchar(max) NOT NULL,
	rol				varchar(50) NOT NULL,
	coddepartamento	varchar(50) NOT NULL,
	estado			Bit NOT NULL,
	CONSTRAINT pk_usuario PRIMARY KEY (cedula),
	CONSTRAINT fk_usuario FOREIGN KEY (coddepartamento)REFERENCES tdepartamento(cod),
	CONSTRAINT fk_usuario2 FOREIGN KEY (rol)REFERENCES trol(nombre)
)
GO

CREATE TABLE tpermiso (
	cod				int identity(1,1),
	nombre			varchar(255) NOT NULL,
    descripcion     varchar(255) NOT NULL,
    estado			Bit NOT NULL,
	CONSTRAINT pk_permiso PRIMARY KEY(cod)
)


CREATE TABLE trol_permiso(
	codpermiso		int NOT NULL,
    nombrerol		varchar(50) NOT NULL,
	CONSTRAINT pk_rol_permiso PRIMARY KEY(codpermiso,nombrerol),
	CONSTRAINT fk_rol_permiso FOREIGN KEY (codpermiso)REFERENCES tpermiso(cod),
	CONSTRAINT fk_rol_permiso2 FOREIGN KEY (nombrerol)REFERENCES trol(nombre)
)

CREATE TABLE tservicio(
	cod								varchar(50) NOT NULL,
    nombre							varchar(50) NOT NULL,
	descripcion						varchar(256) NOT NULL,
	precio_colones					decimal(18,3) NOT NULL, 
	precio_dolares					decimal(18,3) NOT NULL,
	porcentcomisionjuniorcolones	decimal(18,3) NOT NULL,
	porcentcomisionjuniordolares	decimal(18,3) NOT NULL,
	porcentcomisionseniorcolones	decimal(18,3) NOT NULL,
	porcentcomisionseniordolares	decimal(18,3) NOT NULL,
	porcentcomisionmastercolones	decimal(18,3) NOT NULL,
	porcentcomisionmasterdolares	decimal(18,3) NOT NULL,
	estado							Bit NOT NULL,
	CONSTRAINT pk_servicio PRIMARY KEY CLUSTERED(cod)
)

CREATE TABLE tusuario_servicio(
	idusuario       varchar(50) NOT NULL,
	codservicio		varchar(50) NOT NULL,
	CONSTRAINT pk_tusuario_servicio PRIMARY KEY(idusuario,codservicio),
	CONSTRAINT fk_tusuario_servicio FOREIGN KEY (idusuario)REFERENCES tusuario(cedula),
	CONSTRAINT fk_tusuario_servicio2 FOREIGN KEY (codservicio)REFERENCES tservicio(cod)
)


CREATE TABLE tplanventa(
	id				varchar(50) NOT NULL,
	descripcion		varchar(256) NOT NULL,
	fechainicio		datetime NOT NULL,
	fechafin		datetime NOT NULL,
	estado			Bit NOT NULL,
	CONSTRAINT pk_tplanventa PRIMARY KEY(id)
)

CREATE TABLE tplanventa_servicio(
	idplan			varchar(50) NOT NULL,
	codservicio		varchar(50) NOT NULL,
	cantplaneada	decimal(18,3) NOT NULL,
	CONSTRAINT pk_tplanventa_servicio PRIMARY KEY(idplan,codservicio),
	CONSTRAINT fk_tplanventa_servicio FOREIGN KEY (idplan)REFERENCES tplanventa(id),
	CONSTRAINT fk_tplanventa_servicio2 FOREIGN KEY (codservicio)REFERENCES tservicio(cod)
)


CREATE TABLE tgrupodeventa(
	cod				varchar(50) NOT NULL,
	descripcion		varchar(256) NOT NULL,
	idencargado		varchar(50) NOT NULL,
	estado			Bit NOT NULL,
	CONSTRAINT pk_tgrupodeventa PRIMARY KEY(cod)

)


CREATE TABLE tgrupo_usuario(
	codgrupo		varchar(50) NOT NULL,
	idusuario		varchar(50) NOT NULL,
	CONSTRAINT pk_tgrupo_usuario PRIMARY KEY CLUSTERED(codgrupo,idusuario),
	CONSTRAINT fk_tgrupo_usuario FOREIGN KEY (codgrupo)REFERENCES tgrupodeventa(cod),
	CONSTRAINT fk_tgrupo_usuario2 FOREIGN KEY (idusuario)REFERENCES tusuario(cedula)
)


CREATE TABLE tgrupo_servicio(
	codgrupo		varchar(50) NOT NULL,
	codservicio		varchar(50) NOT NULL,
	CONSTRAINT pk_tgrupo_servicio PRIMARY KEY CLUSTERED(codgrupo,codservicio),
	CONSTRAINT fk_tgrupo_servicio FOREIGN KEY (codgrupo)REFERENCES tgrupodeventa(cod),
	CONSTRAINT fk_tgrupo_servicio2 FOREIGN KEY (codservicio)REFERENCES tservicio(cod)
)

CREATE TABLE tperiodo_cancelacion(
	cod						varchar(50)NOT NULL,
	periodo					varchar(50)NOT NULL
	CONSTRAINT	pk_tperiodo_cancelacion PRIMARY KEY(cod)
)

CREATE TABLE ttipo_comision(
	cod						varchar(50)NOT NULL,
	nombre					varchar(50)NOT NULL,
	periodocancelacion		varchar(50) NOT NULL,
	fechaaproxcancelacion   datetime,
	fechacalculo			datetime null,	
	CONSTRAINT pk_ttipo_comision PRIMARY KEY(cod),
	CONSTRAINT fk_ttipo_comision FOREIGN KEY(periodocancelacion)REFERENCES tperiodo_cancelacion(cod)
)

CREATE TABLE tcomision(
	codcomision				int identity(1,1) NOT NULL,
	tipocomision			varchar(50) NOT NULL,
	fechaEmision			datetime NOT NULL,
	fechainicial			datetime,
	fechafinal				datetime, 
	fechacancelacion		datetime,
	porcentajecomision		decimal(18,3) NOT NULL,
	montometa				decimal(18,3),
	montoalcanzado			decimal(18,3),
	cantidadmeta			decimal(18,3),
	cantidadalcanzada		decimal(18,3), 
	montoapagar				decimal(18,3),
	estado					varchar(50),-- cancelado, sin calcular, pendiente, no aprobada
	idusuario				varchar(50) NULL,
	idgrupoventa			varchar(50) NULL,
	CONSTRAINT pk_tcomision PRIMARY KEY CLUSTERED(codcomision),
	CONSTRAINT fk_tcomision FOREIGN KEY (idgrupoventa)REFERENCES tgrupodeventa(cod),
	CONSTRAINT fk_tcomision2 FOREIGN KEY (idusuario)REFERENCES tusuario(cedula),
	CONSTRAINT fk_tcomision3 FOREIGN KEY (tipocomision)REFERENCES ttipo_comision(cod)
)



CREATE TABLE tcliente(
	id			varchar(50) NOT NULL,
	nombre		varchar(50) NOT NULL,
	telefono	varchar(50) NOT NULL,
	correo		varchar(50) NOT NULL,
	contacto	varchar(50) NOT NULL,
	direccion	varchar(256) NOT NULL,
	estado		Bit NOT NULL,
	CONSTRAINT pk_tcliente PRIMARY KEY CLUSTERED(id)
)


CREATE TABLE tusuario_cliente(
	idcliente	varchar(50) NOT NULL,
	idusuario	varchar(50)NOT NULL,
	CONSTRAINT pk_tusuario_cliente PRIMARY KEY CLUSTERED(idcliente,idusuario),
	CONSTRAINT fk_tusuario_cliente FOREIGN KEY (idcliente)REFERENCES tcliente(id),
	CONSTRAINT fk_tusuario_cliente2 FOREIGN KEY (idusuario)REFERENCES tusuario(cedula)
)


CREATE TABLE tfactura(
	num					varchar(50) NOT NULL,
	idcliente			varchar(50) NOT NULL,
	idusuario			varchar(50) NOT NULL,
	fechafacturacion	datetime NULL,
	fechacreacion		datetime NOT NULL,
	fechavalidez		datetime NOT NULL,
	moneda				varchar(50) NOT NULL,
	estado				varchar(50) NOT NULL,
	monto				decimal(18,3) NOT NULL,
	tipodecambio		decimal(18,3) NULL,
	CONSTRAINT pk_num PRIMARY KEY CLUSTERED(num),
	CONSTRAINT fk_tfactura FOREIGN KEY (idcliente)REFERENCES tcliente(id),
	CONSTRAINT fk_tfactura2 FOREIGN KEY (idusuario)REFERENCES tusuario(cedula)	
)



CREATE TABLE tlineasfactura(
	numfactura		varchar(50) NOT NULL,
	codservicio		varchar(50) NOT NULL,
	cantidad		int NOT NULL,
	precio			decimal(18,3) NOT NULL,
	CONSTRAINT pk_tlineasfactura PRIMARY KEY CLUSTERED(numfactura,codservicio),
	CONSTRAINT fk_tlineasfactura FOREIGN KEY (numfactura)REFERENCES tfactura(num),
	CONSTRAINT fk_tlineasfactura2 FOREIGN KEY (codservicio)REFERENCES tservicio(cod)	
)


CREATE TABLE tbitacora(
	id				int identity(1,1) NOT NULL,
	idusuario		varchar(50) NOT NULL,
	detalle			varchar(256) NOT NULL,
	fecha			datetime NOT NULL,
	precio			decimal(18,3) NOT NULL,
	CONSTRAINT pk_tbitacora PRIMARY KEY(id)
)
go

--------------------------Registrar Grupo de Ventas----------------------------------
-------------------------------------------------------------------------------------
create procedure proc_registrargrupodeventa(@codigo			varchar(50),
											@descripcion	varchar(50),
											@idencargado	varchar(50))
as
begin
	insert into tgrupodeventa(cod, descripcion, idencargado, estado)
		values(@codigo, @descripcion, @idencargado,1)	
end
go
----------------------------------Buscar Grupo De Venta------------------------------
-------------------------------------------------------------------------------------
create procedure proc_buscargrupodeventa(@cod  varchar(50))
as
begin
	select cod,descripcion,idencargado 
	from tgrupodeventa 
	where (cod = @cod) and estado <> 0
end
go
---------------------------Buscar Grupo De Venta Por Aproximacion-------------------- NUEVO
-------------------------------------------------------------------------------------
create procedure proc_buscargrupodeventaaprox(@cod  varchar(50))
as
begin
	select cod,descripcion,idencargado 
	from tgrupodeventa 
	where cod like @cod +'%' and estado = 1
	order by cod Asc
end
go
-------------------------------Modificar grupo de Venta------------------------------
-------------------------------------------------------------------------------------
create procedure proc_modificargrupodeventa(@codigo			varchar(50),
											@descripcion	varchar(256),
											@idencargado	varchar(50))
as
begin

	update tgrupodeventa 
	set descripcion = @descripcion,
		idencargado = @idencargado
	where cod = @codigo
end
go
----------------------------------Eliminar grupo de venta----------------------------
-------------------------------------------------------------------------------------
create procedure proc_eliminargrupodeventa(@codigo  varchar(50))
as
begin
	update tgrupodeventa 
	set estado = 0
	where cod = @codigo
end
go
------------------------------Agregar Vendedor A Grupo De Venta----------------------
-------------------------------------------------------------------------------------
create procedure proc_agregarvendedoragrupodeventa(@codgrupo	varchar(50),
													@idusuario  varchar(50))
as
begin
	insert into tgrupo_usuario(codgrupo,idusuario)
	values(@codgrupo,@idusuario)
end
go
----------------------------Agregar Servicio A Grupo De Venta------------------------
-------------------------------------------------------------------------------------
create procedure proc_agregarservicioagrupodeventa(@codgrupo		varchar(50),
													@codservicio	varchar(50))
as
begin
	insert into tgrupo_servicio(codgrupo,codservicio)
	values(@codgrupo,@codservicio)
end
go
---------------------------Eliminar Vendedor De grupo de venta-----------------------
-------------------------------------------------------------------------------------
create procedure proc_eliminarvendedordegrupodeventa(@codgrupo		varchar(50),
													@idusuario	varchar(50))
as
begin

	delete from tgrupo_usuario
	where codgrupo = @codgrupo and idusuario = @idusuario
end
go
--------------------------Eliminar Servicio De grupo de venta------------------------
-------------------------------------------------------------------------------------
create procedure proc_eliminarserviciodegrupodeventa(@codgrupo		varchar(50),
													@codservicio	varchar(50))
as
begin

	delete from tgrupo_servicio
	where codgrupo = @codgrupo and codservicio = @codservicio
end
go
---------------------------Buscar Vendedores de Grupo De Ventas----------------------
-------------------------------------------------------------------------------------
create procedure proc_buscarvendedoresdegrupoventas(@codgrupo varchar(50))
as
begin

	select cedula, nombre, apellido1 , apellido2, correo, coddepartamento, contrasenna, rol
	from tusuario as tu join tgrupo_usuario as tg on tu.cedula = tg.idusuario
	where tg.codgrupo = @codgrupo
end
go
---------------------------Buscar Servicios de Grupo De Ventas-----------------------
-------------------------------------------------------------------------------------
create procedure proc_buscarserviciosdegrupoventas(@codgrupo varchar(50))
as
begin

	select cod, nombre, descripcion, precio_colones, precio_dolares, porcentcomisionjuniorcolones, 
			porcentcomisionjuniordolares, porcentcomisionseniorcolones, porcentcomisionseniordolares,
			porcentcomisionmastercolones, porcentcomisionmasterdolares
	from tgrupo_servicio as tg join tservicio as ts on tg.codservicio = ts.cod
	where tg.codgrupo = @codgrupo
end
go
---------------------------Listar Grupo De Ventas------------------------------------ AGREGADO
-------------------------------------------------------------------------------------
create procedure proc_listargrupos
as
begin
	select cod, descripcion, idencargado 
	from tgrupodeventa
	where estado = 1
	order by cod Asc
end 
go
---------------------------------Registrar Factura-----------------------------------
-------------------------------------------------------------------------------------
create procedure proc_registrarfactura(@num					varchar(50),
										@idcliente			varchar(50),
										@idusuario			varchar(50),
										@fechavalidez    	datetime,
										@moneda   			varchar(50))
as
begin
	insert into tfactura(num,idcliente,idusuario,fechafacturacion,fechacreacion,fechavalidez,
						moneda,estado,monto,tipodecambio)
		values(@num, @idcliente, @idusuario, getdate(), getdate(), @fechavalidez,
						@moneda, 'Proforma', 0.0, 0.0)	
end
go
----------------------------------Aprobar Factura------------------------------------
-------------------------------------------------------------------------------------
create procedure proc_aprobarfactura(@num					varchar(50),
									@tipodecambio     	 	decimal(18,3))
as
begin
	update tfactura
	set fechafacturacion = getdate(),
		estado = 'Aprobada',
		tipodecambio = @tipodecambio
	where num = @num
end
go
----------------------------------Invalidar Factura------------------------------------
-------------------------------------------------------------------------------------
create procedure proc_invalidarfactura
as
begin
	
	update tfactura
	set estado = 'Vencida'
	where (convert(varchar,fechavalidez,102) = convert(varchar,getdate(),102)) and estado <> 'Nulo'
end
go
------------------------------------Listar facturas---------------------------------------- AGREGADO
-------------------------------------------------------------------------------------------

create procedure proc_listarfacturas
as
begin
	select *
	from tfactura
	where estado <> 'Nulo' order by num asc
end
go
----------------------------------Eliminar Factura-----------------------------------
-------------------------------------------------------------------------------------
create procedure proc_eliminarfactura(@num	varchar(50))
as
begin
	update tfactura
	set estado = 'Nulo'
	where num = @num
end
go
------------------------------Buscar Facturas Por Cliente----------------------------
-------------------------------------------------------------------------------------
create procedure proc_buscarfacturasporcliente(@idcliente  varchar(50))
as
begin
	select * 
	from tfactura
	where idcliente = @idcliente and estado <> 'Nulo'
end
go
------------------------------------Buscar Factura Por Aprox------------------------- MODIFICADO
-------------------------------------------------------------------------------------
create procedure proc_buscarfacturaaprox(@num  varchar(50))
as
begin
	select * 
	from tfactura
	where num like @num +'%' and estado <> 'Nulo'
	order by num Asc
end
go
------------------------------------Buscar Factura----------------------------------- MODIFICADO
-------------------------------------------------------------------------------------
create procedure proc_buscarfactura(@num  varchar(50))
as
begin
	select * 
	from tfactura
	where (num = @num) and estado <> 'Nulo'
end
go
-----------------------------------Agregar Linea De Detalle--------------------------
------------------------------------------------------------------------------------- MODIFICANDO
create procedure proc_agregarlineadetalle(@num			varchar(50),
										@codservicio	varchar(50),
										@cantidad  		int,
										@precio    		decimal(18,3))
as
declare @monto decimal(18,3),
		@subTotal decimal(18,3)		
			
begin
	insert into tlineasfactura(numfactura, codservicio, cantidad, precio)
		values(@num, @codservicio, @cantidad, @precio)
	
	set @subTotal = (@cantidad*@precio)
	set @monto = (select monto from tfactura where num = @num) + @subTotal
	
	update tfactura
	set monto = @monto
	where num = @num

end
go
-----------------------------------Eliminar Linea De Detalle-------------------------- MODIFICADO
-------------------------------------------------------------------------------------
create procedure proc_eliminarlineadetalle(@num			varchar(50),
										   @codservicio	varchar(50))
as
declare @subTotal decimal(18,3),
		@cantidad int,
		@precio decimal(18,3)

begin

	set @cantidad = (select cantidad 
					from tlineasfactura 
					where numfactura = @num and codservicio = @codservicio)

	set @precio = (select precio 
					from tlineasfactura 
					where numfactura = @num and codservicio = @codservicio)
	
	delete from tlineasfactura 
	where numfactura = @num and codservicio = @codservicio

	set @subTotal = @cantidad*@precio
	
	update tfactura
	set monto = (select monto from tfactura where num = @num) - @subTotal
	where num = @num

end
go
------------------------------------Buscar Detalle-----------------------------------
-------------------------------------------------------------------------------------
create procedure proc_buscardetalle(@num  varchar(50))
as
begin
	select tl.codservicio, ts.nombre, tl.cantidad, tl.precio
	from tlineasfactura as tl join tservicio as ts on tl.codservicio = ts.cod
	where numfactura = @num
end
go
------------------------------------Buscar usuario Por Correo------------------------  MODIFICADO
-------------------------------------------------------------------------------------
create proc proc_buscarusuarioporcorreoycontrasenna (@correo varchar(50), @contrasenna varchar(50))

as begin 
	select *
	from tusuario
	where (correo = @correo) and (contrasenna = @contrasenna)
end
go
------------------------------------Registrar Servicio-------------------------------
-------------------------------------------------------------------------------------
create procedure proc_insertservicio( 
	@cod							varchar(50), 
    @nombre							varchar(50), 
	@descripcion					varchar(256), 
	@precio_colones					decimal(18,3), 
	@precio_dolares					decimal(18,3),
	@porcentcomisionjuniorcolones	decimal(18,3),
	@porcentcomisionjuniordolares	decimal(18,3), 
	@porcentcomisionseniorcolones	decimal(18,3),
	@porcentcomisionseniordolares	decimal(18,3), 
	@porcentcomisionmastercolones	decimal(18,3), 
	@porcentcomisionmasterdolares	decimal(18,3) 
)
as
begin

	insert into tservicio(cod, nombre, descripcion, precio_colones, precio_dolares, porcentcomisionjuniorcolones, porcentcomisionjuniordolares, porcentcomisionseniorcolones, porcentcomisionseniordolares, porcentcomisionmastercolones, porcentcomisionmasterdolares, estado)
		values(@cod, @nombre, @descripcion, @precio_colones, @precio_dolares, @porcentcomisionjuniorcolones, @porcentcomisionjuniordolares, @porcentcomisionseniorcolones, @porcentcomisionseniordolares, @porcentcomisionmastercolones, @porcentcomisionmasterdolares, 1)
end
go

------------------------------------Listar Gerentes y Masters Disponibles-----------------------
-------------------------------------------------------------------------------------
create procedure proc_listarmastersgerentesdisponibles
as
begin
select distinct tu.cedula, tu.nombre, tu.apellido1, tu.apellido2, tu.rol from tusuario as tu
	left join tgrupodeventa as tg on tg.idencargado = tu.cedula
	where tu.rol = 'Gerente Ventas' or (tu.rol = 'Vendedor Master' and (select count(idencargado) from tgrupodeventa where idencargado = tu.cedula) < 2)
end
go
------------------------------------Buscar Servicio Por Nombre-----------------------
-------------------------------------------------------------------------------------
create procedure proc_selectservicionombre( @nombre 	varchar(50))
as
begin
	select *
	from tservicio 
	where nombre = @nombre and estado = 1 order by nombre asc
end
go
-----------------------------Buscar Servicio por id-----------------------------------
--------------------------------------------------------------------------------------
create procedure proc_selectserviciocod(@cod		varchar(50))
as
begin
	select s.cod as 'Codigo',
			s.nombre as 'Nombre',
			s.descripcion as 'Descripción',
			s.precio_colones as 'Precio Colones',
			s.precio_dolares as 'Precio Dolares',
			s.porcentcomisionjuniorcolones as 'Porcentaje Comisión Junior Colones',
			s.porcentcomisionjuniordolares as 'Porcentaje Comisión Junior Dolares',
			s.porcentcomisionseniorcolones as 'Porcentaje Comisión Senior Colones',
			s.porcentcomisionseniordolares as 'Porcentaje Comisión Senior Dolares',
			s.porcentcomisionmastercolones as 'Porcentaje Comisión Master Colones',
			s.porcentcomisionmasterdolares as 'Porcentaje Comisión Master Dolares'
	from tservicio as s
	where cod = @cod and estado = 1
	order by nombre Asc
end
go
------------------------------------Modificar Servicio----------------------------------------
-----------------------------------------------------------------------------------------------
create procedure proc_updateservicio( 
						@cod							varchar(50), 
						@nombre							varchar(50), 
						@descripcion					varchar(256), 
						@precio_colones					decimal(18,3), 
						@precio_dolares					decimal(18,3),
						@porcentcomisionjuniorcolones	decimal(18,3),
						@porcentcomisionjuniordolares	decimal(18,3), 
						@porcentcomisionseniorcolones	decimal(18,3),
						@porcentcomisionseniordolares	decimal(18,3), 
						@porcentcomisionmastercolones	decimal(18,3), 
						@porcentcomisionmasterdolares	decimal(18,3))
as
begin
	update tservicio 
	set nombre = @nombre,
		descripcion = @descripcion,
		precio_colones = @precio_colones,
		precio_dolares = @precio_dolares,
		porcentcomisionjuniorcolones = @porcentcomisionjuniorcolones,
		porcentcomisionjuniordolares = @porcentcomisionjuniordolares, 
		porcentcomisionseniorcolones = @porcentcomisionseniorcolones,
		porcentcomisionseniordolares = @porcentcomisionseniordolares,
		porcentcomisionmastercolones = @porcentcomisionmastercolones, 
		porcentcomisionmasterdolares = @porcentcomisionmasterdolares,	
		estado = 1
	where cod = @cod
end
go
------------------------------------Eliminar Servicio----------------------------------------
---------------------------------------------------------------------------------------------
create procedure proc_deleteservicio( @cod		varchar(50))
as
begin
	update tservicio
	set estado= 0 
	where cod = @cod
end
go
-------------------------------------Listar Servicios----------------------------------
---------------------------------------------------------------------------------------
create procedure proc_listarservicios
as
begin
	select s.cod as 'Codigo',
			s.nombre as 'Nombre',
			s.descripcion as 'Descripción',
			s.precio_colones as 'Precio Colones',
			s.precio_dolares as 'Precio Dolares',
			s.porcentcomisionjuniorcolones as 'Porcentaje Comisión Junior Colones',
			s.porcentcomisionjuniordolares as 'Porcentaje Comisión Junior Dolares',
			s.porcentcomisionseniorcolones as 'Porcentaje Comisión Senior Colones',
			s.porcentcomisionseniordolares as 'Porcentaje Comisión Senior Dolares',
			s.porcentcomisionmastercolones as 'Porcentaje Comisión Master Colones',
			s.porcentcomisionmasterdolares as 'Porcentaje Comisión Master Dolares'
	from tservicio as s
	where estado = 1
	order by nombre Asc
end
go
------------------------------------Buscar Permisos Por Rol--------------------------------
-------------------------------------------------------------------------------------------
create proc proc_buscarpermisosxrol(@nombrerol  varchar(50))
as
begin
	select p.cod, p.nombre, p.descripcion
	from tpermiso as p join trol_permiso as rp on p.cod = rp.codpermiso
	where rp.nombrerol = @nombrerol
end
go
------------------------------------Listar Permisos----------------------------------------
-------------------------------------------------------------------------------------------
create procedure proc_listarpermisos
as
begin
	select *
	from tpermiso
	where estado = 1 order by cod asc
end
go
------------------------------------Registrar usuario----------------------------------------
--------------------------------------------------------------------------------------------
create proc proc_registrarusuario(@cedula         	varchar(50),
							   	  @nombre        	varchar(50),
								  @apellido1	    varchar(50),
								  @apellido2		varchar(50),
								  @correo			varchar(50),
								  @contrasenna		varchar(max),
								  @rol				varchar(50),
								  @coddepartamento	varchar(50))
as begin
	insert into tusuario 
	values(@cedula,@nombre,@apellido1,@apellido2,@correo,@contrasenna,@rol,@coddepartamento,'true')
end  
go
------------------------------------Eliminar usuario----------------------------------------
--------------------------------------------------------------------------------------------
create proc proc_eliminarusuario (@cedula varchar(50))

as begin
	update tusuario
	set estado = 'false'
	where cedula = @cedula 
end
go
------------------------------------Listar usuarios----------------------------------------
-------------------------------------------------------------------------------------------
create proc proc_listarusuarios

as begin 
	select u.cedula,
		   u.nombre,
		   u.apellido1,
		   u.apellido2,
		   u.correo,
		   u.rol,
		   u.coddepartamento,
		   d.nombre
	from tusuario as u join tdepartamento as d on u.coddepartamento = d.cod
	where u.estado = 'true'
	order by u.nombre asc
end
go
------------------------------------Buscar Usuario Por Id---------------------------------
------------------------------------------------------------------------------------------
create proc proc_buscarusuarioid (@cedula varchar(50))

as begin 
	select u.cedula,
		   u.nombre,
		   u.apellido1,
		   u.apellido2,
		   u.correo,
		   u.rol,
		   u.coddepartamento,
		   d.nombre
	from tusuario as u join tdepartamento as d on u.coddepartamento = d.cod
	where u.cedula like @cedula + '%' and u.estado = 'true'
	order by u.cedula asc
end
go
------------------------------------Modificar Usuario-------------------------------------
------------------------------------------------------------------------------------------
create proc proc_modificarusuario(@cedula         	varchar(50),
							   	  @nombre        	varchar(50),
								  @apellido1	    varchar(50),
								  @apellido2		varchar(50),
								  @correo			varchar(50),
								  @rol				varchar(50),								  
								  @coddepartamento	varchar(50))
as begin
	update tusuario
	set cedula = @cedula,
		nombre = @nombre,
		apellido1 = @apellido1,
		apellido2 = @apellido2,
		correo = @correo,
		coddepartamento = @coddepartamento,
		rol = @rol
	where cedula = @cedula
end
go
------------------------------------Modificar Contraseña-------------------------------------
------------------------------------------------------------------------------------------
create proc proc_cambiarcontrasenna(@cedula   varchar(50), @contrasenna	  varchar(max))

as begin
	
	update tusuario
	set contrasenna = @contrasenna
	where cedula = @cedula

end
go
-------------------------Buscar Usuario Por Aproximacion de Nombre------------------------
------------------------------------------------------------------------------------------
create proc proc_buscarusuarioaproxnombre @nombre varchar(50)

as begin 
	select u.cedula,
		   u.nombre,
		   u.apellido1,
		   u.apellido2,
		   u.correo,
		   u.rol,
		   u.coddepartamento,
		   d.nombre
	from tusuario as u join tdepartamento as d on u.coddepartamento = d.cod
	where u.nombre like @nombre + '%' and u.estado = 'true' 
	order by u.nombre asc
end
go
--------------------------------Registrar Plan de Ventas------------------------------
--------------------------------------------------------------------------------------
create procedure proc_insertplanventa(@id				varchar(50),
									  @descripcion		varchar(256),
									  @fechainicio		datetime,
									  @fechafin			datetime)
as
begin

	insert into tplanventa(id, descripcion, fechainicio, fechafin, estado)
		values(@id, @descripcion, @fechainicio, @fechafin, 1)
end
go
----------------------Registrar Servicios del Plan de Ventas -------------------------
--------------------------------------------------------------------------------------
create procedure proc_insertplanservicio(@idplan	  varchar(50),
										 @codservicio   varchar(50),
										 @cantplaneada decimal(18,3))
as
begin

	insert into tplanventa_servicio(idplan, codservicio, cantplaneada)
		values(@idplan, @codservicio, @cantplaneada)
end
go
---------------------------------Buscar Plan de Ventas--------------------------------
--------------------------------------------------------------------------------------
create procedure proc_selectplanventa(@fechainicio   datetime,
										@fechafin	   datetime)
as
begin
	select id as 'Identificación', 
			descripcion as 'Descripción',
			fechainicio as 'Fecha Inicio',
			fechafin as 'Fecha Fin'
	from tplanventa
	where (fechainicio >= @fechainicio) and (fechafin <= @fechafin) and estado = 1 
	order by  descripcion Asc
end
go
-------------------------Buscar Servicios del Plan de Ventas--------------------------
--------------------------------------------------------------------------------------
create procedure proc_selectplanservicio(@idplan   varchar(50))
as
begin
	select s.cod as 'Codigo',
			s.nombre as 'Nombre',
			s.descripcion as 'Descripción',
			s.precio_colones as 'Precio Colones',
			s.precio_dolares as 'Precio Dolares',
			s.porcentcomisionjuniorcolones as 'Porcentaje Comisión Junior Colones',
			s.porcentcomisionjuniordolares as 'Porcentaje Comisión Junior Dolares',
			s.porcentcomisionseniorcolones as 'Porcentaje Comisión Senior Colones',
			s.porcentcomisionseniordolares as 'Porcentaje Comisión Senior Dolares',
			s.porcentcomisionmastercolones as 'Porcentaje Comisión Master Colones',
			s.porcentcomisionmasterdolares as 'Porcentaje Comisión Master Dolares',
			ps.cantplaneada as 'Cantidad Planeada'
	from tplanventa_servicio as ps join tservicio as s on ps.codservicio = s.cod
	where ps.idplan = @idplan
	order by s.nombre Asc
end
go
------------------------Buscar Servicios no están en el plan--------------------------
--------------------------------------------------------------------------------------
create procedure proc_selectserviciosinplan(@idplan  varchar(50))
as
begin
	select s.cod as 'Codigo',
			s.nombre as 'Nombre',
			s.descripcion as 'Descripción',
			s.precio_colones as 'Precio Colones',
			s.precio_dolares as 'Precio Dolares',
			s.porcentcomisionjuniorcolones as 'Porcentaje Comisión Junior Colones',
			s.porcentcomisionjuniordolares as 'Porcentaje Comisión Junior Dolares',
			s.porcentcomisionseniorcolones as 'Porcentaje Comisión Senior Colones',
			s.porcentcomisionseniordolares as 'Porcentaje Comisión Senior Dolares',
			s.porcentcomisionmastercolones as 'Porcentaje Comisión Master Colones',
			s.porcentcomisionmasterdolares as 'Porcentaje Comisión Master Dolares'
	from tservicio as s
	where s.cod not in (select s.cod
						from tplanventa as pv inner join tplanventa_servicio as pvs on pv.id = pvs.idplan
						inner join tservicio as s on pvs.codServicio = s.cod
						where pv.id = @idplan)
	order by  s.nombre Asc
end
go
-----------------------Eliminar Servicio del Plan de Ventas----------------------------
---------------------------------------------------------------------------------------
create procedure proc_deleteplanservicio( 
										@idplan		   varchar(50),
										@codservicio   varchar(50))
as
begin
	delete from tplanventa_servicio 
	where idplan = @idplan and codservicio = @codservicio
end
go
-------------------------------Listar Planes de Ventas---------------------------------
---------------------------------------------------------------------------------------
create procedure proc_listarplanes
as
begin
	select id as 'Identificación', 
			descripcion as 'Descripción',
			fechainicio as 'Fecha Inicio',
			fechafin as 'Fecha Fin'
	from tplanventa
	where estado = 1
	order by descripcion Asc
end
go
------------------------------Eliminar Plan de Ventas----------------------------------
---------------------------------------------------------------------------------------
create procedure proc_deleteplanventa(@idplan  varchar(50))
as
begin
	update tplanventa
	set estado= 0
	where id = @idplan
end
go
-----------------------------------Registrar Cliente----------------------------------
--------------------------------------------------------------------------------------
create procedure proc_insertcliente(@id			varchar(50),
									@nombre		varchar(50),
									@telefono	varchar(50),
									@correo		varchar(50),
									@contacto	varchar(50),
									@direccion	varchar(256))
as
begin

	insert into tcliente(id, nombre, telefono, correo, contacto, direccion, estado)
		values(@id, @nombre, @telefono, @correo, @contacto, @direccion, 1)
end
go
---------------------------Asignar Cliente a Usuario----------------------------------
--------------------------------------------------------------------------------------
create procedure proc_asignarclienteusuario(@idcliente varchar(50), @idusuario varchar(50))
as
begin

	insert into tusuario_cliente(idcliente, idusuario)
		values(@idcliente, @idusuario)
end
go
-------------------------------Buscar Cliente por id----------------------------------
--------------------------------------------------------------------------------------
create procedure proc_selectclienteid(@id	varchar(50))
as
begin
	select id, 
			nombre, 
			telefono, 
			correo, 
			contacto, 
			direccion
	from tcliente 
	where id like @id +'%' and estado = 1
	order by  nombre Asc
end
go
-------------------------------Buscar Cliente por nombre------------------------------
--------------------------------------------------------------------------------------
create procedure proc_selectclientenombre(@nombre	varchar(50))
as
begin
	select id, 
			nombre, 
			telefono, 
			correo, 
			contacto, 
			direccion
	from tcliente 
	where nombre like @nombre +'%' and estado = 1
	order by  nombre Asc
end
go
-------------------------------------Listar Clientes----------------------------------
--------------------------------------------------------------------------------------
create procedure proc_listarclientes
as
begin
	select id, 
			nombre, 
			telefono, 
			correo, 
			contacto, 
			direccion
	from tcliente
	where estado = 1
	order by nombre Asc
end
go
-----------------------------------Modificar Cliente-----------------------------------
---------------------------------------------------------------------------------------
create procedure proc_updatecliente(@id			varchar(50),
									@nombre		varchar(50),
									@telefono	varchar(50),
									@correo		varchar(50),
									@contacto	varchar(50),
									@direccion	varchar(256))
as
begin
	update tcliente 
	set nombre = @nombre,
		telefono = @telefono,
		correo = @correo,
		contacto = @contacto,
		direccion = @direccion,
		estado = 1
	where id = @id
end
go
----------------------------------Eliminar Cliente-------------------------------------
---------------------------------------------------------------------------------------
create procedure proc_deletecliente(@id	varchar(50))
as
begin
	update tcliente
	set estado= 0 
	where id = @id

end
go
----------------------------------Listar Departamento----------------------------------
---------------------------------------------------------------------------------------
CREATE PROCEDURE proc_SelectAllDepartamento      
AS
BEGIN 
      SET NOCOUNT ON 
      SELECT * FROM dbo.tdepartamento 
END
go
-------------------------------------Listar Roles--------------------------------------
---------------------------------------------------------------------------------------
create PROCEDURE proc_SelectAllRol      
AS
BEGIN
	 select distinct nombre, descripcion
	 from trol 
	 where nombre not in (select rol 
						from tusuario 
						where rol not in ('Vendedor Junior', 'Vendedor Senior', 'Vendedor Master'))
END
go
----------------------------------Cancelar Comisión------------------------------------
---------------------------------------------------------------------------------------
create proc proc_cancelarcomision 
as

	declare @fechaProximaCancelacion1 dateTime,		
			@fechaProximaCancelacion2 dateTime,
			@fechaProximaCancelacion3 dateTime,
			@fechaActual dateTime

	set @fechaProximaCancelacion1 = (select fechaaproxcancelacion 
								 from ttipo_comision
								 where cod = '1')

	set @fechaProximaCancelacion2 = (select fechaaproxcancelacion 
								 from ttipo_comision
								 where cod = '2')

	set @fechaProximaCancelacion3 = (select fechaaproxcancelacion 
								 from ttipo_comision
								 where cod = '3')
	
	set @fechaActual = getDate()
begin 

	if (select convert(varchar,@fechaProximaCancelacion1,102)) = (select convert(varchar,@fechaActual,102))
		begin
			update tcomision
			set estado = 'cancelado',
				fechacancelacion = @fechaActual
			where tipocomision = '1' and estado = 'pendiente'
			
			if (select periodocancelacion from ttipo_comision where cod = '1') = '1'
				begin
					update ttipo_comision
					set fechaaproxcancelacion = dateadd(month,1,@fechaProximaCancelacion1)
					where cod = '1'
				end
			if (select periodocancelacion from ttipo_comision where cod = '1') = '2'
				begin
					update ttipo_comision
					set fechaaproxcancelacion = dateadd(month,3,@fechaProximaCancelacion1)
					where cod = '1'
				end
			if (select periodocancelacion from ttipo_comision where cod = '1') = '3'
				begin
					update ttipo_comision
					set fechaaproxcancelacion = dateadd(year,1,@fechaProximaCancelacion1)
					where cod = '1'
				end
		end

	if (select convert(varchar,@fechaProximaCancelacion2,102)) = (select convert(varchar,@fechaActual,102))
		begin		
			update tcomision
			set estado = 'cancelado',
				fechacancelacion = getDate()
			where tipocomision = '2' and estado = 'pendiente'

			if (select periodocancelacion from ttipo_comision where cod = '2') = '1'
				begin
					update ttipo_comision
					set fechaaproxcancelacion = dateadd(month,1,@fechaProximaCancelacion2)
					where cod = '2'
				end
			if (select periodocancelacion from ttipo_comision where cod = '2') = '2'
				begin
					update ttipo_comision
					set fechaaproxcancelacion = dateadd(month,3,@fechaProximaCancelacion2)
					where cod = '2'
				end
			if (select periodocancelacion from ttipo_comision where cod = '2') = '3'
				begin
					update ttipo_comision
					set fechaaproxcancelacion = dateadd(year,1,@fechaProximaCancelacion2)
					where cod = '2'
				end
		end

	if (select convert(varchar,@fechaProximaCancelacion3,102)) = (select convert(varchar,@fechaActual,102))
		begin
			update tcomision
			set estado = 'cancelado',
				fechacancelacion = getDate()
			where tipocomision = '3' and estado = 'pendiente'
			
			update ttipo_comision
			set fechaaproxcancelacion = dateadd(month,1,@fechaProximaCancelacion3)
			where cod = '3'
		end
end
go

-----------------------Calcular Comisión Producto vendido------------------------------
---------------------------------------------------------------------------------------
create procedure proc_calculocomisionproductovendido as

begin
 
SELECT u.rol, s.nombre, comisioncolones =
	 CASE u.rol WHEN 'Vendedor Junior' THEN s.porcentcomisionjuniorcolones 
	WHEN 'Vendedor Senior' THEN s.porcentcomisionseniorcolones 
	ELSE s.porcentcomisionmastercolones END, 
	comisiondolares = CASE u.rol WHEN 'Vendedor Junior' THEN s.porcentcomisionjuniordolares
	WHEN 'Vendedor Senior' THEN s.porcentcomisionseniordolares
	ELSE s.porcentcomisionmasterdolares END
	FROM tlineasfactura l INNER JOIN tservicio s ON l.codservicio = s.cod
	JOIN tfactura f ON l.numfactura = f.num
	JOIN tusuario u ON f.idusuario = u.cedula
	WHERE f.estado = 'Cancelada'

end
go
-----------------------Calcular Comisión Ventas realizadas------------------------------
---------------------------------------------------------------------------------------
create proc proc_calcularcomisionventasrealizadas
as 
	declare @fechaactual dateTime,
			@fechainicio dateTime,
			@totalapagar decimal,
			@totalapagargerenteventas decimal,
			@fechafacturacion dateTime,
			@porccomision decimal,
			@porccomisiongerenteventas decimal,
			@precioserv decimal,
			@idusuario varchar(50),
			@codservicio varchar(50),
			@numfactura varchar(50),
			@moneda varchar(50),
			@rol varchar(50),
			@idgerenteventas varchar (50),
			@cantidadserv int

	set @fechaactual = (select fechacalculo
						from ttipo_comision
						where cod = '3')
	set @fechainicio = dateadd(month,-1,@fechaactual)
	set @idgerenteventas = (select cedula
							 from tusuario
							 where rol = 'Gerente Ventas')
begin 
	if (select convert(varchar,@fechaactual,102)) = (select convert(varchar,getDate(),102))
		begin
		declare _cursorcalculo cursor
		for
			select num,
				   idusuario,
				   fechafacturacion,
				   moneda
			from tfactura
			where estado = 'Aprobada' and fechafacturacion between @fechainicio and @fechaactual

		open _cursorcalculo
		fetch _cursorcalculo into @numfactura,@idusuario,@fechafacturacion,@moneda

		while @@fetch_status = 0	
		begin
			set @rol = (select rol
						from tusuario
						where cedula = @idusuario)
						
			declare _cursor2 cursor
			for
				select codservicio,
					   cantidad,
					   precio
				from tlineasfactura
				where numfactura = @numfactura

			open _cursor2
			fetch _cursor2 into @codservicio,@cantidadserv,@precioserv
			
			while @@fetch_status = 0
			begin
				if @moneda = 'Colones'
				begin
					set @porccomisiongerenteventas = (select porcentcomisionmastercolones
													  from tservicio
													  where cod = @codservicio)
				end

				if @moneda = 'Dolares'
				begin
					set @porccomisiongerenteventas = (select porcentcomisionmasterdolares
													  from tservicio
													  where cod = @codservicio)
				end
				if	@rol = 'Vendedor Junior' and @moneda = 'Colones'
				begin
					set @porccomision = (select porcentcomisionjuniorcolones
										 from tservicio
										 where cod = @codservicio)
				end
				
				if	@rol = 'Vendedor Junior' and @moneda = 'Dolares'
				begin
					set @porccomision = (select porcentcomisionjuniordolares
										 from tservicio
										 where cod = @codservicio)
				end

				if	@rol = 'Vendedor Senior'and @moneda = 'Colones'
				begin
					set @porccomision = (select porcentcomisionseniorcolones
										 from tservicio
										 where cod = @codservicio)
				end

				if	@rol = 'Vendedor Senior'and @moneda = 'Dolares'
				begin
					set @porccomision = (select porcentcomisionseniordolares
										 from tservicio
										 where cod = @codservicio)
				end 

				if	@rol = 'Vendedor Master'and @moneda = 'Colones'
				begin
					set @porccomision = (select porcentcomisionmastercolones
										 from tservicio
										 where cod = @codservicio)
				end

				if	@rol = 'Vendedor Master'and @moneda = 'Dolares'
				begin
					set @porccomision = (select porcentcomisionmasterdolares
										 from tservicio
										 where cod = @codservicio)
				end
				
				set @totalapagar = (@porccomision/100)*(@precioserv*@cantidadserv)
				set @totalapagargerenteventas = (@porccomisiongerenteventas/100) * @totalapagar

				insert into tcomision values ('3',@fechaactual,@fechainicio,@fechaactual,'',@porccomision,0,0,0,0,@totalapagar,'pendiente',@idusuario,null)
				insert into tcomision values ('4',@fechaactual,@fechainicio,@fechaactual,'',@porccomisiongerenteventas,0,0,0,0,@totalapagargerenteventas,'pendiente',@idgerenteventas,null)
				
				fetch _cursor2 into @codservicio,@cantidadserv,@precioserv
			end
			close _cursor2
			deallocate _cursor2
			
			fetch _cursorcalculo into @numfactura,@idusuario,@fechafacturacion,@moneda
		end

		close _cursorcalculo
		deallocate _cursorcalculo

		update ttipo_comision
		set fechacalculo = dateadd(month,1,@fechaactual)
		where cod = '3'	
	end
end
go
-----------------------------Datos Comisión Calculada----------------------------------
---------------------------------------------------------------------------------------
create proc proc_extraerDatosComisionCalculada
as
begin
	select c.porcentajecomision,
		   c.montoapagar,
		   u.nombre,
		   u.apellido1,
		   u.apellido2,
		   u.correo
	from tcomision as c join tusuario as u on c.idusuario = u.cedula
	where (select convert(varchar,fechaemision,102)) = (select convert(varchar,getDate(),102)) and c.tipocomision = '3' or c.tipocomision = '4' 
end
go
------------------------------------Listar vendedores----------------------------------------
-------------------------------------------------------------------------------------------
create proc proc_listarvendedores

as begin 
	select*
	from tusuario
	where estado = 1 and rol = 'Vendedor Junior' or rol = 'Vendedor Senior' or rol = 'Vendedor Master' or rol = 'Gerente Ventas'
	order by nombre asc
end
go
-----------------Buscar Facturas de un grupo de Ventas Por Fechas--------------------
-------------------------------------------------------------------------------------
create procedure proc_buscarfacturasgrupoventasporfechas(@codgrupo	 varchar(50),
														 @fechainicio datetime,
												         @fechafin    datetime)
as
begin
	
select f.num,
		min(f.idcliente),
		min(f.idusuario),
		min(f.fechafacturacion),
		min(f.fechacreacion),
		min(f.fechavalidez),
		min(f.moneda),
		min(f.estado),
		min(f.monto),
		min(f.tipodecambio) 
	from tfactura as f inner join tlineasfactura as lf on f.num = lf.numfactura inner join 
		 tgrupo_servicio as gs on lf.codservicio = gs.codservicio inner join tgrupo_usuario as gu
		 on gs.codgrupo = gu.codgrupo
	where f.idusuario in (select f.idusuario 
								from tfactura as f inner join tgrupo_usuario as gu on f.idusuario = gu.idusuario inner join
								tgrupodeventa as gv on gu.codgrupo = gv.cod inner join tgrupo_servicio as gs on gv.cod = gs.codgrupo
								inner join tlineasfactura as lf on gs.codservicio = lf.codservicio
								where gu.codgrupo= @codgrupo and f.fechafacturacion between @fechainicio and @fechafin and f.estado = 'Aprobada')
group by f.num

end
go
------------------------------Buscar Facturas Por Fechas----------------------------
-------------------------------------------------------------------------------------
create procedure proc_buscarfacturasporfechas(@idusuario	 varchar(50),
												@fechainicio datetime,
												@fechafin    datetime)
as
begin
	select *
	from tfactura
	where idusuario= @idusuario and fechafacturacion between @fechainicio and @fechafin and estado = 'Aprobada'
end
go
------------------------- 1 - Listar Comisiones de un Vendedor----------------------------
-------------------------------------------------------------------------------------
create procedure proc_listarcomisionesporvendedor(@idusuario	 varchar(50),
												@fechainicio datetime,
												@fechafin    datetime)
as
begin
	select c.codcomision,
			tc.nombre,
		    c.fechaemision,
			c.fechainicial,
			c.fechafinal,
			c.fechacancelacion,
			c.porcentajecomision,
			c.montometa,
			c.montoalcanzado,
			c.cantidadmeta,
			c.cantidadalcanzada,
			c.montoapagar,
			c.estado,
			c.idusuario,
			c.idgrupoventa,
			tc.periodocancelacion
	from tcomision as c inner join ttipo_comision as tc on c.tipocomision = tc.cod
	where c.idusuario= @idusuario and c.fechacancelacion between @fechainicio and @fechafin and c.estado = 'cancelado'
end
go
----------------------Listar Total Comisiones Por Periodo----------------------------
-------------------------------------------------------------------------------------
create procedure proc_listartotalcomisionesporperiodo(@fechainicio datetime, @fechafin    datetime)
as
begin
	select u.nombre, u.apellido1, u.apellido2, tc.nombre as 'Tipo Comisión', c.fechacancelacion, c.montoapagar  
	from ttipo_comision as tc inner join tcomision as c on tc.cod = c.tipocomision inner join tusuario as u on c.idusuario = u.cedula
	where c.fechacancelacion between @fechainicio and @fechafin and c.estado = 'cancelado'
	order by u.nombre Asc, c.fechacancelacion Asc
end
go
----------------Listar Total Comisiones Por Periodo PorVendedor----------------------
-------------------------------------------------------------------------------------
create procedure proc_listartotalcomisionesporperiodoporvendedor(@idusuario	 varchar(50),
																	@fechainicio datetime,
																	@fechafin    datetime)
as
begin
	select u.nombre, u.apellido1, u.apellido2, tc.nombre as 'Tipo Comisión', c.fechacancelacion, c.montoapagar 
	from ttipo_comision as tc inner join tcomision as c on tc.cod = c.tipocomision inner join tusuario as u on c.idusuario = u.cedula
	where c.idusuario= @idusuario and fechacancelacion between @fechainicio and @fechafin and c.estado = 'cancelado'
end
go

------------------------Buscar Servicios no están en el Grupo--------------------------
--------------------------------------------------------------------------------------
create procedure proc_buscarserviciosdispparagrupo(@codgrupo  varchar(50))
as
begin
	select s.cod as 'Codigo',
			s.nombre as 'Nombre',
			s.descripcion as 'Descripción',
			s.precio_colones as 'Precio Colones',
			s.precio_dolares as 'Precio Dolares',
			s.porcentcomisionjuniorcolones as 'Porcentaje Comisión Junior Colones',
			s.porcentcomisionjuniordolares as 'Porcentaje Comisión Junior Dolares',
			s.porcentcomisionseniorcolones as 'Porcentaje Comisión Senior Colones',
			s.porcentcomisionseniordolares as 'Porcentaje Comisión Senior Dolares',
			s.porcentcomisionmastercolones as 'Porcentaje Comisión Master Colones',
			s.porcentcomisionmasterdolares as 'Porcentaje Comisión Master Dolares'
	from tservicio as s
	where s.cod not in (select s.cod
						from tgrupodeventa as gv inner join tgrupo_servicio as gs on gv.cod = gs.codgrupo
						inner join tservicio as s on gs.codservicio = s.cod
						where gv.cod = @codgrupo)
	order by  s.nombre Asc
end
go

------------------------Buscar Vendedores no están en el Grupo--------------------------
--------------------------------------------------------------------------------------
create procedure proc_buscarvendedoresdispparagrupo(@codgrupo  varchar(50))
as
begin
	select u.cedula,
		   u.nombre,
		   u.apellido1,
		   u.apellido2,
		   u.correo,
		   u.rol,
		   u.coddepartamento
	from tusuario  u
	where u.cedula not in (select u.cedula
						from tgrupodeventa  gv inner join tgrupo_usuario as gu on gv.cod = gu.codgrupo
						inner join tusuario u on gu.idusuario = u.cedula
						where gv.cod = @codgrupo)
	order by  u.nombre Asc
end
go
