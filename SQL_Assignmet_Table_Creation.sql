--select * from Production.Product;

--select * from Person.Password;

--SELECT * FROM dbo.STUDENT;

--CREATE DATABASE SQL_SERVER;

--USE SQL_SERVER;

--CREATE TABLE STUDENT(STUDENT_ID INT PRIMARY KEY,STUDENT_NAME VARCHAR(30),STUDENT_ADDRESS VARCHAR(40),COURSE_NAME VARCHAR(25),EMAIL_ID
--VARCHAR(20));

--SP_HELP STUDENT;

--*********Rename the column name**************

--ALTER TABLE STUDENT ADD STUDENT_LASTNAME VARCHAR(10);

--USE SQL_SERVER;

--INSERT INTO STUDENT 
--VALUES (101, 'John', 'Mysore', 'CSE', 'john@gmail.com', '6767676767');
--INSERT INTO STUDENT 
--VALUES (102, 'Alias', 'Benglore', 'MCA', 'alias@gmail.com', '8967676767');
--INSERT INTO STUDENT 
--VALUES (103, 'Smith', 'Belgavi', 'ECE', 'smith@gmail.com', '9067676767');
--INSERT INTO STUDENT 
--VALUES (104, 'Harshitha', 'Mysore', 'CSE', 'harshi@gmail.com', '9867676767');
--INSERT INTO STUDENT 
--VALUES (105, 'Reshmi', 'Tumkur', 'EEE', 'reshmi@gmail.com', '6467676767');
--INSERT INTO STUDENT 
--VALUES (106, 'John', 'Mysore', 'CSE', 'john@gmail.com', '6563676767');

--SP_RENAME 'STUDENT.EMAIL_ID','STU_EMAIL_ID';

--UPDATE STUDENT SET STU_EMAIL_ID='hars@gmail.com' WHERE STUDENT_ID=104;

SELECT * FROM STUDENT;

--CREATE DATABASE Training
--ON 
--( NAME = 'training_data',
--  FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Training.mdf',
--  SIZE = 10MB,
--  MAXSIZE = 100MB,
--  FILEGROWTH = 5MB 
--)
--LOG ON 
--( NAME = 'training_log',
--  FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Training.ldf',
--  SIZE = 5MB,
--  MAXSIZE = 50MB,
--  FILEGROWTH = 1MB 
--);

--select * from sys.fn_dblog(NULL,NULL);