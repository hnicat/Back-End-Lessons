Create database P118 
 use P118

 Create table Employe2(
 EmployeID int Primary key identity(100,1),

 [FirstName] nvarchar(20),
 [LastName] nvarchar(50),
 Salary decimal,
 JoiningDate datetime,
 Department nvarchar(10),
 Gender nvarchar(10) check (Gender in ('Male','Female'))

 )
 drop table Employe2

 select *from Employe2

 insert  into Employe2  values   
 ('John', 'Doe', 50000.50, '2022-01-01', 'IT', 'Male'),
    ('Jane', 'Smith', 60000.75, '2022-02-15', 'HR', 'Female'),
    ('Bob', 'Johnson', 55000.00, '2022-03-10', 'Finance', 'Male'),
    ('Alice', 'Williams', 70000.25, '2022-04-20', 'Marketing', 'Female'),
    ('Mike', 'Brown', 48000.30, '2022-05-05', 'IT', 'Male');

	--1 ci 
	Select Upper( [FirstName]) as 'FirstName' from Employe2
	-- 2 ci 
	Select CONCAT (FirstName,' ',LastName) as [Name] from Employe2
	-- 3 cu
	Select FirstName from Employe2 Where [FirstName] like 'A%'
	--4 cu 
	Select FirstName from Employe2 Where [FirstName]  like '[A-P]%'
	--5 ci 
	Select Max(Salary) from Employe2 
	--6 ci
	Select Department from Employe2 Group By Department
	--7 ci
	Select Min(Salary)from Employe2 
	--8 ci
	Select JoiningDate from Employe2 Where JoiningDate  between  '2022-01-01' and '2022-05-05'
	-- 9 cu 
	Select Count (EmployeID) from Employe2

	Select Count(EmployeID), Department from Employe2 Group By Department

	--10 cu

	Select top(1) * from Employe2

	--11 ci

	select *from Employe2 Where FirstName in ( 'Mike','Alice','Bob')
	--12 ci
    Select FirstName, Case When Gender='Male' then 'M' When Gender='Female'  then 'F'
	else ' ' end as Gender from Employe2 ;

	--13 cu
Select * from Employe2 where Salary>60000

--14 ci

Select Department, Sum(Salary) as 'Total Salary' from Employe2  Group By Department 
--15 ci
Select Department, Sum(Salary) as 'Total Salary' from Employe2  Group By Department order by sum (Salary) asc