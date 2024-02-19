Create dataBase Hotel 

use hotel

create table RoomTypes(
Id int Primary Key Identity,
name nvarchar(10)not null unique 
)

create table Rooms (
Id int identity Primary key,
number int not null unique,
RoomType int ,
foreign key (RoomType) references RoomTypes(Id))

create Procedure UpdateRoomTypes @newdata decimal, @Id int 
as
update RoomTypes
set Price=@newdata where Id=@Id

exec UpdateRoomTypes 200,4

Create Table Customers (
Id int primary key identity,
Name nvarchar(20),
PeenCode nvarchar(20) unique not null,

)




select *from RoomTypes


create table Reservation (
id int primary key identity,
CustomersId int not null ,
RoomId int Not null unique,
 StartTime datetime not null,
 endtime datetime not null,
 Payment decimal not null,

 Foreign key (CustomersId) references Customers(Id),
 Foreign Key (RoomId) references Rooms(Id)
)

create table Payment(
Id int Primary Key identity,
ReservationId int not null,
Amount Decimal Not Null,
Paymentdate datetime not null,
Peymentmethod nvarchar (20) Check(Peymentmethod in ('credit card','cash'))

)


CREATE PROCEDURE InsertRoomTypes @name nvarchar(10)
AS
Insert into RoomTypes Values (@name)



exec InsertRoomTypes 'Ecenom'

create view GetRoomTypesID2
as
Select * from RoomTypes where Id>2

Select * from GetRoomTypesID2


CREATE PROCEDURE InsertRoom @number int ,@TypeId int
AS
Insert into Rooms Values (@number,@TypeId)

exec InsertRoom 125,3

create view GetRoom
as
Select RoomTypes.Name,Rooms.number,Rooms.Id from Rooms
join RoomTypes on RoomTypes.Id=Rooms.RoomType

Select * from GetRoom


CREATE PROCEDURE InsertCustomer @name nvarchar(10),@PeenCode nvarchar(20)
AS
Insert into Customers Values (@name,@Peencode)


exec InsertCustomer 'Ilkin','7878hy'

CREATE PROCEDURE InsertReservetion @CId int,@rid int,@sttime datetime,@endtime datetime,@Peyment decimal
AS
Insert into Reservation Values ( @CId ,@rid ,@sttime ,@endtime ,@Peyment)

exec InsertReservetion 2,1,'2024-02-15 12:20','2024-08-28 12:20',700

create view AllCustomersReservations
as
Select c.name ,r.StartTime,r.endtime  from Customers as c
join Reservation as r on r.CustomersId=c.Id

Select * from AllCustomersReservations

CREATE PROCEDURE GetRoomDetails @RoomId int 
AS
Select Rooms.Id,RoomTypes.name, RoomTypes.Price from Rooms
join RoomTypes on RoomTypes.Id=Rooms.RoomType Where Rooms.Id=@RoomId

exec GetRoomDetails 2