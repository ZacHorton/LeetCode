/* Write your T-SQL query statement below */
select name
from employee
where id in (
    select managerId 
    from employee 
    where managerId is not null 
    group by managerId 
    having count(managerId) >= 5
    )
