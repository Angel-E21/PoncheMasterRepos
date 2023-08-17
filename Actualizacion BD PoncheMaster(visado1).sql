create database PoncheMaster --creamos la base de datos

use PoncheMaster --Cambia la base de datos que esta en uso para usar la que creamos y no la master


--creacion de Tabla de Tipo de Usuario
create table UserType(
IDUserType int identity Constraint PK_IDUserType Primary key, --recuerda que Identity es para que se auto inserte y que no lo inserte el usuario
UserType varchar(50) not null --el Not Null Se usa para que no se poueda dejar vacio OJO un espacio vacio no es igual a null
);
--creacion de Posicion de Empleado
Create Table EmployeePosition(
IDPosition int identity Constraint PK_IDEmpPosition Primary key, 
Position Varchar(50)
);

--creacion deTabla de usuario
Create table UserTable(
IDUser int identity Constraint PK_IDUserTable Primary key, 
Username varchar(50) not null,
UserPassword varchar(50) not null,
IDUserType int constraint FK_IDUSerType foreign Key References UserType(IDUserType) --dato Los Constraints funcional como "not null" 
);
--creacion de tabla de Departamentos
Create Table Departamento(
IDDept int identity Constraint PK_IDDept Primary key,
Nombre Varchar(50)not null
);
--creacion de tabla de Empleados
create Table Employee(
IDEmployee int identity Constraint PK_IDEmployee Primary key,
EmployeeName Varchar(50)not null,
EmployeeLastName Varchar(50) not null,
BirthDate date, --el tipo date es para fechas y si le añades el sufijo time tambien coge fecha
Cedula Varchar(13) Constraint UK_CedulaEmployee Unique,
IDUser int constraint FK_IDUser foreign Key References UserTable(IDUser),
IDDept int constraint FK_IDDept foreign Key References Departamento(IDDept),
IDPosition int constraint FK_IDEmpPosition foreign Key References EmployeePosition(IDPosition),
);
--creacion de tabla de Ponches
Create Table PoncheTable(
IDPonche Int identity Constraint PK_IDPonche Primary key, 
IDEmployee int constraint FK_IDEmployee foreign Key References Employee(IDEmployee), 
In_or_Out bit not null, --el tipo bit es lo mismo que el booleano pero en vez de V o F es 1 o 0
PoncheDate datetime
);


insert into UserType(UserType) values ('Admin')
insert into UserType(UserType) values ('Employee')


insert into UserTable(IDUserType,Username,UserPassword) Values (1,'Admin', '1234')
insert into UserTable(IDUserType,Username,UserPassword) Values (2,'Employee1', '567')
insert into UserTable(IDUserType,Username,UserPassword) Values (2,'Employee2', '890')

insert into Employee(EmployeeName,EmployeeLastName,Cedula,IDUser,BirthDate) Values ('Pepe', 'Sosa', '023-0015151-1', 2, '01-02-1999')
insert into Employee(EmployeeName,EmployeeLastName,Cedula,IDUser,BirthDate) Values ('Carla', 'Mejia', '023-0026262-2', 3, '11-12-1995')


select * from EmployeePosition





