/* Write your PL/SQL query statement below */
SELECT 
    Person.firstName,
    Person.lastName,
    Address.city,
    Address.state 
FROM Person,
     Address
WHERE Person.personId = Address.personID (+)      
