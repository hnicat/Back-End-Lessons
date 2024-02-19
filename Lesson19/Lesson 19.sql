Create DataBase Lesson19
use Lesson19

create table Customers(
Id int primary key identity,
Name nvarchar(20) not null,
Surname nvarchar (20),
Gender nvarchar(10) check (Gender in ('Male','Female')),
Email nvarchar(60) check (Email like '%@gmail.com')
)
Select * from Customers
INSERT INTO Customers (Name, Surname, Gender, Email)
VALUES 
    ('John', 'Doe', 'Male', 'john.doe@gmail.com'),
    ('Alice', 'Smith', 'Female', 'alice.smith@gmail.com'),
    ('Michael', 'Johnson', 'Male', 'michael.johnson@gmail.com'),
    ('Emily', 'Brown', 'Female', 'emily.brown@gmail.com'),
    ('James', 'Wilson', 'Male', 'james.wilson@gmail.com'),
    ('Olivia', 'Taylor', 'Female', 'olivia.taylor@gmail.com'),
    ('Robert', 'Martinez', 'Male', 'robert.martinez@gmail.com'),
    ('Sophia', 'Anderson', 'Female', 'sophia.anderson@gmail.com'),
    ('William', 'Thomas', 'Male', 'william.thomas@gmail.com'),
    ('Isabella', 'Hernandez', 'Female', 'isabella.hernandez@gmail.com'),
    ('Alexander', 'Nelson', 'Male', 'alexander.nelson@gmail.com'),
    ('Emma', 'Walker', 'Female', 'emma.walker@gmail.com'),
    ('David', 'King', 'Male', 'david.king@gmail.com'),
    ('Charlotte', 'Green', 'Female', 'charlotte.green@gmail.com'),
    ('Daniel', 'Evans', 'Male', 'daniel.evans@gmail.com'),
    ('Amelia', 'White', 'Female', 'amelia.white@gmail.com'),
    ('Matthew', 'Scott', 'Male', 'matthew.scott@gmail.com'),
    ('Mia', 'Hill', 'Female', 'mia.hill@gmail.com'),
    ('Joseph', 'Adams', 'Male', 'joseph.adams@gmail.com'),
    ('Ava', 'Baker', 'Female', 'ava.baker@gmail.com'),
    ('Andrew', 'Carter', 'Male', 'andrew.carter@gmail.com'),
    ('Ella', 'Morris', 'Female', 'ella.morris@gmail.com'),
    ('Christopher', 'Wood', 'Male', 'christopher.wood@gmail.com'),
    ('Grace', 'Russell', 'Female', 'grace.russell@gmail.com'),
    ('Ryan', 'Ross', 'Male', 'ryan.ross@gmail.com'),
    ('Chloe', 'Watson', 'Female', 'chloe.watson@gmail.com'),
    ('Nicholas', 'Price', 'Male', 'nicholas.price@gmail.com'),
    ('Lily', 'Bailey', 'Female', 'lily.bailey@gmail.com'),
    ('Tyler', 'Cooper', 'Male', 'tyler.cooper@gmail.com'),
    ('Hannah', 'Reed', 'Female', 'hannah.reed@gmail.com'),
    ('Brandon', 'Bennett', 'Male', 'brandon.bennett@gmail.com'),
    ('Zoe', 'Gray', 'Female', 'zoe.gray@gmail.com'),
    ('Justin', 'James', 'Male', 'justin.james@gmail.com'),
    ('Natalie', 'Kelly', 'Female', 'natalie.kelly@gmail.com'),
    ('Samuel', 'Parker', 'Male', 'samuel.parker@gmail.com'),
    ('Madison', 'Hughes', 'Female', 'madison.hughes@gmail.com'),
    ('Christian', 'Cruz', 'Male', 'christian.cruz@gmail.com'),
    ('Avery', 'Foster', 'Female', 'avery.foster@gmail.com'),
    ('Logan', 'Gonzalez', 'Male', 'logan.gonzalez@gmail.com');

	create table Catalogs(
	Id int primary key identity,
	Name nvarchar(50)
	)
insert into Catalogs (Name)values
('Elektronika'),
('Ayaqqab?lar'),
('Geyim'),
('Avtomobil Aksesuarlar?'),
('M?tb?x avadanl?qlar?'),
('Ev aksesuarlar?'),
('Kitablar'),
('Musiqi aletl?ri'),
('M?i??t texnikas?'),
('?yl?nc? m?hsullar?'),
('Qab-qacaq m?hsullar?'),
('Kompüter v? aksesuarlar'),
('M?kt?b v? ofis mal?'),
('M?i??t kimy?viyyat?'),
('Yataq ota?? aksesuarlar?'),
('?dman v? rekreasiya'),
('Sa?laml?q v? göz?llik'),
('H?diyy?l?r'),
('M?i??t elektronikas?'),
('Qrafika v? çapda? keyfiyy?t');


create table Product (
Id int Primary Key identity,
Name nvarchar(60),
[Count] int,
Price decimal,
CatalogId int,
foreign key (CatalogId) references Catalogs(Id)
)

select * from Catalogs

insert into Product ([Name],[Count],Price,CatalogId) Values
('Smartphone X', 100, 799.99, 1),
('Smart TV', 50, 1299.99, 1),
('Laptop Pro', 75, 1499.99, 1),
('Running Shoes', 200, 99.99, 2),
('Formal Shoes', 150, 129.99, 2),
('Dress Shirt', 300, 49.99, 3),
('Jeans', 200, 39.99, 3),
('Car Cleaning Kit', 100, 29.99, 4),
('Dashboard Camera', 50, 199.99, 4),
('Toaster Oven', 150, 79.99, 5),
('Blender', 100, 59.99, 5),
('Throw Pillows', 250, 19.99, 6),
('Wall Clock', 200, 29.99, 6),
('Bestseller Novel', 500, 14.99, 7),
('Cookbook', 300, 24.99, 7),
('Acoustic Guitar', 50, 299.99, 8),
('Drum Set', 25, 499.99, 8),
('Refrigerator', 50, 999.99, 9),
('Washing Machine', 30, 899.99, 9),
('Board Game', 100, 34.99, 10),
('Playing Cards', 500, 4.99, 10),
('Coffee Mug Set', 200, 19.99, 11),
('Cutlery Set', 150, 29.99, 11),
('Wireless Mouse', 300, 19.99, 12),
('Mechanical Keyboard', 200, 89.99, 12),
('Pencil Set', 500, 9.99, 13),
('Printer Paper Pack', 1000, 14.99, 13),
('Laundry Detergent', 400, 9.99, 14),
('Dish Soap', 300, 4.99, 14),
('Bed Sheet Set', 200, 39.99, 15),
('Pillowcases', 250, 14.99, 15),
('Yoga Mat', 100, 19.99, 16),
('Resistance Bands', 200, 24.99, 16),
('Facial Cleanser', 300, 9.99, 17),
('Moisturizer', 250, 14.99, 17),
('Scented Candles', 200, 7.99, 18),
('Gift Basket', 100, 49.99, 18),
('Smart Thermostat', 50, 129.99, 19),
('Air Purifier', 30, 199.99, 19),
('LED Desk Lamp', 150, 39.99, 20),
('Bluetooth Speaker', 200, 59.99, 20),
('Hair Dryer', 100, 29.99, 20),
('Curling Iron', 75, 34.99, 12),
('Fitness Tracker', 200, 69.99, 16),
('Water Bottle', 500, 9.99, 11),
('Sunscreen', 150, 14.99, 12),
('Shampoo', 200, 7.99, 17),
('Cooking Pot Set', 100, 49.99, 11),
('Non-Stick Pan', 150, 29.99, 19),
('Portable Charger', 300, 19.99, 12),
('Phone Case', 500, 9.99, 12);




Create table Orders(
ProductId int ,
CustomersId int ,
Foreign Key (ProductId)references Product(Id),
Foreign Key (CustomersId)references Customers(Id)
)
insert into Orders(ProductId,CustomersId)Values
(1, 1),
(2, 1),
(3, 2),
(4, 3),
(5, 4),
(6, 5),
(7, 6),
(8, 7),
(9, 8),
(10, 8),
(10,4);
select * from Customers
select * from Orders
Select * from Product

--Select C.Name+' '+C.Surname as'FullName', C.Gender as 'Gender', P.Name as 'Product Name',P.CatalogId from Orders as o
--left join Customers as c on c.Id=o.CustomersId
--left join Product as P on P.Id=o.ProductId

Select C.Name+' '+C.Surname as'FullName',C.Gender as 'Gender',P.name as 'Product Name' from Orders as o
right join Customers  as C  on C.Id=o.CustomersId
Left Join Product as P on p.Id=o.ProductId


insert into Orders  (ProductId,CustomersId) Values 
(12,Null)
------Task2---------
Create Table Teknisyen(
Id int Primary Key Identity,
Name nvarchar(50),
Mobile int Unique,
Email nvarchar(50) check (Email like ('%gmail.com'))
)
create table Product2(
Id int primary key Identity,
Name nvarchar(50),
[Count] int, 
Price int,
TeknisyenId int not null,
foreign key (TeknisyenId)references Teknisyen(Id)
)
INSERT INTO Teknisyen (Name, Mobile, Email)
VALUES 
  ('John Doe', 123456789, 'john.doe@gmail.com'),
  ('Jane Smith', 987654321, 'jane.smith@gmail.com'),
  ('David Wilson', 555111222, 'david.wilson@gmail.com'),
  ('Emily Johnson', 999888777, 'emily.johnson@gmail.com'),
  ('Michael Brown', 444555666, 'michael.brown@gmail.com'),
  ('Jennifer Martinez', 777888999, 'jennifer.martinez@gmail.com'),
  ('Chris Taylor', 111222333, 'chris.taylor@gmail.com'),
  ('Amanda Clark', 666777888, 'amanda.clark@gmail.com'),
  ('Kevin Rodriguez', 222333444, 'kevin.rodriguez@gmail.com'),
  ('Jessica Lee', 888999111, 'jessica.lee@gmail.com');

  INSERT INTO Product2 (Name, [Count], Price, TeknisyenId)
VALUES 
  ('Laptop', 100, 50, 1),
  ('Smartphone', 150, 75, 2),
  ('Tablet', 200, 100, 3),
  ('Printer', 120, 60, 4),
  ('Keyboard', 80, 40, 5),
  ('Mouse', 90, 45, 6),
  ('Headphones', 110, 55, 7),
  ('Monitor', 130, 65, 8),
  ('Camera', 140, 70, 9),
  ('Speaker', 160, 80, 10),
  ('Microphone', 170, 85, 1),
  ('Scanner', 180, 90, 2),
  ('Projector', 190, 95, 3),
  ('Router', 210, 105, 4),
  ('Modem', 220, 110, 5),
  ('Switch', 230, 115, 6),
  ('Server', 240, 120, 7),
  ('Firewall', 250, 125, 8),
  ('UPS', 260, 130, 9),
  ('Storage', 270, 135, 10);


  Select * from Teknisyen
  select * from Product2
  Select T.Name,T.Mobile,T.Email,Pr.Name,Pr.[Count],Pr.Price from Product2 as Pr
  inner join  Teknisyen as T on T.Id=Pr.TeknisyenId

  ------Task3--------
Create Table Menecer(
Id int Primary Key identity,
Name Nvarchar(20),
Mobile int unique,
Duty nvarchar(50) unique
)
;


INSERT INTO Menecer (Name, Mobile, Duty) VALUES
('Ali', 1890, 'HR Manager'),
('Ayşe', 987210, 'Finance Manager'),
('Mehmet', 55967, 'Operations Manager'),
('Fatma', 97776, 'Marketing Manager'),
('Hüseyin', 13334, 'Sales Manager'),
('Zeynep', 46667, 'IT Manager'),
('Mustafa', 777891, 'Project Manager'),
('Emine', 0993183, 'Customer Service Manager'),
('Ahmet', 0709138, 'Production Manager'),
('Şirin', 05557066, 'Quality Assurance Manager');


Create Table Employe(
Id int primary key identity,
Name nvarchar(20),
Surname nvarchar(30),
Mobile int unique,
Duty nvarchar(25),
MenecerId Int,
foreign key (MenecerId) references Menecer(Id)

)
select * from Menecer

Insert Into Employe(Name,Surname,Mobile,Duty,MenecerId) Values 
('Nicat','Heyderzade',05555,'Back-End Developer',6),
('Amin', 'Ahmadov', 17890, 'HR Specialist', 1),
('Fatime', 'Əliyeva', 943210, 'Finance Analyst', 2),
('Mehmet', 'Mehmetov', 554567, 'Operations Coordinator', 3),
('Aygun', 'Əliyeva', 9997776, 'Marketing Assistant', 4),
('Hüseyin', 'Hüseynov', 123334, 'Sales Representative', 5),
('Ahmet', 'Babayev' ,0709200320,'Production Manager',null)


Select * from Employe


Select E.Name+' '+E.Surname as 'Full Name',E.Mobile,E.Duty,M.Name As 'Menecer Name'from Employe as E
Full join Menecer as M on M.Id=E.MenecerId


---Task4---


create table  customer4(
Id int primary key identity ,
Name nvarchar(50),
Mobil int unique,
Gender nvarchar(10) Check (Gender in ('Female','Male'))

)
Insert into customer4(Name,Mobil,Gender) Values 
('Bob Brown', 7856, 'Male'),
  ('Emily Davis', 34987, 'Female'),
  ('Michael Wilson', 58321, 'Male'),
  ('Olivia Taylor', 93654, 'Female'),
  ('William Martinez', 53486, 'Male'),
  ('Sophia Anderson', 39846, 'Female'),
  ('James Thomas', 85971, 'Male'),
  ('Charlotte White', 968147, 'Female'),
  ('Daniel Jackson', 74963, 'Male'),
  ('Amelia Harris', 25147, 'Female'),
  ('Benjamin Clark', 1569, 'Male'),
  ('Ella Lewis', 37258, 'Female');


  create table Product4(
  Id int Primary Key Identity,
  Name nvarchar(50),
  Price decimal ,
  [Count] int 
  )

  create table Orders2(
  customer4Id int ,
  Product4Id int,
  Date datetime,
  Foreign key (customer4Id) references customer4(Id),
  Foreign key (Product4Id ) references Product4(Id)
  )

  insert into Product4(Name,[Count],Price) Values
  ('Laptop', 100, 50),
  ('Smartphone', 150, 75),
  ('Tablet', 200, 100),
  ('Printer', 120, 60),
  ('Keyboard', 80, 40),
  ('Mouse', 90, 45),
  ('Headphones', 110, 55),
  ('Monitor', 130, 65),
  ('Camera', 140, 70),
  ('Speaker', 160, 80),
  ('Microphone', 170, 85)


  INSERT INTO Orders2 (customer4Id, Product4Id, Date)
VALUES
    (1, 5, '2024-02-19 10:30:00'),
    (2, 8, '2024-02-18 09:45:00'),
    (3, 2, '2024-02-17 14:20:00'),
    (4, 7, '2024-02-16 16:55:00'),
    (5, 1, '2024-02-15 11:10:00'),
    (6, 4, '2024-02-14 08:25:00'),
    (7, 9, '2024-02-13 13:40:00'),
    (8, 3, '2024-02-12 15:15:00'),
    (9, 6, '2024-02-11 12:30:00'),
    (10, 10, '2024-02-10 07:45:00');


	Select customer4.Name,Product4.Name,Orders2.Date from Orders2
	join customer4 on customer4.Id=Orders2.customer4Id
	join Product4 on Product4.Id=Orders2.Product4Id
 
  --- Task 5 

  create table Atable (
  id int primary key identity,
  Name nvarchar(20),
  Surname nvarchar(21),
  Age int 
  
  )

  insert into Atable(Name,Surname,Age) Values 
  ('Nicat','Heyderzade',21),
  ('Amin ','Memmedov',17),
  ('Sahin','Memmedov',18),
  ('Ferid','Nabiyev',21),
  ('Celil','Celili',45)

  create table Btable (
  id int primary key identity,
  Name nvarchar(20),
  Surname nvarchar(21),
  Age int
  )

  insert into Btable(Name,Surname,Age) Values
  ('Nicat','Heyderzade',21),
  ('Amin','Memmedov',17),
  ('Sahin','Memmedov',18),
  ('Nayib','Muradov',23),
  ('Salim','Babayev',21)

  Select A.Name from Atable A
  left join Btable b on b.Age=a.Age
  
   Select B.Name from Atable A
 right join Btable b on b.Age=a.Age
 ----6 task

 create table  customer5(
Id int primary key identity ,
Name nvarchar(50),
Mobil int unique,
Gender nvarchar(10) Check (Gender in ('Female','Male')))

 Insert into customer5(Name,Mobil,Gender) Values 
('Bob Brown', 7856, 'Male'),
  ('Emily Davis', 34987, 'Female'),
  ('Michael Wilson', 58321, 'Male'),
  ('Olivia Taylor', 93654, 'Female'),
  ('William Martinez', 53486, 'Male'),
  ('Sophia Anderson', 39846, 'Female'),
  ('James Thomas', 85971, 'Male'),
  ('Charlotte White', 968147, 'Female'),
  ('Daniel Jackson', 74963, 'Male'),
  ('Amelia Harris', 25147, 'Female'),
  ('Benjamin Clark', 1569, 'Male'),
  ('Ella Lewis', 37258, 'Female');

    create table Product5(
  Id int Primary Key Identity,
  Name nvarchar(50),
  Price decimal ,
  [Count] int 
  )

  insert into Product5(Name,[Count],Price) Values
  ('Laptop', 100, 50),
  ('Smartphone', 150, 75),
  ('Tablet', 200, 100),
  ('Printer', 120, 60),
  ('Keyboard', 80, 40),
  ('Mouse', 90, 45),
  ('Headphones', 110, 55),
  ('Monitor', 130, 65),
  ('Camera', 140, 70),
  ('Speaker', 160, 80),
  ('Microphone', 170, 85)

    create table Orders3(
  customer5Id int ,
  Product5Id int,
  Date datetime,
  Querty int ,
  Foreign key (customer5Id) references customer5(Id),
  Foreign key (Product5Id ) references Product5(Id)
  )

  
  insert into Orders3(customer5Id,Product5Id,Querty) values
  (1,4,3),
  (1,5,4),
  (3,5,6),
  (2,7,55),
  (2,6,22),
  (null,4,11),
  (null,2,43),
  (null, 5,55),
  (7,Null,3),
  (3,Null,22)


  Select customer5.Name,Product5.Name 'Product Name',Orders3.Querty  from Orders3 
  full join customer5 on customer5.Id=Orders3.customer5Id
  full join Product5 on Product5.Id=Orders3.Product5Id

  -- task 7 

  create table Course(
  Id int  primary key identity,
  Name nvarchar(50) unique,
  Price Decimal,
  Studentsid int unique ,
  foreign key (Studentsid) references Students(Id)
  )


  insert into Course(Name,Price,Studentsid) Values 
  ('Inglis-Dili',150,2),
  ('Proqramlasdirma',550,4),
  ('Riyaziyyat',200,3),
  ('Fizika',390,1),
  ('Biologiya',300,5)

  create table Students(
  Id int primary key identity ,
  Name nvarchar(20),
  Surname nvarchar(25),
  Age int ,
  )
  insert into Students (Name,Surname,Age)
  Values
  ('Nicat','Heyderzade',20),
 ('Amin','Memmedov',23),
 ('Sahin','Memmedov',22),
 ('Immamyar','Ceferov',25),
 ('Sedyar','Lutfizade',24),
 ('Sabir','Musayev',32),
 ('Elsen','Babayev',33)

 Select Students.Name+ Students.Surname As 'FullName',Course.Name from Students
 left Join Course on Course.Studentsid=Students.Id


