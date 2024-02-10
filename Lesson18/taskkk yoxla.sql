Create database Lesson18

CREATE TABLE Department (
    id int PRIMARY KEY IDENTITY,
    name varchar(20) UNIQUE
);

-- Create Salaries table
CREATE TABLE Salaries (
    id int PRIMARY KEY IDENTITY,
    Amount decimal,
    Date datetime UNIQUE
);

-- Create Employees table
CREATE TABLE Employees (
    id int PRIMARY KEY IDENTITY,
    name varchar(20),
    DepartmentID int,
    SalaryID int UNIQUE,
    FOREIGN KEY (DepartmentID) REFERENCES Department(id),
    FOREIGN KEY (SalaryID) REFERENCES Salaries(id)
);
INSERT INTO Department (name)
VALUES ('Marketing'), ('Finance'), ('Human Resources'), ('Sales'), ('IT'), ('Operations');


INSERT INTO Employees (name, DepartmentID, SalaryID)
VALUES ('John Doe', 1, 1), ('Jane Smith', 2, 2), ('Michael Johnson', 3, 3),
       ('Emily Brown', 1, 4), ('David Lee', 2, 5), ('Sarah Taylor', 3, 6);

	   INSERT INTO Salaries (Amount, Date)
VALUES (54000.00, '2023-07-15'), (59000.00, '2023-08-15'), (56000.00, '2023-09-15'),
       (61000.00, '2023-10-15'), (57000.00, '2023-11-15'), (63000.00, '2023-12-15'),
       (55000.00, '2024-01-15'), (60000.00, '2024-02-15'), (58000.00, '2024-03-15'),
       (62000.00, '2024-04-15'), (53000.00, '2024-05-15'), (54000.00, '2024-06-15');


	   Select * from Employees
	   Select * from Department
	   Select * from Salaries



	   SELECT d.name AS DepartmentName, SUM(s.Amount) AS TotalSalary
FROM Employees e
JOIN Department d ON e.DepartmentID = d.id
JOIN Salaries s ON e.SalaryID = s.id
GROUP BY d.name
having 100000<sum(s.Amount)
order by sum(s.Amount)