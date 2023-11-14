/* Write your PL/SQL query statement below */
select
    email
from 
(
   select email,count(email) email_count  from Person group by email
) 
where email_count > 1;