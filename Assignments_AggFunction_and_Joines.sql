SELECT * FROM SALES.SalesOrderHeader;

--1.
SELECT OrderDate ,SUM(TotalDue) AS TOTALSALES ,SalesPersonID FROM SALES.SalesOrderHeader GROUP BY SalesPersonID,OrderDate;

--2.highest sales
SELECT TOP 1 SalesPersonID,MAX(TotalDue) AS TOTALSALES FROM SALES.SalesOrderHeader GROUP BY SalesPersonID ORDER BY TOTALSALES DESC;

--3.highest sales(mon)
SELECT MONTH(OrderDate) AS Yearmonth,MAX(TotalDue) FROM Sales.SalesOrderHeader  GROUP BY MONTH(OrderDate) 
ORDER BY MAX(TotalDue) DESC offset 0 ROWS FETCH NEXT 1 ROWS ONLY;
 
SELECT * FROM HumanResources.JobCandidate;
--4. 
SELECT * FROM HumanResources.JobCandidate WHERE BusinessEntityID IS NOT NULL;

SELECT COUNT(*) AS TOTAL_JOB_RECEIVED FROM HumanResources.JobCandidate WHERE BusinessEntityID IS NOT NULL;

SELECT * FROM Production.Product;
--5.
SELECT Name FROM Production.Product WHERE FinishedGoodsFlag=1;

SELECT * FROM Sales.SalesOrderDetail;
--6.
SELECT ProductID,COUNT(OrderQty) AS TOTAL_ORDERS FROM Sales.SalesOrderDetail GROUP BY ProductID;

SELECT * FROM Person.Person;
--7.
SELECT CONCAT(FirstName,' '+LastName) AS FULL_NAME FROM Person.Person;


--JOINS 1.
--1.
SELECT * FROM HumanResources.Employee;
SELECT * FROM HumanResources.EmployeeDepartmentHistory;

select * from Person.ContactType;
 
SELECT contactTypeID, Name FROM Person.ContactType WHERE Name like '%Manager';

--2.
SELECT a.PostalCode,p.FirstName,p.LastName,sp.SalesYTD 
FROM Person.Person as p JOIN Sales.SalesPerson AS sp ON p.BusinessEntityID=sp.BusinessEntityID 
JOIN Person.BusinessEntityAddress as bea ON p.BusinessEntityID=bea.BusinessEntityID
JOIN Person.Address AS a ON bea.AddressID=a.AddressID
WHERE sp.TerritoryID IS NOT NULL AND SalesYTD!=0 
ORDER BY a.PostalCode,sp.SalesYTD DESC;

SELECT * FROM Person.Address;
--3.
SELECT * FROM HumanResources.EmployeePayHistory;
SELECT * FROM HumanResources.EmployeePayHistory;
SELECT * FROM Person.Person;

SELECT CONVERT (date,  HumanResources.EmployeePayHistory.RateChangeDate) AS RateChangeDate,
CONCAT (Person.Person.FirstName, ' ', Person.Person.MiddleName, ' ', Person.Person.LastName) AS FullName,
 HumanResources.EmployeePayHistory.Rate * 40 AS WeeklySalary 
 FROM   HumanResources.EmployeePayHistory
JOIN 
 Person.Person ON HumanResources.EmployeePayHistory.BusinessEntityID = Person.Person.BusinessEntityID
 ORDER BY FullName;
 
select count(JobCandidateID) AS CandidatesReceivedJob 
from HumanResources.JobCandidate
where BusinessEntityID is not null;

--4.
select sum(OrderQty) as orders,ProductID from sales.SalesOrderDetail group by ProductID;

select s.SalesOrderID,s.ProductID, p.Name,s.OrderQty,min(OrderQty) as Min,sum(OrderQty) as Sum,max(OrderQty) as Max,avg(Orderqty) 
as Avg,count(OrderQty) as Count 
from Sales.SalesOrderDetail as s join Production.Product as p on s.ProductID=p.ProductID 
where SalesOrderID in (43659,43664) group by s.SalesOrderID,s.ProductID, p.Name,s.OrderQty;

--5.
SELECT p.Name, sod.SalesOrderID  
FROM Production.Product AS p  
LEFT JOIN Sales.SalesOrderDetail AS sod  
ON p.ProductID = sod.ProductID  
ORDER BY p.Name ;

----Joines 2
--1.

SELECT p.Name,sod.SalesOrderID FROM Production.Product as p 
LEFT OUTER JOIN Sales.SalesOrderDetail as sod 
ON p.ProductID=sod.ProductID;

--2.
SELECT SalesOrderID ,SUM(OrderQty*UnitPrice) as TotalPrice
From Sales.SalesOrderDetail GROUP BY SalesOrderID HAVING SUM(OrderQty*UnitPrice) > 100000 ORDER BY SalesOrderID;

--3.
SELECT * FROM Sales.SalesOrderDetail as sod Left JOIN Sales.SalesOrderHeader as soh
ON sod.SalesOrderID=soh.SalesOrderID
WHERE (sod.OrderQty > 5 or sod.UnitPriceDiscount < 1000) and soh.TotalDue > 100;

--4.
SELECT MIN(Rate) AS MIN_SALARY,MAX(Rate) AS MAX_SALARY,AVG(Rate) AS Average_SALARY,COUNT(edh.BusinessEntityID) AS NO_OF_EMPLOYEE 
FROM HumanResources.EmployeeDepartmentHistory as edh JOIN HumanResources.EmployeePayHistory as eph 
ON edh.BusinessEntityID=eph.BusinessEntityID GROUP BY DepartmentID;

--5.
SELECT (VacationHours+SickLeaveHours) as Total_Hours,FirstName,LastName,VacationHours,SickLeaveHours
FROM HumanResources.Employee as e JOIN Person.Person as p
ON e.BusinessEntityID=p.BusinessEntityID ORDER BY Total_Hours;

--Joines 3
SELECT  * FROM HumanResources.Department;
--1.
SELECT COUNT(edh.BusinessEntityID) as Count_Of_Emp,Name,JobTitle, edh.DepartmentID FROM HumanResources.Employee AS emp 
JOIN HumanResources.EmployeeDepartmentHistory AS edh  ON emp.BusinessEntityID=edh.BusinessEntityID
JOIN HumanResources.Department as dept ON dept.DepartmentID=edh.DepartmentID
GROUP BY NAME,JobTitle,edh.DepartmentID
HAVING edh.DepartmentID IN(12,14);

--2.

SELECT soh.SalesOrderID,MONTH(OrderDate) as Month_OrderDate,PersonID,cust.CustomerID,SubTotal,OrderDate
FROM Sales.SalesOrderHeader as soh JOIN Sales.SalesOrderDetail as sod 
ON soh.SalesOrderID=sod.SalesOrderID 
JOIN Sales.Customer as cust ON soh.CustomerID=cust.CustomerID
WHERE OrderDate >= '2011-12-01';

--3.
SELECT * FROM Sales.SalesOrderDetail;
SELECT * FROM Production.Product

SELECT DISTINCT CONCAT(pp.FirstName,+' '+pp.MiddleName,+' '+pp.LastName) AS FULL_NAME
FROM Person.Person as pp JOIN HumanResources.Employee as hre
ON pp.BusinessEntityID=hre.BusinessEntityID
JOIN Sales.SalesOrderHeader as soh ON pp.BusinessEntityID=soh.SalesPersonID
JOIN Sales.SalesOrderDetail as sod ON sod.SalesOrderID=soh.SalesOrderID 
JOIN Production.Product as pdct ON sod.ProductID=pdct.ProductID
WHERE ProductNumber='BK-M68B-42';

--4.
SELECT ppm.ProductModelID FROM Production.Product AS pp
JOIN Production.ProductModel as ppm ON pp.Name=ppm.Name
GROUP BY ppm.ProductModelID 
Having MAX(ListPrice) > 2*AVG(ListPrice);