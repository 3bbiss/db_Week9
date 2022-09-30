use business2;

select * from employee;

select e.id, e.firstname, e.lastname, e.managerid, m.firstname as managername
from employee e
join employee m
on e.managerid = m.id;

select e.id, e.firstname, e.lastname, e.managerid, m.firstname as managername
from employee e
left outer join employee m
on e.managerid = m.id;

select * from employee;
