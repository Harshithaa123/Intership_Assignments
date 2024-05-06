CREATE SCHEMA PRODUCTION;

CREATE TABLE PRODUCTION.QUANTITY
(PRODUCTID INT PRIMARY KEY ,
AVAILABLE_QUANTITY INT,
UNITPRICE DECIMAL(10,2),
TOTALPRICE DECIMAL(10,2) );


INSERT INTO PRODUCTION.QUANTITY (PRODUCTID,AVAILABLE_QUANTITY,UNITPRICE,TOTALPRICE) VALUES
(101,100,20.00,1000.01),
(102,150,100.00,3000.01),
(103,50,17.00,8000.01),
(104,200,19.00,3000.01),
(105,122,70.00,2000.01),
(106,90,11.00,7000.01),
(107,78,87.00,2000.01),
(108,65,12.00,1500.01),
(109,77,120.00,1900.01),
(110,32,14.00,1700.01),
(111,55,10.00,1800.01),
(112,10,20.00,1900.01),
(113,90,22.00,1100.01),
(114,10,23.00,1200.01),
(115,30,25.00,1300.01);

SELECT * FROM PRODUCTION.QUANTITY;

CREATE TABLE PRODUCTION.SALES(
PRODUCTID INT REFERENCES PRODUCTION.QUANTITY(PRODUCTID),
PRODUCTNAME VARCHAR(50),
QUANTITY INT,
UNITPRICE DECIMAL(10,2),
TOTALPRICE DECIMAL(10,2),
DATAOFSALES DATE,
DISCOUNT DECIMAL(5,2));

SELECT * FROM PRODUCTION.SALES
INSERT INTO PRODUCTION.SALES(PRODUCTID,PRODUCTNAME,QUANTITY,UNITPRICE,TOTALPRICE,DATAOFSALES,DISCOUNT) VALUES
(103,'SMARTPHONES',5,20000.00,30000.00,'2021-05-13',0.07),
(102,'HEADPHONES',4,1000.00,40000.00,'2023-05-13',0.08),
(101,'T-SHIRT',17,1000.00,170000.00,'2024-05-13',0.05),
(102,'SNEAKERS',2,200.00,400.00,'2002-05-13',0.08),
(103,'WATCH',5,20000.00,70000.00,'2003-05-13',0.15),
(102,'COFFEE-MUG',5,800.00,40000.00,'2005-05-13',0.12),
(111,'TEA-MUG',8,400.00,30000.00,'2021-05-13',0.13),
(109,'FLOWERS',9,20000.00,30000.00,'2024-05-13',0.03),
(108,'TEDDYBEAR',44,20000.00,330000.00,'2023-05-13',0.00),
(115,'SUNGLASSES',5,800.00,300000.00,'2024-05-13',0.06);

SELECT PRODUCTID,PRODUCTNAME,TOTAL_QUANTITY 
FROM(
	SELECT PRODUCTID,PRODUCTNAME,SUM(QUANTITY) AS TOTAL_QUANTITY,
	DENSE_RANK() OVER(ORDER BY SUM(QUANTITY) DESC ) AS RN
	FROM PRODUCTION.SALES
	GROUP BY PRODUCTID,PRODUCTNAME) AS SS
WHERE RN=1;

--2.

CREATE TABLE SALES.PROMOTION
(PROMOTION_ID INT PRIMARY KEY,
PROMOTION_NAME VARCHAR(50) NOT NULL,
START_DATE DATE NOT NULL,
END_DATE DATE NOT NULL,
DISCOUNT DECIMAL(5,2) CHECK(DISCOUNT >= 0));

SELECT * FROM SALES.PROMOTION;

INSERT INTO SALES.PROMOTION (PROMOTION_ID,PROMOTION_NAME,START_DATE,END_DATE,DISCOUNT)VALUES
(1002,'DASARA SALE','2021-06-12','2022-03-12',0.01),
(1003,'BACK TO SCHOOL','2002-06-12','2005-03-12',0.05),
(1004,'HOLIDAY SEASON','2012-06-12','2018-03-12',0.08),
(1005,'EXCLUSIVE INSIDER OFFERS','2018-06-12','2024-03-12',0.02),
(1006,'END OF SEASON','2022-06-12','2023-03-12',0.06),
(1008,'PRIME TIME PROMOTIONS','2020-06-12','2024-03-12',0.09);

CREATE TABLE PRODUCTION.PRODUCTDETAILS(
PRODUCTID INT PRIMARY KEY,
PRODUCTNAME VARCHAR(45) NOT NULL,
PRODUCTNUMBER VARCHAR(50),
QUANTITY INT CHECK (QUANTITY >=0),
LOCATION VARCHAR(50));

INSERT INTO PRODUCTION.PRODUCTDETAILS(PRODUCTID,PRODUCTNAME,PRODUCTNUMBER,QUANTITY,LOCATION) VALUES
(1001,'PRODUCT A','PA111',22,'MYSORE'),
(1002,'PRODUCT B','PB222',40,'MANDYA'),
(1003,'PRODUCT C','PC333',70,'MADDUR'),
(1004,'PRODUCT D','PD144',20,'BELGAVI'),
(1005,'PRODUCT E','PE165',30,'CHITHRADRGA'),
(1006,'PRODUCT F','PF188',10,'MYSORE'),
(1007,'PRODUCT G','PG142',66,'BENGALURU'),
(1008,'PRODUCT H','PH177',78,'COORG'),
(1009,'PRODUCT I','PI111',12,'BENGALURU'),
(1011,'PRODUCT A','PA177',22,'MYSORE');

SELECT * FROM PRODUCTION.PRODUCTDETAILS;

CREATE TABLE PRODUCTION.PRODUCT(
PRODUCTID INT,
PRODUCTNAME VARCHAR(45),
PRODUCTNUMBER VARCHAR(50),
LOCATION VARCHAR(55));

--***************Copying table from one to another stucture as well as data**************

SELECT PRODUCTID,PRODUCTNAME,PRODUCTNUMBER,LOCATION
INTO PRODUCTION.PRODUCTS_COPY
FROM PRODUCTION.PRODUCTDETAILS;

--STORED PROCEDURE 5.
SELECT * FROM PRODUCTION.SALES;

CREATE PROCEDURE spTOTALSALESOFYEAR
AS
BEGIN
  SELECT YEAR(DATAOFSALES) AS SALESYEAR,SUM(QUANTITY) AS TOTALSALES
  FROM PRODUCTION.SALES
  GROUP BY YEAR(DATAOFSALES)
  ORDER BY SALESYEAR 
END;

 EXEC spTOTALSALESOFYEAR




 















