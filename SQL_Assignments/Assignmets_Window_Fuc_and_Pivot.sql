select color from Production.Product 
where  color is not null
order by color;
--1.
SELECT *
FROM(
SELECT PP.NAME,PP.COLOR,POD.ORDERQTY FROM Production.Product AS PP
JOIN Purchasing.PurchaseOrderDetail AS POD 
ON PP.ProductID=POD.ProductID
WHERE COLOR IS NOT NULL
) AS SOURCE_TABLE
PIVOT(
SUM(ORDERQTY)
FOR COLOR IN ([BLACK],[BLUE],[GREY],[MULTI],[RED],[SILVER],[YELLOW])
) AS PIVOT_TABLE

--2.
SELECT *
FROM 
(SELECT PP.ProductId, SOD.ORDERQTY, YEAR(SOH.OrderDate) AS YEARS FROM Production.Product AS PP
JOIN Sales.SalesOrderDetail AS SOD ON PP.ProductID = SOD.ProductID
JOIN Sales.SalesOrderHeader AS SOH ON SOH.SalesOrderID = SOD.SalesOrderID
)AS SOURCE_TABLE
PIVOT 
(
SUM(ORDERQTY)
FOR YEARS IN ([2011], [2012], [2013], [2014])
)AS pivottable;

--***********WINDOW FINCTION*****************
--1.

SELECT ProductId,Name,TotalQty,
DENSE_RANK() OVER (ORDER BY TotalQty DESC) AS ROW_NUM FROM
(SELECT PP.ProductID,Name,SUM(OrderQty) AS TotalQty FROM Production.Product PP
JOIN  Sales.SalesOrderDetail SOD ON PP.ProductID=SOD.ProductID
GROUP BY PP.ProductID,Name) AS HighestQty;


--2.
SELECT CONCAT(FirstName,' ',MiddleName,' ',LastName) FULL_NAME,SSP.SalesYTD,
RANK() over(order by SalesYTD desc) as Ranking 
FROM Sales.SalesPerson SSP JOIN Person.Person PP on SSP.BusinessEntityID=PP.BusinessEntityID;

--3.
SELECT CONCAT(FIRSTNAME, ' ',MiddleName,' ', LASTNAME) AS FullName,VacationHours AS VACTION_HOURS,JobTitle AS Job_title
FROM (SELECT p.FIRSTNAME,p.MiddleName,p.LASTNAME,emp.VacationHours,emp.JobTitle,
RANK() OVER (ORDER BY emp.VacationHours DESC) AS rank_fuc
FROM Person.Person AS p
JOIN HumanResources.Employee AS emp ON p.BusinessEntityID = emp.BusinessEntityID
)AS ranked_emp
WHERE rank_fuc = 1;

--4.
SELECT CONCAT(FirstName,' ',MiddleName,' ',LastName) AS Name,SST.SalesYTD,SST.SalesLastYear,STH.TerritoryID,
LEAD(SALESYTD,2,0) OVER(ORDER BY SALESYTD) AS SALESYTD_OF_NEXT_PERSON
--LAG(SALESLASTYEAR,1) OVER(ORDER BY SALESLASTYEAR) AS SALESLASTYEAR_OF_PREVIOUS_PERSON
from Person.Person PP 
JOIN Sales.SalesTerritoryHistory STH on PP.BusinessEntityID=STH.BusinessEntityID 
JOIN Sales.SalesTerritory SST on STH.TerritoryID=SST.TerritoryID;