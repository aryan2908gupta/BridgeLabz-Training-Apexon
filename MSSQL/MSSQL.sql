--List Down Existing Database
exec sp_databases
select name from sys.databases

--Creating A new Database
create database school_db;

--Change or Use Database
use school_db -- yeh bata hain ki konsa db use karna hain for runing our query
select db_name()  -- yeh bata hain konsa current db hum use kar rahe hain

--Deleting a Database
--create database demo
--use demo
--drop database demo

--Creating a table
create table students(
--student_id INT PRIMARY KEY,
student_id INT,
name varchar(100) NOT NULL,
age INT NOT NULL,
--constraints ka hum nam bhi de sakte hain
grade INT,

constraint pk_student PRIMARY KEY (student_id)
);

-- creating two or more col row unique
 CREATE TABLE OrderDetails (
OrderID INT NOT NULL,
ProductID INT NOT NULL,
Quantity INT DEFAULT 100,
CONSTRAINT PK_OrderDetails PRIMARY KEY (OrderID, ProductID)
);

-- default value
Create table account (
id INT identity(1,1) Primary key,
name VARCHAR(100) Not null,
email VARCHAR(100) Unique,
created_at DATETIME DEFAULT GETDATE()
)

-- IDENTITY(1,1)
Create table accounts (
id INT identity (1,1) Primary key,

name VARCHAR(100) Not null,

email VARCHAR(100) Unique,
created_at DATETIME DEFAULT GETDATE()
)


--Checking your table

exec sp_help 'students' 

--Inserting data
insert into students(student_id,name,age,grade)
values(101,'Raju',10,5);

insert into students(student_id,name,age,grade)
values(102,'Shame',12,7),(103,'Baburao',14,9);

-- this only works when we are adding or filling all columns value
insert into students
values(104,'Paul',11,6);

--Reading a Table
select * from students;
select name,age from students;
select age from students where name='Paul';
select name from students;

--Modifying and Update
update students
set grade=12
where student_id=103;

--Deleting Data from table
delete from students where student_id=104;
delete from students where 1=1; --Condition true har row par jaakar ekbaar delete karega
--Truncate--
truncate table students;

-- Task1
create table employees(
emp_id int primary key identity(101,1),
fname varchar(20) not null,
lname varchar(20) not null,
email varchar(100) unique not null,
job_title varchar(20) not null,
department varchar(20),
salary DECIMAL(10,2) DEFAULT 30000.00 check(salary>0),
hire_date Date default CONVERT(date,GETDATE()),
city varchar(20)
);

INSERT INTO employees (fname, lname, email, job_title, department, salary, hire_date, city)
VALUES
('Raj', 'Sharma', 'raj.sharma@example.com', 'Software Engineer', 'IT', 50000.00, '2020-01-15', 'Delhi'),
('Priya', 'Singh', 'priya.singh@example.com', 'HR Executive', 'HR', 45000.00, '2019-03-22', 'Mumbai'),
('Arjun', 'Verma', 'arjun.verma@example.com', 'Backend Developer', 'IT', 55000.00, '2021-06-01', 'Bangalore'),
('Suman', 'Patel', 'suman.patel@example.com', 'Accountant', 'Finance', 60000.00, '2018-07-30', 'Ahmedabad'),
('Kavita', 'Rao', 'kavita.rao@example.com', 'HR Manager', 'HR', 47000.00, '2020-11-10', 'Hyderabad'),
('Amit', 'Gupta', 'amit.gupta@example.com', 'Marketing Lead', 'Marketing', 52000.00, '2020-09-25', 'Pune'),
('Neha', 'Desai', 'neha.desai@example.com', 'UI Developer', 'IT', 48000.00, '2019-05-18', 'Surat'),
('Rahul', 'Kumar', 'rahul.kumar@example.com', 'Full Stack Dev', 'IT', 53000.00, '2021-02-14', 'Noida'),
('Anjali', 'Mehta', 'anjali.mehta@example.com', 'Financial Analyst', 'Finance', 61000.00, '2018-12-03', 'Jaipur'),
('Vijay', 'Nair', 'vijay.nair@example.com', 'Marketing Exec', 'Marketing', 50000.00, '2020-04-19', 'Kochi');

select * from employees;

--WHERE
select * from employees where department='IT';
select * from employees where department != 'HR';
select * from employees where salary > 50000;
select * from employees where hire_date > '2020-12-31';

--DISTINCT
select distinct fname from employees;
select distinct department from employees;

--ORDER BY
select * from employees order by salary;
select * from employees order by hire_date;
select fname from employees order by fname  desc;
--ORDER BY THEN BY
select fname,department from employees order by department ,fname;

--LIKE
select * from employees where department like '%Fin%';
select * from employees where fname like 'A%'; --start with A
select * from employees where fname like '----'; -- name with 4 character
select * from employees where fname like '%A'; --ends with A
select * from employees where email like '%gupta%';

--TOP
select TOP 3 * from employees ORDER BY salary desc;

--LOGICAL OPERATOR AND OR
select * from employees where salary>35000 and department='IT';
select * from employees where city='Noida' or department='IT' or salary=34000;

-- IN NOT IN BETWEEN
select * from employees where department in ('IT','HR','Sales');
select * from employees where salary between 42000 and 88000;
select * from employees where city not in ('Surat','Noida','Delhi');

--CASE
SELECT
fname,
lname,
salary,
CASE
WHEN salary > 100000 THEN 'High Earner'
WHEN salary >= 80000 AND salary <= 100000 THEN 'Medium Earner'
ELSE 'Standard Earner'
END AS salary_band
FROM
employees;

--Calculate Bonus
SELECT fname, lname, department, salary,
CASE
WHEN department IN ('Sales', 'Marketing') THEN salary*0.10
WHEN department = 'Tech' THEN salary*0.12
ELSE salary*0.05
END as bonus
FROM employees

-- ISNULL
select * from employees where fname is null;
select * from employees where fname not like 'A%'; -- not start with A

--AGGREGATE FNC
select count(emp_id) from employees;  -- prefer karo pk do
select max(salary) from employees;
select min(salary) from employees;
select avg(salary) from employees;
select sum(salary) from employees;

--GROUPBY
select department, count(emp_id)  as count from employees group by department;
select department, avg(salary)  as count from employees group by department;
select city, count(emp_id)  as count from employees group by city;

--MULTIGROUPING
select department,city, count(emp_id)  as count from employees group by department,city order by department;

--HAVING => WORKS WITH ONLY GROUP BY
select department, count(emp_id)  as count from employees group by department HAVING count(emp_id)>2;

select department, avg(salary) as avgsal   from employees group by department HAVING AVG(salary) >50000;

select department, sum(salary)   from employees group by department having sum(salary)>100000;

--ROLLUP => use to generate totalcount or subcount of groupby
select department, avg(salary)  as count from employees group by rollup(department);

--QUESTION
-- COALESCE IS USED TO REMOVE NULL FROM COL 
select department,COALESCE(city,'Total') as city, count(emp_id)  as count from employees group by rollup (department,city) order by department;

--SUBQUERIES
select * from employees where salary > (select avg(salary) from employees);

select fname,lname,department from employees where department in (
	select department from employees where city = 'Mumbai'
);	

--FIND EMPLOYEE WITH HIGHEST SALARY IN EACH DEPT CORRELEATED SUBQUERY
select * from employees  e1 where salary = (
	SELECT MAX(salary)
    FROM employees e2
    WHERE e2.department = e1.department
);

--OR ANOTHER WAY
select * from employees where salary in (select department,max(salary) from employees group by department);

--INLINE VIEW SUBQUERY
SELECT department, avg_salary
FROM (
SELECT department, AVG(salary) AS avg_salary
FROM employees
GROUP BY department
) AS dept_avg
WHERE avg_salary > 60000;
--OR
SELECT department,AVG(salary) from employees group by department having avg(salary)>60000;

--STRING FNC
--CONCAT
select concat('Hello', ' ','Hi')
select concat(fname,lname) as FULLNAME from employees;
--CONTACT_WS
--ONE:TWO:THREE
select CONCAT_WS(':','ONE','TWO','THREE')
--SUBSTRING
SELECT SUBSTRING('HEY BUDDY',1,4)
--REPLACE
SELECT REPLACE('HEY BUDDY','HEY','HELLO')
SELECT REPLACE(DEPARTMENT,'HR','HUMAN RESOURCE') FROM employees;
--REVERSE
SELECT REVERSE('HELLO WORLD');
--LENGTH
SELECT LEN('ARYAN');
SELECT LEN(fname) from employees;
--UPPER LOWER--
SELECT UPPER(fname) from employees;
SELECT LOWER(fname) from employees;
--LEFT RIGHT--
SELECT LEFT('ABCDE',3);
SELECT RIGHT('A232WBCDE',3);
--TRIM--
SELECT TRIM(' ALRIGHT ');
--CHAR INDEX--
SELECT CHARINDEX('YA','ARYAN');

--STRING FUNCTION EX
SELECT CONCAT_WS(':',emp_id,CONCAT(fname,' ',lname),city) from employees;
SELECT CONCAT_WS(':',UPPER(fname),city) from employees;
SELECT CONCAT(LEFT(department,1),emp_id) from employees;

--DATE FUNCTION
SELECT GETDATE() -- Current Date 
SELECT DATEADD(YEAR,2,GETDATE());
SELECT DATEADD(MONTH,2,GETDATE());
SELECT DATEDIFF(MONTH,'2025-11-12',GETDATE());
SELECT DATEDIFF(YEAR,'2025-11-12',GETDATE());
SELECT MONTH(GETDATE())
SELECT YEAR(GETDATE())
SELECT DAY(GETDATE())
SELECT FORMAT(GETDATE(),'MM/dd/yy')

--ALTERING TABLE
	

alter table employees
add phone varchar(20);

alter table employees
drop column phone;
--MODIFYING COLUMN
alter table employees
alter column lname varchar(100) not null;

--RENAME A COLUMN
exec sp_rename
'employees.first_name','f.name','COLUMN'

--RENAME A TABLE
exec sp_rename
'staff','employees';

select * from employees;

-- Adding constraints
alter table employees
add constraint default_dept DEFAULT 'TRAINEE'
for department;

alter table employees
add unique(department)

--CHECK
alter table employees
add constraint check_emp_pos_sal CHECK(salary>0)

alter table employees
drop constraint check_emp_sal

alter table employees
add constraints chk_valid_email check (email like '%@%.')

----- 1:MANY DATA
CREATE DATABASE store_db
USE store_db

CREATE TABLE Customers (
customer_id INT IDENTITY (100,1) PRIMARY KEY,
customer_name VARCHAR(100) NOT NULL,
email VARCHAR(100) UNIQUE
);

CREATE TABLE Orders ( 
    order_id INT IDENTITY(500,1) PRIMARY KEY, 
    order_date DATE NOT NULL, 
    total_amount DECIMAL(10, 2), 
    customer_id INT, 
    FOREIGN KEY (customer_id) REFERENCES Customers(customer_id) ON DELETE CASCADE
);

exec sp_help 'Orders'

INSERT INTO Customers (customer_name, email)
VALUES
('Raju', 'raju@example.com'),
('Sham', 'sham@example.com'),
('Baburao', 'baburao@example.com');

INSERT INTO Orders (order_date, total_amount, customer_id)
VALUES
('2025-09-15', 1500.00, 100),  -- Raju
('2025-09-28', 800.00, 101),   -- Sham
('2025-10-05', 2200.00, 100),  -- Raju
('2025-10-12', 500.00, 102),   -- Baburao
('2025-10-17', 1200.00, 101);  -- Sham

select * from Customers;
select * from Orders;

insert into Customers(customer_name,email)
values('Paul','paul@gmail.com');

insert into Orders(order_date,total_amount)
values('2025-10-18','3500');

--CROSSJOIN
select * from Customers
CROSS JOIN
Orders 

--INNERJOINS
select * from Customers
INNER JOIN
Orders
    on Customers.customer_id = Orders.customer_id;

select c.customer_name, count(order_id) from Customers c
INNER JOIN
Orders o
    on c.customer_id = o.customer_id group by (c.customer_name);

    select c.customer_name, count(order_id),sum(o.total_amount) from Customers c
INNER JOIN
Orders o
    on c.customer_id = o.customer_id group by (c.customer_name);

--LEFT JOIN
select * from Customers
LEFT JOIN
Orders
    on Customers.customer_id = Orders.customer_id;

     select c.customer_name, count(order_id) as ORDERPALCED ,sum(o.total_amount) from Customers c
LEFT JOIN
Orders o
    on c.customer_id = o.customer_id group by (c.customer_name);

-- RIGHT JOIN

select * from Customers
RIGHT JOIN
Orders
    on Customers.customer_id = Orders.customer_id;

     select c.customer_name, count(order_id) as ORDERPALCED ,sum(o.total_amount) from Customers c
RIGHT JOIN
Orders o
    on c.customer_id = o.customer_id group by (c.customer_name);

--FULL OUTER JOIN

select * from Customers
 FULL OUTER JOIN
Orders
    on Customers.customer_id = Orders.customer_id;

-- OUTER APPLY
SELECT
c.customer_id,
c.customer_name,
o.order_id,
o.order_date,
o.total_amount
FROM Customers AS c
OUTER APPLY (
SELECT TOP 1 *
FROM Orders AS o
WHERE o.customer_id = c.customer_id
ORDER BY o.order_date DESC
) AS o;

--CROSS APPLY
SELECT
c.customer_id,
c.customer_name,
o.order_id,
o.order_date,
o.total_amount
FROM Customers AS c
CROSS APPLY (
SELECT TOP 1 *
FROM Orders AS o
WHERE o.customer_id = c.customer_id
ORDER BY o.order_date DESC
) AS o;

--UNION AND UNION ALL
select * from Customers
UNION
select * from Orders;
--EXCEPT

--SELF JOIN
CREATE TABLE CompanyHierarchy (
EmployeeID INT PRIMARY KEY,
Name VARCHAR(100),
ManagerID INT
);
INSERT INTO CompanyHierarchy (EmployeeID, Name, ManagerID) VALUES
(1, 'Sonia Verma', NULL), -- The CEO
(2, 'Rohan Gupta', 1), -- Reports to Sonia
(3, 'Amit Sharma', 2), -- Reports to Rohan
(4, 'Priya Singh', 1), -- Reports to Sonia
(5, 'Kabir Shah', 2); -- Reports to Rohan

--EXAMPLE OF LEFT JOIN CONNECTING EMP TO THEIR MANAGER
SELECT
e.Name AS EmployeeName,
m.Name AS ManagerName
FROM
Company Hierarchy AS e
LEFT JOIN
Company Hierarchy AS m
ON e.ManagerID = m.EmployeelD;

--MANY TO MANY--
create database Institute;
use Institute;

CREATE TABLE courses ( 
  course_id INT IDENTITY(1,1) PRIMARY KEY, 
  course_name VARCHAR(100) NOT NULL, 
  course_fee NUMERIC(10, 2) NOT NULL 
);

exec sp_help courses
INSERT INTO courses (course_name, course_fee)
VALUES
('Mathematics', 500.00),
('Physics', 600.00),
('Chemistry', 700.00);
select * from courses;

CREATE TABLE students (
    student_id INT IDENTITY(1,1) PRIMARY KEY,
    student_name VARCHAR(100) NOT NULL
);


INSERT INTO Students (student_name) VALUES
('Raju'),
('Sham'),
('Baburao'),
('Alex');

CREATE TABLE enrollment (
    enrollment_id INT IDENTITY(1,1) PRIMARY KEY,
    student_id INT NOT NULL,
    course_id INT NOT NULL,
    enrollment_date DATE NOT NULL,
 
    FOREIGN KEY (student_id) REFERENCES students(student_id),
    FOREIGN KEY (course_id) REFERENCES courses(course_id)
);

INSERT INTO enrollment (student_id, course_id, enrollment_date)
VALUES
(1, 1, '2025-01-01'), -- Raju enrolled in Mathematics
(1, 2, '2025-01-15'), -- Raju enrolled in Physics
(2, 1, '2025-02-01'), -- Sham enrolled in Mathematics
(2, 3, '2025-02-15'), -- Sham enrolled in Chemistry
(3, 3, '2025-03-25'); -- Alex enrolled in Chemistry

select * from enrollment;

select s.student_name, c.course_name, e.enrollment_date, c.course_fee  from enrollment e 
INNER JOIN students s on e.student_id = s.student_id
INNER JOIN
courses c on e.course_id = c.course_id;

SELECT c.course_name, COUNT(s.student_id), SUM(c.course_fee)
FROM enrollment e
INNER JOIN students s ON e.student_id = s.student_id
INNER JOIN courses c ON e.course_id = c.course_id
GROUP BY c.course_name

--ECOMMERCE PROJECT

CREATE TABLE customers (
    cust_id INT IDENTITY(1,1) PRIMARY KEY,
    cust_name VARCHAR(100) NOT NULL
);

INSERT INTO customers (cust_name)
VALUES
    ('Raju'), ('Sham'), ('Paul'), ('Alex'),('Baburao') ;

    SELECT * FROM customers;

    CREATE TABLE orders (
    ord_id INT IDENTITY(1,1) PRIMARY KEY,
    ord_date DATE NOT NULL,
    cust_id INT NOT NULL,
    FOREIGN KEY (cust_id) REFERENCES customers(cust_id) ON DELETE CASCADE
);

INSERT INTO orders (ord_date, cust_id)
VALUES
    ('2025-01-01', 1),  -- Raju first order
    ('2025-02-01', 2),  -- Sham first order
    ('2025-03-01', 3),  -- Paul first order
    ('2025-04-04', 2);  -- Sham second order

        SELECT * FROM orders;


        CREATE TABLE products (
    p_id INT IDENTITY(1,1) PRIMARY KEY,
    p_name VARCHAR(100) NOT NULL,
    price NUMERIC NOT NULL
);

INSERT INTO products (p_name, price)
VALUES
    ('Laptop', 55000.00),
    ('Mouse', 500),
    ('Keyboard', 800.00),
    ('Cable', 250.00),
     ('Monitor', 12000.00);

     CREATE TABLE order_items (
    item_id INT IDENTITY(1,1) PRIMARY KEY,
    ord_id INT NOT NULL,
    p_id INT NOT NULL,
    quantity INT NOT NULL,
    FOREIGN KEY (ord_id) REFERENCES orders(ord_id),
    FOREIGN KEY (p_id) REFERENCES products(p_id)
);

INSERT INTO order_items (ord_id, p_id, quantity)
VALUES
    (1, 1, 1),  -- Raju ordered 1 Laptop
    (1, 4, 2),  -- Raju ordered 2 Cables
    (2, 1, 1),  -- Sham ordered 1 Laptop
    (3, 2, 1),  -- Paul ordered 1 Mouse
    (3, 4, 5),  -- Paul ordered 5 Cables
    (4, 3, 1);  -- Sham ordered 1 Keyboard

    --VIEW
    create view enrollment_details AS
    select 
    	c.cust_name,
	o.ord_date,
	p.p_name,
	p.price,
	oi.quantity,    
	(oi.quantity*p.price) AS total_price
    from order_items oi
    join products p on oi.p_id = p.p_id
    join orders o on oi.ord_id = o.ord_id 
    join customers c on c.cust_id=o.cust_id;

       select 
    	c.cust_name,
	    count(c.cust_id)
    from order_items oi
    join products p on oi.p_id = p.p_id
    join orders o on oi.ord_id = o.ord_id 
    join customers c on c.cust_id=o.cust_id
    group by (c.cust_name);

       select 
    	c.cust_name,
	    count(distinct(c.cust_id))
    from order_items oi
    join products p on oi.p_id = p.p_id
    join orders o on oi.ord_id = o.ord_id 
    join customers c on c.cust_id=o.cust_id
    group by (c.cust_name);

     select 
    	c.cust_name,
	    count(distinct(c.cust_id)),
        sum(oi.quantity) as No_of_Product,
        sum(p.price*oi.quantity) as Total_amt
    from order_items oi
    join products p on oi.p_id = p.p_id
    join orders o on oi.ord_id = o.ord_id 
    join customers c on c.cust_id=o.cust_id
    group by (c.cust_name);

    --VIEWS
    select * from enrollment_details;
    select TABLE_SCHEMA,TABLE_NAME FROM INFORMATION_SCHEMA.VIEWS
    sp_helptext 'enrollment_details';   

    --WINDOW
    USE school_db;
    EXEC sp_help employees;
    EXEC sp_rename 'employees.[f.name]', 'fname', 'COLUMN';
    select fname,salary from employees;

   SELECT 
    fname,
    salary,
    SUM(salary) OVER () AS total_sal,
    CAST(
        salary * 100.0 / SUM(salary) OVER ()
        AS DECIMAL(10,2)
    ) AS pct
FROM employees;
    

select fname,department,salary,
sum(salary) over(partition by department)
from employees;
--ROW_NUMBER
select  row_number() over(order by fname) as Row_Num,fname,department,salary from employees;
--RANK--
select fname,department, salary,rank() over(order by salary desc) from employees;
--DENSE RANK--
select fname,department, salary,dense_rank() over(order by salary desc) from employees;
--LAG AND LEAD
select fname,department,salary,lag(salary)  over(order by salary  desc) as lag_sal from employees;
select fname,department,salary,lead(salary) over(order by salary  desc) from employees;

select fname,hire_date,salary,lag(salary) over(order by hire_date ) as prev_sal,
salary-lag(salary) over(order by hire_date) as sal_diff
from employees;

--TASK
select fname,department, salary,dense_rank() over(partition by department order by salary desc) as Rank from employees;

--RUNNING TOTAL
select fname,department,salary,
sum(salary) over(partition by department order by emp_id,salary desc) from employees;

--ROWS BETWEEN--
SELECT fname, department, salary,
SUM(salary) OVER(
ORDER BY salary DESC
ROWS BETWEEN UNBOUNDED PRECEDING AND CURRENT ROW
) as running_total
FROM employees

SELECT fname, department, salary,
SUM(salary) OVER(
ORDER BY salary DESC
RANGE BETWEEN UNBOUNDED PRECEDING AND CURRENT ROW
) as running_total
FROM employees

--3 ROW/EMPLOYEES MOVING AVG
SELECT fname, hire_date, salary,
CAST (AVG(salary) OVER(
ORDER BY hire_date
ROWS BETWEEN 1 PRECEDING AND 1 FOLLOWING
) AS DECIMAL(10,2)) as three_row_avg
FROM employees

--FNAME AND LNAME
SELECT fname,department,
FIRST_VALUE(fname) OVER(
PARTITION BY department
order by fname) from employees;

SELECT fname,department,
LAST_VALUE(fname) OVER(
PARTITION BY department
order by fname) from employees;

SELECT fname,department,
LAST_VALUE(fname) OVER(
PARTITION BY department
order by fname
ROWS BETWEEN UNBOUNDED PRECEDING AND UNBOUNDED FOLLOWING   
) from employees;

 ---FIND TOP, MIDDLE, BOTTOM Earner in each Department
SELECT fname, department, salary,
NTILE(3) OVER(
PARTITION BY DEPARTMENT
ORDER BY salary DESC)
FROM employees

--CTE
WITH Avgsal as(
select department,avg(salary) as Avg_Sal from employees group by department

)


--select * from employees;

select emp_id,fname,e.department,salary,a.Avg_sal
from employees e join Avgsal a
on e.department = a.department
where salary>a.Avg_sal;

--Another question
WITH MAXSALARY AS (
select department , max(salary) as maxSal from employees group by department
)

--select * from employees;

select emp_id, fname,e.department,salary,maxi.maxSal from employees e
join
MAXSALARY maxi
on e.department = maxi.department
where e.salary=maxi.maxSal;

--STORED PROCEDURE
CREATE PROCEDURE get_employees_sp
as
BEGIN
SELECT emp_id,fname,lname,department,hire_date,city
from employees
END

exec get_employees_sp;

--INPUT PARAMETER
create procedure get_emp_by_dept
    @p_department varchar(100)
as
begin
select emp_id,fname,lname,department,hire_date,city from employees
where department=@p_department
end

exec get_emp_by_dept 'IT'

--HOW TO CHECK Existing SP

SELECT ROUTINE_NAME
FROM INFORMATION_SCHEMA.ROUTINES
WHERE ROUTINE_TYPE = 'PROCEDURE' 

sp_helptext 'get_employees_sp'

--UPDATE AND DELETE WITH SP
CREATE PROCEDURE update_emp_salary
@p_employee_id INT,
@p_new_salary NUMERIC(10, 2)
AS
BEGIN
UPDATE employees
SET salary = @p_new_salary
WHERE emp_id = @p_employee_id;
END;

EXEC update_emp_salary
@p_employee_id = 102, @p_new_salary = 125000.00;
--OR
EXEC update_emp_salary 102, 125000.00;

select * from employees
exec update_emp_salary 103,9000;

--SP WITH OUTPUT
CREATE PROCEDURE get_emp_avgsal
    @p_dept VARCHAR(100),
    @dept_avg NUMERIC(10,2) OUTPUT
AS
BEGIN
    SELECT
        @dept_avg = AVG(salary)
    FROM employees
    WHERE department = @p_dept;
END;

DECLARE @AvgDeptResult NUMERIC(10,2)
EXEC get_emp_avgsal 'IT', @AvgDeptResult OUTPUT
SELECT @AvgDeptResult

--USER DEFINED FNC
CREATE FUNCTION DOUBLE_VALUE (
@p_num NUMERIC(10,2)
)
RETURNS NUMERIC(10,2)
AS
BEGIN
DECLARE @result NUMERIC(10,2)
SET @result = @p_num*2
RETURN @result
END

SELECT dbo.DOUBLE_VALUE(100)

select fname,salary,dbo.DOUBLE_VALUE(salary) from employees;

---ITVF---

CREATE FUNCTION DEPT_MAX_EMP(
@p_dept VARCHAR(100)
)
RETURNS TABLE
AS
RETURN(
SELECT * FROM employees WHERE department= @p_dept AND
salary = (
SELECT MAX(salary) FROM employees WHERE department= @p_dept
)
)

SELECT * FROM dbo.DEPT_MAX_EMP('IT')

--INDEX
 SET STATISTICS TIME ON;
 SET STATISTICS IO ON;

 CREATE INDEX i_salary on employees(salary);

 --single cluster index and multiple cluster allowed

 DROP INDEX i_salary on employees;
