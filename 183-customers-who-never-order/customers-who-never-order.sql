/* Write your PL/SQL query statement below */
SELECT 
    NAME Customers
FROM Customers, Orders
WHERE Customers.ID=ORDERS.customerId(+)
AND ORDERS.customerId IS NULL;