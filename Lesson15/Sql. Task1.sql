create database COMPANY--DataBase Yaratmaq

use COMPANY-- Data Base Cagirmaq 


create table Customers(  -- Table Yaratmaq
Id int primary key identity,
[Name] nvarchar(30),
Surname nvarchar(50),
Salary decimal 
)                     


Insert Into Customers([Name],Surname,Salary)values-- Tablenin Daxiline Deyerler Girmek
('John', 'Doe', 1500.50),
('Jane', 'Smith', 2000.75),
('Alice', 'Johnson', 1800.60),
('Bob', 'Williams', 2500.80),
('Eva', 'Brown', 1700.45),
('Michael', 'Taylor', 2200.90),
('Sophia', 'Clark', 1900.55),
('William', 'White', 2100.70),
('Emma', 'Harris', 1600.35),
('James', 'Hall', 2400.65),
('Liam', 'Martin', 1980.25),
('Olivia', 'Jones', 2150.95),
('Noah', 'Anderson', 1750.40),
('Ava', 'Thompson', 2050.85),
('Harper', 'Walker', 1850.50),
('Mia', 'Wright', 1920.20),
('Jackson', 'Baker', 2250.75),
('Sophie', 'Garcia', 1985.30),
('Ethan', 'Robinson', 1820.40),
('Amelia', 'Hill', 2130.60),
('Lucas', 'Young', 1900.90),
('Chloe', 'Turner', 2050.45),
('Alexander', 'Ward', 1680.80),
('Avery', 'Cooper', 1950.75),
('Zoe', 'Stewart', 2250.50),
('Daniel', 'Reed', 2400.65),
('Madison', 'Perez', 1780.30),
('Sebastian', 'Fisher', 2150.90),
('Evelyn', 'Perry', 1920.55),
('Logan', 'Watson', 1985.70),
('Abigail', 'Cox', 1750.40),
('Leo', 'Barnes', 2120.60),
('Mila', 'Wells', 1880.80),
('Lucy', 'Bennett', 2050.95),
('Owen', 'Coleman', 1680.50),
('Aria', 'Fletcher', 1950.70),
('Landon', 'Hughes', 2320.85),
('Aubrey', 'Lopez', 1785.30),
('Carter', 'Cruz', 1950.40),
('Aiden', 'Harrison', 2120.60),
('Grace', 'Hunter', 1985.80),
('Nora', 'Kennedy', 2150.75),
('Emma', 'Diaz', 1780.20);


Select *from Customers-- Tablenin Deyerlerini Ekrana Cixarmaq


update Customers -- Tablenin Deyerini Duzenlemek
set name='Nicat',Surname='Heyderzade'where name='Bob'

delete Customers where id=16-- Tablenin Deyerini Silmek
 
Select top(1) Name from Customers order by Salary desc--En Cox Maas Alan Iscinin Gostermek

select top(1) Surname from Customers order by Salary asc-- En Az  Maas Alan Iscinin Soyadini Gostermek

select *from Customers Where Name like '%e%' and Salary>2000 --Əmək haqqı 2000 dollardan yuxarı olan və adında “e” hərfi olan işçiləri seçin.


select *from Customers Where Id in (1,3)--Id 1 və ya 3 olan işçiləri gətirin.

select *from Customers Where Name like 'J%'and Surname like 'D%'--Adı 'J' ilə başlayan və soyadı 'D' ilə başlayan işçiləri əldə edin.

select top(3) *from Customers order by Salary desc--Maasina gore en yuksek olan 3 neferin cədvəldən gətirin.

SELECT *
FROM Customers
ORDER BY Salary DESC
OFFSET 3 ROWS
FETCH NEXT 2 ROWS ONLY;


select * from Customers  order by Salary desc offset 3 rows  Fetch Next 2 Rows Only--Maasina gore en yuksek olan 3 neferden basqa  növbəti iki işçini gətirin.