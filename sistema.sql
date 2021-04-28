Create Database BD_Control
go

Use BD_Control
go

Create Table Cargos (
IdCargo int identity(1,1) primary key,
DescripcionCargo varchar(50))
go

Create Proc Listar_Cargos
as
Select * From Cargos
go

Create Proc Registrar_Cargos
@DescripcionCargo varchar(50)
as
Insert Into Cargos(DescripcionCargo) Values (@DescripcionCargo)
go

Create Procedure Modificar_Cargos
@IdCargo int,
@DescripcionCargo varchar(50)
as
	Update Cargos Set 
	DescripcionCargo = @DescripcionCargo
	Where IdCargo = @IdCargo
go
	
Create Procedure Eliminar_Cargos
@IdCargo int
as
	Delete From Cargos
	Where IdCargo = @IdCargo
go



