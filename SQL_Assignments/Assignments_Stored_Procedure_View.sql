SELECT * FROM HumanResources.Employee;
--1.

CREATE PROCEDURE spGetEmployeeDetails
AS
BEGIN
SELECT CONCAT(FirstName,' ',MiddleName,' ',LastName) AS FULLNAME,HRE.NationalIDNumber, HRE.JobTitle
FROM Person.Person AS PP JOIN HumanResources.Employee AS HRE 
ON PP.BusinessEntityID=HRE.BusinessEntityID;
END

EXEC spGETEMPLOYEEDETAILS;
DROP PROCEDURE spGetEmployeeDetails;

--2.
CREATE PROCEDURE spCompareSales
@BusinessEntityID int
AS
BEGIN
SELECT CONCAT(PP.FirstName, ' ', PP.MiddleName, ' ', PP.LastName) AS FullName,PP.BusinessEntityID,SOH.OrderDate,SQ.SalesQuota,
SUM(soh.SubTotal) AS TotalSales
FROM Person.Person PP
    JOIN Sales.SalesPerson sp ON PP.BusinessEntityID = sp.BusinessEntityID
    JOIN Sales.SalesPersonQuotaHistory sq ON sp.BusinessEntityID = sq.BusinessEntityID
    JOIN Sales.SalesOrderHeader soh ON sp.BusinessEntityID = SOH.SalesPersonID
    WHERE  PP.BusinessEntityID = @BusinessEntityID
    GROUP BY PP.FirstName, PP.MiddleName, PP.LastName, PP.BusinessEntityID, soh.OrderDate, sq.SalesQuota
    ORDER BY soh.OrderDate;
END

spCompareSales 277

select * from Sales.SalesPerson
--3.
CREATE PROCEDURE spReturningRankOfProducts
AS
BEGIN
SELECT SUM(QUANTITY) AS TOTAL_QUANTITY,LOCATIONID,
DENSE_RANK() OVER(ORDER BY SUM(QUANTITY) DESC)AS D_RANK
FROM Production.ProductInventory
GROUP BY LOCATIONID
END;

EXEC spReturningRankOfProducts
--4.
CREATE PROCEDURE spGetTopTenEmployees
AS
BEGIN
       SELECT TOP 5 CONCAT(FirstName,' ',MiddleName,' '+LastName) AS FULLNAME,SUM(TOTALDUE) AS [TOTAL SALES],SALESPERSONID,
	   DENSE_RANK() OVER(ORDER BY SUM(TOTALDUE)  DESC) AS RN
       FROM SALES.SalesOrderHeader AS SOH
       JOIN Person.Person AS PP ON SOH.SalesPersonID=PP.BusinessEntityID
	   GROUP BY CONCAT(FirstName,' ',MiddleName,' '+LastName),SalesPersonID;
END

EXEC spGetTopTenEmployees;

--***********View**************
--3.

SELECT * FROM Sales.SalesOrderHeader;

CREATE VIEW vw_CUSTOMER_PURCHASE_SUMMARY
AS
SELECT ORDERDATE ,COUNT(DISTINCT CUSTOMERID) AS CUSTOMER_COUNT,AVG(TOTALDUE) AVERAGE,SUM(TOTALDUE) TOTAL
FROM SALES.SALESORDERHEADER
GROUP BY ORDERDATE 

SELECT * FROM vw_CUSTOMER_PURCHASE_SUMMARY;

SELECT * FROM Person.Person;

--4.
CREATE VIEW vw_SALES_AVG_SUM
AS
SELECT SalesPersonID,CONCAT(FirstName,' ',MiddleName,' '+LastName) AS FULLNAME,AVG(TOTALDUE) AS AVERAGE,SUM(TOTALDUE) TOTAL
FROM Person.Person AS PP 
JOIN Sales.SalesOrderHeader AS SOH 
ON PP.BusinessEntityID=SOH.SalesPersonID
GROUP BY CONCAT(FirstName,' ',MiddleName,' '+LastName),SalesPersonID;

SELECT * FROM vw_SALES_AVG_SUM;