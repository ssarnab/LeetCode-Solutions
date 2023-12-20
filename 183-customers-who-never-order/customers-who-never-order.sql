/* Write your PL/SQL query statement below */
SELECT 
    NAME Customers
FROM Customers
 WHERE Customers.ID NOT IN (SELECT customerId FROM Orders);